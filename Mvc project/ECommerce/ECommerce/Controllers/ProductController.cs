using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Controllers
{
    public class ProductController : Controller
    {   
        ECommEntity Db=new ECommEntity();
        public IActionResult Index()
        {
            List<Product> productsModel = Db.Products.ToList();
            return View(productsModel);
        }

        public IActionResult Details(int id)
        {
            Product product = Db.Products.FirstOrDefault(d=>d.Id==id);
            return View(product);
        }

        public IActionResult Add()
        {
            return View(new Product());
        }
        public IActionResult SaveAdd(Product NewProduct)
            {
            if (ModelState.IsValid)
            {
                Db.Products.Add(NewProduct);
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Add",NewProduct);
            }

       
    }   
}
