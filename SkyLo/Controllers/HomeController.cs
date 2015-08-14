using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkyLo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "SkyLo.";

            if (User.IsInRole("SuperAdmin") || User.IsInRole("Admin"))
                return RedirectToAction("Index", "Admin");

            if (User.IsInRole("Staff"))
                return RedirectToAction("Index", "Glassies");

            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Guest");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This page was made by Minh-Tam Nguyen-Nhat.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My Contact Details.";

            return View();
        }
    }
}