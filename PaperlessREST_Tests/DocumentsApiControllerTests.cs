using System;
using System.IO;
//using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using PaperlessREST.BusinessLogic.Entities;
using PaperlessREST.BusinessLogic.Interfaces;
using PaperlessREST.Controllers;
using PaperlessREST.Entities;

namespace PaperlessREST_Tests
{
    [TestFixture]
    public class DocumentsApiControllerTests
    {
        private Mock<IDocumentLogic> documentLogicMock;
        private DocumentsApiController controller;

        [SetUp]
        public void Setup()
        {
            documentLogicMock = new Mock<IDocumentLogic>();
            controller = new DocumentsApiController(documentLogicMock.Object);
        }

        

        [Test]
        public void GetDocuments_ValidParameters_ReturnsDocuments()
        {
            int page = 1;
            int pageSize = 10;

            var result = controller.GetDocuments(page, pageSize, null, null, null, null, null, null, null);

            Assert.That(result, Is.InstanceOf<ObjectResult>());
            var objectResult = (ObjectResult)result;
            Assert.That(objectResult.Value, Is.InstanceOf<GetDocuments200Response>());
        }

        [Test]
        public void UpdateDocument_ValidData_ReturnsUpdatedDocument()
        {
            int documentId = 1;
            var updateRequest = new UpdateDocumentRequest {};

            var result = controller.UpdateDocument(documentId, updateRequest);

            Assert.That(result, Is.InstanceOf<ObjectResult>());
            var objectResult = (ObjectResult)result;
            Assert.That(objectResult.Value, Is.InstanceOf<UpdateDocument200Response>());
        }

        [Test]
        public async Task UploadDocument_ValidData_ReturnsOk()
        {
            var title = "Sample Title";
            var created = DateTime.Now;
            var documentType = 1;
            var tags = new List<int> { 1, 2, 3 };
            var correspondent = 4;
            var documentData = new Mock<IFormFile>();

            var result = await controller.UploadDocument(title, created, documentType, tags, correspondent, documentData.Object);

            Assert.That(result, Is.InstanceOf<OkResult>());
            documentLogicMock.Verify(x => x.IndexDocument(It.IsAny<Document>(), It.IsAny<Stream>()), Times.Once);
        }
    }
}