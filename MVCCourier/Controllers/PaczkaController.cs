using MVCCourier.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCCourier.Controllers
{
    public class PaczkaController : Controller
    {
        private PaczkaEntity db = new PaczkaEntity();

        //
        // GET: /Paczka/

        public ActionResult Index()
        {
            return View(db.PackageModels.ToList());
        }

        //
        // GET: /Paczka/Details/5

        public ActionResult Details(long id = 0)
        {
            PackageModel packagemodel = db.PackageModels.Find(id);
            if (packagemodel == null)
            {
                return HttpNotFound();
            }
            return View(packagemodel);
        }

        //
        // GET: /Paczka/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Paczka/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PackageModel packagemodel)
        {
            if (ModelState.IsValid)
            {
                db.PackageModels.Add(packagemodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(packagemodel);
        }

        //
        // GET: /Paczka/Edit/5

        public ActionResult Edit(long id = 0)
        {
            PackageModel packagemodel = db.PackageModels.Find(id);
            if (packagemodel == null)
            {
                return HttpNotFound();
            }
            return View(packagemodel);
        }

        //
        // POST: /Paczka/Edit/5

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
        // GET: /Paczka/Delete/5

        public ActionResult Delete(long id = 0)
        {
            PackageModel packagemodel = db.PackageModels.Find(id);
            if (packagemodel == null)
            {
                return HttpNotFound();
            }
            return View(packagemodel);
        }

        //
        // POST: /Paczka/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            PackageModel packagemodel = db.PackageModels.Find(id);
            db.PackageModels.Remove(packagemodel);
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