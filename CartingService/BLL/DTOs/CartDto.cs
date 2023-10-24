using CartingService.Domain;
using System.ComponentModel.DataAnnotations;

namespace CartingService.BLL.DTOs
{
    public class CartDto
    {
        [Required]
        public string Id { get; set; }
        public List<Item> items { get; set; }
    }
}
