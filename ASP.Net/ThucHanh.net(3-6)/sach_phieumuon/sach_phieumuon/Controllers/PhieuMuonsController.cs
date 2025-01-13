using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using sach_phieumuon.Models;

namespace sach_phieumuon.Controllers
{
    public class PhieuMuonsController : Controller
    {
        private Database1Entities db = new Database1Entities();

        // GET: PhieuMuons
        public ActionResult Index()
        {
            var phieuMuons = db.PhieuMuons.Include(p => p.Sach);
            return View(phieuMuons.ToList());
        }
        public ActionResult sosachnhieunhat()
        {
            var max = db.PhieuMuons.GroupBy(m => m.MaSach).Select(g => g.Count()).Max();
            var phieuMuons = db.PhieuMuons.Include(p => p.Sach)
                .GroupBy(m => m.MaSach)
                .Select(g => new ViewSach
                {
                    Masach = g.Key,
                    SoLuong = g.Count(),
                    Sachs = g.Select(pm => pm.Sach).Distinct().ToList()
                }).Where(s => s.SoLuong == max);
            return View(phieuMuons.ToList());
        }
        public ActionResult phieumuonsongaynhieunhat()
        {
            // tách riêng tính số ngày max. k tính được gộp
            // tách riêng p chuyển tolist k thì bị lỗi
            var phieuMuons = db.PhieuMuons.Include(p => p.Sach).ToList();

            var songay = phieuMuons.Max(m => ((m.NgayTra.Value - m.NgayMuon.Value).Days));

            phieuMuons = phieuMuons.Where(m => ((m.NgayTra.Value - m.NgayMuon.Value).Days == songay)).ToList();
            ViewBag.songay = songay;
            return View(phieuMuons);
        }
        public ActionResult timkiem()
        {
            var phieuMuons = db.PhieuMuons.Include(p => p.Sach);
            return View(phieuMuons.ToList());
        }
        [HttpPost]
        public ActionResult timkiem(string ten)
        {
            var phieuMuons = db.PhieuMuons.Include(p => p.Sach);
            if (ten != null)
            {
                phieuMuons = phieuMuons.Where(m => m.NguoiMuon.Contains(ten));
                ViewBag.ten = ten;
            }
            return View(phieuMuons.ToList());
        }
        // GET: PhieuMuons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuMuon phieuMuon = db.PhieuMuons.Find(id);
            if (phieuMuon == null)
            {
                return HttpNotFound();
            }
            return View(phieuMuon);
        }

        // GET: PhieuMuons/Create
        public ActionResult Create()
        {
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach");
            return View();
        }

        // POST: PhieuMuons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPhieu,MaSach,NguoiMuon,NgayMuon,NgayTra")] PhieuMuon phieuMuon)
        {
            if (ModelState.IsValid)
            {
                db.PhieuMuons.Add(phieuMuon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach", phieuMuon.MaSach);
            return View(phieuMuon);
        }

        // GET: PhieuMuons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuMuon phieuMuon = db.PhieuMuons.Find(id);
            if (phieuMuon == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach", phieuMuon.MaSach);
            return View(phieuMuon);
        }

        // POST: PhieuMuons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPhieu,MaSach,NguoiMuon,NgayMuon,NgayTra")] PhieuMuon phieuMuon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phieuMuon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach", phieuMuon.MaSach);
            return View(phieuMuon);
        }

        // GET: PhieuMuons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuMuon phieuMuon = db.PhieuMuons.Find(id);
            if (phieuMuon == null)
            {
                return HttpNotFound();
            }
            return View(phieuMuon);
        }

        // POST: PhieuMuons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PhieuMuon phieuMuon = db.PhieuMuons.Find(id);
            db.PhieuMuons.Remove(phieuMuon);
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
