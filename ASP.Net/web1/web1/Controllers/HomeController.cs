using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web1.Helper;
using web1.Models;

namespace web1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        #region
        /*
        public ActionResult Index()
        {
            
            // 1. truyền = viewbag (nên biud)
            // ViewBag.A = new MathHelp().sum(2,3);

            //2. truyền vào view

            //--truyền số
            //return View(10);

            //--truyền 1 đối tượng
            /*var sv = new SinhVien();
            sv.ID = 1;
            sv.TenSV = "Giang";
            sv.Lop = "12";
            return View(sv);*/

        //truyền 1 list obj
        /*List<SinhVien> dsSV = new List<SinhVien>();
        var sv1 = new SinhVien();
        sv1.ID = 1;
        sv1.TenSV = "Giang";
        sv1.Lop = "12";
        dsSV.Add(sv1);

        var sv2 = new SinhVien();
        sv2.ID = 2;
        sv2.TenSV = "Hoang";
        sv2.Lop = "12";
        dsSV.Add(sv2);

        return View(dsSV);*/

        /* var ds5may = new MayTinh().Tao5May;
         return View(ds5may);

        return View(DanhSachMT.listMT);
    }

    public ActionResult Lay2May() {
        var ds2may = new MayTinh().Tao5May.OrderBy(m => m.DonGia).Take(2).ToList();
        return View(ds2may);
    }

    public ActionResult SapXepGiamDan() {
        var ds5may = new MayTinh().Tao5May.OrderBy(m => m.DonGia).Reverse();
        return View(ds5may);
    }

    public ActionResult TimKiemHangHP() {
        var ds5may = new MayTinh().Tao5May.Where(m => m.HangSanXuat=="HP").ToList();
        return View(ds5may);
    }

    public ActionResult ThemMoiMT()
    {
        return View();
    }

    [HttpPost] // bảo mật hơn và cả 2 bên phải có ms kết nối đc
    //or [HttpGet] mặc định là get
    //truyền từ view về controller
    public ActionResult LuuThongTinMT(string maMay, string dongMay, double donGia, DateTime ngaySanXuat, string hangSanXuat)
    {
        DanhSachMT.listMT.Add(new MayTinh()
        {
            MaMay = maMay,
            DongMay = dongMay,
            DonGia = donGia,
            HangSanXuat = hangSanXuat,
            NgaySanXuat = ngaySanXuat
        });
        return RedirectToAction("Index");
    }

    public ActionResult ThemMoiMT2()
    {
        return View(new MayTinh());
    }

    [HttpPost]
    public ActionResult LuuThongTinMT2(MayTinh model)
    {
        /*DanhSachMT.listMT.Add(new MayTinh()
        {
            MaMay = model.MaMay,
            DongMay = model.DongMay,
            DonGia = model.DonGia,
            HangSanXuat = model.HangSanXuat,
            NgaySanXuat = model.NgaySanXuat
        });
        DanhSachMT.listMT.Add(model);
        return RedirectToAction("Index");
    }
}
*/
        #endregion

    }
}