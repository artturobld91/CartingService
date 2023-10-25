using CartingService.BLL.DTOs;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CartingService.DAL.Repositories
{
    public class ItemRepository : IItemRepository, IDisposable
    {
        private MongoClient _client;
        public ItemRepository(MongoClient client)
        {
            _client = client;
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

        public async Task<ItemDto> GetItemById(Guid id)
        {
            var database = _client.GetDatabase("carting");
            var itemsCollection = database.GetCollection<ItemDto>("items");
            var items = await itemsCollection.FindAsync(item => item.Id == id);
            return items is not null 
                    ? items.FirstOrDefault() 
                    : null;
        }
    }
}
