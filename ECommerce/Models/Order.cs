using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class Order
    {
        public Order()
        {
            OrderedProducts = new HashSet<OrderedProduct>();

        }
        public int Id { get; set; }
        [Required]
        public string Date { get; set; }
        
     
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderedProduct> OrderedProducts { get; set; }
       
    
}
}
