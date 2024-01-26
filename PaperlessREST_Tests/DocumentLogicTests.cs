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
using Microsoft.Extensions.Logging;
using EasyNetQ;
using Minio.DataModel.Response;
using FluentValidation;
using System.ComponentModel.DataAnnotations;
using Elastic.Clients.Elasticsearch;

namespace PaperlessREST_Tests
{
    public static class MinioExtensions
    {
        public static bool Ret(this BucketExistsArgs args)
        {
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
        private Mock<IPubSub> pubSubMock;
        private Mock<IValidator<Document>> validatorMock;
        //ILogger<DocumentLogic> logger, ElasticsearchClient elasticSearchClient
        private Mock<ILogger<DocumentLogic>> loggerMock;
        private Mock<ElasticsearchClient> elasticSearchClientMock;
        [SetUp]
        public void Setup()
        {
            documentRepositoryMock = new Mock<IDocumentRepository>();
            minioClientMock = new Mock<IMinioClient>();
            mapperMock = new Mock<IMapper>();
            busMock = new Mock<IBus>();
            pubSubMock = new Mock<IPubSub>();
            validatorMock = new Mock<IValidator<Document>>();
            loggerMock = new Mock<ILogger<DocumentLogic>>();
            elasticSearchClientMock = new Mock<ElasticsearchClient>();
            documentLogic = new DocumentLogic(mapperMock.Object, documentRepositoryMock.Object, minioClientMock.Object, busMock.Object, loggerMock.Object, elasticSearchClientMock.Object, validatorMock.Object);

        }

        [Test]
        public async Task IndexDocument_WhenCalled_CallsMapperAndRepositoryAddAndSavesFileAndPublishesToBus()
        {
            Document document = new Document
            {
                Id = 42,
                Correspondent = 1,
                DocumentType = 2,
                StoragePath = 3,
                Title = "UniqueDocumentTitle",
                Content = "UniqueDocumentContent",
                Tags = new System.Collections.Generic.List<int> { 4, 5, 6 },
                Created = DateTime.UtcNow,
                CreatedDate = DateTime.UtcNow,
                Modified = DateTime.UtcNow,
                Added = DateTime.UtcNow,
                ArchiveSerialNumber = "UniqueArchiveSerialNumber",
                OriginalFileName = "unique_document.pdf",
                ArchivedFileName = "archived_unique_document.pdf"
            };
            document.Id = 3;
            var pdfStream = new MemoryStream();

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

            DocumentDao sampleDocumentDao = new DocumentDao();
            sampleDocumentDao.Id = 3;
            mapperMock.Setup(x => x.Map<Document, DocumentDao>(It.IsAny<Document>())).Returns(sampleDocumentDao);
            busMock.SetupGet(bus => bus.PubSub).Returns(pubSubMock.Object);


            await documentLogic.IndexDocument(document, pdfStream);

            documentRepositoryMock.Verify(x => x.Add(It.IsAny<DocumentDao>()), Times.Once);
            minioClientMock.Verify(x => x.PutObjectAsync(It.IsAny<PutObjectArgs>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task SaveFile_WhenBucketExists_SavesFileToMinioBucket()
        {
            Document document = new Document
            {
                Id = 42,
                Correspondent = 1,
                DocumentType = 2,
                StoragePath = 3,
                Title = "UniqueDocumentTitle",
                Content = "UniqueDocumentContent",
                Tags = new System.Collections.Generic.List<int> { 4, 5, 6 },
                Created = DateTime.UtcNow,
                CreatedDate = DateTime.UtcNow,
                Modified = DateTime.UtcNow,
                Added = DateTime.UtcNow,
                ArchiveSerialNumber = "UniqueArchiveSerialNumber",
                OriginalFileName = "unique_document.pdf",
                ArchivedFileName = "archived_unique_document.pdf"
            };
            var pdfStream = new MemoryStream();
            IDictionary<string, string> myDictionary = new Dictionary<string, string>
            {
                { "Key1", "Value1" },
                { "Key2", "Value2" },
                { "Key3", "Value3" }
            };

            minioClientMock.Setup(x => x.BucketExistsAsync(It.IsAny<BucketExistsArgs>(), It.IsAny<CancellationToken>())).ReturnsAsync(true);
            minioClientMock.Setup(x => x.PutObjectAsync(It.IsAny<PutObjectArgs>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new PutObjectResponse(System.Net.HttpStatusCode.OK, "uploadFIleName", myDictionary, long.MaxValue, null));

            var result = await documentLogic.SaveFile(document, pdfStream);


            Assert.AreEqual("UniqueArchiveSerialNumber_unique_document.pdf", result);
            minioClientMock.Verify(x => x.PutObjectAsync(It.IsAny<PutObjectArgs>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task SaveFile_WhenBucketDoesNotExist_CreatesBucketAndSavesFileToMinioBucket()
        {
            Document document = new Document
            {
                Id = 42,
                Correspondent = 1,
                DocumentType = 2,
                StoragePath = 3,
                Title = "UniqueDocumentTitle",
                Content = "UniqueDocumentContent",
                Tags = new System.Collections.Generic.List<int> { 4, 5, 6 },
                Created = DateTime.UtcNow,
                CreatedDate = DateTime.UtcNow,
                Modified = DateTime.UtcNow,
                Added = DateTime.UtcNow,
                ArchiveSerialNumber = "UniqueArchiveSerialNumber",
                OriginalFileName = "unique_document.pdf",
                ArchivedFileName = "archived_unique_document.pdf"
            };
            var pdfStream = new MemoryStream();
            IDictionary<string, string> myDictionary = new Dictionary<string, string>
            {
                { "Key1", "Value1" },
                { "Key2", "Value2" },
                { "Key3", "Value3" }
            };

            minioClientMock.Setup(x => x.BucketExistsAsync(It.IsAny<BucketExistsArgs>(), It.IsAny<CancellationToken>())).ReturnsAsync(false);
            minioClientMock.Setup(x => x.PutObjectAsync(It.IsAny<PutObjectArgs>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new PutObjectResponse(System.Net.HttpStatusCode.OK, "uploadFIleName", myDictionary, long.MaxValue, null));
            var result = await documentLogic.SaveFile(document, pdfStream);

            Assert.AreEqual("UniqueArchiveSerialNumber_unique_document.pdf", result);
            minioClientMock.Verify(x => x.PutObjectAsync(It.IsAny<PutObjectArgs>(), It.IsAny<CancellationToken>()), Times.Once);
            minioClientMock.Verify(x => x.MakeBucketAsync(It.IsAny<MakeBucketArgs>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task Document_Validation_Test()
        {
            Document document = new Document
            {
                Id = 42,
                Correspondent = 1,
                DocumentType = 2,
                StoragePath = 3,
                Title = "UniqueDocumentTitle",
                Content = "UniqueDocumentContent",
                Tags = new System.Collections.Generic.List<int> { 4, 5, 6 },
                Created = DateTime.UtcNow,
                CreatedDate = DateTime.UtcNow,
                Modified = DateTime.UtcNow,
                Added = DateTime.UtcNow,
                ArchiveSerialNumber = "UniqueArchiveSerialNumber",
                OriginalFileName = "unique_document.pdf",
                ArchivedFileName = "archived_unique_document.pdf"
            };

            Assert.DoesNotThrow(() => validatorMock.Object.Validate(document));
        }
    }
}

