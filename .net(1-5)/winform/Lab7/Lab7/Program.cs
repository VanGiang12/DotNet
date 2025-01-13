using System;
using System.Text;

namespace Bai1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Chương trình ghi file trong c#");
            Console.WriteLine("------------------------------");
            string path = @"C:\myfile\test.txt";

            StreamWriter myFile = File.AppendText(path);//nếu có file r thì viết tiếp bên dưới, chưa có thì tạo mới
            string line;
            do
            {
                Console.WriteLine("Nhập một câu text");
                line=Console.ReadLine();
                if(line!="")
                    myFile.WriteLine(line);

            } while (line!="");
            myFile.Close();

            //đọc file
            StreamReader myread=File.OpenText(path);

            String content=myread.ReadToEnd();
            Console.WriteLine("Nội dụng file");
            Console.WriteLine(content);
            myread.Close();
        }
    }
}
