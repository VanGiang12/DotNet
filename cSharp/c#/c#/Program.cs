using System;
using System.Text;

namespace Kethua
{
    class programe
    {
        static void Nhap(Student[] a, int n)
        {
            for(int i=0; i<n; i++)
            {
                a[i] = new Student();
                Console.WriteLine("\nNhập người thứ " + (i + 1) + " : ");
                a[i].nhap1();
            }
        }
        static void Xuat(Student[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNgười thứ " + (i + 1) + " : ");
                a[i].xuat1();
            }
        }
        static void Main(String[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("\nNhập số lượng: ");
            int n = int.Parse(Console.ReadLine());
            Student[] a = new Student[n];
            Nhap(a, n);
            Xuat(a, n);
        }
    }
}


