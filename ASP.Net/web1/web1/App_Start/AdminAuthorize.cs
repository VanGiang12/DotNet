using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using web1.Models;

namespace web1.App_Start
{
    public class AdminAuthorize : AuthorizeAttribute
    {
        public int idChucNang { get; set; }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            // Check session: đã đăng nhập cho thực hiện filter ,Ngược lại : quay lại trang đăng nhập
            NhanVien nvSession = (NhanVien)HttpContext.Current.Session["user"];
            if (nvSession != null)
            {
                // Check quyền: có quyền thì cho thực hiện filter, ngược lại: quay lại trang k có quyền
                BanHang_TestEntities1 db = new BanHang_TestEntities1();
                var count = db.PhanQuyens.Count(m => m.idNhanVien == nvSession.ID && m.idChucNang == idChucNang);
                if (count != 0)
                {
                    return;
                }
                else
                {
                    var returnUrl = filterContext.RequestContext.HttpContext.Request.RawUrl;
                    filterContext.Result = new RedirectToRouteResult(new
                        RouteValueDictionary(new
                        {
                            controller = "Error",
                            action = "KhongCoQuyen",
                            area = "Admin",
                            returnUrl = returnUrl.ToString()
                        }));
                }
                return;
            }
            else
            {
                var returnUrl = filterContext.RequestContext.HttpContext.Request.RawUrl;
                filterContext.Result = new RedirectToRouteResult(new
                    RouteValueDictionary(new
                    {
                        controller = "HomeAdmin",
                        action = "Login",
                        area = "Admin",
                        returnUrl = returnUrl.ToString()
                    }));
            }
        }
    }
}