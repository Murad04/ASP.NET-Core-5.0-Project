using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Areas.Admin.ValidationRules;

namespace WebApplication7.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminMessageController : Controller
    {
        Message2Manager MM = new Message2Manager(new EfMessage2Repository());
        Context c = new Context();
        public IActionResult Inbox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(c => c.WriterMail == usermail).Select(z => z.WriterID).FirstOrDefault();
            var values = MM.GetInboxListByWriter(writerID);
            ViewBag.v2 = values.Count;
            return View(values);
        }
        public IActionResult SendBox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(c => c.WriterMail == usermail).Select(z => z.WriterID).FirstOrDefault();
            var values = MM.GetSendboxListByWriter(writerID);
            ViewBag.v3 = values.Count;
            return View(values);
        }
        public IActionResult WorkMessage()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(z => z.Email).FirstOrDefault();
            var writerID = c.Writers.Where(c => c.WriterMail == usermail).Select(d => d.WriterID).FirstOrDefault();
            var values = MM.GetWorkMailListByWriter(writerID);
            ViewBag.v1 = values.Count;
            return View(values);
        }
        public IActionResult ImportantMessage()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(z => z.Email).FirstOrDefault();
            var writerID = c.Writers.Where(c => c.WriterMail == usermail).Select(d => d.WriterID).FirstOrDefault();
            var values = MM.GetImportantMailListByWriter(writerID);
            ViewBag.v4 = values.Count;
            return View(values);
        }
        public IActionResult DocumentMessage()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(z => z.Email).FirstOrDefault();
            var writerID = c.Writers.Where(c => c.WriterMail == usermail).Select(z => z.WriterID).FirstOrDefault();
            var values = MM.GetDocumentsMailListByWriter(writerID);
            ViewBag.v5 = values.Count;
            return View(values);
        }
        public IActionResult PromotionMessage()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(z => z.Email).FirstOrDefault();
            var writerID = c.Writers.Where(c => c.WriterMail == usermail).Select(z => z.WriterID).FirstOrDefault();
            var values = MM.GetPromotionMailListByWriter(writerID);
            ViewBag.v6 = values.Count;
            return View(values);
        }
        public IActionResult DemandMessage()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(z => z.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(x => x.WriterID).FirstOrDefault();
            var values = MM.GetDemandMailListByWriter(writerID);
            ViewBag.v7 = values.Count;
            return View(values);
        }
        [HttpGet]
        public IActionResult Compose()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Compose(Message2 message2)
        {
            AdminMessageValidator validationRules = new AdminMessageValidator();
            ValidationResult VR = validationRules.Validate(message2);
            if (VR.IsValid)
            {
                var username = User.Identity.Name;
                var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
                var writerID = c.Writers.Where(c => c.WriterMail == usermail).Select(z => z.WriterID).FirstOrDefault();
                message2.Message_Sender = writerID;
                message2.Message_Receiver = 2;
                message2.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                message2.Durum = true;
                MM.TAdd(message2);
                return RedirectToAction("SendBox");
            }
            else
            {
                foreach (var item in VR.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
