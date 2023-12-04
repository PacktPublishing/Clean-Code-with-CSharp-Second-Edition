using Amazon.Runtime.Documents;
using MongoDB.Driver;

namespace CH5_ExceptionHandling;

public class DataService : IDataService
{
    private readonly IMongoCollection<Document> _mongoCollection;

    public DataService(IMongoCollection<Document> mongoCollection)
    {
        _mongoCollection = mongoCollection;
    }

    public void PerformDatabaseOperation(Document document)
    {
        try
        {
            // Your MongoDB-related code here.
            // For example, _mongoCollection.InsertOne(document);
        }
        catch(MongoException ex)
        {
            // Handle MongoDB exceptions.
            // Log, rethrow, or perform custom actions.
        }
    }
}
