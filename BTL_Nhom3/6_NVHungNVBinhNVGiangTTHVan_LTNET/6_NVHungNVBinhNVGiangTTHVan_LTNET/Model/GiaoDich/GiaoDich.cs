using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.GiaoDich
{
    public class GiaoDich
    {
        public GiaoDich(string maSo, string maNV, string makh, string sDT, string maLoai, DateTime ngayMoSo, DateTime? ngayDenHan, int soTienGui, bool trangThaiSo)
        {
            MaSo = maSo;
            MaNV = maNV;
            MaKH = makh;
            SDT = sDT;
            MaLoaiSo = maLoai;
            
            NgayMoSo = ngayMoSo;
            NgayDenHan = ngayDenHan;
            SoTienGui = soTienGui;
            
            TrangThaiSo = trangThaiSo;
        }
        public GiaoDich() { }
        public string MaSo { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public string SDT { get; set; }
        public string MaLoaiSo { get; set; }
        public decimal LaiSuat { get; set; }
        public DateTime NgayMoSo { get; set; }
        public DateTime? NgayDenHan { get; set; }
        public int SoTienGui { get; set; }
        public DateTime NgayRut { get; set; }
        public bool TrangThaiSo { get; set; }

    }
}
