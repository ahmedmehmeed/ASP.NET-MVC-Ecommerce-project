using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ecommerce.Models
{
    public class OrderedProduct
    {
        [Key, ForeignKey("Product"), Column(Order = 0)]
        public int ProductId { get; set; }

        [Key, ForeignKey("Order"), Column(Order = 1)]
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }

    }
}
