using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyBanHang.App_Start;
using QuanLyBanHang.Models.QLNhanVien;

namespace QuanLyBanHang.Areas.Admin.Controllers.qlNhanVien
{
    public class ADNhanVienController : Controller
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string user, string password)
        {
            //tạo bảng tài khoản
            var nhanvien = db.NhanViens.SingleOrDefault(m => m.UserName == user && m.PassWord == password);
            if (nhanvien != null)
            {
                SessionConfig.SetUser(nhanvien);
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Tài khoản hoặc mật khẩu không đúng!";
                return View();
            }
        }

        public ActionResult DanhSach(string key)
        {
           /* var nv = new mapNhanVien().DanhSach();
            nv = db.NhanViens.Where(
            m => m.TenNhanVien.ToLower().Contains(key.ToLower()) == true
            || m.SoDienThoai.ToLower().Contains(key) == true).ToList();*/

            List<DanhSachNhanVien_Result> dsnv = db.DanhSachNhanVien(key).ToList();
            ViewBag.key = key;
            return View(dsnv);
        }

        public ActionResult ThemMoi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemMoi(NhanVien model)
        {
            var themmoi = new mapNhanVien();
            themmoi.ThemMoi(model);
            return RedirectToAction("DanhSach");
        }

        public ActionResult CapNhat(int id)
        {
            var upNhanvien = db.NhanViens.Find(id);
            return View(upNhanvien);
        }
        [HttpPost]
        public ActionResult CapNhat(NhanVien model)
        {
            var upNhanvien = new mapNhanVien();
            upNhanvien.CapNhat(model);
            return RedirectToAction("DanhSach");
        }

        public ActionResult Xoa(int id)
        {
            var upNhanvien = new mapNhanVien();
            upNhanvien.Xoa(id);
            return RedirectToAction("DanhSach");
        }
    }

}