using PaperlessREST.DataAccess.Entities;
namespace PaperlessREST.DataAccess.Interfaces
{
    public interface IDocumentRepository
    {
        public DocumentDao GetById(int  id);

        public DocumentDao Add(DocumentDao document);
        public DocumentDao Update(DocumentDao document);
        public void Delete(int id);
    }
}