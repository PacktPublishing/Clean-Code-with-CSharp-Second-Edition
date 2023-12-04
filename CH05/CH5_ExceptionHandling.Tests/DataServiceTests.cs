using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MongoDB.Driver;
using System;

namespace CH5_ExceptionHandling.Tests;

[TestClass]
public class DataServiceTests
{
    [TestMethod]
    public void PerformDatabaseOperation_HandlesMongoException()
    {
        // Arrange
        var mockCollection = new Mock<IMongoCollection<Document>>();
        var dataService = new DataService(mockCollection.Object);

        mockCollection
            .Setup(x => x.InsertOne(It.IsAny<Document>(), null, default(CancellationToken)))
            .Throws(new MongoException("Simulated MongoDB exception"));

        // Act
        var documentToInsert = new Document { Name = "test" };
        dataService.PerformDatabaseOperation(documentToInsert);

        // Assert
        // Add assertions as needed, depending on your specific  requirements
        // For example, you might check logs or perform other verifications

    }
}
