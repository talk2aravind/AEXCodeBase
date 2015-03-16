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
    public class FundraisingsController : Controller
    {
        private FundraisingContext db = new FundraisingContext();

        // GET: Fundraisings
        public ActionResult Index()
        {
            return View(db.Fundraising.ToList());
        }

        // GET: Fundraisings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fundraising fundraising = db.Fundraising.Find(id);
            if (fundraising == null)
            {
                return HttpNotFound();
            }
            return View(fundraising);
        }

        // GET: Fundraisings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fundraisings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserName,Alias")] Fundraising fundraising)
        {
            if (ModelState.IsValid)
            {
                db.Fundraising.Add(fundraising);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fundraising);
        }

        // GET: Fundraisings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fundraising fundraising = db.Fundraising.Find(id);
            if (fundraising == null)
            {
                return HttpNotFound();
            }
            return View(fundraising);
        }

        // POST: Fundraisings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserName,Alias")] Fundraising fundraising)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fundraising).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fundraising);
        }

        // GET: Fundraisings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fundraising fundraising = db.Fundraising.Find(id);
            if (fundraising == null)
            {
                return HttpNotFound();
            }
            return View(fundraising);
        }

        // POST: Fundraisings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fundraising fundraising = db.Fundraising.Find(id);
            db.Fundraising.Remove(fundraising);
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
