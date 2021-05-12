using ProjeForumSozluk.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeForumSozluk.UI.Controllers
{
    public class IstatistikController : Controller
    {
        // GET: Istatistik
        Context c = new Context();

        public ActionResult Index()
        {
            var categoryCount = c.Categories.Count().ToString();
            ViewBag.categoryCnt = categoryCount;

            var categoryYazilim = c.Categories.Count(x => x.CategoryName == "yazılım" || x.CategoryName == "Yazılım").ToString();
            ViewBag.categoryYzlm = categoryYazilim;

            var categoryYazarA = c.Writers.Count(x => x.WriterName == "%a%" || x.WriterName == "%A%").ToString();
            ViewBag.categoryYzrA = categoryYazarA;

            var categoryMaxName = c.Headings.GroupBy(x => x.Category.CategoryName).OrderByDescending(k => k.Count()).Select(t => t.Key).FirstOrDefault();
            ViewBag.categoryMxNm = categoryMaxName;

            
            return View();
        }
    }
}