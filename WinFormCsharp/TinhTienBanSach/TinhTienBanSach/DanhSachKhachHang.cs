using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTienBanSach
{
    public class DanhSachKhachHang
    {
        List<KhachHang> dsKH = new List<KhachHang>();
        public List<KhachHang> KhachS
        {
                get
                {
                    return dsKH;
                }
        }
        public void Mua(KhachHang kh)
        {
            dsKH.Add(kh);
        }
        public int TongSoKH
        {
            get
            {
                return dsKH.Count;
            }
        }
        public int TongSoKHSV
        {
            get
            {
                int sosv = 0;
                foreach(KhachHang kh in dsKH)
                {
                    if (kh.LaSinhVien == true)
                        sosv++;
                }
                return sosv;
            }
        }
        public double TongDoanhDu
        {
            get
            {
                double sum = 0;
                foreach (KhachHang kh in dsKH)
                    sum += kh.TinhTien;
                return sum;
            }
        }
    }
}
