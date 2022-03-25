using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        Context c = new Context();
        Message2Manager MM = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(z => z.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(z => z.WriterID).FirstOrDefault();
            var values = MM.GetInboxListByWriter(writerID);
            return View(values);
        }
    }
}
