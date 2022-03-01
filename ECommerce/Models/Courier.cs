using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Courier
    {
        public Courier()
        {
            Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "You must Enter First Name")]
        public string FName { get; set; }
        [Required(ErrorMessage = "You must Enter Last Name")]
        public string LName { get; set; }
        [Required(ErrorMessage = "You must Enter Your phone Number")]
        //[unique]
        public int PhoneNumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
