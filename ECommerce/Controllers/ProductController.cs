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
        IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            List<Product> productsModel = productRepository.Getall();
            return View(productsModel);
        }

        public IActionResult Details(int id)
        {
            Product product = productRepository.GetById(id);
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

                productRepository.Insert(NewProduct);
                return RedirectToAction("Index");
            }
            else
                return View("Add", NewProduct);
        }

        public IActionResult Edit(int id)
        {
            Product product = productRepository.GetById(id);
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(int id, ProductViewModel Newproduct)
        {
            if (ModelState.IsValid == true)
            {
                productRepository.Update(id, Newproduct);
                return RedirectToAction("Index");
            }
            else
                return View("Edit", Newproduct);
        }

        public IActionResult Delete(int id)
        {

            productRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
