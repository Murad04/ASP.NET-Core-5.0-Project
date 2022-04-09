using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
namespace WebApplication7.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin,Moderator")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new(new EfCategoryRepository());
        public IActionResult Index(int page=1)
        {
            var values = cm.GetList().ToPagedList(page, 3);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            CategoryValidator CV = new CategoryValidator();
            ValidationResult RV = CV.Validate(p);
            if (RV.IsValid)
            {
                p.CategoryStatus = true;
                cm.TAdd(p);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach(var item in RV.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var data = cm.GetById(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category p)
        {
            CategoryValidator CV = new CategoryValidator();
            ValidationResult VR = CV.Validate(p);
            if (VR.IsValid)
            {
                p.CategoryStatus = true;
                cm.TUpdate(p);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach(var item in VR.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult CategoryDelete(int id)
        {
            cm.SetPassive(id);
            return RedirectToAction("Index");
        }
        public IActionResult CategoryActivate(int id)
        {
            cm.SetActive(id);
            return RedirectToAction("Index");
        }
    }
}
