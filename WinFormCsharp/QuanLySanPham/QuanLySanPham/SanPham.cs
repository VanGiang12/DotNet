using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSp { get; set; }
        public double DonGia { get; set; }
        public DateTime HSD { get; set; }
        public string XuatXu { get; set; }
        public DanhMuc Nhom { get; set; }
        public override string ToString()
        {
            return this.TenSp;
        }
    }
}
