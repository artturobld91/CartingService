using System.ComponentModel.DataAnnotations;

namespace CartingService.BLL.DTOs
{
    public class AddItemDto
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Money { get; set; }
        [Required]
        public int Quantity { get; set; }

        public string Image { get; set; }
    }
}
