using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApplication7.ViewComponents.Writer
{
    public class WriterAboutonDashboard:ViewComponent
    {
        readonly WriterManager wm = new(new EfWriterRepository());
        readonly Context c = new();
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            ViewBag.uname = username;
            var usermail = c.Users.Where(x => x.UserName == username).Select(z => z.Email).FirstOrDefault();
            // string mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();
            // var id = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value;
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = wm.GetWriterById(writerID);
            return View(values);
        }
    }
}
