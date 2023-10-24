using CartingService.BLL.Application;
using CartingService.BLL.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CartingService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ILogger<CartController> _logger;
        private CartService _cartService;

        public CartController(ILogger<CartController> logger)
        {
            _logger = logger;
            _cartService = new CartService();
        }

        [HttpGet("GetItems")]
        public async Task<IEnumerable<ItemDto>> GetItems()
        {
            return await _cartService.GetItemListFromCart();
        }

        [HttpPost("AddItem")]
        public async Task<IActionResult> AddItem([FromBody] AddItemDto item)
        {
            await _cartService.AddItemToCart(item);
            return Ok(item);
        }

        [HttpPost("RemoveItem")]
        public async Task<IActionResult> RemoveItem([FromBody] RemoveItemDto item)
        {
            await _cartService.RemoveItemFromCart(item);
            return NoContent();
        }
    }
}
