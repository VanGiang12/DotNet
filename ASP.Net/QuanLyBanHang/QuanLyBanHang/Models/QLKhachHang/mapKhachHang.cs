using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLKhachHang
{
    public class mapKhachHang
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh sách
        public List<KhachHang> DanhSach()
        {
            try
            {
                var lstKhachHang = db.KhachHangs.OrderBy(m => m.TenKhachHang).ToList();
                return lstKhachHang;
            }
            catch
            {
                return new List<KhachHang>();
            }
        }
        #endregion

        #region 2.Chi Tiết
        public KhachHang ChiTiet(int id)
        {
            try
            {
                return db.KhachHangs.Find(id);
            }
            catch
            {
                return new KhachHang();
            }
        }
        #endregion

        #region 3.Thêm mới
        // sau khi thêm trả về id
        public int ThemMoi(KhachHang newModel)
        {
            try
            {
                db.KhachHangs.Add(newModel);
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
        public bool CapNhat(KhachHang upModel)
        {
            try
            {
                var khachhang = db.KhachHangs.Find(upModel.ID);
                khachhang.TenKhachHang = upModel.TenKhachHang;
                khachhang.NgaySinh = upModel.NgaySinh;
                khachhang.SoDienThoai = upModel.SoDienThoai;
                khachhang.Email = upModel.Email;
                
                khachhang.DiaChi = upModel.DiaChi;
                khachhang.GioiTinh = upModel.GioiTinh;
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
                var khachhang = db.KhachHangs.Find(id);
                db.KhachHangs.Remove(khachhang);
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