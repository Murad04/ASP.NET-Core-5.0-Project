using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Areas.Admin.ViewComponents.Admin
{
    public class AdminMessageNotifications:ViewComponent
    {
        readonly Message2Manager M2M = new Message2Manager(new EfMessage2Repository());
        readonly Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(z => z.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(z => z.WriterID).FirstOrDefault();
            var values = M2M.GetInboxListByWriter(writerID).Take(3);
            ViewBag.countmessage = M2M.GetInboxListByWriter(writerID).Count();
            return View(values);
        }
    }
}
