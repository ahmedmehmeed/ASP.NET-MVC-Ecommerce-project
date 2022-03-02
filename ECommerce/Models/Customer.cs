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
            Payments = new HashSet<Payment>();

        }
        [Key]
        public int Id { get; set; }

        [ForeignKey("IdentityUser")]
        public string CustomerId { get; set; }

        [Required(ErrorMessage = "You must Enter Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must Enter A Date OF Birth ")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "You must Enter A First Name")]
        public string FName { get; set; }


        [Required(ErrorMessage = "You must Enter A Last Name")]
        public string LName { get; set; }


        [Required(ErrorMessage = "You must Enter A Date OF Birth ")]
        public string DOB { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }


    }
}
