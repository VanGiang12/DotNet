/*
 * Kiểu distionary dùng để lưu trữ dữ liệu dạng key và value.
 * Các phần tử dictionary có Key là duy nhất(không tồn tại 2 phần gtuwr nào có cùng key)
 * Dictionary dựa vào key để xác định value tương ứng
 * nằm trong thư viện system.Collection.generic
 */
using System.Text;

namespace Dictionary
{
    class program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<int, string> dic = new Dictionary<int, string>();    //key là kiêủ int, value là kiểu string
            if (dic.ContainsKey(1) == false)    //kiểm tra xem khóa 1 đã xuất hiện chưa nếu chưa mới add(tránh trùng lặp)
                dic.Add(1, "Nguyen Văn A");
            if (dic.ContainsKey(2) == false)    
                dic.Add(2, "Nguyen Văn B");
            if (dic.ContainsKey(3) == false)
                dic.Add(3, "Nguyen Văn C");
            if (dic.ContainsKey(3) == false)    //Do key=3 tồn tại rồi nên không đưa vô ds được
                dic.Add(3, "Nguyen Văn D");

            //Duyệt toàn bộ dữ liệu trong dictionary
            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine("Mã = " + item.Key + ";"+"Tên = "+item.Value);
            }

            dic.Remove(2);
            Console.WriteLine("\nSau khi xóa: ");
            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine("Mã = " + item.Key + ";" + "Tên = " + item.Value);
            }

            string value = dic[3];
            Console.WriteLine("\nĐối tượng có key = 3 là :" + value);

            List<string> dsvalue = dic.Values.ToList();  // chuyển dictionary về list và chỉ lấy value
            Console.WriteLine("\nDanh sách value sau khi chuyển: ");
            foreach(string v in dsvalue)
            {
                Console.WriteLine(v);
            }

            List<int> dskey = dic.Keys.ToList();  // chuyển dictionary về list và chỉ lấy key
            Console.WriteLine("\nDanh sách key sau khi chuyển: ");
            foreach (int k in dskey)
            {
                Console.WriteLine(k);
            }
        }
    }
}
