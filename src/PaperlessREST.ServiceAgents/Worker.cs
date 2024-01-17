using EasyNetQ;
using Minio;
using Minio.DataModel;
using Minio.DataModel.Args;
using PaperlessREST.BusinessLogic.Entities;
using PaperlessREST.DataAccess.Interfaces;
using PaperlessREST.ServiceAgents.Interfaces;
using PaperlessREST.Entities;

namespace PaperlessREST.ServiceAgents
{
    public class Worker : BackgroundService
    {
        private readonly IDocumentRepository _documentRepository;
        private readonly ILogger<Worker> _logger;
        private readonly IBus _bus;
        private readonly IOCRService _ocrService;
        private readonly IMinioClient _minioClient;
        public Worker(ILogger<Worker> logger, IDocumentRepository documentRepository, IOCRService ocrService, IMinioClient minioClient)
        {
            _documentRepository = documentRepository;
            _logger = logger;
            _bus = RabbitHutch.CreateBus("host=host.docker.internal");
            _ocrService = ocrService;
            _minioClient = minioClient;
        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //bus.PubSub.Subscribe<Document>("OCR Service Worker", HandleMessage, stoppingToken);
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            await _bus.PubSub.SubscribeAsync<DocumentQueueMessage>("OCR Service Worker", HandleMessage, stoppingToken);
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