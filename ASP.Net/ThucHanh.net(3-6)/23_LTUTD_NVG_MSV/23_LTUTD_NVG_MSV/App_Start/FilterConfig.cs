﻿using System.Web;
using System.Web.Mvc;

namespace _23_LTUTD_NVG_MSV
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
