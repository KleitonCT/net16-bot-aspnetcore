using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBotCore.Logic
{
    public class SimpleBotUser
    {
        public string Reply(SimpleMessage message)
        {
            var cliente = new MongoClient("mongodb://localhost:27017");

            var db = cliente.GetDatabase("net16");

            var col = db.GetCollection<SimpleMessage>("col02");

            col.InsertOne(message);

            //col.InsertOne(new MongoDB.Bson.BsonDocument()
            //{
            //    { "id", message.Id },
            //    { "user", message.User },
            //    { "message", message.Text }
            //});

            return $"{message.User} disse '{message.Text}'";
        }

    }
}