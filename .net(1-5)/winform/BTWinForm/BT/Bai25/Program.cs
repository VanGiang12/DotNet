using System;
using System.Text;

namespace Bai24
{
    class CNhanVien
    {
        private string ho, ten;
        private int sosp;

        public CNhanVien() { }

        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Sosp { get => sosp; set => sosp = value; }

        public CNhanVien(string ho, string ten, int sosp)
        {
            this.ho = ho;
            this.ten = ten;
            this.sosp = sosp;
        }
        public void Nhap()
        {
            Console.Write("Họ: ");
            ho = Console.ReadLine();
            Console.Write("Tên: ");
            ten = Console.ReadLine();
            Console.Write("Số sản phẩm: ");
            sosp = int.Parse(Console.ReadLine());
        }
        public double TinhLuong()
        {
            if (sosp >= 0)
            {
                if (sosp >= 1 && sosp <= 199)
                    return sosp * 0.5;
                else if (sosp >= 200 && sosp <= 399)
                    return sosp * 0.55;
                else if (sosp >= 400 && sosp <= 599)
                    return sosp * 0.6;
                else return sosp * 0.65;
            }
            else
            {
                Console.WriteLine("Số sản phẩm không thể âm");
                sosp = 0;
                return 0;
            }
        }
        public bool LonHon(CNhanVien nv2)
        {
            if (this.sosp > nv2.sosp)
                return true;
            else return false;
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.InputEncoding= Encoding.UTF8;

            CNhanVien nv1=new CNhanVien();
            CNhanVien nv2=new CNhanVien();
            Console.WriteLine("\t\tNhập nv 1");
            nv1.Nhap();
            Console.WriteLine("\t\tNhập nv 2");
            nv2.Nhap();
            Console.WriteLine("\n\n");
            Console.WriteLine("Lương nv 1: "+nv1.TinhLuong());
            Console.WriteLine("Lương nv 2: "+nv2.TinhLuong());

            Console.WriteLine("\n\n");
            if (nv1.LonHon(nv2))
            {
                Console.WriteLine("Số sản phẩm nv1 > nv2 là: {0}",(nv1.Sosp-nv2.Sosp));
            }
            else
            {
                Console.WriteLine("Số sản phẩm nv2 > nv1 là: {0}", (nv2.Sosp - nv1.Sosp));
            }

            if(nv1.Sosp > nv2.Sosp)
            {
                Console.WriteLine("Số sản phẩm nv1 > nv2 là: {0}", (nv1.Sosp - nv2.Sosp));
            }
            else if(nv1.Sosp < nv2.Sosp)
            {
                Console.WriteLine("Số sản phẩm nv2 > nv1 là: {0}", (nv2.Sosp - nv1.Sosp));
            }
            else
            {
                Console.WriteLine("Số sản phẩm 2 nhân viên bằng nhau");
            }
        }
    }
}