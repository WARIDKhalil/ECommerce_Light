using ECommerce_Light_Infrastructure.Abstraction;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace ECommerce_Light_Infrastructure.DBConfiguration
{
    public class MongoDBContext : IDBContext
    {

        private IMongoDatabase Database { get; set; }
        private MongoClient Client { get; set; }

        public MongoDBContext( IOptions<DBSettings.DBSettings> settings)
        {
            Client = new MongoClient(settings.Value.ConnectionString);
            Database = Client.GetDatabase(settings.Value.DatabaseName);
        }
        public object GetClassifier<T>(string collectionName)
        {
            if (!CollectionExists(Database, collectionName))
                Database.CreateCollection(collectionName);
            return Database.GetCollection<T>(collectionName);
        }

        public bool CollectionExists(IMongoDatabase database, string collectionName)
        {
            var filter = new BsonDocument("name", collectionName);
            var options = new ListCollectionNamesOptions { Filter = filter };
            return database.ListCollectionNames(options).Any();
        }
    }
}
