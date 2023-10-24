using CartingService.BLL.DTOs;
using CartingService.Domain;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CartingService.DAL.Repositories
{
    public interface ICartRepository : IDisposable
    {
        public Task<List<ItemDto>> GetItems();

        public Task AddItem(AddItemDto item);

        public Task RemoveItem(RemoveItemDto item);
    }
}
