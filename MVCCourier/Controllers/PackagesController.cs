using MVCCourier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCCourier.Controllers
{
    public class PackagesController : Controller
    {
        public ActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            
            var db = new PackageDataContext();

            if (User.IsInRole("Admin"))
            {
                var packages = db.Packages.ToArray();
                return View("PackagesList", packages);
            }
            else 
            {
                var courierPackages = db.Packages.SqlQuery("Select * from PackageModels where Courier = '" + User.Identity.Name + "' order by DueDate;").ToArray();
                return View("PackagesList", courierPackages);
            }

        }

        [HttpGet]        
        public ActionResult NewPackage()
        {
            if (!User.IsInRole("Admin"))
            {
                return View("BłądUprawnień");
            }
            else
                return View("NewPackage", null);
                
        }

        [HttpPost]
        public ActionResult NewPackage([Bind]Models.PackageModel package)
        {
            if (ModelState.IsValid)
            {
                // Save to the database
                var db = new PackageDataContext();
                db.Packages.Add(package);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return NewPackage();
        }

        [HttpGet]
        public ActionResult Package(long id)
        {
            var db = new PackageDataContext();
            var package = db.Packages.Find(id);

            return View(package);
        }

        [HttpPost]
        public ActionResult Package(long id, bool IsDelivered)
        {
            var db = new PackageDataContext();
            var package = db.Packages.Find(id);
            package.IsDelivered = IsDelivered;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Edycja - do zrobienia!!
        [HttpGet]
        public ActionResult PackageEdit(long id)
        {
            var db = new PackageDataContext();
            var package = db.Packages.Find(id);

            return View("PackageEdit", package);
        }

        [HttpPost]
        public ActionResult PackageEdit()
        {
            var db = new PackageDataContext();
            return View("PackageEdit");
        }

        [HttpGet]
        public ActionResult PackageDelete(long id)
        {
            var db = new PackageDataContext();
            var package = db.Packages.Find(id);

            return View(package);
        }

        [HttpPost]
        public ActionResult PackageDelete([Bind]Models.PackageModel package, long id)
        {
            var db = new PackageDataContext();
            var packageToDelete = db.Packages.Find(id);
            db.Packages.Remove(packageToDelete);
            db.SaveChanges();
            return RedirectToAction("PackagesList");
        }

        public ActionResult Map()
        {
            return View();
        }

        public ActionResult Map2(long id)
        {
            var db = new PackageDataContext();
            var adress = db.Packages.Find(id).Adress;

            return View((object)adress);
        }
    }
}
