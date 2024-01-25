using PaperlessREST.BusinessLogic.Entities;
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
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace PaperlessREST.BusinessLogic
{
    public class DocumentLogic : IDocumentLogic
    {
        private readonly IValidator<Document> _validator;
        //private IDocumentRepository
        private IMapper _mapper;
        private readonly IMinioClient _minioClient;
        private readonly ElasticsearchClient _elasticSearchClient;
        private readonly ILogger<DocumentLogic> _logger;
        private IDocumentRepository _documentRepository;
        private readonly IBus _rabbitMq;

        public DocumentLogic(IMapper mapper, IDocumentRepository documentRepository, IMinioClient minioClient, IBus rabbitMq, ILogger<DocumentLogic> logger, ElasticsearchClient elasticSearchClient, IValidator<Document> validator)
        {
            _validator = validator ?? throw new ArgumentNullException(nameof(_validator));
            _rabbitMq = rabbitMq;
            _mapper = mapper;
            _documentRepository = documentRepository;
            _minioClient = minioClient;
            _logger = logger;
            _elasticSearchClient = elasticSearchClient;
        }

        public async Task IndexDocument(Document document, Stream pdfStream)
        {
            _logger.LogInformation($"Indexing document: {document.Title}");

            try
            {
                var validationResult = _validator.Validate(document);
            }
            catch (ValidationException e)
            {
                _logger.LogError($"Validation Failed: {e.Message}");
                throw new BLValidationException(e.Message);
            }
            catch (NullReferenceException e)
            {
                _logger.LogError($"Null refrence exception: {e.Message}");
                throw e;
            }
            catch (Exception e)
            {
                _logger.LogError($"Indexing Document Failed: {e.Message}");
                throw e;
            }

            document.ArchiveSerialNumber = Guid.NewGuid().ToString();
            //save File to disk

            //write path to document dao
            try
            {
                DocumentDao documentDao = _mapper.Map<Document, DocumentDao>(document);
                _documentRepository.Add(documentDao);

                //saving
                var uploadedName = await SaveFile(document, pdfStream);

                _rabbitMq.PubSub.Publish(new DocumentQueueMessage() { DocumentID = (int)documentDao.Id! });
                _logger.LogInformation($"Finished saving document: {document.Title}");
            }
            catch (Exception e) when(e is DALException or DALConnectionException or DbUpdateException)
            {
                _logger.LogError($"Saving document failed: {e.Message}");
                throw new BLException(e.Message);
            }
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

        public async Task<IEnumerable<Document>> SearchDocumentsAsync(string query)
        {
            _logger.LogInformation($"Elastic called, staring search.");

            var searchResponse = await _elasticSearchClient.SearchAsync<ElasticDocument>(s => s
             .Index("documents")
             .Query(q => q.QueryString(qs => qs.DefaultField(p => p.Content).Query($"*{query}*"))));

            if (!searchResponse.IsSuccess())
            {
                throw new BLSearchException(searchResponse.DebugInformation);
            }

            _logger.LogInformation($"Search finished.");
            return searchResponse.Documents.Select(elasticDocument => _mapper.Map<DocumentDao, Document>(_documentRepository.GetById((int)elasticDocument.Id!)));
        }

        public Task<IEnumerable<Document>> SearchDocuments(string query)
        {
            throw new NotImplementedException();
        }
    }
}