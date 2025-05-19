using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web1.Models;

namespace web1.Controllers
{
    public class BaiVietController : Controller
    {
        BanHang_TestEntities1 db = new BanHang_TestEntities1();

        public ActionResult Index()
        {
            return View(db.BaiViets.ToList());
        }

        #region Thêm
        public ActionResult ThemMoi()
        {
            return View(new BaiViet());
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoi(BaiViet model)
        {
            if (string.IsNullOrEmpty(model.TenBaiViet))
            {
                ModelState.AddModelError("", "Bạn chưa nhập tên");
                return View(model);
            }
            try
            {
                db.BaiViets.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("",ex.Message);
                return View(model);
            }
        }
        #endregion

        #region ckEditor
        // Các bước nhúng ckEditor
        // 1.Tải bộ plugin và cho vào project
        // 2.Kéo file js vào layout(dòng 250)
        // 3.Thay đổi nội dung thành textarea, có đặt id cho input(dòng 100)
        // 4.Viết lệnh js cho textarea(dòng 113)
        // 5.Lưu dữ liệu - Tắt kiểm tra HTML cho action lưu dữ liệu

        public ActionResult Edit(int id)
        {
            return View(db.BaiViets.Find(id));
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(BaiViet model)
        {
            var baiViet=db.BaiViets.Find(model.ID);

            if (string.IsNullOrEmpty(model.TenBaiViet))
            {
                ModelState.AddModelError("", "Bạn chưa nhập tên");
                return View(model);
            }
            try
            {
                baiViet.NoiDung = model.NoiDung;
                baiViet.TenBaiViet = model.TenBaiViet;
                baiViet.NguoiViet = model.NguoiViet;
                baiViet.NgayViet = model.NgayViet;

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

        #region skFinder
        //// Các bước nhúng ckFinder
        // 1.Tải bộ plugin và cho vào project
        // 2.Kéo file js vào layout(dòng 249)
        // 3.Thêm DLL vào project
        // 4.Cấu hình
        // 5.Sử dụng

        #endregion
    }
}