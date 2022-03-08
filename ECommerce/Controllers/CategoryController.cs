using Microsoft.AspNetCore.Mvc;
using Ecommerce.Repository;
using Ecommerce.Models;
using Ecommerce.View_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryRepository categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            List<Category> categories = categoryRepository.Getall();
            return View(categories);
        }

        public IActionResult allproductsbycatid(int catid)
        {
            List<Product> products = categoryRepository.Getallproductsbycatid(catid);
            return View(products);
        }
       
        public IActionResult Details(int id)
        {
            Category category = categoryRepository.GetById(id);
            return View(category);
        }
        public IActionResult Add()
        {

            return View(new Category());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult SaveAdd(Category NewCetgory)
        {
            if (ModelState.IsValid)
            {
               
                    categoryRepository.Insert(NewCetgory);
                    return RedirectToAction("Index");
                
                
            }else
            
                return View("Add", NewCetgory);
        }
        
        public IActionResult Edit(int id)
        {
            Category category = categoryRepository.GetById(id);
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(int id, Category NewCategory)
        {
            if (ModelState.IsValid == true)
            {
                categoryRepository.Update(id, NewCategory);
                return RedirectToAction("Index");
            }
            else
                return View("Edit", NewCategory);
        }

        public IActionResult Delete(int id)
        {

            categoryRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

