using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ontap4.Models;

namespace ontap4.Controllers
{
    public class BenhNhansController : Controller
    {
        private Database1Entities1 db = new Database1Entities1();

        // GET: BenhNhans
        public ActionResult Index()
        {
            return View(db.BenhNhans.ToList());
        }

        // GET: BenhNhans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BenhNhan benhNhan = db.BenhNhans.Find(id);
            if (benhNhan == null)
            {
                return HttpNotFound();
            }
            return View(benhNhan);
        }

        // GET: BenhNhans/Create
        public ActionResult Create()
        {
            var gt = new SelectList(new List<SelectListItem>
            {
                new SelectListItem{ Text = "Nam", Value = "Nam"} ,
                new SelectListItem{ Text = "Nữ", Value = "Nữ"}
            }, "Value", "Text");

            ViewBag.gt = gt;
            return View();
        }

        // POST: BenhNhans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaBN,HoTen,NgaySinh,GioiTinh,SDT")] BenhNhan benhNhan)
        {
            if (ModelState.IsValid)
            {
                db.BenhNhans.Add(benhNhan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(benhNhan);
        }

        // GET: BenhNhans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BenhNhan benhNhan = db.BenhNhans.Find(id);
            if (benhNhan == null)
            {
                return HttpNotFound();
            }
            var gt = new SelectList(new List<SelectListItem>
            {
                new SelectListItem{ Text = "Nam", Value = "Nam"} ,
                new SelectListItem{ Text = "Nữ", Value = "Nữ"}
            }, "Value", "Text");
            ViewBag.gt = gt;
            return View(benhNhan);
        }

        // POST: BenhNhans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaBN,HoTen,NgaySinh,GioiTinh,SDT")] BenhNhan benhNhan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(benhNhan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(benhNhan);
        }

        // GET: BenhNhans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BenhNhan benhNhan = db.BenhNhans.Find(id);
            if (benhNhan == null)
            {
                return HttpNotFound();
            }
            return View(benhNhan);
        }

        // POST: BenhNhans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BenhNhan benhNhan = db.BenhNhans.Find(id);
            db.BenhNhans.Remove(benhNhan);
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
