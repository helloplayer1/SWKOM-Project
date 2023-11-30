using PaperlessREST.BusinessLogic.Entities;
using PaperlessREST.BusinessLogic.Interfaces;
using PaperlessREST.ServiceAgents.Interfaces;

namespace PaperlessREST.BusinessLogic
{
    public class DocumentLogic : IDocumentLogic
    {
        //private IDocumentRepository
        private IOCRService _OCRService;
        public DocumentLogic(IOCRService oCRService)
        {
            _OCRService = oCRService;
        }
        public void IndexDocument(Document document, Stream pdfStream)
        {
            document.Content = _OCRService.PerformORC(pdfStream);
            
            //save File to disk

            //save Document to db
        }
    }
}