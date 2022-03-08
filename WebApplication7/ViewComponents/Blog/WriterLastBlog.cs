using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.ViewComponents.Blog
{
    public class WriterLastBlog:ViewComponent
    {
        BlogManager BM = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = BM.GetBlogListByWriter(2);
            return View(values);
        }
    }
}
