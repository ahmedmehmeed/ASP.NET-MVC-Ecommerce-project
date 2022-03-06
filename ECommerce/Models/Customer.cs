using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
            ProductsCart = new HashSet<Product>();
           

        }
        [Key]
        public int Id { get; set; }

        [ForeignKey("IdentityUser")]
        public string CustomerId { get; set; }

        [Required(ErrorMessage = "You must Enter A First Name")]
        public string FName { get; set; }

        [Required(ErrorMessage = "You must Enter A Last Name")]
        public string LName { get; set; }
        public virtual IdentityUser IdentityUser { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Product> ProductsCart { get; set; }
      


    }
}
