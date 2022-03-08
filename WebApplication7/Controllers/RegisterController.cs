using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            WriterValidator WriterV = new WriterValidator();
            ValidationResult ValidationR = WriterV.Validate(writer);
            if (ValidationR.IsValid)
            {
                writer.WriterStatus = true;
                writer.WriterAbout = "Olmusdu";
                wm.TAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach(var item in ValidationR.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
