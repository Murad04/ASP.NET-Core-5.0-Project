using BusinessLayer.Concrete;
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
        Message2Manager MM = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            var values = MM.GetInboxListByWriter(2);
            return View(values);
        }
    }
}
