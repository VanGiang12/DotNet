using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ontap.App_Start;
using ontap.Models;

namespace ontap.Controllers
{
    public class SanPhamsController : Controller
    {
        private QLBanHangDataContext db = new QLBanHangDataContext();

        // GET: SanPhams
        public ActionResult Index()
        {
            return View(db.SanPhams.ToList());
        }

        public ActionResult TimKiem()
        {
            var loaisp = db.SanPhams.Select(sp => sp.Loaisp).ToList();
            ViewBag.lsp = new SelectList(loaisp);
            return View(db.SanPhams.ToList());
        }
        [HttpPost]
        public ActionResult TimKiem(string min, string max, string loaisp)
        {
            if (!string.IsNullOrWhiteSpace(min) && !string.IsNullOrWhiteSpace(max)
                )
            {
                int Min = int.Parse(min); int Max = int.Parse(max);
                var sanphams = db.SanPhams.Where(sp => sp.Gia > Min && sp.Gia < Max);
                if (!string.IsNullOrWhiteSpace(loaisp) && loaisp != "Choose")
                {
                    sanphams = db.SanPhams.Where(s => s.Loaisp == loaisp);
                }
                var loaispp = db.SanPhams.Select(sp => sp.Loaisp).ToList();
                ViewBag.lsp = new SelectList(loaispp);
                return View(sanphams.ToList());
            }
            return View(db.SanPhams.ToList());
        }

       
        // GET: SanPhams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }

        // GET: SanPhams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SanPhams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Masp,Tensp,Gia,Soluong,Loaisp")] SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                db.SanPhams.Add(sanPham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sanPham);
        }

        // GET: SanPhams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }

        // POST: SanPhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Masp,Tensp,Gia,Soluong,Loaisp")] SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sanPham);
        }

        // GET: SanPhams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }

        // POST: SanPhams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SanPham sanPham = db.SanPhams.Find(id);
            db.SanPhams.Remove(sanPham);
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
