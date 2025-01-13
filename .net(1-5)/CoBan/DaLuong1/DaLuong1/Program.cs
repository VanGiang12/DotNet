using System;
using System.Text;

namespace thread
{
    internal class Program
    {
        static int result;
        static void A()
        {
            Random random = new Random();
            result = random.Next(1, 21);
            Console.Write(result + "\t");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread t1 = new Thread(A);
            t1.Start();
            /*while (true)
            {
                Thread.Sleep(2000);
                if (!t1.IsAlive) //kiểm tra xem luồng cũ kết thúc chưa
                {
                    t1 = new Thread(A);
                    t1.Start();
                }
            }*/
            t1.Join();//chờ đợi luồng kết thúc
            Console.WriteLine("Bình phương của {0} là: {1}",result,(result*result));
        }
    }
}