using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Controllers
{
    public class DashboardController : Controller
    {
        Context c = new();
        public IActionResult Index()
        {
            var name = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == name).Select(y => y.Email).FirstOrDefault();
            var id = c.Writers.Where(x => x.WriterMail == usermail).Select(z => z.WriterID).FirstOrDefault();
            ViewBag.v1 = c.Blogs.Count().ToString();
            ViewBag.v2 = c.Blogs.Where(x => x.WriterID == id).Count().ToString();
            ViewBag.v3 = c.Blogs.Where(x => (x.BlogDate.Year == 2022))
                .Where(x => (DateTime.Now.DayOfYear - (x.BlogDate.DayOfYear) <= 7))
                .Where(x => (DateTime.Now.DayOfYear - (x.BlogDate.DayOfYear) >= 0)).Count().ToString();
            return View();
        }
    }
}
