using Castle.Components.DictionaryAdapter;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.View_Models
{
    public class LoginViewModel
    {    
        [Required]
        public string username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }    
        [Display(Name ="Remember Me")]
        public bool persist { get; set; }

    }
}
