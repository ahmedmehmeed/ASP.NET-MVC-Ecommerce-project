﻿using Ecommerce.Models;
using Ecommerce.Repository;
using Ecommerce.View_Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class AccountController : Controller
    {
        //Cusstomer repository في مشكله علشان كدا مش عارف استخدم ال 
        ECommerceEntity ECommerceEntity =new ECommerceEntity();

        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> _userManager,SignInManager<IdentityUser> _signInManager)
        {
            this.userManager = _userManager;
            this.signInManager = _signInManager;
        }
      // register
      [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> Register(RegisterViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser IdentityUser = new IdentityUser();
                IdentityUser.UserName = customerViewModel.UserName;
                IdentityUser.Email = customerViewModel.Email;
                IdentityUser.PhoneNumber = customerViewModel.PhoneNumber;
                IdentityUser.PasswordHash = customerViewModel.Password;

                IdentityResult result =  await userManager.CreateAsync(IdentityUser, customerViewModel.Password);
                if(result.Succeeded)
                {
                    IdentityUser user    =  await userManager.FindByNameAsync(customerViewModel.UserName);

                    Customer customer = new Customer();
                    customer.FName = customerViewModel.FName;
                    customer.LName = customerViewModel.LName;
                    customer.CustomerId=user.Id;
                    ECommerceEntity.Customers.Add(customer);
                    ECommerceEntity.SaveChanges();


                    //save success cookie to save login in client
                    await signInManager.SignInAsync(IdentityUser, false);

                    //authorize id cookie


                }
                else
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(customerViewModel);
        }




        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }



        [HttpPost]
        public async Task< IActionResult> Login(LoginViewModel loginView)
        {
            if (ModelState.IsValid)
            {
              var User= await userManager.FindByNameAsync(loginView.username);
                if (User != null)
                {

                  await  signInManager.PasswordSignInAsync(User,loginView.password,loginView.persist,false);
                    return RedirectToAction("Index", "Product");

                }
                else
                {
                    ModelState.AddModelError("", "username & password invalid");
                }



            }



            return View(loginView);
        }

    }
}
