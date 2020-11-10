using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QlCoffe.ViewsModels;

namespace QlCoffe.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;


        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    userName: model.Username,
                    password: model.Password,
                    isPersistent: model.Remember,
                    lockoutOnFailure:false

                    );
                if (result.Succeeded)
                {
                    return RedirectToAction("Register");
                }
              
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser()
                {
                    Email = model.UserName,
                    UserName=model.UserName
                    
                };
              var result=await userManager.CreateAsync(user, model.PassWord);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user:user, isPersistent:false) ;
                    return RedirectToAction("Login");
                }

            }
            return View(model);
        }
    }
}
