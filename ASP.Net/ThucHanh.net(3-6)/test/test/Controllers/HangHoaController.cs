using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class HangHoaController : Controller
    {
        public static List<HangHoa> lstHangHoa = new List<HangHoa>
        {
            new HangHoa{Mahh=1,Tenhh="a",Dongia=1000,Loaihang="a1",Nsx=DateTime.Parse("03/12/2022"),Soluong=102},
            new HangHoa{Mahh=2,Tenhh="b",Dongia=2000,Loaihang="a2",Nsx=DateTime.Parse("02/12/2022"),Soluong=103},
            new HangHoa{Mahh=3,Tenhh="c",Dongia=3000,Loaihang="a3",Nsx=DateTime.Parse("01/12/2022"),Soluong=106}
        };
        // GET: HangHoa
        public ActionResult Index()
        {
            var lstLoaiHangHoa = lstHangHoa.Select(m => m.Loaihang).Distinct()
                .Select(m => new SelectListItem { Value = m, Text = m }).ToList();
            ViewBag.lhh = lstLoaiHangHoa;
            return View(lstHangHoa);
        }

        [HttpPost]
        public ActionResult Index(string dongia, string loaihang)
        {
            List<HangHoa> mat_hang = null;

            var lstLoaiHangHoa = lstHangHoa.Select(m => m.Loaihang).Distinct()
               .Select(m => new SelectListItem { Value = m, Text = m }).ToList();
            ViewBag.lhh = lstLoaiHangHoa;

            if (!string.IsNullOrWhiteSpace(dongia))
            {
                mat_hang = lstHangHoa.Where(m => m.Dongia <= int.Parse(dongia)).ToList();
            }
            else return View(lstHangHoa);
            if (!string.IsNullOrWhiteSpace(loaihang))
            {
                var sum = lstHangHoa.Where(m => m.Loaihang == loaihang).Sum(m => m.Thanhtien);
                ViewBag.sum = sum;
                ViewBag.lh = loaihang;
            }
            else return View(lstHangHoa);

            return View(mat_hang);
        }

        // GET: HangHoa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HangHoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HangHoa/Create
        [HttpPost]
        public ActionResult Create(HangHoa hh)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    lstHangHoa.Add(hh);
                    return RedirectToAction("Index");
                }
                return View(hh);
            }
            catch
            {
                return View();
            }
        }

        // GET: HangHoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HangHoa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HangHoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HangHoa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
