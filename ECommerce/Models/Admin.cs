using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class Admin
    {   [Key]
        public int Id { get; set; } 
        [ForeignKey("IdentityUser")]
        public string User_Id { get; set; }
        [Required]
        public string Image { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
