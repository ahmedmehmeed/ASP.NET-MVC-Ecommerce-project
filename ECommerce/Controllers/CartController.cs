using Ecommerce.Models;
using Ecommerce.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Controllers
{
    public class CartController : Controller
    {
        ICartRepositoy cartRepositoy;
        public CartController(ICartRepositoy cartRepositoy)
        {
            this.cartRepositoy = cartRepositoy;
        }
        public IActionResult Index()
        {
            List<Cart> carts = cartRepositoy.Getall();
            return View(carts);
        }

        public IActionResult Details(int id)
        {
            Cart cart = cartRepositoy.GetById(id);
            return View(cart);
        }

        public IActionResult Add()
        {
            return View(new Cart());
        }
        public IActionResult SaveAdd(Cart NewCart)
        {
            if (ModelState.IsValid)
            {

                cartRepositoy.Insert(NewCart);
                return RedirectToAction("Index");
            }
            else
                return View("Add", NewCart);
        }

      
        public IActionResult Delete(int id)
        {

            cartRepositoy.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
