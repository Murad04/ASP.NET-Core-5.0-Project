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

namespace WebApplication7.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
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
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }
        // [HttpPost]
        //public async Task<IActionResult> Index(Writer p)
        //{
        //    Context c = new();
        //    var datavalue = c.Writers.FirstOrDefault(w => w.WriterPassword == p.WriterPassword && w.WriterMail == p.WriterMail);
        //    if(datavalue !=null)
        //    {
        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name,p.WriterID.ToString()),
        //            new Claim(ClaimTypes.Email,p.WriterMail)
        //        };
        //        var useridentity = new ClaimsIdentity(claims,"a");
        //        ClaimsPrincipal principal = new(useridentity);
        //        await HttpContext.SignInAsync(principal);
        //        return RedirectToAction("Index", "Dashboard");
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index", "Login");
        //    }
        //}
    }
}