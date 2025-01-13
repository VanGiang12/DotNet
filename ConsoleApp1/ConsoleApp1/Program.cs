using ConsoleApp1;
using System;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Nhap(Student[] arr, int n)
        {
            for(int i = 0; i < n; i++)
            {
                arr[i] = new Student();
                Console.WriteLine("Nhập sv thứ {0}:",(i+1));
                arr[i].input();
            }
        }
        static void Xuat(Student[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i].display();
            }
        }
        static void Nhap1(HanhKhach[] arr, int n)
        {
            for(int i=0; i < n; i++)
            {
                Console.WriteLine("Nhập thông tin hành khách thứ {0}",(i+1));
                arr[i]=new HanhKhach();
                arr[i].Nhap();
            }    
        }
        static void Xuat1(HanhKhach[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i].Xuat();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            /*Console.Write("Nhập số lượng sv: ");
            int n = int.Parse(Console.ReadLine());
            Student[] arr = new Student[n];
            Nhap(arr, n);
            Console.WriteLine("Danh sách sv ");
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-30}", "Mã","Tên","Tuổi","Quê Quán");
            Xuat(arr, n);*/

            Console.Write("Nhập số lượng hành khách: ");
            int n=int.Parse(Console.ReadLine());
            HanhKhach[] arr=new HanhKhach[n];

            Nhap1(arr, n); 
            Console.WriteLine("Danh sách hành khách ");
            Console.WriteLine("{0,-15}{1,-10}{2,-10}{3,-15}{4,-20}{5,-18}", "Tên", "Giới tính", "Tuổi", "Tên chuyến bay", "Ngày bay", "Giá vé");
            Xuat1(arr, n);
        }
    }
}