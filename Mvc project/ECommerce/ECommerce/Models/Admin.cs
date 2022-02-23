using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Admin
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
        
    }
}
 