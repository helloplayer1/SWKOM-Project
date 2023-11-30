using PaperlessREST.BusinessLogic.Entities;
using PaperlessREST.BusinessLogic.Interfaces;
using PaperlessREST.ServiceAgents.Interfaces;
using AutoMapper;
using PaperlessREST.DataAccess.Entities;
using PaperlessREST.DataAccess.Interfaces;

namespace PaperlessREST.BusinessLogic
{
    public class DocumentLogic : IDocumentLogic
    {
        //private IDocumentRepository
        private IOCRService _OCRService;
        private IMapper _mapper;
        private IDocumentRepository _documentRepository;
        public DocumentLogic(IOCRService oCRService, IMapper mapper, IDocumentRepository documentRepository)
        {
            _OCRService = oCRService;
            _mapper = mapper;
            _documentRepository = documentRepository;
        }
        public void IndexDocument(Document document, Stream pdfStream)
        {
            document.Content = _OCRService.PerformORC(pdfStream);

            //save File to disk

            //write path to document dao

            DocumentDao documentDao = _mapper.Map<Document, DocumentDao>(document);

            _documentRepository.Add(documentDao);
        }
    }
}