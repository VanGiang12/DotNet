using System;

namespace DaLuong
{
    public class Program
    {
        private static void A()
        {
            for (int i = 0; i < 10; i++)
                Console.Write(" A ");
        }
        private static void B()
        {
            for (int i = 0; i < 10; i++)
                Console.Write(" B ");
        }
        private static void D()
        {
            for (int i = 0; i < 10; i++)
                Console.Write(" D ");
        }
        private static void C(object n)
        {
            int t = (int)n;
            for (int i = 0; i < t; i++)
                Console.Write(" C ");
        }

        static void Main(string[] args)
        {
            Thread Luong1 = new Thread(A);
            Thread Luong2 = new Thread(B);
            Thread Luong3 = new Thread(C);
            Thread Luong4 = new Thread(D);
            Luong1.Start();
            Thread.Sleep(2000);
            Luong2.Start();
            Thread.Sleep(2000);
            Luong3.Start(10);
            Thread.Sleep(2000);
            Luong4.Start();

        }
    }
}