using btvn_Tuan4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace btvn_Tuan4.Controllers
{
    public class BTVNController : Controller
    {
        // GET: BTVN
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Logins lg)
        {
            if (lg != null)
            {
                Logins login = lg;
                if (login.Username.Equals("admin") && login.Password.Equals("admin"))
                {
                    //TempData["u"]=login.Username;
                    //return View("Home");
                    ViewBag.s = "Đăng nhập thành công! Xin chào: "+login.Username;
                    return View();
                }
                else
                {
                    ViewBag.e = "Sai tên đăng nhập hoặc mật khẩu";
                    return View();
                }
            }
            return View();
        }

        public ActionResult Home()
        {
            string u = TempData["u"] as string;
            ViewBag.u= u;
            return View();
        }
    }
}