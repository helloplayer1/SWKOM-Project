using Microsoft.EntityFrameworkCore;
using PaperlessREST.DataAccess.Entities;
using PaperlessREST.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessREST.DataAccess.Sql.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private ApplicationDbContext _context;

        public DocumentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public DocumentDao Add(DocumentDao document)
        {
            try
            {
                _context.Add(document);
                _context.SaveChanges();
            }
            catch (Exception e) when (e is DbUpdateException or DBConcurrencyException)
            {
                throw new DALException(e.Message);
            }
            return document;
        }

        public void Delete(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();

        }

        public DocumentDao GetById(int id)
        {
            return _context.Documents.Find(id);
        }

        public DocumentDao Update(DocumentDao document)
        {
            _context.Update(document);
            _context.SaveChanges();
            return document;
        }
    }
}
