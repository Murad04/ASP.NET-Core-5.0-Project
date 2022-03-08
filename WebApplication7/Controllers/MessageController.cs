using BusinessLayer.Concrete;
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
        public IActionResult Inbox()
        {
            int id = 2;
            var values = MM.GetInboxListByWriter(id);
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
