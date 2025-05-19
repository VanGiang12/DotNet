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
    public class BenhNhansController : Controller
    {
        private NguyenVanGiangEntities db = new NguyenVanGiangEntities();

        // GET: BenhNhans
        public ActionResult Index()
        {
            return View(db.BenhNhans.ToList());
        }

        public ActionResult timkiem()
        {
            // Lấy danh sách bệnh nhân từ database
            var benhnhan = db.BenhNhans.Select(g => g.HoTen).ToList();

            // Tạo danh sách SelectListItem từ danh sách bệnh nhân
            var selectListItems = benhnhan.Select(name => new SelectListItem
            {
                Text = name,
                Value = name
            }).ToList();

            // Gửi dữ liệu qua ViewBag
            ViewBag.Ten = new SelectList(selectListItems, "Value", "Text");
            return View();
        }

        public ActionResult tongphimax()
        {
            /* var max = db.BenhNhans.GroupBy(m => m.MaBN).Select(g => g.Count()).Max();
             var benhnhan = db.BenhNhans.GroupBy(m => m.MaBN)
                 .Select(g => new BenhNhanTongPhi
                 {
                     MaBN = g.Key,
                     Tong = g.Count(),
                     BenhNhans = g.ToList()
                 });*/

            var mabn = db.BenhNhans.Select(b => b.MaBN).ToList();
            List<decimal> chiphi = new List<decimal>();
            foreach (var item in mabn)
            {
               
            }

            return View();
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
            return View();
        }

        // POST: BenhNhans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaBN,HoTen,NgaySinh,GioiTinh,SDT,DiaChi")] BenhNhan benhNhan)
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
            return View(benhNhan);
        }

        // POST: BenhNhans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaBN,HoTen,NgaySinh,GioiTinh,SDT,DiaChi")] BenhNhan benhNhan)
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
