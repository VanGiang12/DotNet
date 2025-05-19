using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web1.Models;

namespace web1.Controllers
{
    public class DonHangController : Controller
    {
        public ActionResult Index()
        {
            return View(DanhSachDH.lstDonHang);
        }

        #region Thêm Mới Đơn Hàng
        public ActionResult ThemMoi()
        {
            return View(new DonHang());
        }

        [HttpPost]
        public ActionResult ThemMoi(DonHang model) 
        {
            if (model.ID == 0)
            {
                ModelState.AddModelError("","ID phải !=0");
                return View(model);
            }
            DanhSachDH.lstDonHang.Add(model);
            return RedirectToAction("Index");
        }

        #endregion

        #region Sửa thông tin đơn thàng
        public ActionResult CapNhat(int IDDH)
        {
            //tìm đơn hàng
            var donhang = DanhSachDH.lstDonHang.SingleOrDefault(m => m.ID == IDDH);
            //truyền thông tin đơn vừa tìm đc sang view
            return View(donhang);
        }

        [HttpPost]
        public ActionResult CapNhat(DonHang model)
        {
            if (string.IsNullOrEmpty(model.TenKH))
            {
                ModelState.AddModelError("", "Bạn chưa nhập tên"); // in ra tb
                return View(model); //quay lại view themmoi va truyền lại model
            }

            //tìm đối tượng
            var donhang = DanhSachDH.lstDonHang.SingleOrDefault(m => m.ID == model.ID);
            //cập nhật thông tin
            donhang.TenKH = model.TenKH;
            donhang.SDT = model.SDT;
            donhang.DiaChi = model.DiaChi;
            donhang.NgayDat = model.NgayDat;

            return RedirectToAction("Index");
        }
        #endregion

        #region Xóa đơn hàng
        public ActionResult Xoa(int IDDH)
        {
            //tìm đối tg xóa
            var donhang = DanhSachDH.lstDonHang.SingleOrDefault(m => m.ID == IDDH);
            //thực hiện xóa
            DanhSachDH.lstDonHang.Remove(donhang);
            return RedirectToAction("Index");
        }
        #endregion

        #region Chi tiết sản phẩm trong đơn hàng
        public ActionResult ChiTiet(int IDDH)
        {
            //tìm đơn hàng
            var donhang = DanhSachDH.lstDonHang.SingleOrDefault(m => m.ID == IDDH);
            //truyền thông tin đơn vừa tìm đc sang view
            return View(donhang);
        }

        public ActionResult ThemChiTiet(int IDDH)//add view máy tính
        {
            ViewBag.IDDH = IDDH;
            return View(new MayTinh());
        }

        [HttpPost]
        public ActionResult ThemChiTiet(MayTinh model,int IDDH)//add view máy tính
        {
            var donhang = DanhSachDH.lstDonHang.SingleOrDefault(m => m.ID == IDDH);
            donhang.MTDatMua.Add(model);
            return RedirectToAction("ChiTiet", new { IDDH = IDDH });
        }
        #endregion

        #region Sửa sản phẩm bên trong đơn hàng
        public ActionResult SuaChiTiet(int IDDH, string maMay)
        {
            var donhang = DanhSachDH.lstDonHang.SingleOrDefault(m => m.ID == IDDH);
            var maytinh = donhang.MTDatMua.SingleOrDefault(m => m.MaMay == maMay);
            ViewBag.IDDH = IDDH;
            return View(maytinh);
        }

        [HttpPost]
        public ActionResult SuaChiTiet(MayTinh model, int IDDH)
        {
            var donhang = DanhSachDH.lstDonHang.SingleOrDefault(m => m.ID == IDDH);
            var maytinh = donhang.MTDatMua.SingleOrDefault(m => m.MaMay == model.MaMay);
            maytinh.DongMay = model.DongMay;
            maytinh.DonGia = model.DonGia;
            maytinh.NgaySanXuat = model.NgaySanXuat;
            maytinh.HangSanXuat = model.HangSanXuat;
            return RedirectToAction("ChiTiet", new { IDDH = IDDH });
        }
        #endregion

        #region Xóa đơn sản phẩm bên trong đơn hàng
        public ActionResult XoaChiTiet(int IDDH, string maMay)
        {
            var donhang = DanhSachDH.lstDonHang.SingleOrDefault(m => m.ID == IDDH);
            var maytinh = donhang.MTDatMua.SingleOrDefault(m => m.MaMay == maMay);
            donhang.MTDatMua.Remove(maytinh);
            return RedirectToAction("ChiTiet", new { IDDH = IDDH });
        }
        #endregion
    }
}