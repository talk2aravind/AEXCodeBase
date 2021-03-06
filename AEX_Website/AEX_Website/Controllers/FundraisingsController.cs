﻿using System;
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
        private FundraisingDBEntities db = new FundraisingDBEntities();

        // GET: Fundraisings
        public ActionResult Index()
        {
            var fundraisings = db.Fundraisings.Include(f => f.SubDivision).Include(f => f.Member);
            return View(fundraisings.ToList());
        }

        // GET: Fundraisings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fundraising fundraising = db.Fundraisings.Find(id);
            if (fundraising == null)
            {
                return HttpNotFound();
            }
            return View(fundraising);
        }

        // GET: Fundraisings/Create
        public ActionResult Create()
        {
            ViewBag.SubDivisionId = new SelectList(db.SubDivisions, "Id", "Name");
            ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName");
            return View();
        }

        // POST: Fundraisings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MemberId,SubDivisionId,AchievedTarget,ProfileDiscription,isActive")] Fundraising fundraising)
        {
            if (ModelState.IsValid)
            {
                db.Fundraisings.Add(fundraising);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SubDivisionId = new SelectList(db.SubDivisions, "Id", "Name", fundraising.SubDivisionId);
            ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName", fundraising.MemberId);
            return View(fundraising);
        }

        // GET: Fundraisings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fundraising fundraising = db.Fundraisings.Find(id);
            if (fundraising == null)
            {
                return HttpNotFound();
            }
            ViewBag.SubDivisionId = new SelectList(db.SubDivisions, "Id", "Name", fundraising.SubDivisionId);
            ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName", fundraising.MemberId);
            return View(fundraising);
        }

        // POST: Fundraisings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MemberId,SubDivisionId,AchievedTarget,ProfileDiscription,isActive")] Fundraising fundraising)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fundraising).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SubDivisionId = new SelectList(db.SubDivisions, "Id", "Name", fundraising.SubDivisionId);
            ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName", fundraising.MemberId);
            return View(fundraising);
        }

        // GET: Fundraisings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fundraising fundraising = db.Fundraisings.Find(id);
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
            Fundraising fundraising = db.Fundraisings.Find(id);
            db.Fundraisings.Remove(fundraising);
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
