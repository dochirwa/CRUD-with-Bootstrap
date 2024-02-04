using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Controllers
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

        public ActionResult Gallery()
        {
            ViewBag.Message = "Your gallery page.";

            return View();
        }

        public ActionResult Info()
        {
            ViewBag.Message = "Your info page.";

            return View();
        }

        public ActionResult SimpleAddition()
        {
            ViewBag.Message = "Your addition page.";

            return View();
        }

        public ActionResult VariableDatatype()
        {
            ViewBag.Message = "Your variables and data types page.";

            return View();
        }

        public ActionResult ConditionsLoops()
        {
            ViewBag.Message = "Your conditional loop logic page.";

            return View();
        }

        public ActionResult UserDetails()
        {
            ViewBag.Message = "Your user details page.";

            return View();
        }

        public ActionResult Objects()
        {
            ViewBag.Message = "Your objects page.";

            return View();
        }

        public ActionResult Arrays()
        {
            ViewBag.Message = "Your arrays page.";

            return View();
        }

        public ActionResult Dictionary()
        {
            ViewBag.Message = "Your dictionary page.";

            return View();
        }

        public ActionResult Result()
        {
            ViewBag.Message = "Your results page.";

            return View();
        }
    }
}