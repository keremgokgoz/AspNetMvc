using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Deneme()
        {
            ViewBag.Message = "Burası Deneme Sayfasıdır";
            return View();
        }
        public ActionResult Test()
        {
            ViewBag.Message = "Burası Test Sayfasıdır";
            return View();
        }
        public ActionResult DenemeLayout()
        {
            ViewBag.Message = "Burası DenemeLayout Sayfasıdır";
            return View();
        }
    }
}