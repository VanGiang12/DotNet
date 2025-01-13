using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDonBanXe
{
    public class KhachHang
    {
        
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string Phone { get; set; }
        public double GiaTien { get; set; }
        public double PhuThu { get; set; }
        public double Thue { get; set; }
        public bool MuaXeDen { get; set; }
        public bool MuaXeMauKhac { get; set; }
        public double ThanhTien
        {
            get
            {
                return GiaTien + PhuThu*GiaTien + Thue*GiaTien;
            }
        }
    }
}
