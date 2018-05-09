using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is about me! Hello World";

            return View();
        }

        public ActionResult Contact()
        {
            var profile = new Models.Profile();
            ViewBag.Title = "Welcome To Business Technology";
            ViewBag.Message = "This is my contact page.";
            return View(profile);
        }
    }
}