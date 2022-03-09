using Ecommerce.Models;
using Ecommerce.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Controllers
{
    public class CustomerProductController : Controller
    {
        ECommerceEntity context;
        ICategoryRepository categoryRepository;
        IProductRepository productRepository;
        public CustomerProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
            context=new ECommerceEntity();
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


        public IActionResult Details(int id)
        {
            Product product = productRepository.GetById(id);
            return View(product);
        }
    }
}
