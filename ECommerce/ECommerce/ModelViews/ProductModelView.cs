using Microsoft.AspNetCore.Http;
using ECommerce.Models;
using System.Collections.Generic;

namespace ECommerce.ModelViews
{
    public class ProductModelView
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int OldPrice { get; set; }
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
        public int CategoryId { get; set; }
        public List<Category> Category { get; set; }


    }
}
