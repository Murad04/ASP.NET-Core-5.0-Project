using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Areas.Admin.ViewComponents.Admin
{
    public class Adminname:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public Adminname(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        AdminManager AM = new AdminManager(new EfAdminRepository());
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var writerid = _userManager.FindByNameAsync(username).Result;
            ViewBag.namesA = writerid.NameSurname;
            //ViewBag.imagesA = writerid.ImageUrl;
            return View();
        }
    }
}
