using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You must Enter A Name")]

        public string Name { get; set; }
        [Required(ErrorMessage = "You must Enter Description")]

        public string Description { get; set; }
        [Required(ErrorMessage = "You must Enter Price")]

        public int Price { get; set; }
        [Required(ErrorMessage = "You must Upload Image Og The Product")]

        public string Image { get; set; }
        [Required(ErrorMessage = "You must Enter Category Id")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        

    }
}
