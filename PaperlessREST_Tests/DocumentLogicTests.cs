using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Minio.DataModel.Args;
using Minio.Exceptions;
using Minio;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using PaperlessREST.Attributes;
using PaperlessREST.BusinessLogic;
using PaperlessREST.BusinessLogic.Entities;
using PaperlessREST.BusinessLogic.Interfaces;
using PaperlessREST.Controllers;
using PaperlessREST.DataAccess.Entities;
using PaperlessREST.DataAccess.Interfaces;
using PaperlessREST.Entities;
using Swashbuckle.AspNetCore.Annotations;
using EasyNetQ;
using Minio.DataModel.Response;

namespace PaperlessREST_Tests
{
    public static class MinioExtensions
    {
        public static bool Ret(this BucketExistsArgs args)
        {
            // Add any logic to determine the return value based on args
            return true;
        }
    }

    [TestFixture]
    public class DocumentLogicTests
    {
        private DocumentLogic documentLogic;
        private Mock<IDocumentRepository> documentRepositoryMock;
        private Mock<IMinioClient> minioClientMock;
        private Mock<IMapper> mapperMock;
        private Mock<IBus> busMock;

        [SetUp]
        public void Setup()
        {
            documentRepositoryMock = new Mock<IDocumentRepository>();
            minioClientMock = new Mock<IMinioClient>();
            mapperMock = new Mock<IMapper>();
            busMock = new Mock<IBus>();
            documentLogic = new DocumentLogic(mapperMock.Object, documentRepositoryMock.Object, minioClientMock.Object, busMock.Object);

        }

        [Test]
        public async Task IndexDocument_WhenCalled_CallsMapperAndRepositoryAddAndSavesFileAndPublishesToBus()
        {
            // Arrange
            var document = new Document();
            document.Id = 3;
            var pdfStream = new MemoryStream();

            //Task<bool> BucketExistsAsync(BucketExistsArgs args, CancellationToken cancellationToken = default);
            //minioClientMock.Setup(x => x.BucketExistsAsync(It.IsAny<BucketExistsArgs>(), It.IsAny<CancellationToken>()))
            //.Callback<BucketExistsArgs>(args => args.Ret());
            minioClientMock
            .Setup(x => x.BucketExistsAsync(It.IsAny<BucketExistsArgs>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);

            IDictionary<string, string> myDictionary = new Dictionary<string, string>
            {
                { "Key1", "Value1" },
                { "Key2", "Value2" },
                { "Key3", "Value3" }
            };
            minioClientMock.Setup(x => x.PutObjectAsync(It.IsAny<PutObjectArgs>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new PutObjectResponse(System.Net.HttpStatusCode.OK, "uploadFIleName", myDictionary, long.MaxValue, null));

            mapperMock.Setup(x => x.Map<Document, DocumentDao>(It.IsAny<Document>())).Returns(new DocumentDao());

            //busMock.Setup(bus => bus.PubSub.Publish(It.IsAny<DocumentQueueMessage>(), It.IsAny<CancellationToken>()));

            // Act
            await documentLogic.IndexDocument(document, pdfStream);

            // Assert
            documentRepositoryMock.Verify(x => x.Add(It.IsAny<DocumentDao>()), Times.Once);
            minioClientMock.Verify(x => x.PutObjectAsync(It.IsAny<PutObjectArgs>(), It.IsAny<CancellationToken>()), Times.Once);
            busMock.Verify(x => x.PubSub.Publish(It.IsAny<DocumentQueueMessage>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task SaveFile_WhenBucketExists_SavesFileToMinioBucket()
        {
            // Arrange
            var document = new Document();
            var pdfStream = new MemoryStream();

            minioClientMock.Setup(x => x.BucketExistsAsync(It.IsAny<BucketExistsArgs>(), It.IsAny<CancellationToken>())).ReturnsAsync(true);
            minioClientMock.Setup(x => x.PutObjectAsync(It.IsAny<PutObjectArgs>(), It.IsAny<CancellationToken>())).ReturnsAsync(new PutObjectResponse(System.Net.HttpStatusCode.OK, "uploadFIleName", null, long.MaxValue, null));

            // Act
            var result = await documentLogic.SaveFile(document, pdfStream);

            // Assert
            Assert.AreEqual("uploadedFileName", result);
            minioClientMock.Verify(x => x.PutObjectAsync(It.IsAny<PutObjectArgs>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task SaveFile_WhenBucketDoesNotExist_CreatesBucketAndSavesFileToMinioBucket()
        {
            // Arrange
            var document = new Document();
            var pdfStream = new MemoryStream();

            minioClientMock.Setup(x => x.BucketExistsAsync(It.IsAny<BucketExistsArgs>(), It.IsAny<CancellationToken>())).ReturnsAsync(false);
            minioClientMock.Setup(x => x.PutObjectAsync(It.IsAny<PutObjectArgs>(), It.IsAny<CancellationToken>())).ReturnsAsync(new PutObjectResponse(System.Net.HttpStatusCode.OK, "uploadFIleName", null, long.MaxValue, null));

            // Act
            var result = await documentLogic.SaveFile(document, pdfStream);

            // Assert
            Assert.AreEqual("uploadedFileName", result);
            minioClientMock.Verify(x => x.PutObjectAsync(It.IsAny<PutObjectArgs>(), It.IsAny<CancellationToken>()), Times.Once);
            minioClientMock.Verify(x => x.MakeBucketAsync(It.IsAny<MakeBucketArgs>(), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}

