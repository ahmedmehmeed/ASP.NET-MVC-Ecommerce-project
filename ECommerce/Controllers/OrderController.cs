using Ecommerce.Models;
using Ecommerce.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ecommerce.Controllers
{
    public class OrderController : Controller
    {
        IOrderRepository orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public IActionResult Index()
        {
            List<Order> orders = orderRepository.Getall();
            return View(orders);
        }

        public IActionResult Details(int id)
        {
            Order order = orderRepository.GetById(id);
            return View(order);
        }

        public IActionResult Add()
        {
            return View(new Order());
        }
        public IActionResult SaveAdd(Order NewOrder)
        {
            if (ModelState.IsValid)
            {

                orderRepository.Insert(NewOrder);
                return RedirectToAction("Index");
            }
            else
                return View("Add", NewOrder);
        }

        public IActionResult Edit(int id)
        {
            Order order = orderRepository.GetById(id);
            return View(order);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(int id, Order NewOrder)
        {
            if (ModelState.IsValid == true)
            {
                orderRepository.Update(id, NewOrder);
                return RedirectToAction("Index");
            }
            else
                return View("Edit", NewOrder);
        }
        public IActionResult Delete(int id)
        {

            orderRepository.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
