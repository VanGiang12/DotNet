using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models.QLSanPham
{
    public class mapNhomSanPham
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        #region 1.Danh sách
        public List<NhomSanPham> DanhSach()
        {
            try
            {
                var lstNhomSanPham = db.NhomSanPhams.OrderBy(m => m.TenNhom).ToList();
                return lstNhomSanPham;
            }
            catch
            {
                return new List<NhomSanPham>();
            }
        }
        #endregion

        #region 2.Chi Tiết
        public NhomSanPham ChiTiet(int id)
        {
            try
            {
                return db.NhomSanPhams.Find(id);
            }
            catch
            {
                return new NhomSanPham();
            }
        }
        #endregion

        #region 3.Thêm mới
        // sau khi thêm trả về id
        public int ThemMoi(NhomSanPham newModel)
        {
            try
            {
                db.NhomSanPhams.Add(newModel);
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
        public bool CapNhat(NhomSanPham upModel)
        {
            try
            {
                var nhomSanPham = db.NhomSanPhams.Find(upModel.ID);
                nhomSanPham.TenNhom = upModel.TenNhom;
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
                var nhomSanPham = db.NhomSanPhams.Find(id);
                db.NhomSanPhams.Remove(nhomSanPham);
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