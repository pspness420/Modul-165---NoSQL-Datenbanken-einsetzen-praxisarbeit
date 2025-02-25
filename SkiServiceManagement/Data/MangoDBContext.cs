using MongoDB.Driver;
using MongoDB.Bson;
using System;
using SkiServiceManagement.Models;

namespace SkiServiceManagement.Data 
{
    public class MangoDBContext
    {
        private readonly IMongoDatabase _database;
        public MangoDBContext()
        {
            var connectionString = " mongodb://127.0.0.1:27017";
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new Exception("MongoDB URI is missing in environment variables.");
            }
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase("SkiServiceDB");
        }

        public IMongoCollection<Benutzer> Benutzer
        {
            get
            {
                return _database.GetCollection<Benutzer>("Benutzer");
            }
        }

        public IMongoCollection<BsonDocument> Serviceauftraege
        {
            get
            {
                return _database.GetCollection<BsonDocument>("Serviceauftraege");
            }
        }
    }
}