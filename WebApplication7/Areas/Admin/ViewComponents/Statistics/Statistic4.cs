using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Areas.Admin.ViewComponents.Statistics
{
    public class Statistic4:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Admins.Where(x => x.AdminID == 1).Select(x => x.AdminName).FirstOrDefault();
            ViewBag.v2 = c.Admins.Where(x => x.AdminID == 1).Select(x => x.AdminImage).FirstOrDefault();
            ViewBag.v3 = c.Admins.Where(x => x.AdminID == 1).Select(x => x.AdminBio).FirstOrDefault();
            return View();
        }
    }
}
