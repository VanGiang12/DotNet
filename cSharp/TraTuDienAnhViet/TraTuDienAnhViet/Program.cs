using System.Text;

namespace Anhviet
{
    class program
    {
        static Dictionary<string, string> dic = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                menu();
                Console.WriteLine("Có muốn tiếp tục sử dụng?(c/k)");
                string s = Console.ReadLine();
                if (s == "k")
                    break;
            }
        }
        private static void menu()
        {
            Console.WriteLine("1.Tạo từ mới");
            Console.WriteLine("2.Sửa từ ");
            Console.WriteLine("3.Tra cứu từ ");
            Console.WriteLine("4.Xóa từ ");
            Console.Write("\nNhập lựa chọn: ");
            try
            {
                int lc = int.Parse(Console.ReadLine());
                switch (lc)
                {
                    case 1:
                        TaoTu();
                        break;
                    case 2:
                        SuaTu();
                        break;
                    case 3:
                        TraCuu();
                        break;
                    case 4:
                        XoaTu();
                        break;
                    default:
                        Console.WriteLine("\nNhập sai lựa chọn!");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("\nLỗi gì đó " + ex.Message);
            }
        }

        private static void XoaTu()
        {
            Console.WriteLine("Nhập từ muốn xóa:");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                dic.Remove(ta);
                Console.WriteLine("Xóa thành công từ {0}", ta);
            }
            else
            {
                Console.WriteLine("Không tồn tại từ này!");
            }
        }

        private static void TraCuu()
        {
            Console.Write("\n Nhập từ cần tra cứu: ");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                string tv = dic[ta];
                Console.WriteLine("\n{0} : {1}", ta, tv);
            }
            else
            {
                Console.WriteLine("\nTừ điển chưa cập nhật!");
            }
        }

        private static void SuaTu()
        {
            Console.Write("\nNhập từ tiếng anh để sửa nghĩa: ");
                string ta = Console.ReadLine();
            if (dic.ContainsKey(ta) == false)
            {
                Console.WriteLine("\nKhong tìm thấy từ!");
            }
            else
            {
                Console.Write("\nNhập lại nghĩa tiếng việt: ");
                string tv = Console.ReadLine();
                dic[ta] = tv;
            }
        }

        private static void TaoTu()
        {
            Console.Write("\n Nhập vào 1 từ tiếng anh: ");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                Console.WriteLine("\nTừ đã tồn tại trong từ điển!");
            }
            else
            {
                Console.Write("\nNHập nghĩa tiếng việt: ");
                string tv = Console.ReadLine();
                dic.Add(ta, tv);
            }
        }
    }
}
