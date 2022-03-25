using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBlogController : Controller
    {
        BlogManager BM = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = BM.GetBlogListWithCategory();
            return View(values);
        }
    }
}
