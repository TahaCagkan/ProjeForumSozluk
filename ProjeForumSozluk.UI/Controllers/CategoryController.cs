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
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EfCategoryDal()); 

        public ActionResult Index()
        {
            return View(); 
        }

        public ActionResult GetCategoryList()
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
            //cm.CategoryAddBL(category);
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(category);
            
            if(results.IsValid)
            {
                cm.CategoryAdd(category);
                return RedirectToAction("GetCategoryList");
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
    }
}