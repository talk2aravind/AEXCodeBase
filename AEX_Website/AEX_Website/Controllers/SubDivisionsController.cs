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
    public class SubDivisionsController : Controller
    {
        private FundraisingDBEntities db = new FundraisingDBEntities();

        // GET: SubDivisions
        public ActionResult Index()
        {
            var subDivisions = db.SubDivisions.Include(s => s.Division);
            return View(subDivisions.ToList());
        }

        // GET: SubDivisions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubDivision subDivision = db.SubDivisions.Find(id);
            if (subDivision == null)
            {
                return HttpNotFound();
            }
            return View(subDivision);
        }

        // GET: SubDivisions/Create
        public ActionResult Create()
        {
            ViewBag.DivisionId = new SelectList(db.Divisions, "Id", "Name");
            return View();
        }

        // POST: SubDivisions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,DivisionId,FundTarget,IsActive")] SubDivision subDivision)
        {
            if (ModelState.IsValid)
            {
                db.SubDivisions.Add(subDivision);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DivisionId = new SelectList(db.Divisions, "Id", "Name", subDivision.DivisionId);
            return View(subDivision);
        }

        // GET: SubDivisions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubDivision subDivision = db.SubDivisions.Find(id);
            if (subDivision == null)
            {
                return HttpNotFound();
            }
            ViewBag.DivisionId = new SelectList(db.Divisions, "Id", "Name", subDivision.DivisionId);
            return View(subDivision);
        }

        // POST: SubDivisions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,DivisionId,FundTarget,IsActive")] SubDivision subDivision)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subDivision).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DivisionId = new SelectList(db.Divisions, "Id", "Name", subDivision.DivisionId);
            return View(subDivision);
        }

        // GET: SubDivisions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubDivision subDivision = db.SubDivisions.Find(id);
            if (subDivision == null)
            {
                return HttpNotFound();
            }
            return View(subDivision);
        }

        // POST: SubDivisions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubDivision subDivision = db.SubDivisions.Find(id);
            db.SubDivisions.Remove(subDivision);
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
