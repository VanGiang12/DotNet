using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLThongKe
{
    public class mapBienBanKiemKe
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh sách
        public List<BienBanKiemKe> DanhSach()
        {
            try
            {
                var lstBienBan = db.BienBanKiemKes.ToList();
                return lstBienBan;
            }
            catch
            {
                return new List<BienBanKiemKe>();
            }
        }
        #endregion

        #region 2.Chi Tiết
        public BienBanKiemKe ChiTiet(int id)
        {
            try
            {
                return db.BienBanKiemKes.Find(id);
            }
            catch
            {
                return new BienBanKiemKe();
            }
        }
        #endregion

        #region 3.Thêm mới
        // sau khi thêm trả về id
        public int ThemMoi(BienBanKiemKe newModel)
        {
            try
            {
                db.BienBanKiemKes.Add(newModel);
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
        public bool CapNhat(BienBanKiemKe upModel)
        {
            try
            {
                var bienban = db.BienBanKiemKes.Find(upModel.ID);
                bienban.TenBienBan = upModel.TenBienBan;
                bienban.NgayLap = upModel.NgayLap;
                bienban.idNguoiLap = upModel.idNguoiLap;
                bienban.TrangThai = upModel.TrangThai;
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
                var bienban = db.BienBanKiemKes.Find(id);
                db.BienBanKiemKes.Remove(bienban);
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