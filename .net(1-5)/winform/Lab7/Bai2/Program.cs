using System;
using System.Text;

namespace Bai2
{
    public class program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Đếm số ký tự xuất hiện trong file");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Nhập kí tự muốn đếm");
            String letter = Console.ReadLine();
            int count = 0;
            StreamReader reader = File.OpenText(@"C:\myfile\test.txt");
            string line;
            do
            {
                line = reader.ReadLine();
                if (line != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line.Substring(i, 1).Equals(letter))
                        {
                            count++;
                        }
                    }
                }
            }while(line != null);
            reader.Close();
            Console.WriteLine("Kí tự {0} xuất hiện {1} lần!",letter,count);
        }
    }
}
