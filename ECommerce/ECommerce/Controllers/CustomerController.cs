using ECommerce.Models;
using ECommerce.ModelViews;
using ECommerce.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECommerce.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepository customerRepository;

        public CustomerController()
        {
            customerRepository = new CustomerRepository();
        }
        public ActionResult Index()
        {
            List<Customer> customers = customerRepository.Getall();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            Customer customer=customerRepository.GetById(id);
            return View(customer);
        }

        // GET: CustomerController/Create
        public ActionResult Add()
        {
            return View(new Customer());
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveAdd(CustomerModelView customerModelView)
        {
            if (ModelState.IsValid)
            {
                customerRepository.Insert(customerModelView);
                return RedirectToAction("Index");
            }
            else
                return View("Add",customerModelView);

        }

        public ActionResult Edit(int id)
        { Customer customer=customerRepository.GetById(id);
            return View(customer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveEdit(int id, CustomerModelView customerModelView)
        {
            if (ModelState.IsValid)
            {
                customerRepository.Update(id, customerModelView);
                return RedirectToAction("Index");
            }
            else
                return View("Edit", customerModelView);
        }

        
    }
}
