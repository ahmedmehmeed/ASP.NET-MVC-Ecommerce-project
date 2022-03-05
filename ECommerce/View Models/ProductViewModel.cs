using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.View_Models
{
    public class ProductViewModel
    {
        [Required(ErrorMessage = "You must Enter Product Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must Enter A Product Desription")]

        public string Description { get; set; }
        [Required(ErrorMessage = "You must Enter Price")]

        public int Price { get; set; }

        public string image { get; set; }

        [Required(ErrorMessage = "You must Upload Image")] 

        public IFormFile Image { get; set; }
        public int CategoryId { get; set; }
        public List<Category> Category { get; set; }

    }
}
