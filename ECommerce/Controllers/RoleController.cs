using Ecommerce.View_Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
              this.roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult AddRole()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel newrole)
        {

            if (ModelState.IsValid)
            {

                IdentityRole identityRole = new IdentityRole();
                identityRole.Name = newrole.Role;

                 var res =  await roleManager.CreateAsync(identityRole);
                if (res.Succeeded)
                {
                    return View(newrole);
                }
                else
                {
                    foreach (var error in res.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }



            }




            return View(newrole);
        }








    }
}
