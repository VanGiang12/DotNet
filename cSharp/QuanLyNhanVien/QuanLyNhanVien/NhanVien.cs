using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    public class NhanVien
    {
        public const long LUONG_CO_BAN = 10000000;
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public string ChucVu { get; set; }

        public string Phong { get; set; }
        
        public void NhapNhanVien()
        {
            
            Console.WriteLine("Mã nhân viên: ");
            MaNhanVien = (Console.ReadLine());
            Console.WriteLine("Tên nhân viên: ");
            TenNhanVien = Console.ReadLine();
            Console.WriteLine("Ngày sinh: ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Phong Ban: ");
            Phong = Console.ReadLine();
            Console.WriteLine("Chức vụ: ");
            ChucVu = Console.ReadLine();

        }
        
        public override string ToString()
        {
            return this.MaNhanVien + "\t" + this.TenNhanVien + "\t" + NgaySinh.ToString("dd/MM/yyyy") +"\t"+this.ChucVu+ "\t" + this.TinhLuong();
        }
        public long TinhLuong()
        {
            if (ChucVu.ToLower() == "giam doc")
                return (long)(LUONG_CO_BAN + LUONG_CO_BAN * 0.25);
            if (ChucVu.ToLower() == "truong phong")
                return (long)(LUONG_CO_BAN + LUONG_CO_BAN * 0.15);
            if (ChucVu.ToLower() == "pho phong")
                return (long)(LUONG_CO_BAN + LUONG_CO_BAN * 0.05);
            return LUONG_CO_BAN;
        }
    }
}
