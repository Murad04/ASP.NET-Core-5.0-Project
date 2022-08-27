using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.ViewComponents.Writer
{
    public class WriterNameMenu:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        public WriterNameMenu(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        Context c = new Context();
        AdminManager AM = new AdminManager(new EfAdminRepository());
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var writerid = _userManager.FindByNameAsync(username).Result;
            ViewBag.names = writerid.NameSurname;
            //ViewBag.images = writerid.ImageUrl;
            return View();
        }
    }
}
