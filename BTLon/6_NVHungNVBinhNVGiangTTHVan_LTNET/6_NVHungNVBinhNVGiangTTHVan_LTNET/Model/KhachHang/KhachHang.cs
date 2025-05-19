using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.KhachHang
{
    internal class KhachHang
    {
        private string makh;
        private string tenkh;
        private string cmnd;
        private string diachi;
        private string sdt;

        public KhachHang(string makh, string tenkh, string cmnd, string diachi, string sdt)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.cmnd = cmnd;
            this.diachi = diachi;
            this.sdt = sdt;
        }

        public string Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
