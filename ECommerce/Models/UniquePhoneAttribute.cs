using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Ecommerce.Models
{
    public class UniquePhoneAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Customer customer = (Customer)validationContext.ObjectInstance;
            string phone = value.ToString();
            ECommerceEntity EC = new ECommerceEntity();
            Customer cust = EC.Customers.FirstOrDefault(c => c.PhoneNumber == phone);
            if (cust == null || customer.Id == cust.Id)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Phone number already exists");
            }
        }
    }
}
