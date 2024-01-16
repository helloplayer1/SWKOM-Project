using EasyNetQ;
using PaperlessREST.BusinessLogic.Entities;
using PaperlessREST.DataAccess.Interfaces;

namespace PaperlessREST.ServiceAgents
{
    public class Worker : BackgroundService
    {
        private readonly IDocumentRepository _documentRepository;
        private readonly ILogger<Worker> _logger;
        private readonly IBus _bus;
        public Worker(ILogger<Worker> logger, IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
            _logger = logger;
            _bus = RabbitHutch.CreateBus("host=host.docker.internal");
        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //bus.PubSub.Subscribe<Document>("OCR Service Worker", HandleMessage, stoppingToken);
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            await _bus.PubSub.SubscribeAsync<Document>("OCR Service Worker", HandleMessage, stoppingToken);
        }

        private void HandleMessage(Document document)
        {
            //ocr, save to db
            _logger.LogInformation($"Received document {document.OriginalFileName} for processing");
        }
        
        public override async Task StopAsync(CancellationToken stoppingToken)
        {
           _bus.Dispose();
        }
    }
}