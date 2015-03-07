using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoodSamaritan.Models.Client;
using GoodSamaritan.Models.Smart;

namespace GoodSamaritan.Controllers
{
    public class SmartsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: Smarts
        public ActionResult Index()
        {
            return View(db.Smarts.ToList());
        }

        // GET: Smarts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Smart smart = db.Smarts.Find(id);
            if (smart == null)
            {
                return HttpNotFound();
            }
            return View(smart);
        }

        // GET: Smarts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Smarts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SmartId,ClientId,AccompanimentMinutes,NumTransportProvided,ReferToNurse")] Smart smart)
        {
            if (ModelState.IsValid)
            {
                db.Smarts.Add(smart);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(smart);
        }

        // GET: Smarts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Smart smart = db.Smarts.Find(id);
            if (smart == null)
            {
                return HttpNotFound();
            }
            return View(smart);
        }

        // POST: Smarts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SmartId,ClientId,AccompanimentMinutes,NumTransportProvided,ReferToNurse")] Smart smart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(smart).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(smart);
        }

        // GET: Smarts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Smart smart = db.Smarts.Find(id);
            if (smart == null)
            {
                return HttpNotFound();
            }
            return View(smart);
        }

        // POST: Smarts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Smart smart = db.Smarts.Find(id);
            db.Smarts.Remove(smart);
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
