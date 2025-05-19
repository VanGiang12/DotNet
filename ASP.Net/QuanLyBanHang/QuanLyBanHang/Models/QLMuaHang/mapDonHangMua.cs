using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLMuaHang
{
    public class mapDonHangMua
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh sách
        public List<DonHangMua> DanhSach()
        {
            try
            {
                var lstDonHangMua = db.DonHangMuas.ToList();
                return lstDonHangMua;
            }
            catch
            {
                return new List<DonHangMua>();
            }
        }
        #endregion

        #region 2. Chi Tiết
        public DonHangMua ChiTiet(int id)
        {
            try
            {
                var donhangmua = db.DonHangMuas.Find(id);
                return donhangmua;
            }
            catch
            {
                return new DonHangMua();
            }
        }
        #endregion

        #region 3.Thêm Mới
        public int ThemMoi(DonHangMua newModel)
        {
            try
            {
                db.DonHangMuas.Add(newModel);
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
        public bool CapNhat(DonHangMua upModel)
        {
            try
            {
                var DonHang = db.DonHangMuas.Find(upModel.ID);
                DonHang.idNguongHang = upModel.idNguongHang;
                DonHang.idNhanVienLap = upModel.idNhanVienLap;
                DonHang.ThoiGian = upModel.ThoiGian;
                DonHang.TongTien = upModel.TongTien;
                DonHang.GiaTriGiamGia = upModel.GiaTriGiamGia;
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
        public bool Xoa(int idDonHang)
        {
            try
            {
                var donhang = db.DonHangMuas.Find(idDonHang);
                db.DonHangMuas.Remove(donhang);
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
