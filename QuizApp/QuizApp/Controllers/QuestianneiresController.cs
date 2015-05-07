using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuizApp.DAL;
using QuizApp.Models;

namespace QuizApp.Controllers
{
    public class QuestianneiresController : Controller
    {
        private QuizContext db = new QuizContext();

        // GET: Questianneires
        public ActionResult Index()
        {
            return View(db.Questianneires.ToList());
        }

        // GET: Questianneires/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questianneire questianneire = db.Questianneires.Find(id);
            if (questianneire == null)
            {
                return HttpNotFound();
            }
            return View(questianneire);
        }

        // GET: Questianneires/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Questianneires/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Questianneire questianneire)
        {
            if (ModelState.IsValid)
            {
                db.Questianneires.Add(questianneire);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(questianneire);
        }

        // GET: Questianneires/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questianneire questianneire = db.Questianneires.Find(id);
            if (questianneire == null)
            {
                return HttpNotFound();
            }
            return View(questianneire);
        }

        // POST: Questianneires/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Questianneire questianneire)
        {
            if (ModelState.IsValid)
            {
                db.Entry(questianneire).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(questianneire);
        }

        // GET: Questianneires/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questianneire questianneire = db.Questianneires.Find(id);
            if (questianneire == null)
            {
                return HttpNotFound();
            }
            return View(questianneire);
        }

        // POST: Questianneires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Questianneire questianneire = db.Questianneires.Find(id);
            db.Questianneires.Remove(questianneire);
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
