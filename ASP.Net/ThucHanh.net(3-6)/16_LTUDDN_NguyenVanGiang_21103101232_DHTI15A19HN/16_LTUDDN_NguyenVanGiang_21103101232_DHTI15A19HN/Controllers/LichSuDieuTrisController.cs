using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _16_LTUDDN_NguyenVanGiang_21103101232_DHTI15A19HN.Models;

namespace _16_LTUDDN_NguyenVanGiang_21103101232_DHTI15A19HN.Controllers
{
    public class LichSuDieuTrisController : Controller
    {
        private NguyenVanGiangEntities db = new NguyenVanGiangEntities();

        // GET: LichSuDieuTris
        public ActionResult Index()
        {
            var lichSuDieuTris = db.LichSuDieuTris.Include(l => l.BenhNhan);
            return View(lichSuDieuTris.ToList());
        }

        public ActionResult chiphimax()
        {
            var max = db.LichSuDieuTris.Max(l => l.ChiPhi);
            var benhnhan = db.LichSuDieuTris.Where(l => l.ChiPhi == max);
            return View(benhnhan.ToList());
        }

        // GET: LichSuDieuTris/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LichSuDieuTri lichSuDieuTri = db.LichSuDieuTris.Find(id);
            if (lichSuDieuTri == null)
            {
                return HttpNotFound();
            }
            return View(lichSuDieuTri);
        }

        // GET: LichSuDieuTris/Create
        public ActionResult Create()
        {
            ViewBag.MaBN = new SelectList(db.BenhNhans, "MaBN", "HoTen");
            return View();
        }

        // POST: LichSuDieuTris/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLS,MaBN,NgayDieuTri,ChuanDoan,PhuongPhap,ChiPhi")] LichSuDieuTri lichSuDieuTri)
        {
            if (ModelState.IsValid)
            {
                db.LichSuDieuTris.Add(lichSuDieuTri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaBN = new SelectList(db.BenhNhans, "MaBN", "HoTen", lichSuDieuTri.MaBN);
            return View(lichSuDieuTri);
        }

        // GET: LichSuDieuTris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LichSuDieuTri lichSuDieuTri = db.LichSuDieuTris.Find(id);
            if (lichSuDieuTri == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaBN = new SelectList(db.BenhNhans, "MaBN", "HoTen", lichSuDieuTri.MaBN);
            return View(lichSuDieuTri);
        }

        // POST: LichSuDieuTris/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLS,MaBN,NgayDieuTri,ChuanDoan,PhuongPhap,ChiPhi")] LichSuDieuTri lichSuDieuTri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lichSuDieuTri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaBN = new SelectList(db.BenhNhans, "MaBN", "HoTen", lichSuDieuTri.MaBN);
            return View(lichSuDieuTri);
        }

        // GET: LichSuDieuTris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LichSuDieuTri lichSuDieuTri = db.LichSuDieuTris.Find(id);
            if (lichSuDieuTri == null)
            {
                return HttpNotFound();
            }
            return View(lichSuDieuTri);
        }

        // POST: LichSuDieuTris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LichSuDieuTri lichSuDieuTri = db.LichSuDieuTris.Find(id);
            db.LichSuDieuTris.Remove(lichSuDieuTri);
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
