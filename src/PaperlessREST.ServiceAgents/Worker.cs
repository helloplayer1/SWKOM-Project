using EasyNetQ;
using PaperlessREST.BusinessLogic.Entities;
using PaperlessREST.DataAccess.Interfaces;

namespace PaperlessREST.ServiceAgents
{
    public class Worker : BackgroundService
    {
        private readonly IDocumentRepository _documentRepository;
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger, IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //maybe bus is disposed?
            using var bus = RabbitHutch.CreateBus("host=host.docker.internal");
            bus.PubSub.Subscribe<Document>("OCR Service Worker", HandleMessage, stoppingToken);

            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        }

        private void HandleMessage(Document document)
        {
            //ocr, save to db
            _logger.LogInformation($"Received document {document.OriginalFileName} for processing");
            throw new Exception();
        }
    }
}