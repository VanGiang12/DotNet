using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLNhanVien
{
    public class mapTamUng
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh Sách
        public List<TamUng> DanhSach()
        {
            try
            {
                return db.TamUngs.ToList();
            }
            catch
            {
                return new List<TamUng>();
            }
        }
        #endregion

        #region 2.Chi Tiết
        public TamUng ChiTiet(int id)
        {
            try
            {
                return db.TamUngs.Find(id);
            }
            catch
            {
                return new TamUng();
            }
        }
        #endregion

        #region 3.Thêm Mới
        public int ThemMoi(TamUng newModel)
        {
            try
            {
                db.TamUngs.Add(newModel);
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
        public bool CapNhat(TamUng upModel)
        {
            try
            {
                var tamung = db.TamUngs.Find(upModel.ID);
                tamung.idBangLuong = upModel.idBangLuong;
                tamung.LyDo = upModel.LyDo;
                tamung.SoTienUng = upModel.SoTienUng;
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
                db.TamUngs.Remove(db.TamUngs.Find(id));
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