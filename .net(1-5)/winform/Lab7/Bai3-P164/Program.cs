using System;
using System.Reflection.PortableExecutable;

namespace Bai3_P164
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream nguon = new FileStream(@"D:\myfile\array.dat", FileMode.Open);
            FileStream dich = new FileStream(@"D:\myfile\binary.dat", FileMode.Open);
            try
            {
                nguon.CopyTo(dich);
                Console.WriteLine("Copy thành công");
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message +" không sao chép được");
            }
            BinaryReader rd=new BinaryReader(dich);
            while (rd.BaseStream.Position != rd.BaseStream.Length)
            {
                int intValue = rd.ReadInt32();
                /*double doubleValue = rd.ReadDouble();
                bool boolValue = rd.ReadBoolean();
                string stringValue = rd.ReadString();*/
                //Console.WriteLine($"Int: {intValue}, Double: {doubleValue}, Boolean: {boolValue}, String: {stringValue}");
                Console.WriteLine($"Int: {intValue}");
            }
            rd.Close();
        }
    }
}