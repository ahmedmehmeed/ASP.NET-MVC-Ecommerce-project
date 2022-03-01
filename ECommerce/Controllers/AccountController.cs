using Ecommerce.View_Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class AccountController : Controller
    {
      // register
      [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel  Customer)
        {
            return View();
        }
    }
}
