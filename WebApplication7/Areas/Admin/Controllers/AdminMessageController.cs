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
        Message2TrashBinManager M2TM = new Message2TrashBinManager(new EfMessage2TrashBinRepository());
        Message2Manager MM = new Message2Manager(new EfMessage2Repository());
        Context c = new Context();
        public IActionResult Inbox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(c => c.WriterMail == usermail).Select(z => z.WriterID).FirstOrDefault();
            var values = MM.GetInboxListByWriter(writerID);
            ViewBag.v2 = values.Where(x=>x.Read!=true).ToList().Count;
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
        public IActionResult DeleteMessage(int id)
        {
            Message2TrashBin MMt = new Message2TrashBin();
            var message = MM.GetById(id);
            if(message is not null)
            {
                MMt.Message_Receiver = message.Message_Receiver;
                MMt.Message_Title = message.Message_Title;
                MMt.Date = message.Date;
                MMt.Message_Context = message.Message_Context;
                MMt.Message_Sender = message.Message_Sender;
                MMt.Type = message.Type;
                M2TM.AddMessage(MMt);
                MM.TDelete(message);
                return RedirectToAction("Inbox");
            }
            else
            {
                return View();
            }
        }
        public IActionResult MarkAsImportant(int id)
        {
            var data = MM.GetById(id);
            if(data is not null)
            {
                MM.MarkAsImportant(data.Message_ID);
                return RedirectToAction("ImportantMessage", "AdminMessage");
            }
            else
            {
                return View();
            }
        }
        public IActionResult MarkAsNotImportant(int id)
        {
            var data = MM.GetById(id);
            if(data is not null)
            {
                MM.MarkAsNotImportant(data.Message_ID);
                return RedirectToAction("Inbox");
            }
            else
            {
                return View();
            }
        }
        public IActionResult MarkAsRead(int id)
        {
            var data = MM.GetById(id);
            if (data is not null)
            {
                MM.MarkAsRead(data.Message_ID);
                return RedirectToAction("Inbox");
            }
            else
            {
                return View();
            }
        }
    }
}
