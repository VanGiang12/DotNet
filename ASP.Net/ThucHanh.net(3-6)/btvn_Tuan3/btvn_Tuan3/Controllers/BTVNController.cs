using btvn_Tuan3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace btvn_Tuan3.Controllers
{
    public class BTVNController : Controller
    {
        // GET: BTVN
        public ActionResult Bai1()
        {
            return View();
        }

        #region bài 2
        public ActionResult TimSoHoanHao()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TimSoHoanHao(int n)
        {
            string msg = "Số hoàn hảo là: ";
            for (int i = 1; i < n; i++)
            {
                if (ktrhh(i))
                    msg += i + " ";
            }
            ViewBag.msg = msg;
            return View();
        }

        public bool ktrhh(int a)
        {
            int sum = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                    sum += i;
            }
            if (sum == a)
                return true;
            return false;
        }
        #endregion

        #region bài 3
        public ActionResult TimSoChinhPhuong()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TimSoChinhPhuong(string s)
        {
            string msg = "Số chính phương là: ";
            int[] num = s.Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < num.Length; i++)
            {
                if (ktracp(num[i]))
                {
                    msg += num[i] + " ";
                }
            }
            ViewBag.msg = msg;
            return View();
        }

        public bool ktracp(int a)
        {
            int sqrt = Convert.ToInt32(Math.Sqrt(a));
            if (sqrt * sqrt == a)
                return true;
            return false;
        }
        #endregion

        #region bài 4
        public ActionResult GiaiPT2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GiaiPT2(PTB2 pt2)
        {
            float a = pt2.a;
            float b = pt2.b;
            float c = pt2.c;
            string msg = "";
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0) msg = "Phương trình vô số nghiệm";
                    else msg = "Phương trình vô nghiệm";
                }
                else msg = $"Phương trình có nghiệm là: {(-c / b).ToString("F2")}";
            }
            else
            {
                float delta = b * b - 4 * a * c;
                if (delta < 0) msg = "Phương trình vô nghiệm";
                else if (delta == 0) msg = $"Phương trình có nghiệm kép x1 = x2 = {(-b / (2 * a)).ToString("F2")}";
                else msg = $"Phương trình có 2 nghiệm phân biệt x1 = {(-b + Math.Sqrt(delta) / (2 * a)).ToString("F2")} " +
                        $"x2 = {(-b - Math.Sqrt(delta) / (2 * a)).ToString("F2")}";
            }
            ViewBag.msg = msg;
            return View();
        }
        #endregion

        public ActionResult Truyen1SV()
        {
            var sv = new SinhVien
            {
                Msv = 1,
                GioiTinh = true,
                Lop="DHTI15A19HN",
                Name="A",
                NgaySinh=DateTime.Parse("03/12/2003"),
                QueQuan="HY"
            };
            return View(sv);
        }
        public ActionResult TruyenNhieuSV()
        {
            var sv = new List<SinhVien>
            {
                new SinhVien {
                Msv = 1,
                GioiTinh = true,
                Lop = "DHTI15A19HN",
                Name = "A",
                NgaySinh = DateTime.ParseExact("03/12/2003","dd/MM/yyyy",null),
                QueQuan = "HY"
                },
                new SinhVien {
                Msv = 2,
                GioiTinh = false,
                Lop = "DHTI15A19HN",
                Name = "B",
                NgaySinh = DateTime.ParseExact("13/10/2003","dd/MM/yyyy",null),
                QueQuan = "HN"
                }
            };
            return View(sv);
        }
    }
}