using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace entregaVenta.Controllers
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
        public ActionResult SellerHome()
        {
            ViewBag.UserRole = TempData["UserRole"] as string;
            return View();
        }

        public ActionResult AccountantHome()
        {
            ViewBag.UserRole = TempData["UserRole"] as string;
            return View();
        }

    }
}