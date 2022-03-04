using Ecommerce.Models;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.View_Models
{
    public class CheckOutViewModel
    {      
       
        [Required(ErrorMessage = "You must Enter A First Name")]
        public string FName { get; set; }

        [Required(ErrorMessage = "You must Enter A Last Name")]
        public string LName { get; set; }


        [Required(ErrorMessage = "You must Enter A Username")]
        [UniqueUserName]
        public string UserName { get; set; }


        [Required(ErrorMessage = "You must Enter A Date OF Birth ")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "You must Enter Your Address")]
        
        public string Adress { get; set; }
     
        [Required(ErrorMessage = "You must Enter Your Country ")]
        public string Country { get; set; }
    }
}
