using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebApplication7.Areas.Admin.ViewComponents.Statistics
{
    public class Statistic1 : ViewComponent
    {
        BlogManager BM = new(new EfBlogRepository());
        Context c = new();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = BM.GetList().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();
            string APIKey = "8ea28950fbeaf6fac3fb660a28377eac";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Baku&units=metric&mode=xml&appid=" + APIKey;
            XDocument document = XDocument.Load(connection);
            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("unit").Value;
            ViewBag.v6 = document.Descendants("weather").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
