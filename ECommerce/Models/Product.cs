using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class Product
    {
        public Product()
        {

            OrderedProducts = new HashSet<OrderedProduct>();
            Customers = new HashSet<Customer>();

        }
        public int Id { get; set; }

        [Required(ErrorMessage = "You must Enter A Name")]

        public string Name { get; set; }
        [Required(ErrorMessage = "You must Enter A Discription")]

        public string Description { get; set; }
        [Required(ErrorMessage = "You must Enter A Price")]

        public decimal Price { get; set; }

        [Required(ErrorMessage = "You must Enter An Image")]
        public string Image { get; set; }
        [Required(ErrorMessage = "You must Enter A Date")]
        public string Date { get; set; }
        [Required(ErrorMessage = "You must Enter ")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }


        public virtual Category Category { get; set; }
        public virtual ICollection<OrderedProduct> OrderedProducts { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }

    }
}
