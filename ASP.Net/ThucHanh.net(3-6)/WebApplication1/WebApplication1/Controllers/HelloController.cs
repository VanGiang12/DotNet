using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public string Index()
        {
            return "tôi là action index";
        }
        public string Welcome(string name, int id = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", id: " + id);
        }
        public string GiaiPTBac2(int a, int b, int c)
        {
            string kq = $"Phương trình: {a}x^2+{b}x+{c}=0<br/>";
            int delta = b * b - 4 * a * c;
            kq+=$"delta={delta}<br/>";
            if (delta < 0)
            {
                kq += " Phương trình vô nghiệm<br/>";
            }else if (delta == 0)
            {
                int x =-b/2*a;
                kq += $" Phương trình nghiệm kép: {x}<br/>";
            }
            else
            {
                double x1= Math.Round((-b+Math.Sqrt(delta))/(2*a),2);
                double x2= Math.Round((-b-Math.Sqrt(delta))/(2*a),2);
                kq += $" Phương trình có 2 nghiệm phân biệt: x1={x1}, x2={x2}<br/>";
            }
            return kq;
        }
    }
}