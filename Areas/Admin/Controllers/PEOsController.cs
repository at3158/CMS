﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CMS.Models;

namespace CMS.Areas.Admin.Controllers
{
    public class PEOsController : Controller
    {
        private TESTDBEntities db = new TESTDBEntities();

        // GET: Admin/PEOs
        public ActionResult Index()
        {
            return View(db.PEO.ToList());
        }

        // GET: Admin/PEOs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PEO pEO = db.PEO.Find(id);
            if (pEO == null)
            {
                return HttpNotFound();
            }
            return View(pEO);
        }

        // GET: Admin/PEOs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/PEOs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NAME,CREATEDATE")] PEO pEO)
        {
            if (ModelState.IsValid)
            {
                db.PEO.Add(pEO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pEO);
        }

        // GET: Admin/PEOs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PEO pEO = db.PEO.Find(id);
            if (pEO == null)
            {
                return HttpNotFound();
            }
            return View(pEO);
        }

        // POST: Admin/PEOs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NAME,CREATEDATE")] PEO pEO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pEO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pEO);
        }

        // GET: Admin/PEOs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PEO pEO = db.PEO.Find(id);
            if (pEO == null)
            {
                return HttpNotFound();
            }
            return View(pEO);
        }

        // POST: Admin/PEOs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PEO pEO = db.PEO.Find(id);
            db.PEO.Remove(pEO);
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
