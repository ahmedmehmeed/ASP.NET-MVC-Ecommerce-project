using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Courier
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You must Enter A Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must Enter Your phone Number")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "You must Enter Your Email")]
        [EmailAddress]
        public string Email { get; set; }
        public virtual ICollection<Order> Orders { get; set; }


    }
}
