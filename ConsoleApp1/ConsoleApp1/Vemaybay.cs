using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vemaybay
    {
        string tenchuyen;
        DateTime ngaybay;
        double giave;

        public Vemaybay()
        {

        }

        public Vemaybay(string tenchuyen, DateTime ngaybay, double giave)
        {
            this.tenchuyen = tenchuyen;
            this.ngaybay = ngaybay;
            this.giave = giave;
        }
        ~Vemaybay() { }

        public string Tenchuyen { get => tenchuyen; set => tenchuyen = value; }
        public DateTime Ngaybay { get => ngaybay; set => ngaybay = value; }

        public void Nhap()
        {
            Console.Write("Nhập tên chuyến: ");
            tenchuyen = Console.ReadLine();
            Console.Write("Nhập ngày bay(dd/MM/yyyy): ");
            ngaybay = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null).Date;
            Console.Write("Nhập giá vé: ");
            giave = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("{0,-15}{1,-20}{2,-18}",tenchuyen,ngaybay.ToString("dd/MM/yyyy"),giave);
        }
        public double getgiave()
        {
            return giave;
        }
    }
}
