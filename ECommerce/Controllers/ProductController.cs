using Ecommerce.Models;
using Ecommerce.Repository;
using Ecommerce.View_Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository productReposit;
        public ProductController()
        {
            productReposit = new ProductRepository();
        }
        public IActionResult Index()
        {
            List<Product> productsModel = productReposit.Getall();
            return View(productsModel);
        }

        public IActionResult Details(int id)
        {
            Product product = productReposit.GetById(id);
            return View(product);
        }

        public IActionResult Add()
        {
            return View(new ProductViewModel());
        }
        public IActionResult SaveAdd(ProductViewModel NewProduct)
        {
            if (ModelState.IsValid)
            {

                productReposit.Insert(NewProduct);
                return RedirectToAction("Index");
            }
            else
                return View("Add", NewProduct);
        }

        public IActionResult Edit(int id)
        {
            Product product = productReposit.GetById(id);
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(int id, ProductViewModel Newproduct)
        {
            if (ModelState.IsValid == true)
            {
                productReposit.Update(id, Newproduct);
                return RedirectToAction("Index");
            }
            else
                return View("Edit", Newproduct);
        }

        public IActionResult Delete(int id)
        {

            productReposit.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
