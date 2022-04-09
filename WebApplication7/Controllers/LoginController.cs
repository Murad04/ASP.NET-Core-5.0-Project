using DataAccessLayer.Concrete;
using EntityLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication7.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace WebApplication7.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    { 
        AdminManager adminManager = new AdminManager(new EfAdminRepository());
        private readonly SignInManager<AppUser> _signInManager;
        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);
                if (result.Succeeded)
                {
                    var adminrole = adminManager.GetadminRole(p.username);
                    if(adminrole.Select(x => x.AdminRole).ToString()=="Admin")
                    {
                        return View("~/Admin/Widget/Index/");
                    }
                    else if(adminrole.Select(x=>x.AdminRole).ToString()=="Writer")
                    {
                        return RedirectToAction("Index", "Dashboard");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Login");
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}