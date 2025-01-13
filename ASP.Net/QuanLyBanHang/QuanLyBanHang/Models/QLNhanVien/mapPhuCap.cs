using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLNhanVien
{
    public class mapPhuCap
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh Sách
        public List<PhuCap> DanhSach()
        {
            try
            {
                return db.PhuCaps.ToList();
            }
            catch
            {
                return new List<PhuCap>();
            }
        }
        #endregion


        #region 2.Chi Tiết
        public PhuCap ChiTiet(int id)
        {
            try
            {
                return db.PhuCaps.Find(id);
            }
            catch
            {
                return new PhuCap();
            }
        }
        #endregion

        #region 3.Thêm Mới
        public int ThemMoi(PhuCap newModel)
        {
            try
            {
                db.PhuCaps.Add(newModel);
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
        public bool CapNhat(PhuCap upModel)
        {
            try
            {
                var phucap = db.PhuCaps.Find(upModel.ID);
                phucap.LoaiPhuCap=upModel.LoaiPhuCap;
                phucap.SoTienPhuCap = upModel.SoTienPhuCap;
                phucap.idBangLuong = upModel.idBangLuong;
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
                db.PhuCaps.Remove(db.PhuCaps.Find(id));
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