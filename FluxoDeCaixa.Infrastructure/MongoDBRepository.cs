using System;
using MongoDB.Driver;

namespace FluxoDeCaixa.Infrastructure
{
    public class MongoDBRepository : IDisposable
    {
         public MongoDBRepository()
            : this("FluxoDeCaixa")
        {

        }

        public MongoDBRepository(string databaseName)
        {
            DatabaseName = databaseName;
            _client = new MongoClient();
            _database = _client.GetDatabase(DatabaseName);
        }
        public string DatabaseName { get; set; }
        private IMongoClient _client;
        private IMongoDatabase _database;
        public void Dispose()
        {
              _client = null;
            _database = null;
        }

         public IMongoDatabase Database
        {
            get
            {
                return _database;
            }
        }
    }
}