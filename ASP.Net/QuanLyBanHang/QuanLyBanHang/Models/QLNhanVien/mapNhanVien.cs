using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLNhanVien
{
    
    public class mapNhanVien
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh sách
        public List<NhanVien> DanhSach()
        {
            try
            {
                var lstNhanVien = db.NhanViens.OrderBy(m=>m.TenNhanVien).ToList();
                return lstNhanVien;
            }
            catch
            {
                return new List<NhanVien>();
            }
        }
        #endregion

        #region 2.Chi Tiết
        public NhanVien ChiTiet(int maNV)
        {
            try
            {
                return db.NhanViens.Find(maNV);
            }
            catch
            {
                return new NhanVien();
            }
        }
        #endregion

        #region 3.Thêm mới
        // sau khi thêm trả về id
        public int ThemMoi(NhanVien newModel)
        {
            try
            {
                db.NhanViens.Add(newModel);
                db.SaveChanges();
                return newModel.MaNV ;
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region 4.Sửa
        public bool CapNhat(NhanVien upModel)
        {
            try
            {
                var nhanvien = db.NhanViens.Find(upModel.MaNV);
                nhanvien.TenNhanVien = upModel.TenNhanVien;
                nhanvien.NgaySinh = upModel.NgaySinh;
                nhanvien.SoDienThoai = upModel.SoDienThoai;
                nhanvien.Email = upModel.Email;
                nhanvien.DiaChi = upModel.DiaChi;
                nhanvien.TimeBatDauLam = upModel.TimeBatDauLam;
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
        public bool Xoa(int maNV)
        {
            try
            {
                var nhanvien = db.NhanViens.Find(maNV);
                db.NhanViens.Remove(nhanvien);
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