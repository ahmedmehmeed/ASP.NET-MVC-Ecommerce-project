using Ecommerce.View_Models;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Ecommerce.Models
{
    public class UniqueUserName:ValidationAttribute
    {
        protected override ValidationResult IsValid
           (object value, ValidationContext validationContext)
        {
            CheckOutViewModel check = (CheckOutViewModel)validationContext.ObjectInstance;
            string UserName = value.ToString();
            ECommerceEntity context = new ECommerceEntity();
            CheckOutViewModel checkOut = context.checkOuts.FirstOrDefault(s => s.UserName == UserName);
            if ((checkOut == null) || (check.UserName == checkOut.UserName))
            {
                //unique
                return ValidationResult.Success;
            }
            return new ValidationResult("UserName already found");
        }
    }
}
