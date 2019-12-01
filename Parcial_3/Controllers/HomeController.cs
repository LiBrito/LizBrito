using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial_3.Controllers
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

        public ActionResult Visita()
        {
            ViewBag.Message = "Visit Inventory";

            return View();
        }
        public ActionResult Persona()
        {
            ViewBag.Message = "People Inventory";

            return View();
        }
        public ActionResult Area()
        {
            ViewBag.Message = "Area Inventory";

            return View();
        }
    }
}