using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web1.Models;

namespace web1.Controllers
{
    public class LoaiBaiVietController : Controller
    {
        BanHang_TestEntities1 db = new BanHang_TestEntities1();

        public ActionResult Index()
        {
            return View(db.LoaiBaiViets.ToList());
        }

        #region Thêm
        public ActionResult ThemMoi()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemMoi(LoaiBaiViet model)
        {
            if (string.IsNullOrEmpty(model.TenLoai) == true)
            {
                ModelState.AddModelError("", "Bạn chưa nhập tên!");
                return View(model);
            }
            try
            {
                db.LoaiBaiViets.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("",ex.Message);
                return View(model);
            }
        }
        #endregion

        #region Sửa
        public ActionResult CapNhat(int id)
        {
            return View(db.LoaiBaiViets.Find(id));
        }

        [HttpPost]
        public ActionResult CapNhat(LoaiBaiViet model)
        {
            if (string.IsNullOrEmpty(model.TenLoai) == true)
            {
                ModelState.AddModelError("", "Bạn chưa nhập tên!");
                return View(model);
            }
            try
            {
                var updateModel = db.LoaiBaiViets.Find(model.ID);
                updateModel.TenLoai = model.TenLoai;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(model);
            }
        }
        #endregion

        #region Xóa
        public ActionResult Xoa(int id)
        {
            var model = db.LoaiBaiViets.Find(id);
            db.LoaiBaiViets.Remove(model);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        #endregion
    }
}