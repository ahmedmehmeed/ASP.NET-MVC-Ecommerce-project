using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class ProductInfo
    {
        // make three prop as primary key in function of onmodelcreate
        [ForeignKey("Product")]
        public int Prod_ID { get; set; }
        [Required(ErrorMessage = "You must Enter Image")]
        public string Image { get; set; }
        [Required(ErrorMessage = "You must Enter Color")]
        public string Color { get; set; }
        public string Size { get; set; }
        public virtual Product Product { get; set; }
    }
}
