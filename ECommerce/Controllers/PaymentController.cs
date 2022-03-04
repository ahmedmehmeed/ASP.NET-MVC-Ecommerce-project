using Ecommerce.Models;
using Ecommerce.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ecommerce.Controllers
{
    public class PaymentController : Controller
    {
        IPaymentRepository paymentRepository;
        public PaymentController(IPaymentRepository paymentRepository)
        {
            this.paymentRepository = paymentRepository;
        }
        public IActionResult Index()
        {
            List<Payment> payments = paymentRepository.Getall();
            return View(payments);
        }

        public IActionResult Details(int id)
        {
            Payment payment = paymentRepository.GetById(id);
            return View(payment);
        }

        public IActionResult Add()
        {
            return View(new Payment());
        }
        public IActionResult SaveAdd(Payment NewPayment)
        {
            if (ModelState.IsValid)
            {

                paymentRepository.Insert(NewPayment);
                return RedirectToAction("Index");
            }
            else
                return View("Add", NewPayment);
        }

        public IActionResult Edit(int id)
        {
            Payment payment = paymentRepository.GetById(id);
            return View(payment);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(int id, Payment NewPayment)
        {
            if (ModelState.IsValid == true)
            {
                paymentRepository.Update(id, NewPayment);
                return RedirectToAction("Index");
            }
            else
                return View("Edit", NewPayment);
        }
        public IActionResult Delete(int id)
        {

            paymentRepository.Delete(id);
            return RedirectToAction("Index");
        }

    }
}

