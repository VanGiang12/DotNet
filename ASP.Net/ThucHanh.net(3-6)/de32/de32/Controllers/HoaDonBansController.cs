using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using de32.Models;

namespace de32.Controllers
{
    public class HoaDonBansController : Controller
    {
        private Database1Entities db = new Database1Entities();

        // GET: HoaDonBans
        public ActionResult Index()
        {
            var hoaDonBans = db.HoaDonBans.Include(h => h.Sach).Include(h => h.KhachHang);
            return View(hoaDonBans.ToList());
        }

        [HttpPost]
        public ActionResult Index(string ten)
        {
            var hoaDonBans = db.HoaDonBans.Include(h => h.Sach).Include(h => h.KhachHang);

            if (!string.IsNullOrWhiteSpace(ten))
            {
                hoaDonBans = hoaDonBans.Where(m => m.KhachHang.HoTen.Contains(ten));
                ViewBag.ten = ten;
            }

            return View(hoaDonBans.ToList());
        }

        public ActionResult tongdoanhthumax()
        {
            var max = db.HoaDonBans.GroupBy(m => m.MaSach)
                .Select(g => new DoanhThuMax
                {
                    Doanhthu = g.Sum(m => m.SoLuong * m.Sach.DonGia)
                }).Max(m => m.Doanhthu);
            var hoaDonBans = db.HoaDonBans.Include(h => h.Sach).Include(h => h.KhachHang)
                .GroupBy(m => m.MaSach)
                .Select(g => new DoanhThuMax
                {
                    Masach = g.Key,
                    Doanhthu = g.Sum(m => m.SoLuong * m.Sach.DonGia),
                    Sachs = g.Select(m => m.Sach).Distinct().ToList()
                }).Where(m => m.Doanhthu == max);


            return View(hoaDonBans.ToList());
        }

        public ActionResult hoadonslmax()
        {
            var max = db.HoaDonBans.Max(m => m.SoLuong);

            var hoaDonBans = db.HoaDonBans.Include(h => h.Sach).Include(h => h.KhachHang)
                .Where(m => m.SoLuong == max);

            return View(hoaDonBans.ToList());
        }

        // GET: HoaDonBans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonBan hoaDonBan = db.HoaDonBans.Find(id);
            if (hoaDonBan == null)
            {
                return HttpNotFound();
            }
            return View(hoaDonBan);
        }

        // GET: HoaDonBans/Create
        public ActionResult Create()
        {
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach");
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "HoTen");
            return View();
        }

        // POST: HoaDonBans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHD,MaSach,MaKH,NgayBan,SoLuong")] HoaDonBan hoaDonBan)
        {
            if (ModelState.IsValid)
            {
                db.HoaDonBans.Add(hoaDonBan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach", hoaDonBan.MaSach);
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "HoTen", hoaDonBan.MaKH);
            return View(hoaDonBan);
        }

        // GET: HoaDonBans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonBan hoaDonBan = db.HoaDonBans.Find(id);
            if (hoaDonBan == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach", hoaDonBan.MaSach);
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "HoTen", hoaDonBan.MaKH);
            return View(hoaDonBan);
        }

        // POST: HoaDonBans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHD,MaSach,MaKH,NgayBan,SoLuong")] HoaDonBan hoaDonBan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoaDonBan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach", hoaDonBan.MaSach);
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "HoTen", hoaDonBan.MaKH);
            return View(hoaDonBan);
        }

        // GET: HoaDonBans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonBan hoaDonBan = db.HoaDonBans.Find(id);
            if (hoaDonBan == null)
            {
                return HttpNotFound();
            }
            return View(hoaDonBan);
        }

        // POST: HoaDonBans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HoaDonBan hoaDonBan = db.HoaDonBans.Find(id);
            db.HoaDonBans.Remove(hoaDonBan);
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
