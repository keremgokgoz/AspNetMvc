using BusinessLayer.Concreate;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeUI.Controllers
{
    public class ContactController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        ContactManager com = new ContactManager();
        public ActionResult GetContactList()
        {
            var contactvalues = com.GetAll();
            return View(contactvalues);
        }
        public ActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddContact(Contact p)
        {
            com.ContactAddBL(p);
            return RedirectToAction("GetContactList");
        }
    }
}