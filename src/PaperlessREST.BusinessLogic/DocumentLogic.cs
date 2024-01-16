using PaperlessREST.BusinessLogic.Entities;
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


namespace PaperlessREST.BusinessLogic
{
    public class DocumentLogic : IDocumentLogic
    {
        //private IDocumentRepository
        private IOCRService _OCRService;
        private IMapper _mapper;
        private readonly IMinioClient _minioClient;
        private IDocumentRepository _documentRepository;
        public DocumentLogic(IOCRService oCRService, IMapper mapper, IDocumentRepository documentRepository)
        {
            _OCRService = oCRService;
            _mapper = mapper;
            _documentRepository = documentRepository;
        }
        public async Task IndexDocument(Document document, Stream pdfStream)
        {
            document.Content = _OCRService.PerformORC(pdfStream);

            //save File to disk

            //write path to document dao

            DocumentDao documentDao = _mapper.Map<Document, DocumentDao>(document);


            //saving
            var uploadedName = await SaveFile(document);



            var bus = RabbitHutch.CreateBus("host=host.docker.internal");
            bus.PubSub.Publish(document);

            _documentRepository.Add(documentDao);
        }

        protected async Task<string> SaveFile(Document file)
        {
            var bucketName = "paperless-bucket";

            string originalName = file.OriginalFileName;
            string UID = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff");
            string uniqueName = $"{UID}_{originalName}";

            var contentType = "application/octet-stream";

            try
            {

                using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(file.Content)))
                {

                    var putObjectArgs = new PutObjectArgs()
                            .WithBucket(bucketName)
                            .WithObject(uniqueName)
                            .WithStreamData(memoryStream)
                            .WithObjectSize(memoryStream.Length)
                            .WithContentType(contentType);

                    //await _minioClient.PutObjectAsync(putObjectArgs).ConfigureAwait(false);

                }
            }
            catch (MinioException e)
            {
                Console.WriteLine($"Minio Error: {e.Message}");
            }

            return uniqueName;
        }
    }
}