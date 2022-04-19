using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApplication7.Controllers
{
    public class BlogController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public BlogController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        BlogManager bm = new BlogManager(new EfBlogRepository());
        CommentManager cmm = new CommentManager(new EfCommentRepository());
        CategoryManager cm = new(new EfCategoryRepository());
        WriterManager wm = new WriterManager(new EfWriterRepository());
        Context c = new();
        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();                                                                                          
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogByID(id);
            int commentcount = c.Comments.Where(c => c.BlogID == id).Count();
            ViewBag.commentc = commentcount;
            int bloglikes = values.Select(x => x.BlogLikes).FirstOrDefault();
            ViewBag.bloglike = bloglikes;
            ViewBag.countblog = c.Blogs.Count().ToString();
            ViewBag.commentcount = c.Comments.Count().ToString();
            return View(values);
        }
        [Authorize(Roles ="Writer, Admin")]
        public IActionResult BlogListByWriter()
        {
            var name = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == name).Select(y => y.Email).FirstOrDefault();
            var writerid = _userManager.FindByEmailAsync(usermail).Result;
            //var id = c.Writers.Where(x => x.WriterMail == usermail).Select(z=>z.WriterID).FirstOrDefault();
            var data = bm.GetListWithCategoryByWriterbm(writerid.Id);
            return View(data);
        }
        [Authorize(Roles = "Writer,Admin")]
        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   where x.CategoryStatus == true
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            var name = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == name).Select(y => y.Email).FirstOrDefault();
            var data =  _userManager.FindByEmailAsync(usermail).Result;
            //var writerid = c.Writers.Where(x => x.WriterMail == usermail).Select(z => z.WriterID).FirstOrDefault();
            BlogValidator BV = new BlogValidator();
            ValidationResult result = BV.Validate(blog);
            if (result.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.WriterID = data.Id;
                bm.TAdd(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteBlog(int id)
        {
            var blogvalue = bm.GetById(id);
            if (blogvalue is not null)
            {
                bm.TDelete(blogvalue);
                return RedirectToAction("BlogListByWriter");
            }
            else
            {
                return RedirectToAction("BlogListByWriter");
            }
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogValue = bm.GetById(id);
            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cvu = categoryvalues;
            return View(blogValue);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            var name = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == name).Select(y => y.Email).FirstOrDefault();
            var writerid = _userManager.FindByEmailAsync(usermail).Result;
            //var writerid = c.Writers.Where(x => x.WriterMail == usermail).Select(z => z.WriterID).FirstOrDefault();
            blog.WriterID = writerid.Id;
            bm.TUpdate(blog);
            return RedirectToAction("BlogListByWriter");
        }
        public IActionResult LikeBlog(int id)
        {
            var blogdata = bm.GetBlogByID(id);
            if (blogdata is not null)
            {
                bm.LikeBlog(id);
                return RedirectToAction("/BlogReadAll/" + id);
            }
            else
            {
                return View();
            }
        }
    }
}
