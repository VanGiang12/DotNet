using QuanLyBanHang.Models;
using QuanLyBanHang.Models.QLNhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBanHang.Areas.Admin.Controllers.qlNhanVien
{
    public class ADPhuCapController : Controller
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        public ActionResult DanhSach()
        {
            return View(new mapPhuCap().DanhSach());
        }
        public ActionResult ThemMoi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemMoi(PhuCap model)
        {
            var themmoi = new mapPhuCap();
            themmoi.ThemMoi(model);
            return RedirectToAction("DanhSach");
        }
        public ActionResult CapNhat(int ID)
        {
            return View(db.PhuCaps.Find(ID));
        }
        [HttpPost]
        public ActionResult CapNhat(PhuCap model)
        {
            var up = new mapPhuCap();
            up.CapNhat(model);
            return RedirectToAction("DanhSach");
        }
        public ActionResult Xoa(int ID)
        {
            var delete = new mapPhuCap();
            delete.Xoa(ID);
            return RedirectToAction("DanhSach");
        }
    }
}