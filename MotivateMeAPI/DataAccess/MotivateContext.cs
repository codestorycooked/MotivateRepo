using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MotivateMeAPI.DataAccess.Models;
using MotivateMeAPI.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotivateMeAPI.DataAccess
{

    public class MotivateContext
    {
        private readonly IMongoDatabase _database = null;
        public MotivateContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(settings.Value.Database);
            }

        }
        public IMongoCollection<Categories> Categories
        {
            get
            {
                return _database.GetCollection<Categories>("Categories");
            }
        }

        public IMongoCollection<Thoughts> Thoughts
        {
            get
            {
                return _database.GetCollection<Thoughts>("Thoughts");
            }
        }

    }
}
