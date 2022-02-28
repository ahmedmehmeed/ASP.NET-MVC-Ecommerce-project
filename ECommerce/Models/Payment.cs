using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class Payment
    {
        public int Id { get; set; }
        [Required]
        public string PaymentAmount { get; set; }
        [Required]
        public string PaymentDate { get; set; }
        [ForeignKey("Customer")]  
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
