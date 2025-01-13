using System;
using System.Text;

namespace Chuoi
{
    class program
    {
        //Nhập vào một chuỗi:
        //1.Xem có bao nhiêu ký tự in hoa, thường, số
        //2.Đếm số khoảng trắng trong chuỗi
        static void Xulychuoi1()
        {
            string s = "";
            Console.WriteLine("Mời bạn nhập vào một chuỗi: ");
            s = Console.ReadLine();
            int demHoa = 0, demThuong = 0, demSo = 0, demKT = 0;
            char[] arr = s.ToCharArray();
            for(int i=0; i<arr.Length; i++)
            {
                if (char.IsDigit(arr[i]))
                    demSo++;
                if (char.IsLower(arr[i]))
                    demThuong++;
                if (char.IsUpper(arr[i]))
                    demHoa++;
                if (char.IsWhiteSpace(arr[i]))
                    demKT++;
            }
            Console.WriteLine("Có {0} ký tự đếm thường.", demThuong);
            Console.WriteLine("Có {0} ký tự đếm hoa.", demHoa);
            Console.WriteLine("Có {0} ký tự đếm số.", demSo);
            Console.WriteLine("Có {0} ký tự đếm khoảng trắng.", demKT);
        }
            static void Xulychuoi2()
            {
                string s = "";
                Console.WriteLine("Mời bạn nhập vào một chuỗi: ");
                s = Console.ReadLine();
                int demHoa = 0, demThuong = 0, demSo = 0, demKT = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    char kt = s[i];
                    if (char.IsDigit(kt))
                        demSo++;
                    if (char.IsLower(kt))
                        demThuong++;
                    if (char.IsUpper(kt))
                        demHoa++;
                    if (char.IsWhiteSpace(kt))
                        demKT++;
                }
                Console.WriteLine("Có {0} ký tự đếm thường.", demThuong);
                Console.WriteLine("Có {0} ký tự đếm hoa.", demHoa);
                Console.WriteLine("Có {0} ký tự đếm số.", demSo);
                Console.WriteLine("Có {0} ký tự đếm khoảng trắng.", demKT);
            }
        static void Xulychuoi3()
        {
            Console.WriteLine("Nhập chuỗi 1: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Nhập chuỗi 2: ");
            string s2 = Console.ReadLine();
            //So sánh cả in hoa và thường
            //int kq = s1.CompareTo(s2);
            //Đưa về 1 dạng(hoa/thường) r so sánh
            int kq = s1.ToLower().CompareTo(s2.ToLower());
            if (kq == 0)
            {
                Console.WriteLine("S1=S2");
            }
            else if (kq < 0)
            {
                Console.WriteLine("S1<S2");
            }
            else
            {
                Console.WriteLine("S1>S2");
            }
        }
        static void Xulychuoi4()
        {
            string s;
            // hoặc khởi tạo: Datetime date=new Datetime()
            //Today is monday, feburary 2, 2011
            s = string.Format("Today is {0:D}", DateTime.Now);
            Console.WriteLine(s);

            s = string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            Console.WriteLine(s);

            int n = 14;
            //Giá trị của n=14.00, căn bậc 2 = 3.74
            s = string.Format("Giá trị n={0:N}, căn bậc 2 là: {1:N}", n, Math.Sqrt(n));
            Console.WriteLine(s);

            //Giá thành sản phẩm: $200.00
            s = string.Format("Giá thành sản phẩm ={0:C}", 200);
            Console.WriteLine(s);
        }
        static void Xulychuoi5()
        {
            String s = "D:/baihat/nhactre/noinaycoanh.mp3";
            //Tìm ký tự / đầu tiên trong chuỗi
            int vt;
            vt = s.IndexOf("/");
            Console.WriteLine("Vị tri đầu tiên ký tự / la {0}", vt);

            //Tìm ký tự / cuối cùng trong chuỗi
            vt = s.LastIndexOf("/");
            Console.WriteLine("Vị tri cuối cùng ký tự / la {0}", vt);

            // Kiểm tra chuỗi true false
            bool b;
            b = s.Equals("abc");
            Console.WriteLine("Chuỗi s và chuỗi value là {0}",b);

            //Chèn chuỗi tại vị trí bất kỳ
            string c = "abc";
            s = "hello";
            //chèn c tại vị trí thứ 5
            s = s.Insert(5, c);
            Console.WriteLine("Sau khi chèn: {0}", s);


        }
        static void Xulychuoi6()
        {
            String s = "D:/baihat/nhactre/noinaycoanh.mp3";
            int vt1 = s.LastIndexOf("/");
            string tenbh = s.Substring(vt1 + 1);
            Console.WriteLine(tenbh);
            int vt2 = tenbh.LastIndexOf(".");
            string tenBH = tenbh.Substring(0, vt2);
            Console.WriteLine(tenBH);
        }
        static void Xulychuoi7()
        {
            string s = "m123;Nguyen Van A;ha noi";
            string[] arr = s.Split(";");
            Console.WriteLine("Ma la: {0}", arr[0]);
            Console.WriteLine("Ten la: {0}", arr[1]);
            Console.WriteLine("Dia chi la: {0}", arr[2]);
        }
        static void Toiuuchuoi()
        {
            Console.WriteLine("Mời bạn nhập chuỗi: ");
            string s = Console.ReadLine();

            string[] arr = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //StringSplitOptions.RemoveEmptyEntries: khi tách thì phần tử nào đó trong mản rỗng thì bỏ qua
            s = " ";
            for(int i=0; i<arr.Length; i++)
            {
                //lấy từng phần tử ra
                string word = arr[i];
                word = word.ToLower();
                char[] arrword = word.ToCharArray();
                arrword[0] = char.ToUpper(arrword[0]);
                string newword = new string(arrword);
                s += newword + " ";
            }
            s = s.Trim(); //Xóa dư thừa trái phải
            Console.WriteLine("Chuỗi sau khi tối ưu:{0}",s);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //--Đếm ký tự
            //Cách 1
            //Xulychuoi1();
            // Cách 2
            //Xulychuoi2();
            //--So sánh chuỗi
            //Xulychuoi3();
            //Xulychuoi4();
            //Xulychuoi5();
            //Xulychuoi6();
            //Xulychuoi7();
            Toiuuchuoi();
        }
    }
}
