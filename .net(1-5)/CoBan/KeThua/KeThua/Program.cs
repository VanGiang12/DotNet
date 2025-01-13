using System.Text;

namespace KeThua
{
    class program
    {
        static void TestNhanVien()
        {
            NhanVienChinhThuc teo = new NhanVienChinhThuc();
            teo.Ma = 1;
            teo.Ten = "Nguen van teo";
            teo.TinhLuong();


            NhanVienThoiVu ty = new NhanVienThoiVu();
            ty.Ma = 2;
            ty.Ten = "Nguyen van ty";
            ty.TinhLuong();


        }
        static void TestNhanvien2()
        {
            NhanVienChinhThuc teo = new NhanVienChinhThuc();
            int luong = teo.TinhLuong(20);
            Console.WriteLine("Lương Tèo: " + luong);
        } 

        //Ví dụ đa hình
        static void TestHinhHoc()
        {
            HinhHoc h;
            h = new HinhHoc();
            Console.WriteLine("Diện tích: " + h.TinhDienTich());
            h = new HInhTron();
            Console.WriteLine("Diện tích: " + h.TinhDienTich());
        }
        static void TestHinhChuNhatHinhVuong()
        {
            HinhChuNhat h = new HinhChuNhat(4, 10);
            Console.WriteLine("Chu vi: " + h.ChuVi());
            Console.WriteLine("Diện tích: " + h.DienTich());

            HinhChuNhat h2 = new HinhVuong(4);
            Console.WriteLine("Chu vi: " + h2.ChuVi());
            Console.WriteLine("Diện tích: " + h2.DienTich());
        }
        //Ví dụ interface
        static void TestInterface()
        {
            ILamViec teo = new NhanVien();
            Console.WriteLine(teo.LamViec("báo cáo"));

            ILamViec ty = new SinhVien();
            Console.WriteLine(ty.LamViec("bài tập"));
        }
        static void Hoc_As_va_Is()
        {
            /*
            ILamViec teo = new NhanVien();  //giống upcasting
            if(teo is NhanVien)
            {
                Console.WriteLine("Tèo là nhân viên");
                NhanVien x = teo as NhanVien;   //ép kiểu về nhân viên(giống dowcasting)
                
            }
            ILamViec ty = new SinhVien();
            */

            List<ILamViec> ds = new List<ILamViec>();
            NhanVien teo = new NhanVien() { Ma = 1, Ten = "teo" };
            ds.Add(teo);
            SinhVien ty = new SinhVien() { MaSv = "sv1", TenSv = "ty" };
            ds.Add(ty);
            ds.Add(new NhanVien() { Ma = 2, Ten = "Bin" });

            foreach(ILamViec i in ds)
            {
                if(i is NhanVien)
                {
                    NhanVien nv = i as NhanVien;
                    Console.WriteLine("Nhân viên " + nv.Ten);

                }
                else if(i is SinhVien)
                {
                    SinhVien sv = i as SinhVien;
                    Console.WriteLine("Sinh viên " + sv.TenSv);
                }
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //TestNhanVien();
            //TestNhanvien2();
            //TestHinhHoc();
            //TestHinhChuNhatHinhVuong();
            //TestInterface();
            Hoc_As_va_Is();
        }
    }
}