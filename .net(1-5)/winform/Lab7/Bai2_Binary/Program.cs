using System;

namespace Bai2_Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n = ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ",i);
                a[i] = int.Parse(Console.ReadLine());
            }
            BinaryWriter bw = new BinaryWriter(new FileStream(@"D:\myfile\array.dat", FileMode.Create));
            for(int i=0; i < n; i++)
            {
                bw.Write(a[i]);
            }
            bw.Close();

            BinaryReader br = new BinaryReader(new FileStream(@"D:\myfile\array.dat", FileMode.Open));
            while (br.BaseStream.Position != br.BaseStream.Length)
            {
                Console.WriteLine(br.ReadInt32());
            }
            br.Close();
        }
    }
}