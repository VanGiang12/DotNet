using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuanLyBanHang.Models;

namespace QuanLyBanHang.App_Start
{
    public static class SessionConfig
    {
        public static void SetUser(NhanVien user)
        {
            HttpContext.Current.Session["user"] = user;
        }
        public static NhanVien GetUser()
        {
            return (NhanVien)HttpContext.Current.Session["user"];
        }
    }
}