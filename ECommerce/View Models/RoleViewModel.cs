using System;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.View_Models
{
    public class RoleViewModel
    {
        [Required,Display(Name ="Role Name")]
        public String Role { get; set; } 
    }
}
