using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTienBanSach
{
    public class KhachHang
    {
        const double Gia = 20000;
        public string Ten { get; set; }
        public int SoLuong { get; set; }
        public bool LaSinhVien { get; set; }
        public double TinhTien
        {
            get
            {
                if (LaSinhVien == true)
                    return SoLuong * Gia * 0.95;
                else
                    return SoLuong * Gia;
            }
        }
    }
}
