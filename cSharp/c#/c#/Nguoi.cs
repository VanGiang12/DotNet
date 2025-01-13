using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethua
{
    internal class Nguoi
    {
        public string ma { get; set; }
        public string ten { get; set; }
        public Nguoi() { }
        public Nguoi(string ma, string ten)
        {
            this.ma = ma;
            this.ten = ten;
        }

        public void nhap()
        {
            Console.Write("\nNhập mã: ");
            this.ma = Console.ReadLine();
            Console.Write("\nNhập tên: ");
            this.ten = Console.ReadLine();
        }
        public void xuat()
        {
            Console.WriteLine("\nMã: " + ma);
            Console.WriteLine("\nTên: " + ten);
        }
    }
}
