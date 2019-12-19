using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SimpleBotCore.Logic
{
    public class SimpleMessage
    {
        [BsonId]
        public string Id { get; }

        [BsonElement]
        public string User { get; }

        [BsonElement]
        public string Text { get; }

        [BsonExtraElements]
        public BsonDocument Others { get; set; }

        public SimpleMessage(string id, string username, string text)
        {
            Id = id;
            User = username;
            Text = text;
        }
    }
}