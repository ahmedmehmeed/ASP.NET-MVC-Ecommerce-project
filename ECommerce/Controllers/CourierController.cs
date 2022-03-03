using Ecommerce.Models;
using Ecommerce.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ecommerce.Controllers
{
    public class CourierController : Controller
    {
        CourierRepository courierRepository;
        public CourierController()
        {
            courierRepository = new CourierRepository();
        }
        public IActionResult Index()
        {
            List<Courier> couriers = courierRepository.Getall();
            return View(couriers);
        }

        public IActionResult Details(int id)
        {
            Courier courier = courierRepository.GetById(id);
            return View(courier);
        }

        public IActionResult Add()
        {
            return View(new Courier());
        }
        public IActionResult SaveAdd(Courier NewCourier)
        {
            if (ModelState.IsValid)
            {

                courierRepository.Insert(NewCourier);
                return RedirectToAction("Index");
            }
            else
                return View("Add", NewCourier);
        }

        public IActionResult Edit(int id)
        {
            Courier courier = courierRepository.GetById(id);
            return View(courier);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(int id, Courier NewCourier)
        {
            if (ModelState.IsValid == true)
            {
                courierRepository.Update(id, NewCourier);
                return RedirectToAction("Index");
            }
            else
                return View("Edit", NewCourier);
        }


    }
}