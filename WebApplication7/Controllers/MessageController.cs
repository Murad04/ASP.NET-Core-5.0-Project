using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Controllers
{
    [AllowAnonymous]
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
    }
}
