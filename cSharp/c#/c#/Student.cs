using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethua
{
    internal class Student:Nguoi
    {
        public int toan { get; set; }
        public int ly { get; set; }
        public int hoa { get; set; }
        public Student() { }
        public Student(string ma, string ten, int toan, int ly, int hoa) : base(ma, ten)
        {
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
        }
        public void nhap1()
        {
            base.nhap();
            Console.Write("\nToán: ");
            toan = int.Parse(Console.ReadLine());
            Console.Write("\nLý: ");
            ly = int.Parse(Console.ReadLine());
            Console.Write("\nHóa: ");
            hoa = int.Parse(Console.ReadLine());
        }
        public void xuat1()
        {
            base.xuat();
            Console.WriteLine("\nToán: " + toan);
            Console.WriteLine("\nLý: " + ly);
            Console.WriteLine("\nHóa: " + hoa);
            Console.WriteLine("\nDTB: " + dtb());
        }
        public int dtb()
        {
            return toan + ly + hoa;
        }
    }
}
