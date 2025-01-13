using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web1.Models;
using web1.App_Start;

namespace web1.Areas.Admin.Controllers
{
    public class NhanVienController : Controller
    {
        BanHang_TestEntities1 db = new BanHang_TestEntities1();

        [AdminAuthorize(idChucNang =1)]
        public ActionResult Index()
        {
            List<NhanVien> lstNhanVien = db.NhanViens.ToList();
            return View(lstNhanVien);
        }
        
        #region Thêm
        [AdminAuthorize(idChucNang =2)]
        public ActionResult ThemMoi()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult ThemMoi(NhanVien model)
        {
            db.NhanViens.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion
        
        [AdminAuthorize(idChucNang = 3)]
        public ActionResult CapNhat()
        {
            
            return View();
        }
        
        [AdminAuthorize(idChucNang = 4)]
        public ActionResult Xoa()
        {
            
            return View();
        }
    }
}