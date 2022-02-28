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
        [Required(ErrorMessage = "You must Enter A Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must Enter Your phone Number")]
        //[unique]
        public int PhoneNumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
