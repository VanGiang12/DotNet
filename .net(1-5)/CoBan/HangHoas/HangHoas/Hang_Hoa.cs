using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangHoas
{
    public class Hang_Hoa
    {
        private string maDon, tenDon;
        private long donGia;
        public Hang_Hoa()
        {
            maDon = "";
            tenDon = "";
            donGia = 0;
        }
        public Hang_Hoa(string maDon, string tenDon, long donGia)
        {
            this.maDon = maDon;
            this.tenDon = tenDon;
            this.donGia = donGia;
        }

        ~Hang_Hoa() { }

        public string MaDon { get => maDon; set => maDon = value; }
        
        public string TenDon { get => tenDon; set => tenDon = value; }
        public long DonGia { get => donGia; set => donGia = value; }

        public virtual void Nhap()
        {
            Console.Write("Mã đơn: ");
            this.maDon = Console.ReadLine();
            Console.Write("Tên đơn: ");
            this.tenDon = Console.ReadLine();
            Console.Write("Đơn giá: ");
            this.donGia = long.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.Write("Mã đơn: {0},Ten đơn: {1},Dơn giá: {2}", MaDon, TenDon, DonGia);
        }
    }
}
