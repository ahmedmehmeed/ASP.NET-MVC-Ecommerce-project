using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using System.Collections.Generic;
using System.Linq;
using ECommerce.Repository;
using System;
using ECommerce.ModelViews;

namespace ECommerce.Controllers
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
            return View(new ProductModelView());
        }
        public IActionResult SaveAdd(ProductModelView NewProduct)
            {
            if (ModelState.IsValid)
            {
               
                productReposit.Insert(NewProduct);
                return RedirectToAction("Index");
            }
            else
            return View("Add",NewProduct);
            }

        public  IActionResult Edit (int id)
        {
            Product product = productReposit.GetById(id);
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(int id,ProductModelView Newproduct)
        {
            if (ModelState.IsValid == true)
            {
                productReposit.Update(id, Newproduct);
                return RedirectToAction("Index");
            }
            else
                return View("Edit", Newproduct);
        }

       
    }   
}
