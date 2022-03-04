using Ecommerce.Repository;
using Ecommerce.View_Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class CheckoutController : Controller
    {
        CheckOutRepository checkOutRepository;
        public CheckoutController()
        {
            checkOutRepository = new CheckOutRepository();
        }
       

        public IActionResult Details(string user)
        {
            CheckOutViewModel checkOut = checkOutRepository.GetByUserName(user);
            return View(checkOut);
        }

        public IActionResult Add()
        {
            return View(new CheckOutViewModel());
        }
        public IActionResult SaveAdd(CheckOutViewModel checkOut)
        {
            if (ModelState.IsValid)
            {

                checkOutRepository.Insert(checkOut);
                return RedirectToAction("Index");
            }
            else
                return View("Add", checkOut);
        }

    }
}
