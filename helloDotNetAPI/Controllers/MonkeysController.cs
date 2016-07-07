using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using helloDotNetAPI.Models;

namespace helloDotNetAPI.Controllers
{
    public class MonkeysController : Controller
    {
        private helloDotNetAPIContext db = new helloDotNetAPIContext();

        // GET: Monkeys
        public ActionResult Index()
        {
            return View(db.Monkeys.ToList());
        }

        // GET: Monkeys/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monkey monkey = db.Monkeys.Find(id);
            if (monkey == null)
            {
                return HttpNotFound();
            }
            return View(monkey);
        }

        // GET: Monkeys/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Monkeys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Size,Location")] Monkey monkey)
        {
            if (ModelState.IsValid)
            {
                db.Monkeys.Add(monkey);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(monkey);
        }

        // GET: Monkeys/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monkey monkey = db.Monkeys.Find(id);
            if (monkey == null)
            {
                return HttpNotFound();
            }
            return View(monkey);
        }

        // POST: Monkeys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Size,Location")] Monkey monkey)
        {
            if (ModelState.IsValid)
            {
                db.Entry(monkey).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(monkey);
        }

        // GET: Monkeys/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monkey monkey = db.Monkeys.Find(id);
            if (monkey == null)
            {
                return HttpNotFound();
            }
            return View(monkey);
        }

        // POST: Monkeys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Monkey monkey = db.Monkeys.Find(id);
            db.Monkeys.Remove(monkey);
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
