using System.Text;

namespace List
{
    class program
    {
        static void List1()
        {
            //cấp phát bộ nhớ để sử dụng đối tượng list
            List<string> ds = new List<string>();
            //thêm một phần tử vào ds
            ds.Add("an");
            ds.Add("bình");
            ds.Add("hạnh");
            ds.Add("phúc");
            //chèn một phần tử vào ds
            ds.Insert(2, "aaaaa");
            //xóa phần tử
            ds.Remove("an");
            ds.RemoveAt(3);

            for(int i=0; i<ds.Count; i++)
            {
                string v = ds[i];
                Console.WriteLine(v);
            }
        }
        static void List2()
        {
            List<int> ds = new List<int>();
            Random rd = new Random();
            Console.WriteLine("danh sách vừa nhập: ");
            for(int i=0; i <= 10; i++)
            {
                ds.Add(rd.Next(100));
                Console.Write(ds[i]+"\t");
            }
            Console.WriteLine("\nDanh sach sắp xếp: ");
            ds.Sort();
            foreach(int i in ds)
            {
                Console.Write(i+"\t");
            }

            Console.Write("\nNhập số cần tìm: ");
            int k = int.Parse(Console.ReadLine());
            int kq = ds.IndexOf(k);
            if (kq < 0)
                Console.WriteLine("\nKhông tìm thấy!!");
            else
                Console.WriteLine("\nSố {0} tìm thấy ở vị trí thứ {1}", k, kq);
            //xóa phần tử
            ds.RemoveAt(3);
            foreach (int i in ds)
            {
                Console.Write(i + "\t");
            }
            
            //xóa toàn bộ ds
            ds.Clear();
            
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //List1();
            List2();
        }
    }
}
