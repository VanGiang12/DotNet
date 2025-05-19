using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLThongKe
{
    public class mapBienBanKiemKeChiTiet
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh sách
        public List<BienBanKiemKeChiTiet> DanhSach()
        {
            try
            {
                var lstBienBan = db.BienBanKiemKeChiTiets.ToList();
                return lstBienBan;
            }
            catch
            {
                return new List<BienBanKiemKeChiTiet>();
            }
        }
        #endregion

        #region 2.Chi Tiết
        public BienBanKiemKeChiTiet ChiTiet(int id)
        {
            try
            {
                return db.BienBanKiemKeChiTiets.Find(id);
            }
            catch
            {
                return new BienBanKiemKeChiTiet();
            }
        }
        #endregion

        #region 3.Thêm mới
        // sau khi thêm trả về id
        public int ThemMoi(BienBanKiemKeChiTiet newModel)
        {
            try
            {
                db.BienBanKiemKeChiTiets.Add(newModel);
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
        public bool CapNhat(BienBanKiemKeChiTiet upModel)
        {
            try
            {
                var bienban = db.BienBanKiemKeChiTiets.Find(upModel.ID);
                bienban.idBienBan = upModel.idBienBan;
                bienban.idLoaiSanPham = upModel.idLoaiSanPham;
                bienban.SoLuongTonKho = upModel.SoLuongTonKho;
                bienban.SoLuongThucTe = upModel.SoLuongThucTe;
                bienban.ChenhLech = upModel.ChenhLech;
                bienban.LyDo = upModel.LyDo;
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
                var bienban = db.BienBanKiemKeChiTiets.Find(id);
                db.BienBanKiemKeChiTiets.Remove(bienban);
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