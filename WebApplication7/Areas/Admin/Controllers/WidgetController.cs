using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Areas.Admin.Controllers
{
    public class WidgetController : Controller
    {
        [Area("Admin")]
        [Authorize(Roles ="Admin,Moderator")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
