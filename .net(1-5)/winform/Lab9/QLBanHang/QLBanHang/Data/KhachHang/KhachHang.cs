using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Data.KhachHang
{
    public class KhachHang
    {
        private string makh, hoten, diachi, gioitinh, dienthoai;

        public KhachHang()
        {
            this.makh ="";
            this.hoten = "";
            this.diachi = "";
            this.gioitinh = "";
            this.dienthoai = "";
        }
        public KhachHang(string makh, string hoten, string diachi, string gioitinh, string dienthoai)
        {
            this.makh = makh;
            this.hoten = hoten;
            this.diachi = diachi;
            this.gioitinh = gioitinh;
            this.dienthoai = dienthoai;
        }

        public string Makh { get => makh; set => makh = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
    }
}
