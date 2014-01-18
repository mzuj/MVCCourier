using MVCCourier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCCourier.Controllers
{
    public class AdministrationController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            if (!User.IsInRole("Admin"))
                return View("BłądUprawnień");
            else
                return View();
        }

        public ActionResult UsersList()
        {
            if (!User.IsInRole("Admin"))
                return View("BłądUprawnień");
            else
            {
                var db = new AccountDataContext();
                var users = db.Users.ToArray();
                return View("UsersList", users);
            }    
        }




    }
}
