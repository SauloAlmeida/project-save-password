using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SavePassword.API.Core.Contracts.Settings;

namespace SavePassword.API.Infrastructure.Persistence.Context
{
    public class DatabaseContext
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _database;


        public DatabaseContext(IDatabaseSettings settings)
        {
            _client = new MongoClient(settings.ConnectionString);
            _database = _client.GetDatabase(settings.DatabaseName);
        }

        public IMongoClient Client => _client;
        public IMongoDatabase Database => _database;
    }
}
