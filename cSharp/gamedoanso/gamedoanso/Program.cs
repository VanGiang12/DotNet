using System;

namespace Doanso
{
    class Program
    {
        static void Choi()
        {
            Random rd = new Random();
            int soCuaMay = rd.Next(11);
            int soCuaNguoi;
            int soLanchoi = 1;
            Console.Write("\nMay da ra 1 so [1...10], ban co 3 lan doan, moi ban doan!! ");
            while (true)
            {
                Console.WriteLine("\nLan thu {0}:", soLanchoi);
                soCuaNguoi = int.Parse(Console.ReadLine());
                
                if (soCuaNguoi == soCuaMay)
                {
                    Console.WriteLine("\nYou win!!");
                    break;
                }
                if (soCuaNguoi < soCuaMay)
                {
                    Console.WriteLine("\nSo ban doan < so cua May!!");
                }
                else
                {
                    Console.WriteLine("\nSo ban doan > so cua May!!");
                }
                soLanchoi++;
                if (soLanchoi == 4)
                {
                    Console.WriteLine("\nGame over!!");
                    Console.WriteLine("\nSo cua may la: {0}", soCuaMay);
                    break;
                }
            }
        }
        static void Main(string[] agrs)
        {
            while (true)
            {
                Choi();
                Console.WriteLine("\nBan co muon choi tiep khong?(y/n):");
                string s = Console.ReadLine();
                if (s == "n") break;
            }
            
        }
    }
    
}
