using NUnit.Framework;
using Moq;
using PaperlessREST.DataAccess.Entities;
using PaperlessREST.DataAccess.Interfaces;
using PaperlessREST.DataAccess.Sql.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using PaperlessREST.DataAccess.Sql;
using PaperlessREST;

namespace PaperlessREST_Tests
{
    [TestFixture]
    public class DocumentRepositoryTests
    {
        [Test]
        public void Add_ShouldAddDocumentToContext()
        {
            // Arrange
            
            
            var documentDaoList = new List<DocumentDao>(); // Mocked in-memory storage
            var dbContextMock = new Mock<ApplicationDbContext>();
            dbContextMock.Setup(db => db.Documents).Returns(MockDbSet(documentDaoList));

            var documentRepository = new DocumentRepository(dbContextMock.Object);
            var document = new DocumentDao { /* initialize properties */ };

            // Act
            var addedDocument = documentRepository.Add(document);

            // Assert
            Assert.IsNotNull(addedDocument);
            Assert.AreEqual(document, addedDocument);
            Assert.AreEqual(1, documentDaoList.Count);
        }

        [Test]
        public void Delete_ShouldRemoveDocumentFromContext()
        {
            // Arrange
            var document = new DocumentDao { Id = 1, /* initialize other properties */ };
            var dbContextMock = new Mock<ApplicationDbContext>();
            var documentRepository = new DocumentRepository(dbContextMock.Object);

            // Mock DbSet
            var dbSetMock = new Mock<DbSet<DocumentDao>>();
            dbSetMock.Setup(d => d.Find(It.IsAny<int>())).Returns<int>(id => id == document.Id ? document : null);
            dbContextMock.Setup(c => c.Documents).Returns(dbSetMock.Object);

            // Act
            documentRepository.Delete((int)document.Id);

            // Assert
            dbSetMock.Verify(d => d.Remove(It.IsAny<DocumentDao>()), Times.Once);
            dbContextMock.Verify(c => c.SaveChanges(), Times.Once);
        }

        [Test]
        public void GetById_ShouldReturnDocumentFromContext()
        {
            // Arrange
            var document = new DocumentDao { Id = 1, /* initialize other properties */ };
            var dbContextMock = new Mock<ApplicationDbContext>();
            var documentRepository = new DocumentRepository(dbContextMock.Object);

            // Mock DbSet
            var dbSetMock = new Mock<DbSet<DocumentDao>>();
            dbSetMock.Setup(d => d.Find(It.IsAny<int>())).Returns<int>(id => id == document.Id ? document : null);
            dbContextMock.Setup(c => c.Documents).Returns(dbSetMock.Object);

            // Act
            var retrievedDocument = documentRepository.GetById((int)document.Id);

            // Assert
            Assert.IsNotNull(retrievedDocument);
            Assert.AreEqual(document, retrievedDocument);
        }

        [Test]
        public void Update_ShouldUpdateDocumentInContext()
        {
            // Arrange
            var document = new DocumentDao { Id = 1, /* initialize other properties */ };
            var dbContextMock = new Mock<ApplicationDbContext>();
            var documentRepository = new DocumentRepository(dbContextMock.Object);

            // Mock DbSet
            var dbSetMock = new Mock<DbSet<DocumentDao>>();
            dbSetMock.Setup(d => d.Find(It.IsAny<int>())).Returns<int>(id => id == document.Id ? document : null);
            dbContextMock.Setup(c => c.Documents).Returns(dbSetMock.Object);

            // Act
            var updatedDocument = documentRepository.Update(document);

            // Assert
            dbSetMock.Verify(d => d.Update(It.IsAny<DocumentDao>()), Times.Once);
            dbContextMock.Verify(c => c.SaveChanges(), Times.Once);
            Assert.IsNotNull(updatedDocument);
            Assert.AreEqual(document, updatedDocument);
        }

        public class DocumentRepository : IDocumentRepository
        {
            private ApplicationDbContext _context;

            public DocumentRepository(ApplicationDbContext context)
            {
                _context = context;
            }

            public DocumentDao Add(DocumentDao document)
            {
                //throw new NotImplementedException();
                _context.Add(document);
                _context.SaveChanges();

                return document;
            }

            public void Delete(int id)
            {
                //throw new NotImplementedException();
                _context.Remove(id);
                _context.SaveChanges();
            }

            public DocumentDao GetById(int id)
            {
                //throw new NotImplementedException();
                return _context.Documents.Find(id);
            }

            public DocumentDao Update(DocumentDao document)
            {
                //throw new NotImplementedException();
                _context.Update(document);
                _context.SaveChanges();
                return document;
            }

            // ... (Other methods remain the same)
        }

        // Helper method to mock DbSet<T> using Moq
        private static DbSet<T> MockDbSet<T>(List<T> data) where T : class
        {
            var queryable = data.AsQueryable();
            var dbSet = new Mock<DbSet<T>>();
            dbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            dbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());
            dbSet.Setup(d => d.Add(It.IsAny<T>())).Callback<T>(data.Add);
            return dbSet.Object;
        }
        //    [Test]
        //    public void Add_WhenCalled_ShouldAddDocumentToContextAndSaveChanges()
        //    {
        //        // Arrange
        //        var dbContextMock = new Mock<ApplicationDbContext>();
        //        var repository = new DocumentRepository(dbContextMock.Object);
        //        var document = new DocumentDao();

        //        // Act
        //        repository.Add(document);

        //        // Assert
        //        dbContextMock.Verify(x => x.Add(document), Times.Once);
        //        dbContextMock.Verify(x => x.SaveChanges(), Times.Once);
        //    }

        //    [Test]
        //    public void Delete_WhenCalled_ShouldRemoveDocumentFromContextAndSaveChanges()
        //    {
        //        // Arrange
        //        var dbContextMock = new Mock<ApplicationDbContext>();
        //        var repository = new DocumentRepository(dbContextMock.Object);
        //        var documentId = 1;

        //        // Act
        //        repository.Delete(documentId);

        //        // Assert
        //        dbContextMock.Verify(x => x.Remove(It.IsAny<DocumentDao>()), Times.Once);
        //        dbContextMock.Verify(x => x.SaveChanges(), Times.Once);
        //    }

        //    [Test]
        //    public void GetById_WhenDocumentExists_ShouldReturnDocument()
        //    {
        //        // Arrange
        //        var dbContextMock = new Mock<ApplicationDbContext>();
        //        var repository = new DocumentRepository(dbContextMock.Object);
        //        var documentId = 1;
        //        var expectedDocument = new DocumentDao { Id = documentId };

        //        dbContextMock.Setup(x => x.Documents.Find(documentId)).Returns(expectedDocument);

        //        // Act
        //        var result = repository.GetById(documentId);

        //        // Assert
        //        Assert.AreEqual(expectedDocument, result);
        //    }

        //    [Test]
        //    public void Update_WhenCalled_ShouldUpdateDocumentInContextAndSaveChanges()
        //    {
        //        // Arrange
        //        var dbContextMock = new Mock<ApplicationDbContext>();
        //        var repository = new DocumentRepository(dbContextMock.Object);
        //        var document = new DocumentDao();

        //        // Act
        //        repository.Update(document);

        //        // Assert
        //        dbContextMock.Verify(x => x.Update(document), Times.Once);
        //        dbContextMock.Verify(x => x.SaveChanges(), Times.Once);
        //    }
    }
}

