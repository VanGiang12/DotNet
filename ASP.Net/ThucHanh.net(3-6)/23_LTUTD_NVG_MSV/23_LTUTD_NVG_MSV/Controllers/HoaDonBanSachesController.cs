using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _23_LTUTD_NVG_MSV.Models;

namespace _23_LTUTD_NVG_MSV.Controllers
{
    public class HoaDonBanSachesController : Controller
    {
        private Database1Entities1 db = new Database1Entities1();

        // GET: HoaDonBanSaches
        public ActionResult Index()
        {
            var hoaDonBanSaches = db.HoaDonBanSaches.Include(h => h.Sach);
            return View(hoaDonBanSaches.ToList());
        }
        public ActionResult timkiem()
        {
            return View();
        }

        // GET: HoaDonBanSaches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonBanSach hoaDonBanSach = db.HoaDonBanSaches.Find(id);
            if (hoaDonBanSach == null)
            {
                return HttpNotFound();
            }
            return View(hoaDonBanSach);
        }

        // GET: HoaDonBanSaches/Create
        public ActionResult Create()
        {
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach");
            return View();
        }

        // POST: HoaDonBanSaches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHD,MaSach,KhachHang,NgayBan,SoLuong")] HoaDonBanSach hoaDonBanSach)
        {
            if (ModelState.IsValid)
            {
                db.HoaDonBanSaches.Add(hoaDonBanSach);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach", hoaDonBanSach.MaSach);
            return View(hoaDonBanSach);
        }

        // GET: HoaDonBanSaches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonBanSach hoaDonBanSach = db.HoaDonBanSaches.Find(id);
            if (hoaDonBanSach == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach", hoaDonBanSach.MaSach);
            return View(hoaDonBanSach);
        }

        // POST: HoaDonBanSaches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHD,MaSach,KhachHang,NgayBan,SoLuong")] HoaDonBanSach hoaDonBanSach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoaDonBanSach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach", hoaDonBanSach.MaSach);
            return View(hoaDonBanSach);
        }

        // GET: HoaDonBanSaches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonBanSach hoaDonBanSach = db.HoaDonBanSaches.Find(id);
            if (hoaDonBanSach == null)
            {
                return HttpNotFound();
            }
            return View(hoaDonBanSach);
        }

        // POST: HoaDonBanSaches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HoaDonBanSach hoaDonBanSach = db.HoaDonBanSaches.Find(id);
            db.HoaDonBanSaches.Remove(hoaDonBanSach);
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
