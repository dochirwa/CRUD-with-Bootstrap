using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Controllers
{
    public class MyFirstController : Controller
    {
        // GET: MyFirst
        public string Index()
        {
            return "This is a default action..";
        }

        public string Welcome()
        {
            return "This is my own Welcome action method!!";
        }
    }
}