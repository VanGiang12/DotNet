using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace QuanLyBanHang.Models.QLBanHang
{
    public class mapDonHangBan
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh sách
        public List<DonHangBan> DanhSach()
        {
            try
            {
                var lstDonHangBan = db.DonHangBans.ToList();
                return lstDonHangBan;
            }
            catch
            {
                return new List<DonHangBan>();
            }
        }
        #endregion

        #region 2. Chi Tiết
        public DonHangBan ChiTiet(int idDonHangBan)
        {
            try
            {
                var donhangban = db.DonHangBans.Find(idDonHangBan);
                return donhangban;
            }
            catch
            {
                return new DonHangBan();
            }
        }
        #endregion

        #region 3.Thêm Mới
        public int ThemMoi(DonHangBan newModel)
        {
            try
            {
                db.DonHangBans.Add(newModel);
                db.SaveChanges();
                return newModel.ID;
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region 4. Cập Nhật
        public bool CapNhat(DonHangBan upModel)
        {
            try
            {
                var DonHang = db.DonHangBans.Find(upModel.ID);
                DonHang.NgayLap = upModel.NgayLap;
                DonHang.idNhanVienLap = upModel.idNhanVienLap;
                DonHang.idKhachHang = upModel.idKhachHang;
                DonHang.TongTien = upModel.TongTien;
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
                var donhang = db.DonHangBans.Find(idDonHang);
                db.DonHangBans.Remove(donhang);
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