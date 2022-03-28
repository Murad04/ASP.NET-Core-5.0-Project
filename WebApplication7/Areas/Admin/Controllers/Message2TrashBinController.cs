using DataAccessLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Areas.Controllers
{
    [Area("Admin")]
    public class Message2TrashBinController : Controller
    {
        Message2TrashBinManager M2TM = new(new EfMessage2TrashBinRepository());
        Context c = new Context();
        public IActionResult Trash()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(c => c.WriterMail == usermail).Select(z => z.WriterID).FirstOrDefault();
            var values = M2TM.GetListById(writerID);
            ViewBag.v2 = values.Count();
            return View(values);
        }
        public IActionResult DeleteMessage(int id)
        {
            var data = M2TM.GetById(id);
            if (data is not null)
            {
                M2TM.TDelete(data);
                return RedirectToAction("Trash");
            }
            else
            {
                return View();
            }
        }
    }
}
