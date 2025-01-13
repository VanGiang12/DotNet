using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLSanPham
{
    public class mapLoaiSanPham
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh sách
        public List<LoaiSanPham> DanhSach()
        {
            try
            {
                var lstLoaiSanPham = db.LoaiSanPhams.OrderBy(m => m.TenSanPham).ToList();
                return lstLoaiSanPham;
            }
            catch
            {
                return new List<LoaiSanPham>();
            }
        }
        #endregion

        #region 2.Chi Tiết
        public LoaiSanPham ChiTiet(int id)
        {
            try
            {
                return db.LoaiSanPhams.Find(id);
            }
            catch
            {
                return new LoaiSanPham();
            }
        }
        #endregion

        #region 3.Thêm mới
        // sau khi thêm trả về id
        public int ThemMoi(LoaiSanPham newModel)
        {
            try
            {
                db.LoaiSanPhams.Add(newModel);
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
        public bool CapNhat(LoaiSanPham upModel)
        {
            try
            {
                var LoaiSanPham = db.LoaiSanPhams.Find(upModel.ID);
                LoaiSanPham.TenSanPham = upModel.TenSanPham;
                LoaiSanPham.GiaNiemYet = upModel.GiaNiemYet;
                LoaiSanPham.MaVach = upModel.MaVach;
                LoaiSanPham.DonViTinh = upModel.DonViTinh;
                LoaiSanPham.GiaNiemYet = upModel.GiaNiemYet;
                LoaiSanPham.GiaTriGiamGia = upModel.GiaTriGiamGia;
                LoaiSanPham.PhanTramGiamGia = upModel.PhanTramGiamGia;
                LoaiSanPham.idNhomSanPham = upModel.idNhomSanPham;
                LoaiSanPham.NgayHetHan = upModel.NgayHetHan;
                LoaiSanPham.NgaySanXuat = upModel.NgaySanXuat;
                LoaiSanPham.NhaSanXuat = upModel.NhaSanXuat;
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
                var LoaiSanPham = db.LoaiSanPhams.Find(id);
                db.LoaiSanPhams.Remove(LoaiSanPham);
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