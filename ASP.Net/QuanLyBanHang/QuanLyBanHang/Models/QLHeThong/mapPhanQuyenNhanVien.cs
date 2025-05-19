using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLHeThong
{
    public class mapPhanQuyenNhanVien
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh sách
        public List<PhanQuyenNhanVien> DanhSach()
        {
            try
            {
                var lstPhanQuyen = db.PhanQuyenNhanViens.ToList();
                return lstPhanQuyen;
            }
            catch
            {
                return new List<PhanQuyenNhanVien>();
            }
        }
        #endregion

        #region 2.Chi Tiết
        public PhanQuyenNhanVien ChiTiet(int MaCN, int MaNV)
        {
            try
            {
                //                              khớp thứ tự trong database
                return db.PhanQuyenNhanViens.Find(MaCN,MaNV);
            }
            catch
            {
                return new PhanQuyenNhanVien();
            }
        }
        #endregion

        #region 3.Thêm mới
        // sau khi thêm trả về id
        public int ThemMoi(PhanQuyenNhanVien newModel)
        {
            try
            {
                db.PhanQuyenNhanViens.Add(newModel);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region 4.Sửa
        public bool CapNhat(PhanQuyenNhanVien upModel)
        {
            try
            {
                var phanquyen = db.PhanQuyenNhanViens.Find(upModel.MaChucNang,upModel.MaNV);
                phanquyen.GhiChu = upModel.GhiChu;
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
        public bool Xoa(int MaCN,int MaNV)
        {
            try
            {
                var phanquyen = db.PhanQuyenNhanViens.Find(MaCN,MaNV);
                db.PhanQuyenNhanViens.Remove(phanquyen);
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