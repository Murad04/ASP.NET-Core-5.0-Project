using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult Compose()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Compose(Message2 message2)
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
    }
}
