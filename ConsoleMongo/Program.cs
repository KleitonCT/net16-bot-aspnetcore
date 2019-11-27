using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace ConsoleMongo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var cliente = new MongoClient("mongodb://localhost:27017");

            var db = cliente.GetDatabase("net16");

            var col = db.GetCollection<BsonDocument>("col01");

            col.Find(new BsonDocument() {
                { "nome", 1 }
            });


            var insert = new BsonDocument()
            {
                { "nome", "Kleiton Cunha" },
                { "array", new BsonArray()
                            {
                                "MS", "FIAP"
                            }
                }
            };
        }
    }
}
