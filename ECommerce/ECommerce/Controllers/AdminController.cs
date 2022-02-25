using ECommerce.Models;
using ECommerce.ModelViews;
using ECommerce.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECommerce.Controllers
{
    public class AdminController : Controller
    {
        AdminRepository AdminReposit;
        public AdminController()
        {
            AdminReposit = new AdminRepository();
        }
        public ActionResult Index()
        {
            List<Admin> admins = AdminReposit.Getall();
            return View(admins);
        }

        public ActionResult Details(int id)
        {
            Admin admin=AdminReposit.GetById(id);
            return View(admin);
        }

        public ActionResult Add()
        { 
            
            return View(new Admin());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveAdd(AdminModelView adminModelView)
        {
            if (ModelState.IsValid == true) { 
                AdminReposit.Insert(adminModelView);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Add",adminModelView);
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {  Admin admin = AdminReposit.GetById(id);

            return View(admin);
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AdminModelView adminModelView)
        {
            if(ModelState.IsValid == true) 
            { AdminReposit.Update(id, adminModelView);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit",adminModelView);
            }
        }

      
    }
}
