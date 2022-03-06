using Ecommerce.Models;
using Ecommerce.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ecommerce.Controllers
{
    public class CustomerProductController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;

        public CustomerProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)

        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            List<Product> productsModel = productRepository.Getall();
            return View(productsModel);

        }

        //don't have view
        public IActionResult Details(int id)
        {
            Product product = productRepository.GetById(id);
            return View(product);
        }
    }
}
