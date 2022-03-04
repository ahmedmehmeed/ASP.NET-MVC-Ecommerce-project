using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Ecommerce.Models
{
    public class Cart
    {
        public Cart()
        {
            ProductCarts = new HashSet<ProductCart>();
        }
        public int Id { get; set; }
        //public int DateCreated { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int Count { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<ProductCart> ProductCarts { get; set; }


    }
}
