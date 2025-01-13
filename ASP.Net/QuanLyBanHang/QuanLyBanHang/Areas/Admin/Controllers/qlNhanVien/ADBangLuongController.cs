using QuanLyBanHang.Models;
using QuanLyBanHang.Models.QLNhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBanHang.Areas.Admin.Controllers.qlNhanVien
{
    public class ADBangLuongController : Controller
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        public ActionResult DanhSach()
        {
            var dsbl = new mapBangLuong().DanhSach();
            return View(dsbl);
        }
        public ActionResult ThemMoi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemMoi(BangLuong model)
        {
            var themmoi = new mapBangLuong();
            themmoi.ThemMoi(model);
            return RedirectToAction("DanhSach");
        }
        public ActionResult CapNhat(int ID)
        {
            return View(db.BangLuongs.Find(ID));
        }
        [HttpPost]
        public ActionResult CapNhat(BangLuong model)
        {
            var upmodel = new mapBangLuong();
            upmodel.CapNhat(model);
            return RedirectToAction("DanhSach");
        }
        public ActionResult Xoa(int ID)
        {
            var xoa = new mapBangLuong();
            xoa.Xoa(ID);
            return RedirectToAction("DanhSach");
        }
    }
}