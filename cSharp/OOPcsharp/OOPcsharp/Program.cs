using OOPcsharp;
using System.Text;

namespace OOPcshap
{
    class program
    {
        static void TestAliasvaGomRac()
        {
            KhachHang teo = new KhachHang() { Ma = 1, Ten = "Tèo", Phone = "12314155" };
            KhachHang ty = new KhachHang() { Ma = 2, Ten = "Tý", Phone = "02342552" };
            teo = ty;   // vùng nhớ của tèo trỏ tới vùng nhớ của tý
            Console.WriteLine("Tên của Tèo là {0} ", teo.Ten);
            //Như vậy lúc này ô nhớ mà tèo trỏ tới trước lúc gán teo=ty đã bị thu hồi
            //và lúc này ô nhớ mà tý đang trỏ có thêm tèo trỏ vào nữa
            //nên tèo hoặc tý thay đổi thì cx làm cho ô nhớ tèo và tý thay đổi
            teo.Ten = "abc";
            Console.WriteLine("Tên của Tý là {0} ", ty.Ten);

            KhachHang an = new KhachHang() { Ma = 3, Ten = "An", Phone = "543659365" };
            KhachHang binh = an.copy();
            //lúc này theo memberwiseclone thì nó sao chép toàn bộ thông tin của an
            //ra một ô nhớ hoàn toàn độc lập do bình quản lý
            //->an và bình quản lý 2 ô nhớ hoàn toàn khác nhau và dộc lập 
            //nên khi một trong hai thay đổi thì không ảnh hưởng gì tới bên còn lại
            binh.Ten = "Bình";
            Console.WriteLine("Tên của An là {0} ", an.Ten);
            Console.WriteLine("Tên của Bình là {0} ", binh.Ten);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*SinhVien teo = new SinhVien();
            teo.Ten = "Nguyễn Văn Tèo";
            teo.Ma = 1;
            Console.WriteLine(teo);

            SinhVien ty = new SinhVien(113, "Tèo thị Tý");

            Console.WriteLine(ty);*/
            TestAliasvaGomRac();
        }
    }
}
