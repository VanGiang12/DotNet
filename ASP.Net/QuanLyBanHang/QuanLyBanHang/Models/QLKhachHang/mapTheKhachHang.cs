using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLKhachHang
{
    public class mapTheKhachHang
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh sách
        public List<TheKhachHang> DanhSach()
        {
            try
            {
                var lstKhachHang = db.TheKhachHangs.ToList();
                return lstKhachHang;
            }
            catch
            {
                return new List<TheKhachHang>();
            }
        }
        #endregion

        #region 2.Chi Tiết
        public TheKhachHang ChiTiet(int id)
        {
            try
            {
                return db.TheKhachHangs.Find(id);
            }
            catch
            {
                return new TheKhachHang();
            }
        }
        #endregion

        #region 3.Thêm mới
        // sau khi thêm trả về id
        public int ThemMoi(TheKhachHang newModel)
        {
            try
            {
                db.TheKhachHangs.Add(newModel);
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
        public bool CapNhat(TheKhachHang upModel)
        {
            try
            {
                var khachhang = db.TheKhachHangs.Find(upModel.ID);
                khachhang.MaSoThe = upModel.MaSoThe;
                khachhang.idKhachHang = upModel.idKhachHang;
                khachhang.NgayCap = upModel.NgayCap;
                khachhang.NgayHetHan = upModel.NgayHetHan;
                khachhang.LoaiThe = upModel.LoaiThe;
                khachhang.TrangThaiHoatDong = upModel.TrangThaiHoatDong;
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
                var khachhang = db.TheKhachHangs.Find(id);
                db.TheKhachHangs.Remove(khachhang);
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