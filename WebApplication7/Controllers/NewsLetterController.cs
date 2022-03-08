using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Controllers
{
    public class NewsLetterController : Controller
    {
        readonly NewsLetterManager NM = new(new EfNewsLetterRepository());
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter p )
        {
            p.MailStatus = true;
            NM.AddNewsLetter(p);
            return PartialView();
        }
    }
}
