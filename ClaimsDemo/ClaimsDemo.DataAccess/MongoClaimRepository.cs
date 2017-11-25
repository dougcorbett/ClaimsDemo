using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using ClaimsDemo.DataAccess;
using ClaimsDemo.DataAccess.MongoPOCO;
using ClaimsDemo.DataAccess.Validators;
using System.Threading.Tasks;

namespace ClaimsDemo.DataAccess
{
    public class MongoClaimRepository
    {

        private IMongoDatabase _db;

        private MongoClaimRepository() { }

        public MongoClaimRepository(string ConnectionString, string DatabaseName)
        {
            var client = new MongoClient(ConnectionString);
            _db = client.GetDatabase(DatabaseName);
        }

        public MongoClaimRepository(IMongoDatabase database)
        {
            _db = database;
        }

        public ObjectId? InsertClaim(Claim c)
        {
            return InsertClaimAsync(c).GetAwaiter().GetResult();
        }

        public void DropCollection(string collectionName)
        {
            _db.DropCollection(collectionName);
        }
        private async Task<ObjectId> InsertClaimAsync(Claim c)
        {
            var col = _db.GetCollection<Claim>("claims");

            await col.InsertOneAsync(c).ConfigureAwait(false);

            return c.Id;
        }

        public Claim GetClaim(string ID)
        {
            return GetClaimAsync(ID).GetAwaiter().GetResult();
        }

        private async Task<Claim> GetClaimAsync(string ID)
        {
            ObjectId validId;
            Claim results = null;

            if (!ObjectId.TryParse(ID, out validId)) { return null; }
            
            var col = _db.GetCollection<Claim>("claims");

            var filter = new BsonDocument { { "_id", validId } };

            results = await col.Find(filter)
                            .FirstOrDefaultAsync()
                            .ConfigureAwait(false);

            return results;
        }
        
    }
}
