using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ontap_de2.App_Start;
using ontap_de2.Models;

namespace ontap_de2.Controllers
{
    public class DiemsController : Controller
    {
        private QLSinhVienDataContext db = new QLSinhVienDataContext();

        // GET: Diems
        public ActionResult Index()
        {
            return View(db.Diems.ToList());
        }

        public ActionResult TimKiem()
        {

            return View(db.Diems.ToList());
        }
        [HttpPost]
        public ActionResult TimKiem(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                var sinvien = db.Diems.Include(sv => sv.SinhVien).Where(s => s.SinhVien.Hoten.Contains(name));
                return View(sinvien.ToList());
            }
            return View(db.Diems.ToList());
        }
        public ActionResult DiemMax()
        {
            var diemmax = db.Diems.Where(m => m.Tenmh.Contains("Cơ sở Dữ Liệu")).Max(d => d.Diemmh);
            var sinhvien = db.Diems.Where(m => m.Tenmh.Contains("Cơ sở Dữ Liệu") && m.Diemmh == diemmax).ToList();

            return View(sinhvien);
        }
        // GET: Diems/Details/5
        public ActionResult Details(int? id1, string id2)
        {
            if (id1 == null && id2 == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diem diem = db.Diems.Find(id1, id2);
            if (diem == null)
            {
                return HttpNotFound();
            }
            return View(diem);
        }

        // GET: Diems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Diems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Masv,Tenmh,Diemmh")] Diem diem)
        {
            if (ModelState.IsValid)
            {
                db.Diems.Add(diem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(diem);
        }

        // GET: Diems/Edit/5
        public ActionResult Edit(int? id1, string id2)
        {
            if (id1 == null && id2 == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diem diem = db.Diems.Find(id1, id2);
            if (diem == null)
            {
                return HttpNotFound();
            }
            return View(diem);
        }

        // POST: Diems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Masv,Tenmh,Diemmh")] Diem diem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(diem);
        }

        // GET: Diems/Delete/5
        public ActionResult Delete(int? id1, string id2)
        {
            if (id1 == null && id2 == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diem diem = db.Diems.Find(id1, id2);
            if (diem == null)
            {
                return HttpNotFound();
            }
            return View(diem);
        }

        // POST: Diems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id1, string id2)
        {
            Diem diem = db.Diems.Find(id1, id2);
            db.Diems.Remove(diem);
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
