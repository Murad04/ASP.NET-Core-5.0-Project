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
            var writername = User.Identity.Name;
            var writermail = c.Writers.Where(w => w.WriterName == writername).Select(z => z.WriterMail).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == writermail).Select(z => z.WriterID).FirstOrDefault();
            ViewBag.v1 = c.Blogs.Count().ToString();
            ViewBag.v2 = c.Blogs.Where(x => x.WriterID == writerID).Count().ToString();
            ViewBag.v3 = c.Blogs.Where(x => (x.BlogDate.Year == 2022))
                .Where(x => (DateTime.Now.DayOfYear - (x.BlogDate.DayOfYear) <= 7))
                .Where(x => (DateTime.Now.DayOfYear - (x.BlogDate.DayOfYear) >= 0)).Count().ToString();
            // int id = c.BlogRatings.OrderBy(r => r.BlogTotalScore).Take(1).First().BlogID;
            // var data = c.Blogs.OrderBy(b => b.BlogID==id).FirstOrDefault().BlogTitle;
            // ViewBag.v4 = data
            return View();
        }
    }
}
