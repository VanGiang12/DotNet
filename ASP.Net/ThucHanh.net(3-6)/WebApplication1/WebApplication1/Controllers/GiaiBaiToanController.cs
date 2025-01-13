using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GiaiBaiToanController : Controller
    {
        // GET: GiaiBaiToan
        public ActionResult TimUCLN()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TimUCLN(int a, int b)
        {
            string msg = $"UCLN của {a} và {b} là: ";
            while (a != b)
            {
                if (a > b) a = a - b; else b = b - a;
            }
            msg += $"{a}";
            ViewBag.msg = msg;
            //return Content(msg);
            return View();
        }

        public ActionResult TruyenDoiTuong()
        {
            var user = new Users
            {
                Id = 1,
                Name = "Giang",
                Address = "HY",
                Email = "g@gmail.com",
                Password = "123",
                Gender = true
            };
            //ViewBag.user = user;
            return View(user);
        }

        public ActionResult TruyenTapDoiTuong()
        {
            var users = new List<Users>()
            {
                new Users
                {
                    Id = 1,
                    Name = "Giang",
                    Address = "HY",
                    Email = "g@gmail.com",
                    Password = "123",
                    Gender = true
                } ,
                new Users
                {
                    Id = 2,
                    Name = "Giang2",
                    Address = "HY",
                    Email = "g@gmail.com",
                    Password = "123",
                    Gender = false
                } ,
                new Users
                {
                    Id = 3,
                    Name = "Giang3",
                    Address = "HY",
                    Email = "g@gmail.com",
                    Password = "123",
                    Gender = true
                }
            };
            //ViewBag.user = users;
            return View(users);
        }
        public ActionResult NhanDL(Users u)
        {
            string msg = $"{u.Id} <br/>{u.Name} " +
                $" <br/>{u.Address}  <br/>{u.Email} " +
                $" <br/>{u.Password}  <br/>{u.Gender} \n";
            return Content(msg);
        }
    }
}