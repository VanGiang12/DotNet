using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TruyCapDL_CodeFirst.App_Start;
using TruyCapDL_CodeFirst.Models;

namespace TruyCapDL_CodeFirst
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // khởi tạo bảng k có dữ liệu
          
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ShopDataContext>());
            
            
            Database.SetInitializer(new MyDBInitializer());
        }
    }
}
