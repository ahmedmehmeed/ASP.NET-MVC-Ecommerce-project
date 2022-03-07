using Ecommerce.Models;
using Ecommerce.Repository;
using Ecommerce.View_Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.IO;
using System;
using System.Threading.Tasks;


namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductController(IProductRepository productRepository,ICategoryRepository categoryRepository,IWebHostEnvironment hostEnvironment)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
            this._hostEnvironment = hostEnvironment;
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


        [HttpGet]
        public IActionResult Add()
        {
           ProductViewModel productViewModel = new ProductViewModel();  
         var allcategs = categoryRepository.Getall();
            productViewModel.Category = allcategs;

            return View(productViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddAsync(ProductViewModel NewProduct)
        {
            if (ModelState.IsValid)
            {

                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(NewProduct.Image.FileName);
                string extension = Path.GetExtension(NewProduct.Image.FileName);
                NewProduct.image = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/Images/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await NewProduct.Image.CopyToAsync(fileStream);
                }

                productRepository.Insert(NewProduct);
                return RedirectToAction("Index");
            }
            else
                return View("Add", NewProduct);
        }





        [HttpGet]
        public IActionResult Edit(int id)
        {
            ProductViewModel productViewModel = new ProductViewModel();

            var allcategs = categoryRepository.Getall();
            
            Product product = productRepository.GetById(id);
            productViewModel.Name = product.Name;   
            productViewModel.Description = product.Description;
            productViewModel.Price = (int)product.Price;
            productViewModel.image = product.Image;
            productViewModel.CategoryId = product.CategoryId;
            productViewModel.Category = allcategs;
           
            return View(productViewModel);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(int id, ProductViewModel NewProduct)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(NewProduct.Image.FileName);
                string extension = Path.GetExtension(NewProduct.Image.FileName);
                NewProduct.image = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/Images/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await NewProduct.Image.CopyToAsync(fileStream);
                }



                productRepository.Update(id, NewProduct);
                return RedirectToAction("Index");
            }
            else
                return View("Edit", NewProduct);
        }

        public IActionResult Delete(int id)
        {

            productRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
