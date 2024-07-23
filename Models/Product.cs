using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace crud_razor_web_app.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Product Name")]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Count { get; set; }

    }
}
