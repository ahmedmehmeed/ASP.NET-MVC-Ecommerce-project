﻿using Ecommerce.Models;
using Ecommerce.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ICategoryRepository categoryRepository;
        ECommerceEntity context;
        public HomeController(ILogger<HomeController> logger,ICategoryRepository categoryRepository  )
        {
            _logger = logger;
            this.categoryRepository = categoryRepository;
            context= new ECommerceEntity();
        }

        public IActionResult Index()
        {
            List<Category> categories = categoryRepository.Getall();
            return View(categories);
        }

        
          public IActionResult Products(int CatId)
            {
                List<Product> products = context.Products.Where(n => n.CategoryId == CatId).ToList();
                return PartialView("_Products", products);
            }


        public IActionResult ProductDetails(int id)
        {
            Product product = context.Products.FirstOrDefault(n => n.Id == id);
              return View(product);
        }
        public IActionResult Privacy()
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
