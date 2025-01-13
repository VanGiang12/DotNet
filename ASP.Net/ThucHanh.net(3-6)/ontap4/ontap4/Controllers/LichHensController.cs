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
    public class LichHensController : Controller
    {
        private Database1Entities1 db = new Database1Entities1();

        // GET: LichHens
        public ActionResult Index()
        {
            var lichHens = db.LichHens.Include(l => l.BenhNhan);
            return View(lichHens.ToList());
        }
        public ActionResult lichhengannhat()
        {
            var lichHens = db.LichHens.Include(l => l.BenhNhan).OrderByDescending(m=>m.NgayHen).FirstOrDefault();
            return View(new List<LichHen> { lichHens });
        }
        // hiển thị bênh nhận có sl lịch hẹn nheieuf nhất
        public ActionResult slmax()
        {
            var max = db.LichHens.Include(l => l.BenhNhan)
                .GroupBy(m => m.BenhNhan.HoTen)
                .Select(g => g.Count()).Max();

            var lichHens = db.LichHens.Include(l => l.BenhNhan).GroupBy(m => m.BenhNhan.HoTen).
                  Select(g => new SLLichHen2
                  {
                      BenhNhan = g.Key,
                      SoLuong = g.Count(),
                      LichHens = g.ToList()
                  }).Where(m => m.SoLuong == max);
            return View(lichHens.ToList());
        }
        public ActionResult TimKiem()
        {
            var lichHens = db.LichHens.Include(l => l.BenhNhan);
            return View(lichHens.ToList());
        }
        [HttpPost]
        public ActionResult TimKiem(string ten)
        {
            var lichHens = db.LichHens.Include(l => l.BenhNhan);
            if (ten != null)
            {
                lichHens = lichHens.Where(m => m.BenhNhan.HoTen.Contains(ten));
                ViewBag.ten = ten;
            }
            return View(lichHens.ToList());
        }
        // in thêm cột số lượng theo bacs sĩ
        public ActionResult soluonglichhen()
        {
            var lichHens = db.LichHens.Include(l => l.BenhNhan).GroupBy(m => m.BacSi).
                Select(g => new SLLichHen
                {
                    BacSi = g.Key,
                    SoLuong = g.Count(),
                    LichHens = g.ToList()
                });
            return View(lichHens.ToList());
        }

        // GET: LichHens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LichHen lichHen = db.LichHens.Find(id);
            if (lichHen == null)
            {
                return HttpNotFound();
            }
            return View(lichHen);
        }

        // GET: LichHens/Create
        public ActionResult Create()
        {
            ViewBag.MaBN = new SelectList(db.BenhNhans, "MaBN", "HoTen");
            return View();
        }

        // POST: LichHens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLichHen,MaBN,NgayHen,BacSi,LyDo")] LichHen lichHen)
        {
            if (ModelState.IsValid)
            {
                db.LichHens.Add(lichHen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaBN = new SelectList(db.BenhNhans, "MaBN", "HoTen", lichHen.MaBN);
            return View(lichHen);
        }

        // GET: LichHens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LichHen lichHen = db.LichHens.Find(id);
            if (lichHen == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaBN = new SelectList(db.BenhNhans, "MaBN", "HoTen", lichHen.MaBN);
            return View(lichHen);
        }

        // POST: LichHens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLichHen,MaBN,NgayHen,BacSi,LyDo")] LichHen lichHen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lichHen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaBN = new SelectList(db.BenhNhans, "MaBN", "HoTen", lichHen.MaBN);
            return View(lichHen);
        }

        // GET: LichHens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LichHen lichHen = db.LichHens.Find(id);
            if (lichHen == null)
            {
                return HttpNotFound();
            }
            return View(lichHen);
        }

        // POST: LichHens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LichHen lichHen = db.LichHens.Find(id);
            db.LichHens.Remove(lichHen);
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
