using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
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
      
        
        public string Image { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
