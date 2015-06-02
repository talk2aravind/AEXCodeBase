using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AEXApplication.Models;

namespace AEXApplication.Controllers
{
    public class GearListsController : Controller
    {
        private AdventureExplorersDBEntities db = new AdventureExplorersDBEntities();

        // GET: GearLists
        public ActionResult Index()
        {
            return View(db.GearLists.ToList());
        }

        // GET: GearLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GearList gearList = db.GearLists.Find(id);
            if (gearList == null)
            {
                return HttpNotFound();
            }
            return View(gearList);
        }

        // GET: GearLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GearLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Gear,Model,DateOut,DateIn,CheckOutBy,CreatedDate,UpdatedDate,isActive")] GearList gearList)
        {
            if (ModelState.IsValid)
            {
                db.GearLists.Add(gearList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gearList);
        }

        // GET: GearLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GearList gearList = db.GearLists.Find(id);
            if (gearList == null)
            {
                return HttpNotFound();
            }
            return View(gearList);
        }

        // POST: GearLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Gear,Model,DateOut,DateIn,CheckOutBy,CreatedDate,UpdatedDate,isActive")] GearList gearList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gearList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gearList);
        }

        // GET: GearLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GearList gearList = db.GearLists.Find(id);
            if (gearList == null)
            {
                return HttpNotFound();
            }
            return View(gearList);
        }

        // POST: GearLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GearList gearList = db.GearLists.Find(id);
            db.GearLists.Remove(gearList);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
