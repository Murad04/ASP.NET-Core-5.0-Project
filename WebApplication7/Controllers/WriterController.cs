using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        Context c = new();
        [Authorize]
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;
            var writername = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.v2 = writername;
            return View();
        }
        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult WriterMail()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            string mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();
            var name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value;
            var writerID = c.Writers.Where(x => x.WriterMail == mail).Select(y => y.WriterID).FirstOrDefault();
            var writervalues = wm.GetById(writerID);
            return View(writervalues);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer w)
        {
            WriterValidator wl = new WriterValidator();
            ValidationResult results = wl.Validate(w);
            if (results.IsValid)
            {
                wm.TUpdate(w);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach(var itm in results.Errors)
                {
                    ModelState.AddModelError(itm.PropertyName, itm.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if(p.WriterImage is not null)
            {
                var extensions = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extensions;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename;
            }
            w.WriterMail = p.WriterMail;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            w.WriterName = p.WriterName;
            w.WriterAbout = p.WriterAbout;
            wm.TAdd(w);
            return RedirectToAction("Index","Dashboard");
        }
    }
}
