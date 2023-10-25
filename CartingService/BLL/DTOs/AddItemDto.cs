using System.ComponentModel.DataAnnotations;

namespace CartingService.BLL.DTOs
{
    public class AddItemDto
    {
        [Required]
        [RegularExpression(@"(?im)^[{(]?[0-9A-F]{8}[-]?(?:[0-9A-F]{4}[-]?){3}[0-9A-F]{12}[)}]?$")]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Money { get; set; }
        [Required]
        public int Quantity { get; set; }

        public string Image { get; set; }
    }
}
