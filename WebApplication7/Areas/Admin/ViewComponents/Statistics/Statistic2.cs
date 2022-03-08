using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Areas.Admin.ViewComponents.Statistics
{
    public class Statistic2 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Blogs.OrderByDescending(x => x.BlogID).Select(y => y.BlogTitle).Take(1).FirstOrDefault();
            ViewBag.v2 = c.Comments.Take(1);
            return View();
        }
    }
}
