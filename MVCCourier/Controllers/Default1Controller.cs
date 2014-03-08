using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCourier.Models;

namespace MVCCourier.Controllers
{
    public class Default1Controller : Controller
    {
        private PackageDataContext db = new PackageDataContext();

        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View(db.Packages.ToList());
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(long id = 0)
        {
            PackageModel packagemodel = db.Packages.Find(id);
            if (packagemodel == null)
            {
                return HttpNotFound();
            }
            return View(packagemodel);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PackageModel packagemodel)
        {
            if (ModelState.IsValid)
            {
                db.Packages.Add(packagemodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(packagemodel);
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(long id = 0)
        {
            PackageModel packagemodel = db.Packages.Find(id);
            if (packagemodel == null)
            {
                return HttpNotFound();
            }
            return View(packagemodel);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PackageModel packagemodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(packagemodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(packagemodel);
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(long id = 0)
        {
            PackageModel packagemodel = db.Packages.Find(id);
            if (packagemodel == null)
            {
                return HttpNotFound();
            }
            return View(packagemodel);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            PackageModel packagemodel = db.Packages.Find(id);
            db.Packages.Remove(packagemodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}