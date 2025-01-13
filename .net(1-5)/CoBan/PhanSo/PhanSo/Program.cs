using System;
using System.Text;

namespace PhanSo
{
    class phanso
    {
        private int tuso;
        private int mauso;
        public int TS { get { return tuso; } set { this.tuso = value; } }
        public int MS { get { return mauso; } set { this.mauso = value; } }
        public phanso()
        {
            this.tuso = 0;
            this.mauso = 1;
        }
        /*~phanso() { }*/
        public void nhap()
        {
            Console.Write("Tử = ");
            this.tuso = int.Parse(Console.ReadLine());
            Console.Write("Mẫu = ");
            this.mauso = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("{0}/{1}", TS, MS);
        }
        public phanso Cong(phanso x)
        {
            phanso p = new phanso();
            p.TS = this.TS * x.MS + this.MS * x.TS;
            p.MS = this.MS * x.MS;
            return p;
        }
        public phanso Tru(phanso x)
        {
            x.TS = this.TS * x.MS - this.MS * x.TS;
            x.MS = this.MS * x.MS;
            return x;
        }
        public phanso Nhan(phanso x)
        {
            x.TS = this.TS * x.TS;
            x.MS = this.MS * x.MS;
            return x;
        }
        public phanso Chia(phanso x)
        {
            x.TS = this.MS * x.TS;
            x.MS = this.TS * x.MS;
            return x;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            phanso x1 = new phanso();
            x1.nhap();
            phanso x2 = new phanso();
            x2.nhap();
            /*Console.Write("Tông 2 phân số: ");
            x1.Cong(x2).Xuat();
            
            Console.Write("Hiệu 2 phân số: ");
            x1.Tru(x2).Xuat();*/

            /*Console.Write("Tích 2 phân số: ");
            x1.Nhan(x2).Xuat();*/

            Console.Write("Thương 2 phân số: ");
            x2.Chia(x1).Xuat();
        }
    }
}
