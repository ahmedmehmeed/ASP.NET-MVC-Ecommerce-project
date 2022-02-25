using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        [ForeignKey("Courier")]

        public int CourierId { get; set; }
        [Required]
        [ForeignKey("Customer")]

        public int CustomerId { get; set; }
        [Required]
       [ForeignKey("Product")]
        public int ProductId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual Courier Courier { get; set; }
    }
}
