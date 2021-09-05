using ProjeForumSozluk.BusinessLayer.Concrete;
using ProjeForumSozluk.BusinessLayer.ValidationRules;
using ProjeForumSozluk.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeForumSozluk.UI.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        public ActionResult Index()
        {
            var contatctValues = cm.GetList();
            return View(contatctValues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactValues = cm.GetById(id);
            return View(contactValues);
        }
    }
}