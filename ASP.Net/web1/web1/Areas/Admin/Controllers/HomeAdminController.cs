using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using web1.Models;

namespace web1.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        public ActionResult Index()
        {
            //kiểm tra nếu chưa có đăng nhập thì k cho vào trang index
            if (Session["user"] == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string user, string password)
        {
            #region kiểm tra bằng db
            BanHang_TestEntities1 db = new BanHang_TestEntities1();
            // tìm bằng đếm số lượng
            int count = db.NhanViens.Count(m => m.Username.ToLower() == user && m.Password == password);
            //tìm bằng đối tượng
            var nhanvien = db.NhanViens.SingleOrDefault(m => m.Username.ToLower() == user && m.Password == password);

            //if (count==1)
            if (nhanvien != null)
            {
                //lưu lại phiên làm việc(biến là user value là admin) trong 1 khoảng thời gian
                /*Session["user"] = user;
                ViewBag.user = user;*/
                Session["user"] = nhanvien;
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Tài khoản hoặc mật khẩu không đúng";
                return View();
            }
            #endregion

            #region kiểm tra bằng code
            /*if (user == "Admin" && password == "12345")
            {
                //lưu lại phiên làm việc(biến là user value là admin) trong 1 khoảng thời gian
                Session["user"] = "Admin";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Tài khoản hoặc mật khẩu không đúng";
                return View();
            }*/
            #endregion
        }

        public ActionResult Logout()
        {
            //xóa session thông tin về người dùng hiện tại sẽ bị xóa khỏi phiên,
            //và ứng dụng sẽ không còn nhận ra người dùng này nữa.
            Session.Remove("user");
            // dùng để đăng xuất người dùng khỏi hệ thống xác thực Forms.
            // Điều này sẽ xóa cookie xác thực, nếu có, từ trình duyệt của người dùng.
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");

        }
    }
}