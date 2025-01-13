// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace Bai24
{
    class CHinhChuNhat
    {
        private int ma, mb, mc;

        public int Ma { get => ma; set => ma = value; }
        public int Mb { get => mb; set => mb = value; }
        public int Mc { get => mc; set => mc = value; }

        public CHinhChuNhat()
        {
        }

        public CHinhChuNhat(int ma, int mb, int mc)
        {
            this.ma = ma;
            this.mb = mb;
            this.mc = mc;
        }

        public bool LaTamGiac()
        {
            if (ma + mb > mc && ma + mc > mb && mb + mc > ma) return true;
            return false;
        }

        public int ChuVi()
        {
            if (LaTamGiac())
                return ma + mb + mc;
            return 0;
        }
        public double DienTich()
        {
            double p = (double)(ma + mb + mc) / 2;
            if (!LaTamGiac())
                return 0;
            return  Math.Sqrt(p * (p - ma) * (p - mb) * (p - mc));
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CHinhChuNhat hcn = new CHinhChuNhat();
            Console.Write("A = ");
            hcn.Ma = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            hcn.Mb = int.Parse(Console.ReadLine());
            Console.Write("C = ");
            hcn.Mc = int.Parse(Console.ReadLine());

            if (hcn.LaTamGiac())
            {
                Console.WriteLine("Chu vi tam giác: " + hcn.ChuVi());
                Console.WriteLine("Diện tích tam giác: " + hcn.DienTich());
            }
            else { Console.WriteLine("3 cạnh không tạo thành tam giác"); }
        }
    }
}

