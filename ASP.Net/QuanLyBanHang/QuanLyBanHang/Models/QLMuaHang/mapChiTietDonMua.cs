using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLMuaHang
{
    public class mapChiTietDonMua
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh Sách
        public List<ChiTietDonHangMua> DanhSach()
        {
            try
            {
                return db.ChiTietDonHangMuas.ToList();
            }
            catch
            {
                return new List<ChiTietDonHangMua>();
            }
        }
        #endregion
        #region 2.Chi Tiết
        public ChiTietDonHangMua ChiTiet(int idDonBan)
        {
            try
            {
                var donhang = db.ChiTietDonHangMuas.Find(idDonBan);
                return donhang;
            }
            catch
            {
                return new ChiTietDonHangMua();
            }
        }
        #endregion
        #region 3.Thêm Mới
        public int ThemMoi(ChiTietDonHangMua newModel)
        {
            try
            {
                db.ChiTietDonHangMuas.Add(newModel);
                db.SaveChanges();
                return newModel.ID;
            }
            catch
            {
                return 0;
            }
        }
        #endregion
        #region 4.Cập Nhật
        public bool CapNhatj(ChiTietDonHangMua upModel)
        {
            try
            {
                var donhang = db.ChiTietDonHangMuas.Find(upModel.ID);
                donhang.idDonHangMua = upModel.idDonHangMua;
                donhang.idLoaiSanPham = upModel.idLoaiSanPham;
                donhang.SoLuong = upModel.SoLuong;
                donhang.TenSanPham = upModel.TenSanPham;
                donhang.DonGiaNhap = upModel.DonGiaNhap;
                donhang.GiaTriGiamGia = upModel.GiaTriGiamGia;
                donhang.PhanTramGiamGia = upModel.PhanTramGiamGia;
                donhang.ThanhTien = upModel.ThanhTien;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region 5.Xóa 
        public bool Xoa(int idDonHang)
        {
            try
            {
                var donhang = db.ChiTietDonHangMuas.Find(idDonHang);
                db.ChiTietDonHangMuas.Remove(donhang);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}