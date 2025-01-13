using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HanhKhach : Nguoi
    {
        Vemaybay[] ve;
        int soluong;

        public HanhKhach(string name, string gender, int age, Vemaybay[] ve, int soluong) : base(name, gender, age)
        {
            this.ve = ve;
            this.soluong = soluong; ;
        }
        public HanhKhach() { }
        ~HanhKhach() { }

        public void Nhap()
        {
            
            base.Nhap();
            Console.Write("Nhập số lượng vé: ");
            soluong = int.Parse(Console.ReadLine());

            ve = new Vemaybay[soluong];

            for (int i = 0; i < soluong; i++)
            {
                Console.WriteLine("Nhập thông tin vé thứ {0}", (i + 1));
                ve[i] = new Vemaybay();
                ve[i].Nhap();
            }
        }
        public void Xuat()
        {
            double sum = 0;
            for (int i = 0; i < soluong; i++)
            {
                base.Xuat();
                ve[i].Xuat();
                sum += ve[i].getgiave();
            }
            Console.WriteLine("Tổng tiền của hành khách {0} phải trả là: {1}VNĐ",Name,sum);
        }
    }
}
