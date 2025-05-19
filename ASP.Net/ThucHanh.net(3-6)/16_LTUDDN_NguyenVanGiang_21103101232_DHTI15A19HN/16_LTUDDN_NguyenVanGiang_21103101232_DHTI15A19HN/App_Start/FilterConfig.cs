using System.Web;
using System.Web.Mvc;

namespace _16_LTUDDN_NguyenVanGiang_21103101232_DHTI15A19HN
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
