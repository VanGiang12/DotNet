using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using De26.Models;

namespace De26.Controllers
{
    public class HoaDonDatMonsController : Controller
    {
        private QLNHEntities1 db = new QLNHEntities1();

        // GET: HoaDonDatMons
        public ActionResult Index()
        {
            var hoaDonDatMons = db.HoaDonDatMons.Include(h => h.MonAn);
            return View(hoaDonDatMons.ToList());
        }
        [HttpPost]
        public ActionResult Index(string tenkh)
        {
            var hoaDonDatMons = db.HoaDonDatMons.Include(h => h.MonAn);
            if (tenkh != null)
            {
                hoaDonDatMons = hoaDonDatMons.Where(m => m.KhachHang.Contains(tenkh));
            }
            return View(hoaDonDatMons.ToList());
        }
        public ActionResult monantongdoanhthumax()
        {
            var max = db.HoaDonDatMons.Include(h => h.MonAn).GroupBy(m => m.MaMon)
                .Select(g => new DoanhThus
                {
                    DoanhThu = g.Sum(m => m.SoLuong * m.MonAn.DonGia)
                }).Max(m => m.DoanhThu);
            var hoaDonDatMons = db.HoaDonDatMons.Include(h => h.MonAn)
                .GroupBy(m => m.MaMon)
                .Select(g => new DoanhThus
                {
                    MaMon = g.Key,
                    DoanhThu = g.Sum(m => m.SoLuong * m.MonAn.DonGia),
                    MonAns = g.Select(m => m.MonAn).Distinct().ToList()
                }).Where(m => m.DoanhThu == max);


            return View(hoaDonDatMons.ToList());
        }
        public ActionResult hoadonthanhtienmax()
        {
            var max = db.HoaDonDatMons.Include(m => m.MonAn).Max(m => m.SoLuong * m.MonAn.DonGia);
            var hoadonDatMons = db.HoaDonDatMons.Include(m => m.MonAn)
                .Where(m => (m.SoLuong * m.MonAn.DonGia) == max);
            return View(hoadonDatMons.ToList());

        }

        // GET: HoaDonDatMons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonDatMon hoaDonDatMon = db.HoaDonDatMons.Find(id);
            if (hoaDonDatMon == null)
            {
                return HttpNotFound();
            }
            return View(hoaDonDatMon);
        }

        // GET: HoaDonDatMons/Create
        public ActionResult Create()
        {
            ViewBag.MaMon = new SelectList(db.MonAns, "MaMon", "TenMon");
            return View();
        }

        // POST: HoaDonDatMons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHD,MaMon,KhachHang,NgayDat,SoLuong")] HoaDonDatMon hoaDonDatMon)
        {
            if (ModelState.IsValid)
            {
                db.HoaDonDatMons.Add(hoaDonDatMon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaMon = new SelectList(db.MonAns, "MaMon", "TenMon", hoaDonDatMon.MaMon);
            return View(hoaDonDatMon);
        }

        // GET: HoaDonDatMons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonDatMon hoaDonDatMon = db.HoaDonDatMons.Find(id);
            if (hoaDonDatMon == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaMon = new SelectList(db.MonAns, "MaMon", "TenMon", hoaDonDatMon.MaMon);
            return View(hoaDonDatMon);
        }

        // POST: HoaDonDatMons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHD,MaMon,KhachHang,NgayDat,SoLuong")] HoaDonDatMon hoaDonDatMon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoaDonDatMon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaMon = new SelectList(db.MonAns, "MaMon", "TenMon", hoaDonDatMon.MaMon);
            return View(hoaDonDatMon);
        }

        // GET: HoaDonDatMons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonDatMon hoaDonDatMon = db.HoaDonDatMons.Find(id);
            if (hoaDonDatMon == null)
            {
                return HttpNotFound();
            }
            return View(hoaDonDatMon);
        }

        // POST: HoaDonDatMons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HoaDonDatMon hoaDonDatMon = db.HoaDonDatMons.Find(id);
            db.HoaDonDatMons.Remove(hoaDonDatMon);
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
