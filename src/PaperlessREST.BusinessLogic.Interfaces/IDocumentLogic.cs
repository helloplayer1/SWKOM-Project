
using PaperlessREST.BusinessLogic.Entities;

namespace PaperlessREST.BusinessLogic.Interfaces
{
    public interface IDocumentLogic
    {
        public Task IndexDocument(Document document, Stream pdfStream);
    }
}