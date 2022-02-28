using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Admin
    {
        public Admin()
        {
            Products = new HashSet<Product>();

        }
        public int Id { get; set; }
        [Required(ErrorMessage = "You must Enter Your First Name")]

        public string FName { get; set; }
        [Required(ErrorMessage = "You must Enter Your Last Name")]

        public string LName { get; set; }
        [Required(ErrorMessage = "You must Enter A Date OF Birth ")]
        public string DateOfBirth { get; set; }
        [Required(ErrorMessage = "You must Enter Your Address ")]
        public string Address { get; set; }
        [Required(ErrorMessage = "You must Enter Your Email")]
        [EmailAddress]
        //[unique]
        public string Email { get; set; }
        [Required(ErrorMessage = "You must Enter Password")]

        public string Password { get; set; }
        [Required(ErrorMessage = "You must Enter Your phone Number")]
        //[unique]
        public string PhoneNumber { get; set; }

        public string Gender { get; set; }
        
        public virtual ICollection<Product> Products { get; set; }
    }
}
 