using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController1 : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterUserController1(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpViewModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new()
                {
                    Email = p.Mail,
                    UserName = p.Username,
                    NameSurname = p.nameSurname
                };

                var result = await _userManager.CreateAsync(user, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach(var itm in result.Errors)
                    {
                        ModelState.AddModelError("", itm.Description);
                    }
                }
            }
            return View(p);
        }
    }
}
