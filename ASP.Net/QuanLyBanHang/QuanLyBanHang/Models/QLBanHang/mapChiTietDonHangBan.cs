using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLBanHang
{
    public class mapChiTietDonHangBan
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh Sách
        public List<ChiTietDonHangban> DanhSach()
        {
            try
            {
                return db.ChiTietDonHangbans.ToList();
            }
            catch
            {
                return new List<ChiTietDonHangban>();
            }
        }
        #endregion
        #region 2.Chi Tiết
        public ChiTietDonHangban ChiTiet(int idDonBan)
        {
            try
            {
                var donhang=db.ChiTietDonHangbans.Find(idDonBan);
                return donhang;
            }
            catch
            {
                return new ChiTietDonHangban();
            }
        }
        #endregion
        #region 3.Thêm Mới
        public int ThemMoi(ChiTietDonHangban newModel)
        {
            try
            {
                db.ChiTietDonHangbans.Add(newModel);
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
        public bool CapNhatj(ChiTietDonHangban upModel)
        {
            try
            {
                var donhang = db.ChiTietDonHangbans.Find(upModel.ID);
                donhang.idDonHangBan = upModel.idDonHangBan;
                donhang.idSanPham = upModel.idSanPham;
                donhang.SoLuong = upModel.SoLuong;
                donhang.DonGiaApDung = upModel.DonGiaApDung;
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
                var donhang = db.ChiTietDonHangbans.Find(idDonHang);
                db.ChiTietDonHangbans.Remove(donhang);
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