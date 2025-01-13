using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web1.Areas.Admin.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult KhongCoQuyen()
        {
            return View();
        }
    }
}