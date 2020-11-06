using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Recruitment.Data.Entities;
using Recruitment.Data.ViewModel;

namespace Recruitment.WebApp.Controllers
{
        [Route("tai-khoan")]
        public class AccountController : Controller
        {
            private readonly UserManager<AppUser> userManager;
            private readonly SignInManager<AppUser> signInManager;

            public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
            {
                this.userManager = userManager;
                this.signInManager = signInManager;
            }

            [HttpGet]
            [AllowAnonymous]
            [Route("dang-ky")]
            public IActionResult Register()
            {
                return View();
            }

            [HttpPost]
            [AllowAnonymous]
        [Route("dang-ky")]
        public async Task<IActionResult> Register(RegisterViewModel model)
            {
                if (ModelState.IsValid)
                {
                    var user = new AppUser
                    {
                        UserName = model.Email,
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        FullName = model.LastName + " " + model.FirstName,
                        Email = model.Email
                    };
                    var result = await userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Login", "Account");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                return View();
            }

            [HttpGet]
            [Route("dang-nhap")]
            [AllowAnonymous]
            public async Task<IActionResult> Login(string returnUrl)
            {
                LoginViewModel model = new LoginViewModel
                {
                    ReturnUrl = returnUrl,
                    ExternalLogins =
                    (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
                };

                return View(model);
            }

            [HttpPost]
            [AllowAnonymous]
        [Route("dang-nhap")]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
            {
                if (ModelState.IsValid)
                {
                    var result = await signInManager.PasswordSignInAsync(
                        model.Email,
                        model.Password,
                        model.RememberMe,
                        false);
                    if (result.Succeeded)
                    {
                        if (!string.IsNullOrEmpty(returnUrl))
                        {
                            return Redirect(returnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }

                }
                return View(model);
            }

            [Route("dang-xuat")]
            [HttpGet]
            public async Task<IActionResult> Logout()
            {
                await signInManager.SignOutAsync();
                return RedirectToAction("index", "home");
            }

            // This method added for role tutorial
            [HttpGet]
            [Route("tu-choi")]
            [AllowAnonymous]
            public IActionResult AccessDenied()
            {
                return View();
            }
        }
}