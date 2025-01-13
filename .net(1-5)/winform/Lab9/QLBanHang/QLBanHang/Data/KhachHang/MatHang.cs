using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Data.KhachHang
{
    internal class MatHang
    {
        string mamh;
        string tenmh;
        string donvitinh;

        public MatHang() { }
        public MatHang(string mamh, string tenmh, string donvitinh)
        {
            this.mamh = mamh;
            this.tenmh = tenmh;
            this.donvitinh = donvitinh;
        }

        public string Mamh { get => mamh; set => mamh = value; }
        public string Tenmh { get => tenmh; set => tenmh = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
    }
}
