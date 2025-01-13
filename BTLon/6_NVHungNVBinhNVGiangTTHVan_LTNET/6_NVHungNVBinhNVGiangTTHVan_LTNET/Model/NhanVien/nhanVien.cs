using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.NhanVien
{
    internal class nhanVien
    {
        private string manhanvien;
        private string? tennhanvien;
        private DateTime? ngaysinh;
        private string? sdt;
        private string? matkhau;
        private int? loainguoidung;

        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string? Tennhanvien { get => tennhanvien; set => tennhanvien = value; }
        public DateTime? Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string? Sdt { get => sdt; set => sdt = value; }
        public string? Matkhau { get => matkhau; set => matkhau = value; }
        public int? Loainguoidung { get => loainguoidung; set => loainguoidung = value; }

        public nhanVien()
        {
        }

        public nhanVien(string manhanvien, string? tennhanvien, DateTime? ngaysinh, string? sdt, string? matkhau, int? loainguoidung)
        {
            this.manhanvien = manhanvien;
            this.tennhanvien = tennhanvien;
            this.ngaysinh = ngaysinh;
            this.sdt = sdt;
            this.matkhau = matkhau;
            this.loainguoidung = loainguoidung;
        }
    }
}
