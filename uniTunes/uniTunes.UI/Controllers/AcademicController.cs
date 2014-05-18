using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using uniTunes.Models;
using uniTunes.Data;

namespace uniTunes.UI.Controllers
{
    public class AcademicController : Controller
    {
        private UniContext db = new UniContext();

        // GET: /Academic/
        public ActionResult Index()
        {
            return View(db.Academics.ToList());
        }

        // GET: /Academic/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Academic academic = db.Academics.Find(id);
            if (academic == null)
            {
                return HttpNotFound();
            }
            return View(academic);
        }

        // GET: /Academic/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Academic/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="AcademicId,Login,Password,FirstName,LastName,Email,Link")] Academic academic)
        {
            if (ModelState.IsValid)
            {
                db.Academics.Add(academic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(academic);
        }

        // GET: /Academic/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Academic academic = db.Academics.Find(id);
            if (academic == null)
            {
                return HttpNotFound();
            }
            return View(academic);
        }

        // POST: /Academic/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="AcademicId,Login,Password,FirstName,LastName,Email,Link")] Academic academic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(academic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(academic);
        }

        // GET: /Academic/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Academic academic = db.Academics.Find(id);
            if (academic == null)
            {
                return HttpNotFound();
            }
            return View(academic);
        }

        // POST: /Academic/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Academic academic = db.Academics.Find(id);
            db.Academics.Remove(academic);
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
