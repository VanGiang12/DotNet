using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDonBanXe
{
    public class DanSachKhachHang
    {
        public List<KhachHang> dsKH = new List<KhachHang>();
        public List<KhachHang> Khachs
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
        public int TongSoSoKH
        {
            get
            {
                return dsKH.Count;
            }
        }
        public int TongSoKHMuaXeDen
        {
            get
            {
                int dem = 0;
                foreach(KhachHang i in dsKH)
                {
                    if (i.MuaXeDen == true)
                        dem++;
                }
                return dem;
            }
        }
        public double TongDoanhThu
        {
            get
            {
                double sum = 0;
                foreach (KhachHang i in dsKH)
                    sum += i.ThanhTien;
                return sum;
            }
        }
    }
}
