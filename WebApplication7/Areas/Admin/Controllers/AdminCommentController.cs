using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin,Moderator")]
    public class AdminCommentController : Controller
    {
        CommentManager CM = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            var values = CM.GetListWithBlog();
            return View(values);
        }
    }
}
