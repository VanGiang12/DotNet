using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web1.Models;

namespace web1.Controllers
{
    public class KhachHangController : Controller
    {

        /*public ActionResult Index()
        {
            //truyền = model
            return View(DanhSachKH.lstKH);
        }
        #region Thêm Mới
        public ActionResult ThemMoi()
        {
            return View(new KhachHang() { ID = 0 });
        }

        //do cùng tên nên cùng view
        [HttpPost]                                              
        public ActionResult ThemMoi(KhachHang model, HttpPostedFileBase fileAnh)//cùng nên với name
        {
            if (model.ID == 0)
            {
                ModelState.AddModelError("", "ID phải > 0"); // in ra tb
                return View(model); //quay lại view themmoi va truyền lại model
            }

            if (fileAnh.ContentLength > 0)
            {
                // Lưu file
                string rootFolder = Server.MapPath("/Data/");
                string pathImage = rootFolder + fileAnh.FileName;
                fileAnh.SaveAs(pathImage);

                // Lưu thuộc tính UrlHinhAnh
                model.UrlHinhanh = "/Data/" + fileAnh.FileName;
            }
            DanhSachKH.lstKH.Add(model);
            return RedirectToAction("Index");
        }

        #endregion

        #region Sửa
        public ActionResult CapNhat(int IDKH)
        {
            // Tìm đối tượng khách hàng cần sửa

            var khachhang = DanhSachKH.lstKH.SingleOrDefault(m => m.ID == IDKH);

            // Truyền thông tin đối tượng cần sửa sang bên view
            return View(khachhang);
        }

        [HttpPost]
        public ActionResult CapNhat(KhachHang model)
        {
            if (string.IsNullOrEmpty(model.TenKH))
            {
                ModelState.AddModelError("", "Bạn chưa nhập tên"); // in ra tb
                return View(model); //quay lại view themmoi va truyền lại model
            }

            //tìm đối tượng
            var khachhang = DanhSachKH.lstKH.SingleOrDefault(m => m.ID == model.ID);
            //cập nhật thông tin
            khachhang.TenKH = model.TenKH;
            khachhang.SDT= model.SDT;
            khachhang.DiaChi= model.DiaChi;
            khachhang.Email= model.Email;
            khachhang.GioiTinh = model.GioiTinh;
            khachhang.UrlHinhanh = model.UrlHinhanh;


            return RedirectToAction("Index");
        }
        #endregion

        #region Xóa
        public ActionResult Xoa(int IDKH)
        {
            // Tìm đối tượng khách hàng cần xóa

            var khachhang = DanhSachKH.lstKH.SingleOrDefault(m => m.ID == IDKH);

            DanhSachKH.lstKH.Remove(khachhang);
            return RedirectToAction("Index");
        }
        #endregion*/
        
        BanHang_TestEntities1 db = new BanHang_TestEntities1();


        //Lọc theo tên or sdt
        //Nếu k ghi gì sẽ hiện hết vì lúc nào cx có 1 chuỗi trống ""
        public ActionResult Index(string key,int? idloaiKH)
        {
            //List<KhachHang> lstKhachHang = db.KhachHangs.Where(m => m.TenKhachHang.ToLower().Contains(key.ToLower()) == true
            //                                                     || m.SoDienThoai.ToLower().Contains(key) == true).ToList();//chuyển về list
            //cách 2
            /*List<KhachHang> lstKhachHang = (from m in db.KhachHangs
                                            join loaiKH in db.LoaiKhachHangs on m.idLoaiKhachHang equals loaiKH.ID
                                            where (m.TenKhachHang.ToLower().Contains(key.ToLower()) == true
                                            || m.SoDienThoai.Contains(key) == true)
                                            & (loaiKH.ID==idloaiKH || idloaiKH==null )
                                            select m
                                           ).ToList();
*/
            //Cách 3: dùng  procedures
            List<spDanhSachKhachHang_Result> dsKH = db.spDanhSachKhachHang(key, idloaiKH).ToList();
            ViewBag.key = key;
            ViewBag.idloaiKH = idloaiKH;

            //return View(lstKhachHang);
            return View(dsKH);
        }

        #region Thêm
        public ActionResult ThemMoi() 
        { 
            return View();
        }

        [HttpPost]
        public ActionResult ThemMoi(KhachHang model)
        {
            db.KhachHangs.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        #region Sửa
        public ActionResult CapNhat(int id)
        {
            

            KhachHang model = db.KhachHangs.Find(id);
            //KhachHang model2 = db.KhachHangs.SingleOrDefault(m => m.ID == id); 1 trong 2 cách
            return View(model);
        }

        [HttpPost]
        public ActionResult CapNhat(KhachHang model)
        {
            var updatemodel = db.KhachHangs.Find(model.ID);
            //gán
            updatemodel.TenKhachHang = model.TenKhachHang;
            updatemodel.SoDienThoai = model.SoDienThoai;
            updatemodel.DiaChi = model.DiaChi;
            updatemodel.idLoaiKhachHang = model.idLoaiKhachHang;
            //lưu
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        #region Xóa
        public ActionResult Xoa(int id)
        {


            var model = db.KhachHangs.Find(id);
            //KhachHang model2 = db.KhachHangs.SingleOrDefault(m => m.ID == id); 1 trong 2 cách
            db.KhachHangs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        #region Xóa Nhóm
        public ActionResult XoaKhachHangTheoNhom(int idLoaiKhachHang)
        {
            // Xóa dữ liệu bảng con: Khách Hàng-Xóa luôn các khách hàng thuộc nhóm đó
            var danhsachKhachhangThuocNhom = db.KhachHangs.Where(m => m.idLoaiKhachHang == idLoaiKhachHang).ToList();
            db.KhachHangs.RemoveRange(danhsachKhachhangThuocNhom);
            db.SaveChanges();

            // Xóa sữ liệu bảng cha: Loại khách hàng
            var deleteLoaiKhachHang = db.LoaiKhachHangs.Find(idLoaiKhachHang);
            db.LoaiKhachHangs.Remove(deleteLoaiKhachHang);
            db.SaveChanges();

            return RedirectToAction("Index");

        }
        #endregion

    }
}