using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.MuaHang.QLMuaHang
{
    public class mapNguonHang
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh sách
        public List<NguonHang> DanhSach()
        {
            try
            {
                var lstNguonHang = db.NguonHangs.ToList();
                return lstNguonHang;
            }
            catch
            {
                return new List<NguonHang>();
            }
        }
        #endregion

        #region 2.Chi Tiết
        public NguonHang ChiTiet(int id)
        {
            try
            {
                return db.NguonHangs.Find(id);
            }
            catch
            {
                return new NguonHang();
            }
        }
        #endregion

        #region 3.Thêm mới
        // sau khi thêm trả về id
        public int ThemMoi(NguonHang newModel)
        {
            try
            {
                db.NguonHangs.Add(newModel);
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
        public bool CapNhat(NguonHang upModel)
        {
            try
            {
                var nguon = db.NguonHangs.Find(upModel.ID);
                nguon.TenNguonHang = upModel.TenNguonHang;
                nguon.NgayTao = upModel.NgayTao;
                nguon.SoDienThoai = upModel.SoDienThoai;
                nguon.Email = upModel.Email;
                nguon.DiaChi = upModel.DiaChi;
                nguon.NganHang = upModel.NganHang;
                nguon.STK = upModel.STK;
                nguon.nguoiDaiDien = upModel.nguoiDaiDien;
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
                var nguon = db.NguonHangs.Find(id);
                db.NguonHangs.Remove(nguon);
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