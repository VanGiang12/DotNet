using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ontap3.Models;

namespace ontap3.Controllers
{
    public class ThietBisController : Controller
    {
        private qltbEntities db = new qltbEntities();

        // GET: ThietBis
        public ActionResult Index()
        {
            var thietBis = db.ThietBis.Include(t => t.NhaCungCap);
            return View(thietBis.ToList());
        }
        public ActionResult max()
        {
            var max = db.ThietBis.Include(t => t.NhaCungCap).Max(m => m.SoLuong * m.DonGia);
            var thietBis = db.ThietBis.Include(t => t.NhaCungCap).Where(m => m.SoLuong * m.DonGia == max);
            return View(thietBis.ToList());
        }
        public ActionResult timkiem()
        {
            var thietBis = db.ThietBis.Include(t => t.NhaCungCap);
            return View(thietBis.ToList());
        }
        [HttpPost]
        public ActionResult timkiem(string ten)
        {
            var thietBis = db.ThietBis.Include(t => t.NhaCungCap);
            if (ten != null)
            {
                thietBis = thietBis.Where(m => m.TenTB.Contains(ten));
                ViewBag.tentb = ten;
            }
            return View(thietBis.ToList());
        }
        // GET: ThietBis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThietBi thietBi = db.ThietBis.Find(id);
            if (thietBi == null)
            {
                return HttpNotFound();
            }
            return View(thietBi);
        }

        // GET: ThietBis/Create
        public ActionResult Create()
        {
            ViewBag.MaNCC = new SelectList(db.NhaCungCaps, "MaNCC", "TenNhaCC");
            return View();
        }

        // POST: ThietBis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTB,TenTB,SoLuong,DonGia,ThanhTien,MaNCC")] ThietBi thietBi)
        {
            if (ModelState.IsValid)
            {
                db.ThietBis.Add(thietBi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNCC = new SelectList(db.NhaCungCaps, "MaNCC", "TenNhaCC", thietBi.MaNCC);
            return View(thietBi);
        }

        // GET: ThietBis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThietBi thietBi = db.ThietBis.Find(id);
            if (thietBi == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNCC = new SelectList(db.NhaCungCaps, "MaNCC", "TenNhaCC", thietBi.MaNCC);
            return View(thietBi);
        }

        // POST: ThietBis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTB,TenTB,SoLuong,DonGia,ThanhTien,MaNCC")] ThietBi thietBi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thietBi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNCC = new SelectList(db.NhaCungCaps, "MaNCC", "TenNhaCC", thietBi.MaNCC);
            return View(thietBi);
        }

        // GET: ThietBis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThietBi thietBi = db.ThietBis.Find(id);
            if (thietBi == null)
            {
                return HttpNotFound();
            }
            return View(thietBi);
        }

        // POST: ThietBis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ThietBi thietBi = db.ThietBis.Find(id);
            db.ThietBis.Remove(thietBi);
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
