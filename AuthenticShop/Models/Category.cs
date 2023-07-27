using System.ComponentModel.DataAnnotations;

namespace AuthenticShop.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(150)]
        public string? CategoryName { get; set; }
        public string? CategoryPhoto { get; set;}
        public int CategoryOrder { get; set;}
    }
}
