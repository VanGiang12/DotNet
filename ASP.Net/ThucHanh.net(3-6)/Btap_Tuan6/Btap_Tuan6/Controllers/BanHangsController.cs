using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Btap_Tuan6.Models;

namespace Btap_Tuan6.Controllers
{
    public class BanHangsController : Controller
    {
        private _DbContext db = new _DbContext();

        // GET: BanHangs
        public ActionResult Index()
        {
            var banHangs = db.BanHangs.Include(b => b.NhanVien).Include(b => b.SanPham);
            return View(banHangs.ToList());
        }

        [HttpPost]
        public ActionResult Index(string sp)
        {
            List<BanHang> banHangs = null;
            if (string.IsNullOrWhiteSpace(sp))
            {
                banHangs = db.BanHangs.Include(b => b.NhanVien).Include(b => b.SanPham).ToList();
            }
            else
            {
                banHangs = db.BanHangs.Where(b => b.SanPham.Tensp == sp)
                   .Include(b => b.NhanVien).Include(b => b.SanPham).ToList();
            }
            return View(banHangs);
        }

        public ActionResult TongSL()
        {
            var nhanvien = db.NhanViens.ToList();
            var sum = nhanvien.Select(nv => new TongSLBan
            {
                ID = nv.Manv,
                Ten = nv.Hoten,
                SLBan = db.BanHangs.Where(b => b.Manv == nv.Manv).Sum(b => b.Slban)
            }).ToList();
            ViewBag.sum = sum;
            return View("Index", db.BanHangs.ToList());
        }

        public ActionResult VuotDinhMuc()
        {
            var ds = db.BanHangs.Where(b => b.Slban > b.Dinhmuc).OrderByDescending(b => b.Slban).ToList();
            ViewBag.msg = "Danh sách vượt định mức";
            return View("Index", ds);
        }

        public ActionResult SPMax()
        {
            var sanpham = db.SanPhams.ToList();
            var sumsp = sanpham.Select(sp => new SLSanPham
            {
                IdSP = sp.Masp,
                Ten = sp.Tensp,
                SLBan = db.BanHangs.Where(b => b.Masp == sp.Masp).Sum(b => b.Slban)
            }).ToList();

            var max = sumsp.Max(m => m.SLBan);
            var maxds = sumsp.Where(m => m.SLBan == max).ToList();
            ViewBag.maxds = maxds;
            ViewBag.sumsp = sumsp;
           
            return View("Index", db.BanHangs.ToList());
        }

        // GET: BanHangs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BanHang banHang = db.BanHangs.Find(id);
            if (banHang == null)
            {
                return HttpNotFound();
            }
            return View(banHang);
        }

        // GET: BanHangs/Create
        public ActionResult Create()
        {
            ViewBag.Manv = new SelectList(db.NhanViens, "Manv", "Tenquay");
            ViewBag.Masp = new SelectList(db.SanPhams, "Masp", "Tensp");
            return View();
        }

        // POST: BanHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Manv,Masp,Dinhmuc,Slban")] BanHang banHang)
        {
            if (ModelState.IsValid)
            {
                db.BanHangs.Add(banHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Manv = new SelectList(db.NhanViens, "Manv", "Tenquay", banHang.Manv);
            ViewBag.Masp = new SelectList(db.SanPhams, "Masp", "Tensp", banHang.Masp);
            return View(banHang);
        }

        // GET: BanHangs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BanHang banHang = db.BanHangs.Find(id);
            if (banHang == null)
            {
                return HttpNotFound();
            }
            ViewBag.Manv = new SelectList(db.NhanViens, "Manv", "Tenquay", banHang.Manv);
            ViewBag.Masp = new SelectList(db.SanPhams, "Masp", "Tensp", banHang.Masp);
            return View(banHang);
        }

        // POST: BanHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Manv,Masp,Dinhmuc,Slban")] BanHang banHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(banHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Manv = new SelectList(db.NhanViens, "Manv", "Tenquay", banHang.Manv);
            ViewBag.Masp = new SelectList(db.SanPhams, "Masp", "Tensp", banHang.Masp);
            return View(banHang);
        }

        // GET: BanHangs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BanHang banHang = db.BanHangs.Find(id);
            if (banHang == null)
            {
                return HttpNotFound();
            }
            return View(banHang);
        }

        // POST: BanHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BanHang banHang = db.BanHangs.Find(id);
            db.BanHangs.Remove(banHang);
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
