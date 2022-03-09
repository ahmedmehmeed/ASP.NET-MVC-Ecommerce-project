using Ecommerce.Models;
using Ecommerce.Repository;
using Ecommerce.View_Models;
using Microsoft.AspNetCore.Authorization;
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
                    //add user to role
                   await userManager.AddToRoleAsync(IdentityUser, "Customer");

                    //save success cookie to save login in client
                    await signInManager.SignInAsync(IdentityUser, false);

                    //authorize id cookie
                    return RedirectToAction("Index", "Home");

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


        // login 

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

                 var log = await  signInManager.PasswordSignInAsync(User,loginView.password,false,false);
                    if (log.Succeeded)
                    {
                        return RedirectToAction("Index","Home");
                    }
                    else
                        ModelState.AddModelError("", "password invalid");


                }
                else
                {
                    ModelState.AddModelError("", "username & password invalid");
                }



            }
            return View(loginView);
        }

        public async Task<IActionResult>  Logout()
        {
         await   signInManager.SignOutAsync();
           
          

            return RedirectToAction("Login");
        }






    }
}
