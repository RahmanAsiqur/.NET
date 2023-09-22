using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Education()
        {
            ViewBag.Message1 = "HSC";
            ViewBag.Message2= "Institution : Patuakhali GOVT College";
            ViewBag.Message3 = "Year : 2019";
            ViewBag.Message4 = "Grp : Science";
            ViewBag.Message5 = "Result : 4.31 ";


            return View();
        }

        public ActionResult References()
        {
          return View();
        }
    }
}