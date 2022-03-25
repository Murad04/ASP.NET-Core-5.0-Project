using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager MM = new(new EfMessage2Repository());
        Context c = new Context();
        public IActionResult Inbox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(c => c.WriterMail == usermail).Select(z => z.WriterID).FirstOrDefault();
            var values = MM.GetInboxListByWriter(writerID);
            return View(values);
        }
        public IActionResult SendBox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(c => c.WriterMail == usermail).Select(z => z.WriterID).FirstOrDefault();
            var values = MM.GetSendboxListByWriter(writerID);
            return View(values);
        }
        [HttpGet]
        public PartialViewResult PartialGetList()
        {
            return PartialView();
        }
        public IActionResult MessageDetails(int id)
        {
            var messagevalue = MM.GetById(id);
            return View(messagevalue);
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message2 message)
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(z => z.WriterID).FirstOrDefault();
            message.Message_Sender = writerID;
            //message.Message_Receiver = 2;
            message.Durum = true;
            message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            MM.TAdd(message);
            return RedirectToAction("Inbox");
        }
    }
}
