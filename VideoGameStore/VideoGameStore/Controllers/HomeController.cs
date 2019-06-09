using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoGameStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() // returns the view home index in the home folder
        {
            return View();
        }
    }
}