﻿using System.Web;
using System.Web.Mvc;

namespace Authentication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //Làm như này thì tất cả controller bắt buộc phải login mà không cần [Authurize]
            //filters.Add(new System.Web.Mvc.AuthorizeAttribute());


            filters.Add(new HandleErrorAttribute());
        }
    }
}
