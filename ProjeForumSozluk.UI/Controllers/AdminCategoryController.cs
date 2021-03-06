using FluentValidation.Results;
using ProjeForumSozluk.BusinessLayer.Concrete;
using ProjeForumSozluk.BusinessLayer.ValidationRules;
using ProjeForumSozluk.DataAccessLayer.EntityFramework;
using ProjeForumSozluk.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeForumSozluk.UI.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var categoryValues = cm.GetList();
            return View(categoryValues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(category);
            if(results.IsValid)
            {
                cm.CategoryAdd(category);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        public ActionResult DeleteCategory(int id)
        {
            var categoryValue = cm.GetById(id);
            cm.CategoryDelete(categoryValue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var categoryValue = cm.GetById(id);

            return View(categoryValue);

        }

        [HttpPost]
        public ActionResult EditCategory(Category category)
        {
            cm.CategoryUpdate(category);
            return RedirectToAction("Index");
        }
    }
}