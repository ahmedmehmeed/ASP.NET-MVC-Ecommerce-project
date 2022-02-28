using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class Customer
    {
        public Customer()
        {
            Orders=new HashSet<Order>();
            Payments=new HashSet<Payment>();

        }
        public int Id { get; set; }

        [Required(ErrorMessage = "You must Enter A First Name")]
        public string FName { get; set; }


        [Required(ErrorMessage = "You must Enter A Last Name")]
        public string LName { get; set; }


        [Required(ErrorMessage = "You must Enter A Date OF Birth ")]
        public string DOB { get; set; }


        [Required(ErrorMessage = "You must Enter Your Email")]
        [EmailAddress]
        //[unique]
        public string Email { get; set; }


        [Required(ErrorMessage = "You must Enter Password")]

        public string Password { get; set; }


        [Required(ErrorMessage = "You must Enter Your phone Number")]
        //[unique]

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "You must Enter Your Address ")]

        public string Address { get; set; }


        //must be male or female
        public string Gender { get; set; }
       

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }



    }


}
