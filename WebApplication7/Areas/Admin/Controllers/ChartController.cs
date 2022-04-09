using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Areas.Admin.Models;

namespace WebApplication7.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> categories = new List<CategoryClass>()
            {
                new CategoryClass
                {
                    categoryname = "Bilim-kurgu",
                    categorycount = 8
                },
                new CategoryClass
                {
                    categoryname="Yazilim",
                    categorycount=12
                },
                new CategoryClass
                {
                    categoryname="Siber Guvenlik",
                    categorycount=22
                }
            };
            return Json(new { jsonList = categories });
        }
    }
}
