using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UserManagementSystem.Models;

namespace UserManagementSystem.Controllers
{
    public class usersystemsController : Controller
    {
        private Model1 db = new Model1();

        // GET: usersystems
        public ActionResult Index()
        {
            return View(db.usersystems.ToList());
        }

        // GET: usersystems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            usersystem usersystem = db.usersystems.Find(id);
            if (usersystem == null)
            {
                return HttpNotFound();
            }
            return View(usersystem);
        }

        // GET: usersystems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: usersystems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,email,password,contact,address,aadharNo,dob")] usersystem usersystem)
        {
            if (ModelState.IsValid)
            {
                db.usersystems.Add(usersystem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usersystem);
        }

        // GET: usersystems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            usersystem usersystem = db.usersystems.Find(id);
            if (usersystem == null)
            {
                return HttpNotFound();
            }
            return View(usersystem);
        }

        // POST: usersystems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,email,password,contact,address,aadharNo,dob")] usersystem usersystem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usersystem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usersystem);
        }

        // GET: usersystems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            usersystem usersystem = db.usersystems.Find(id);
            if (usersystem == null)
            {
                return HttpNotFound();
            }
            return View(usersystem);
        }

        // POST: usersystems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            usersystem usersystem = db.usersystems.Find(id);
            db.usersystems.Remove(usersystem);
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
