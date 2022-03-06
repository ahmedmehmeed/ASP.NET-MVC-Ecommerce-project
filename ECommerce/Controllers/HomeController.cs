using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Repository;


namespace Ecommerce.Controllers
{
    public class HomeController : Controller

    {
        private readonly ILogger<HomeController> _logger;

        ECommerceEntity entity;
        ICategoryRepository categoryRepository;
        public HomeController(ILogger<HomeController> logger, ICategoryRepository categoryRepository)
        {
            _logger = logger;
            this.categoryRepository = categoryRepository;
            entity = new ECommerceEntity();
        }

        public IActionResult Index()
        {
            List<Category> catModel = categoryRepository.Getall();
            return View(catModel);
            
        }
        public IActionResult Products(int CatId)
        {
            List<Product> products = entity.Products.Where(n => n.CategoryId == CatId).ToList();
            return PartialView("_Products", products);
            
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
