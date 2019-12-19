using MongoDB.Driver;

namespace SimpleBotCore.Logic
{
    public class MongoContext
    {
        private readonly IMongoClient _mongoClient;
        private readonly IMongoDatabase _database;
        public IMongoCollection<SimpleMessage> Values { get; set; }
        public MongoContext(string connectionString)
        {
            _mongoClient = new MongoClient(connectionString);
            _database = _mongoClient.GetDatabase("net16");
            Values = _database.GetCollection<SimpleMessage>("col02");
        }        
    }
}

