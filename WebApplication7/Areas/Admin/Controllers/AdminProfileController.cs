using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Areas.Admin.Models;

namespace WebApplication7.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin,Moderator")]
    public class AdminProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AdminProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        Context c = new Context();
        AdminManager AM = new AdminManager(new EfAdminRepository());
        UserManager usermanager = new UserManager(new EfUserRepository());
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            AdminUpdateViewModel model = new AdminUpdateViewModel();
            model.AdminName = values.NameSurname;
            model.AdminImage = values.ImageUrl;
            model.AdminUsername = values.UserName;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(AdminUpdateViewModel models)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.NameSurname = models.AdminName;
            values.ImageUrl = models.AdminImage;
            values.UserName = models.AdminUsername;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, models.AdminPassword);
            var result = await _userManager.UpdateAsync(values);
            if (result.Succeeded)
                return RedirectToAction("Index", "Login");
            else
                return View();
        }
    }
}
