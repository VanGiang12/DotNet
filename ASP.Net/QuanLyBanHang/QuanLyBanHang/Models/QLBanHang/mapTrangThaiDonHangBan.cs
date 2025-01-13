using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLBanHang
{
    public class mapTrangThaiDonHangBan
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh Sách
        public List<TrangThaiDonHangBan> DanhSach()
        {
            try
            {
                return db.TrangThaiDonHangBans.ToList();
            }
            catch
            {
                return new List<TrangThaiDonHangBan>();
            }
        }
        #endregion
        #region 2.Chi Tiết
        public TrangThaiDonHangBan ChiTiet(int idDonBan)
        {
            try
            {
                var donhang = db.TrangThaiDonHangBans.Find(idDonBan);
                return donhang;
            }
            catch
            {
                return new TrangThaiDonHangBan();
            }
        }
        #endregion
        #region 3.Thêm Mới
        public int ThemMoi(TrangThaiDonHangBan newModel)
        {
            try
            {
                db.TrangThaiDonHangBans.Add(newModel);
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
        public bool CapNhatj(TrangThaiDonHangBan upModel)
        {
            try
            {
                var donhang = db.TrangThaiDonHangBans.Find(upModel.ID);
                donhang.TenTrangThai = upModel.TenTrangThai;
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
                var donhang = db.TrangThaiDonHangBans.Find(idDonHang);
                db.TrangThaiDonHangBans.Remove(donhang);
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