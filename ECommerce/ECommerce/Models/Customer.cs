using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You must Enter A Name")]

        public string Name { get; set; }
        [Required(ErrorMessage = "You must Enter A Date OF Birth ")]

        public string DateOfBirth { get; set; }
        [Required(ErrorMessage = "You must Enter Your Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "You must Enter Password")]

        public string Password { get; set; }
        [Required(ErrorMessage = "You must Enter Your phone Number")]

        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "You must Enter Product Id")]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }



    }


}
