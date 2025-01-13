using System;
using System.Text;

namespace Bai1_DocGhiFileNhiPhan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.InputEncoding=Encoding.UTF8;
            BinaryWriter bw;
            BinaryReader br;
            int i = 13;
            double d = 2.56317;
            bool b = true;
            string s = "Hello World !!";
            try
            {
                bw = new BinaryWriter(new FileStream(@"D:\myfile\binary.dat", FileMode.Create));
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message + " Không thể tạo file ");
                return;
            }
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message + " không thể ghi file ");
                return;
            }
            bw.Close();

            Console.WriteLine("Đọc file nhị phân");
            try
            {
                br = new BinaryReader(new FileStream(@"D:\myfile\binary.dat", FileMode.Open));
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message + " không thể mở file ");
                return;
            }
            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Interger: {0}", i);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean: {0}", b);
                d = br.ReadDouble();
                Console.WriteLine("Double: {0}", d);
                s = br.ReadString();
                Console.WriteLine("String: {0}", s);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message + " không thể đọc ");
                return;
            }
            br.Close();
        }
    }
}
