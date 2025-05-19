using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TruyCapDL_CodeFirst.Models;

namespace TruyCapDL_CodeFirst.Controllers
{
    public class OdersController : Controller
    {
        private ShopDataContext db = new ShopDataContext();

        // GET: Oders
        public ActionResult Index()
        {
            var oders = db.Oders.Include(o => o.customer);
            oders = oders.OrderBy(o => o.Price); // sắp sếp tăng
            oders = oders.OrderByDescending(o => o.Price); // sắp sếp giảm
            var kt = oders.All(u => u.Price > 10000);  // trả về true false
            var kt2 = oders.Any(u => u.Price > 10000); // trả về true false

            return View(oders.ToList());
        }

        public ActionResult TimKiem()
        {
            var oders = db.Oders.Include(o => o.customer);
            //oders = oders.Where(o => o.customer.Name.Contains("a"));
            oders = oders.Where(o => o.customer.Name.Contains("a"));

            var thanhtienmax = oders.Max(o => o.Price * o.Quantity);
            var thanhtienmin = oders.Min(o => o.Price * o.Quantity);
            var trungbinhthanhtien = oders.Average(o => o.Price * o.Quantity);
            var sumthanhtien = oders.Sum(o => o.Price * o.Quantity);
            oders = oders.Where(o => o.Price * o.Quantity == thanhtienmax);
            return View(oders.ToList());
        }

        // GET: Oders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oders oders = db.Oders.Find(id);
            if (oders == null)
            {
                return HttpNotFound();
            }
            return View(oders);
        }

        // GET: Oders/Create
        public ActionResult Create()
        {
            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "Name");
            return View();
        }

        // POST: Oders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ProductName,Price,Quantity,CustomerId")] Oders oders)
        {
            if (ModelState.IsValid)
            {
                db.Oders.Add(oders);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "Name", oders.CustomerId);
            return View(oders);
        }

        // GET: Oders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oders oders = db.Oders.Find(id);
            if (oders == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "Name", oders.CustomerId);
            return View(oders);
        }

        // POST: Oders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ProductName,Price,Quantity,CustomerId")] Oders oders)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oders).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "Name", oders.CustomerId);
            return View(oders);
        }

        // GET: Oders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oders oders = db.Oders.Find(id);
            if (oders == null)
            {
                return HttpNotFound();
            }
            return View(oders);
        }

        // POST: Oders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Oders oders = db.Oders.Find(id);
            db.Oders.Remove(oders);
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
