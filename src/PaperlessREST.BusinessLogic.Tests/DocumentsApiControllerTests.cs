//using System;
//using System.IO;
////using System.Reflection.Metadata;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Moq;
//using NUnit.Framework;
//using PaperlessREST.BusinessLogic.Entities;
//using PaperlessREST.BusinessLogic.Interfaces;
//using PaperlessREST.Controllers;

//namespace PaperlessREST.BusinessLogic.Tests
//{
//    [TestFixture]
//    public class DocumentsApiControllerTests
//    {
//        [Test]
//        public async Task UploadDocument_ValidData_ReturnsOk()
//        {
//            // Arrange
//            var documentLogicMock = new Mock<IDocumentLogic>();
//            var controller = new DocumentsApiController(documentLogicMock.Object);

//            var title = "Sample Title";
//            var created = DateTime.Now;
//            var documentType = 1;
//            var tags = new List<int> { 1, 2, 3 };
//            var correspondent = 4;
//            var documentData = new Mock<IFormFile>();

//            // Act
//            var result = await controller.UploadDocument(title, created, documentType, tags, correspondent, documentData.Object);

//            // Assert
//            Assert.That(result, Is.InstanceOf<OkResult>());
//            documentLogicMock.Verify(x => x.IndexDocument(It.IsAny<Document>(), It.IsAny<Stream>()), Times.Once);
//        }
//    }
//}
