using btvn_Tuan4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace btvn_Tuan4.Controllers
{
    public class NhanVienController : Controller
    {
        public static List<NhanVien> lstnv = new List<NhanVien>
        {
            new NhanVien{Manhanvien=1,Hoten="a",Hesoluong=1,Luong=11000000,Gioitinh=true,Ngaysinh=DateTime.Parse("03/12/2003"),Dienthoai="09896859403",Tenphong="A"},
            new NhanVien{Manhanvien=2,Hoten="b",Hesoluong=2,Luong=12000000,Gioitinh=false,Ngaysinh=DateTime.Parse("04/22/2003"),Dienthoai="09896859403",Tenphong="B"},
            new NhanVien{Manhanvien=3,Hoten="c",Hesoluong=3,Luong=13000000,Gioitinh=true,Ngaysinh=DateTime.Parse("05/02/2003"),Dienthoai="09896859403",Tenphong="C"},
            new NhanVien{Manhanvien=4,Hoten="d",Hesoluong=4,Luong=14000000, Gioitinh=false,Ngaysinh=DateTime.Parse("06/10/2003"),Dienthoai="09896859403",Tenphong="D"},
        };
        // GET: NhanVien
        public ActionResult Index()
        {
            return View(lstnv);
        }
        [HttpPost]
        public ActionResult Index(string gioitinh, string tinhluong)
        {
            List<NhanVien> nv = lstnv;
            if (!string.IsNullOrWhiteSpace(gioitinh))
            {
                bool gt;
                if ("Nam".Equals(gioitinh, StringComparison.OrdinalIgnoreCase))
                {
                    gt = true;
                }
                else gt = false;
                nv = lstnv.Where(m => m.Gioitinh == gt).ToList();
            }
            if (!string.IsNullOrWhiteSpace(tinhluong))
            {
                nv = lstnv.Where(m => m.Tenphong.ToLower().Contains(tinhluong.ToLower())).ToList();
                double sum = nv.Sum(m => m.Hesoluong * m.Luong);
                ViewBag.sum = sum;
            }
            return View(nv);
        }

        // GET: NhanVien/Details/5
        public ActionResult Details(int id)
        {
            NhanVien nv = lstnv.FirstOrDefault(m => m.Manhanvien == id);
            if (nv == null)
            {
                HttpNotFound();
            }
            return View(nv);
        }

        // GET: NhanVien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanVien/Create
        [HttpPost]
        public ActionResult Create(NhanVien nv)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    lstnv.Add(nv);
                    return RedirectToAction("Index");
                }

                return View(nv);
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Edit/5
        public ActionResult Edit(int id)
        {
            NhanVien nv = lstnv.FirstOrDefault(m => m.Manhanvien == id);
            if (nv == null)
            {
                HttpNotFound();
            }
            return View(nv);
        }

        // POST: NhanVien/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, NhanVien NV)
        {
            try
            {
                // TODO: Add update logic here
                NhanVien nv = lstnv.FirstOrDefault(m => m.Manhanvien == id);
                nv.Hoten = NV.Hoten;
                nv.Gioitinh = NV.Gioitinh;
                nv.Ngaysinh = NV.Ngaysinh;
                nv.Tenphong = NV.Tenphong;
                nv.Dienthoai = NV.Dienthoai;
                nv.Hesoluong = NV.Hesoluong;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Delete/5
        public ActionResult Delete(int id)
        {
            NhanVien nv = lstnv.FirstOrDefault(m => m.Manhanvien == id);
            if (nv == null)
            {
                HttpNotFound();
            }
            return View(nv);
        }

        // POST: NhanVien/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                NhanVien nv = lstnv.FirstOrDefault(m => m.Manhanvien == id);
                lstnv.Remove(nv);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
