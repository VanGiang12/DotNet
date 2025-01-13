using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLNhanVien
{
    public class mapTruLuong
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh Sách
        public List<TruLuong> DanhSach()
        {
            try
            {
                return db.TruLuongs.ToList();
            }
            catch
            {
                return new List<TruLuong>();
            }
        }
        #endregion

        #region Danh Sách lý do trừ lương của 1 người
        public List<TruLuong> DanhSach(int idBangLuong)
        {
            try
            {
                return db.TruLuongs.Where(m=>m.idBangLuong==idBangLuong).ToList();
            }
            catch
            {
                return new List<TruLuong>();
            }
        }
        #endregion

        #region 2. Chi Tiết
        public TruLuong ChiTiet(int id)
        {
            try
            {
                return db.TruLuongs.Find(id);
            }
            catch
            {
                return new TruLuong();
            }
        }
        #endregion

        #region 3. Thêm Mới
        public int ThemMoi(TruLuong newModel)
        {
            try
            {
                db.TruLuongs.Add(newModel);
                db.SaveChanges();
                return newModel.ID;
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region 4. Cập Nhật
        public bool CapNhat(TruLuong upModel)
        {
            try
            {
                var truluong = db.TruLuongs.Find(upModel.ID);
                truluong.idBangLuong = upModel.idBangLuong;
                truluong.LyDoTru = upModel.LyDoTru;
                truluong.SoTienTru = upModel.SoTienTru;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region 5. Xóa
        public bool Xoa(int id)
        {
            try
            {
                db.TruLuongs.Remove(db.TruLuongs.Find(id));
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