using CartingService.BLL.DTOs;

namespace CartingService.DAL.Repositories
{
    public interface IItemRepository : IDisposable
    {
        public Task<ItemDto> GetItemById(Guid id);
    }
}
