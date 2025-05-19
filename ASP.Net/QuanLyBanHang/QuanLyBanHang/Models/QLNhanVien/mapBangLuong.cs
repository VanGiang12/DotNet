using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLNhanVien
{
    public class mapBangLuong
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1. Danh Sách
        public List<BangLuong> DanhSach()
        {
            try
            {
                var lstBangLuong = db.BangLuongs.ToList();
                return lstBangLuong;
            }
            catch
            {
                return new List<BangLuong>();
            }
        }
        #endregion
        #region 2.Chi Tiết
        public BangLuong ChiTiet(int id)
        {
            try
            {
                return db.BangLuongs.Find(id);
            }
            catch
            {
                return new BangLuong();
            }
        }
        #endregion
        #region 3.Thêm
        public int ThemMoi(BangLuong newModel)
        {
            try
            {
                db.BangLuongs.Add(newModel);
                db.SaveChanges();
                return newModel.ID;
            }
            catch
            {
                return 0;
            }
        }
        #endregion
        #region 4.Sửa
        public bool CapNhat(BangLuong upModel)
        {
            try
            {
                var bangluong = db.BangLuongs.Find(upModel.ID);
                bangluong.MaNV = upModel.MaNV;
                bangluong.Nam = upModel.Nam;
                bangluong.Thang = upModel.Thang;
                bangluong.LuongNhan = upModel.LuongNhan;
                bangluong.LuongTheoNgay = upModel.LuongTheoNgay;
                bangluong.SoNgayCong = upModel.SoNgayCong;
                bangluong.NgayTra = upModel.NgayTra;
                bangluong.DanhDauTra = upModel.DanhDauTra;
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
        public bool Xoa(int id)
        {
            try
            {
                var bangluong = db.BangLuongs.Find(id);
                db.BangLuongs.Remove(bangluong);
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