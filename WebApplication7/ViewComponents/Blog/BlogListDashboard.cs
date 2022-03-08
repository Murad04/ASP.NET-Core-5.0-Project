using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.ViewComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {
        readonly BlogManager bm = new(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListWithCategory().OrderByDescending(x=>x.BlogDate).ToList();
            return View(values);
        }
    }
}
