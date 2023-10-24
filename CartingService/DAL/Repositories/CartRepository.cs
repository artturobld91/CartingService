using CartingService.BLL.DTOs;
using CartingService.Domain;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CartingService.DAL.Repositories
{
    public class CartRepository : ICartRepository, IDisposable
    {
        private MongoClient _client;
        public CartRepository(MongoClient client)
        {
            _client = client;
        }

        public async Task<List<ItemDto>> GetItems()
        {
            var database = _client.GetDatabase("carting");
            var itemsCollection = database.GetCollection<ItemDto>("items");
            return await itemsCollection.Find(new BsonDocument()).ToListAsync(); ;
        }

        public async Task AddItem(AddItemDto item)
        {
            var database = _client.GetDatabase("carting");
            var itemsCollection = database.GetCollection<AddItemDto>("items");
            await itemsCollection.InsertOneAsync(item);
        }

        public async Task RemoveItem(RemoveItemDto item)
        {
            var database = _client.GetDatabase("carting");
            var itemsCollection = database.GetCollection<Item>("items");
            await itemsCollection.DeleteOneAsync(itemCol => itemCol.Id.ToString() == item.Id.ToString());
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    // No need to dispose MongoClient
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
