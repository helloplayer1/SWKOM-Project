
using PaperlessREST.BusinessLogic.Entities;

namespace PaperlessREST.BusinessLogic.Interfaces
{
    public interface IDocumentLogic
    {
        Task IndexDocument(Document document, Stream pdfStream);

        Task<IEnumerable<Document>> SearchDocumentsAsync(string query);
    }
}