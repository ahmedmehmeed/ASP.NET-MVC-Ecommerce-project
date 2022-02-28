using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
   // [MetadataType(typeof(ProductMetaData))]

    public class Product
    {
        public Product()
        {
            ProductInfo = new HashSet<ProductInfo>();
            OrderedProducts = new HashSet<OrderedProduct>();

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

        //Replace with user
        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        
        public virtual Admin Admin { get; set; }
        public virtual ICollection<OrderedProduct> OrderedProducts { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductInfo> ProductInfo { get; set; }

    }
}
