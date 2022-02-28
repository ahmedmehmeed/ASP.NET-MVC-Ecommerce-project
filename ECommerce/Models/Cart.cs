using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Ecommerce.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int DateCreated { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        
        public virtual Customer Customer { get; set; }

    }
}
