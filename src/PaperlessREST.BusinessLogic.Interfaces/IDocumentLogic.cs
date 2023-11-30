
using PaperlessREST.BusinessLogic.Entities;

namespace PaperlessREST.BusinessLogic.Interfaces
{
    public interface IDocumentLogic
    {
        public void IndexDocument(Document document, Stream pdfStream);
    }
}