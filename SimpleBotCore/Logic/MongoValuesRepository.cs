using MongoDB.Driver;
using System.Threading.Tasks;

namespace SimpleBotCore.Logic
{
    public class MongoValuesRepository : IValuesRepository
    {
        private readonly IMongoCollection<SimpleMessage> _values;
        public MongoValuesRepository(MongoContext database)
        {
            _values = database.Values;
        }
        public Task InsertAsync(SimpleMessage val)
        {
            return _values.InsertOneAsync(val);
        }
    }
}
