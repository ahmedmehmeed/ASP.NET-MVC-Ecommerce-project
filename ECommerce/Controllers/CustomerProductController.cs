using Ecommerce.Models;
using Ecommerce.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ecommerce.Controllers
{
    public class CustomerProductController : Controller
    {

        IProductRepository productRepository;
        public CustomerProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            List<Product> products = productRepository.Getall();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            Product product = productRepository.GetById(id);
            return View(product);
        }
    }
}
