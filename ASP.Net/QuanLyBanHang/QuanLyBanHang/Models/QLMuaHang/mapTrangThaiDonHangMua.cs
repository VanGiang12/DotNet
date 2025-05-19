using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLMuaHang
{
    public class mapTrangThaiDonHangMua
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh Sách
        public List<TrangThaiDonHangMua> DanhSach()
        {
            try
            {
                return db.TrangThaiDonHangMuas.ToList();
            }
            catch
            {
                return new List<TrangThaiDonHangMua>();
            }
        }
        #endregion
        #region 2.Chi Tiết
        public TrangThaiDonHangMua ChiTiet(int idDonMua)
        {
            try
            {
                var donhang = db.TrangThaiDonHangMuas.Find(idDonMua);
                return donhang;
            }
            catch
            {
                return new TrangThaiDonHangMua();
            }
        }
        #endregion
        #region 3.Thêm Mới
        public int ThemMoi(TrangThaiDonHangMua newModel)
        {
            try
            {
                db.TrangThaiDonHangMuas.Add(newModel);
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
        public bool CapNhatj(TrangThaiDonHangMua upModel)
        {
            try
            {
                var donhang = db.TrangThaiDonHangMuas.Find(upModel.ID);
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
                var donhang = db.TrangThaiDonHangMuas.Find(idDonHang);
                db.TrangThaiDonHangMuas.Remove(donhang);
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
