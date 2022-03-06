using Castle.Components.DictionaryAdapter;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.View_Models
{
    public class RegisterViewModel
    {
     
        [Required(ErrorMessage = "You must Enter A Username")]
       
        public string UserName { get; set; }

        [Required(ErrorMessage = "You must Enter A First Name")]
        public string FName { get; set; }

        [Required(ErrorMessage = "You must Enter A Last Name")]
        public string LName { get; set; }

        [Required(ErrorMessage = "You must Enter Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must Enter Your PhoneNumber ")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "You must Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Not matched")]
        [Required(ErrorMessage = "You must Enter Confirm Password ")]
        public string Confirmpassword { get; set; }

    }
}