using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLHeThong
{
    public class mapChucNang
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh sách
        public List<ChucNang> DanhSach()
        {
            try
            {
                var lstChucNang = db.ChucNangs.ToList();
                return lstChucNang;
            }
            catch
            {
                return new List<ChucNang>();
            }
        }
        #endregion

        #region 2.Chi Tiết
        public ChucNang ChiTiet(int id)
        {
            try
            {
                return db.ChucNangs.Find(id);
            }
            catch
            {
                return new ChucNang();
            }
        }
        #endregion

        #region 3.Thêm mới
        // sau khi thêm trả về id
        public int ThemMoi(ChucNang newModel)
        {
            try
            {
                db.ChucNangs.Add(newModel);
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
        public bool CapNhat(ChucNang upModel)
        {
            try
            {
                var chucnang = db.ChucNangs.Find(upModel.ID);
                chucnang.TenChucNang = upModel.TenChucNang;
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
                var chucnang = db.ChucNangs.Find(id);
                db.ChucNangs.Remove(chucnang);
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