using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web1.Models;

namespace web1.Controllers
{
    public class MayTinhController : Controller
    {
        public BanHang_TestEntities1 db = new BanHang_TestEntities1();

        public ActionResult Index(string key)
        {
            List<MayTinh> lstMayTinh = db.MayTinhs.Where(m=>m.TenMayTinh.ToLower().Contains(key.ToLower())).ToList();
            return View(lstMayTinh);
        }

        #region Thêm
        public ActionResult ThemMoi()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemMoi(MayTinh model)
        {
            db.MayTinhs.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        #region Sửa
        public ActionResult CapNhat(int id)
        {
            var update = db.MayTinhs.Find(id);
            return View(update);
        }

        [HttpPost]
        public ActionResult CapNhat(MayTinh model)
        {
            var update = db.MayTinhs.Find(model.ID);

            update.TenMayTinh = model.TenMayTinh;
            update.HangSanXuat = model.HangSanXuat;
            update.NamSanXuat = model.NamSanXuat;

            db.SaveChanges();
            return RedirectToAction("Index");

        }
        #endregion

        #region Xoa
        public ActionResult Xoa(int id)
        {
            var xoa = db.MayTinhs.Find(id);
            db.MayTinhs.Remove(xoa);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

    }
}