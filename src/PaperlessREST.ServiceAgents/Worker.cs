using EasyNetQ;
using Minio;
using Minio.DataModel;
using Minio.DataModel.Args;
using PaperlessREST.BusinessLogic.Entities;
using PaperlessREST.DataAccess.Interfaces;
using PaperlessREST.ServiceAgents.Interfaces;
using PaperlessREST.Entities;
using System;
using Elastic.Clients.Elasticsearch;
using PaperlessREST.ElasticSearch.Interfaces;

namespace PaperlessREST.ServiceAgents
{
    public class Worker : BackgroundService
    {
        private readonly IDocumentRepository _documentRepository;
        private readonly ILogger<Worker> _logger;
        private readonly IBus _bus;
        private readonly IOCRService _ocrService;
        private readonly IMinioClient _minioClient;
        private readonly ElasticsearchClient _elasticsearchClient;
       
        public Worker(ILogger<Worker> logger, IDocumentRepository documentRepository, IOCRService ocrService, IMinioClient minioClient, ElasticsearchClient elasticsearchClient)
        {
            _documentRepository = documentRepository;
            _logger = logger;
            _bus = RabbitHutch.CreateBus("host=host.docker.internal");
            _ocrService = ocrService;
            _minioClient = minioClient;
            _elasticsearchClient = elasticsearchClient;
        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //bus.PubSub.Subscribe<Document>("OCR Service Worker", HandleMessage, stoppingToken);
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            await _bus.PubSub.SubscribeAsync<DocumentQueueMessage>("OCR Service Worker", HandleMessage, stoppingToken);
        }

        public void AddDocumentAsync(ElasticDocument document)
        {             
            if (!_elasticsearchClient.Indices.Exists("documents").Exists)
                _elasticsearchClient.Indices.Create("documents");

            var indexResponse = _elasticsearchClient.Index(document, "documents");
            if (!indexResponse.IsSuccess())
            {
                // Handle errors
                _logger.LogError($"Failed to index document: {indexResponse.DebugInformation}\n{indexResponse.ElasticsearchServerError}");

                throw new Exception($"Failed to index document: {indexResponse.DebugInformation}\n{indexResponse.ElasticsearchServerError}");
            }
        }

        private async void HandleMessage(DocumentQueueMessage message)
        {
            var document = _documentRepository.GetById(message.DocumentID);
            //ocr, save to db
            var bucketName = "paperless-bucket";
            string uniqueName = $"{document.ArchiveSerialNumber}_{document.OriginalFileName}";


            var getObjectArgs = new GetObjectArgs()
                .WithBucket(bucketName)
                .WithObject(uniqueName)
                .WithCallbackStream((stream) =>
                {
                    document.Content = _ocrService.PerformORC(stream);
                    _documentRepository.Update(document);
                    AddDocumentAsync(new ElasticDocument()
                    {
                        Id = document.Id,
                        Content = document.Content,
                        Title = document.Title,
                    });
                });              

            _logger.LogInformation($"Received document {document.OriginalFileName} for processing");
            ObjectStat result = await _minioClient.GetObjectAsync(getObjectArgs);
        }

        public override async Task StopAsync(CancellationToken stoppingToken)
        {
            _bus.Dispose();
        }
    }
}