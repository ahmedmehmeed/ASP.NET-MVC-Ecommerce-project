using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ecommerce.Models
{
    public class OrderedProduct
        // key composite should be in model create
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [ ForeignKey("Order")]
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }

    }
}
