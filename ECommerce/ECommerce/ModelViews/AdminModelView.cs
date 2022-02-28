using System.ComponentModel.DataAnnotations;

namespace ECommerce.ModelViews
{
    public class AdminModelView
    {
        [Required(ErrorMessage = "You must Enter Your First Name")]

        public string FName { get; set; }
        [Required(ErrorMessage = "You must Enter Your Last Name")]

        public string LName { get; set; }
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
