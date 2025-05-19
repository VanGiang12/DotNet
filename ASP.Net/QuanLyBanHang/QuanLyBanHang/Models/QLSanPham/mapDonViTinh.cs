using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLSanPham
{
    public class mapDonViTinh
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh sách
        public List<DonViTinh> DanhSach()
        {
            try
            {
                var lstDonViTinh = db.DonViTinhs.ToList();
                return lstDonViTinh;
            }
            catch
            {
                return new List<DonViTinh>();
            }
        }
        #endregion

        #region 2.Chi Tiết
        public DonViTinh ChiTiet(int id)
        {
            try
            {
                return db.DonViTinhs.Find(id);
            }
            catch
            {
                return new DonViTinh();
            }
        }
        #endregion

        #region 3.Thêm mới
        // sau khi thêm trả về id
        public int ThemMoi(DonViTinh newModel)
        {
            try
            {
                db.DonViTinhs.Add(newModel);
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
        public bool CapNhat(DonViTinh upModel)
        {
            try
            {
                var donvitinh = db.DonViTinhs.Find(upModel.ID);
                donvitinh.DonViTinh1 = upModel.DonViTinh1;
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
                var donvitinh = db.DonViTinhs.Find(id);
                db.DonViTinhs.Remove(donvitinh);
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