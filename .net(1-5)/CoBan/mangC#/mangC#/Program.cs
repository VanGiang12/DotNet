using System;
using System.Text;

namespace Mang
{
    class program
    {
        /// <summary>
        /// Tạo một mảng có n phần tử sau đó:
        /// 1.Nhập mảng ngẫu nhiên
        /// 2.xuất
        /// 3.đảo mảng
        /// 4.sắp xếp
        /// 5.tính tổng các phần tử
        /// 6.tìm kiếm phần tử
        /// </summary>
        static void Mang1chieu()
        {
            Console.Write("Nhập số phần tử mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            //1.Nhập ngẫu nhiên mảng
            Random rd = new Random();
            for(int i=0; i<a.Length; i++)
            {
                a[i] = rd.Next(100);
            }
            //2.xuất giá trị mảng
            Console.WriteLine("Mảng vừa nhập: ");
            for(int i=0; i<a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            //3.đảo mảng
            Array.Reverse(a);
            Console.WriteLine("\nMảng sau khi đảo: ");
            foreach(int i in a)
            {
                Console.Write(i + " ");
            }
            //4.Sắp xếp mảng
            Array.Sort(a);// sắp xếp giảm dần
            //Array.Reverse(a);//đảo lại thành tăng dần
            Console.WriteLine("\nMảng sau khi sắp xếp: ");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            //5.tính tổng
            int sum = 0;
            foreach(int i in a)
            {
                sum += i;
            }
            Console.WriteLine("\nTổng mảng là: {0}", sum);
            //6.Tìm kiếm theo hàm(đã sắp xếp)
            Console.Write("\nNhập số cần tìm: ");
            int k = int.Parse(Console.ReadLine());
            int kq = Array.BinarySearch(a, k);  // phải sắp xếp rồi mới đc dùng binarysearch và trả về <0 khi không tìm thấy
            if (kq <0)
            {
                Console.WriteLine("\nKhông tìm thấy!!");
            }
            else
            {
                Console.WriteLine("\nTìm thấy {0} tại vị trí thứ {1}.", k, kq);
            }
            //7.tìm kiếm tuyến tính(không quan tâm sắp xếp hay chưa)
            Console.Write("\nNhập số cần tìm mới: ");
            k = int.Parse(Console.ReadLine());
            kq = -1;
            for(int i=0; i<n; i++)
            {
                if (a[i] == k)
                {
                    kq = i;
                    break;
                }
            }
            if (kq <0)
            {
                Console.WriteLine("\nKhông tìm thấy!!");
            }
            else
            {
                Console.WriteLine("\nTìm thấy {0} tại vị trí thứ {1}.", k, kq);
            }
        }
        static void Mang2chieu()
        {
            Console.Write("Nhập số hàng: ");
            int hang = int.Parse(Console.ReadLine());
            Console.Write("NHập sô cột: ");
            int cot = int.Parse(Console.ReadLine());
            int[,] a = new int[hang, cot];
            Random rd = new Random();
            for(int i=0; i<a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    a[i, j] = rd.Next(100);
                }
            }
            Console.WriteLine("\nMảng vừa nhập: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]+ "\t");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Mang1chieu();
            Mang2chieu();
        }
    }
}