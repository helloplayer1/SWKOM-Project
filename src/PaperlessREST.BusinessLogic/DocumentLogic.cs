﻿using PaperlessREST.BusinessLogic.Entities;
using PaperlessREST.Entities;
using PaperlessREST.BusinessLogic.Interfaces;
using PaperlessREST.ServiceAgents.Interfaces;
using AutoMapper;
using PaperlessREST.DataAccess.Entities;
using PaperlessREST.DataAccess.Interfaces;
using Microsoft.AspNetCore.Http;
using PaperlessREST.BusinessLogic.Entities;
using PaperlessREST.BusinessLogic.Interfaces;
using System.Xml.Linq;
using FluentValidation;
using Microsoft.Extensions.Logging;
using PaperlessREST.DataAccess.Interfaces;
using Minio;
using Minio.DataModel.Args;
using Minio.Exceptions;
using Microsoft.AspNetCore.Http;
using System.Text;
using EasyNetQ;
using Elastic.Clients.Elasticsearch;

namespace PaperlessREST.BusinessLogic
{
    public class DocumentLogic : IDocumentLogic
    {
        private readonly IValidator<Document> _validator;
        //private IDocumentRepository
        private IMapper _mapper;
        private readonly IMinioClient _minioClient;
        private readonly ElasticsearchClient _elasticSearchClient;
        private IDocumentRepository _documentRepository;
        private readonly IBus _rabbitMq;


        public DocumentLogic(IMapper mapper, IDocumentRepository documentRepository, IMinioClient minioClient, IBus rabbitMq, ElasticsearchClient elasticSearchClient)
        {
            //hier kommt der logger hin
            //IValidator<Document> validator
            //_validator = validator ?? throw new ArgumentNullException(nameof(_validator));
            _rabbitMq = rabbitMq;
            _mapper = mapper;
            _documentRepository = documentRepository;
            _minioClient = minioClient;
            _elasticSearchClient = elasticSearchClient;
        }

        public async Task IndexDocument(Document document, Stream pdfStream)
        {
            var validationResult = _validator.Validate(document);

            if (!validationResult.IsValid)
            {
                //throw custom exception here
            }

            document.ArchiveSerialNumber = Guid.NewGuid().ToString();
            //save File to disk

            //write path to document dao

            DocumentDao documentDao = _mapper.Map<Document, DocumentDao>(document);
            _documentRepository.Add(documentDao);

            //saving
            var uploadedName = await SaveFile(document, pdfStream);


            _rabbitMq.PubSub.Publish(new DocumentQueueMessage() { DocumentID = (int)documentDao.Id! });
        }

        //changed to public for testing
        public async Task<string> SaveFile(Document document, Stream pdfStream)
        {
            var bucketName = "paperless-bucket";
            string uniqueName = $"{document.ArchiveSerialNumber}_{document.OriginalFileName}";
            var contentType = "application/octet-stream";

            try
            {
                // Make a bucket on the server, if not already present.
                var beArgs = new BucketExistsArgs()
                    .WithBucket(bucketName);
                bool found = await _minioClient.BucketExistsAsync(beArgs).ConfigureAwait(false);
                if (!found)
                {
                    var mbArgs = new MakeBucketArgs()
                        .WithBucket(bucketName);
                    await _minioClient.MakeBucketAsync(mbArgs).ConfigureAwait(false);
                }
                pdfStream.Position = 0;
                var putObjectArgs = new PutObjectArgs()
                        .WithBucket(bucketName)
                        .WithObject(uniqueName)
                        .WithStreamData(pdfStream)
                        .WithObjectSize(pdfStream.Length)
                        .WithContentType(contentType);

                await _minioClient.PutObjectAsync(putObjectArgs).ConfigureAwait(false);
            }
            catch (MinioException e)
            {
                Console.WriteLine($"Minio Error: {e.Message}");
            }
            return uniqueName;
        }

        public async Task<IEnumerable<Document>> SearchDocuments(string query)
        {
            var searchResponse = await _elasticSearchClient.SearchAsync<ElasticDocument>(s => s
             .Index("documents")
             .Query(q => q.QueryString(qs => qs.DefaultField(p => p.Content).Query($"*{query}*"))));

            return searchResponse.Documents.Select(elasticDocument => _mapper.Map<DocumentDao, Document>(_documentRepository.GetById((int)elasticDocument.Id!)));
        }
    }
}