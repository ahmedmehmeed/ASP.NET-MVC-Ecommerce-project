using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Ecommerce.Models
{
    public class UniqueEmailAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Customer customer = (Customer)validationContext.ObjectInstance;
            string email = value.ToString();
            ECommerceEntity EC = new ECommerceEntity();
            Customer cust = EC.Customers.FirstOrDefault(c => c.Email == email);
            if (cust == null || customer.Id == cust.Id)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("This Email already exists");
            }
        }
    }
}
