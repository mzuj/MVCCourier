using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCourier.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login","Account");               
            }
            else
                return View();
        }

        public ActionResult Packages()
        {
            return RedirectToAction("Index","Packages");
        }

    }
}
