using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Model
{
    internal class DatSach
    {
        private String maSach;
        private String maPhieuMua;
        private String tenSach;
        private String tacGia;
        private String theLoai;
        private int soLuong;
        private float donGia;
        private float thanhTien;

        public DatSach() { }
        public DatSach(string maSach, string maPhieuMua, string tenSach, string tacGia, string theLoai, int soLuong, float donGia, float thanhTien)
        {
            this.maSach = maSach;
            this.maPhieuMua = maPhieuMua;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.theLoai = theLoai;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }

        public string MaSach { get => maSach; set => maSach = value; }
        public string MaPhieuMua { get => maPhieuMua; set => maPhieuMua = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
