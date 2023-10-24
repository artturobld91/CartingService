using CartingService.BLL.DTOs;

namespace CartingService.BLL.Application
{
    public interface ICartService
    {
        public Task<List<ItemDto>> GetItemListFromCart();
        public Task AddItemToCart(AddItemDto item);
        public Task RemoveItemFromCart(RemoveItemDto item);
    }
}
