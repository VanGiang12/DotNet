using System.Text;

namespace SinhVien
{
    class sinhvien
    {
        private string ten, quequan;
        private int namsinh;
        private double dtk;
        public string Ten { get { return ten; } set { ten = value; } }
        public int NamSinh { get { return namsinh; } set { namsinh = value; } }
        public string QueQuan { get { return quequan; } set { quequan = value; } }
        public double DTK { get { return dtk; } set { dtk = value; } }
        public sinhvien()
        {
            this.ten = "";
            this.quequan = "";
            this.namsinh = 0;
            this.dtk = 0;
        }
        public sinhvien(string ten, string quequan, int namsinh, double dtk)
        {
            this.DTK = dtk;
            this.Ten = ten;
            this.QueQuan = quequan;
            this.NamSinh = namsinh;
        }
        ~sinhvien() { }

        public void Nhap()
        {
            Console.Write("Tên: ");
            this.Ten = Console.ReadLine();
            Console.Write("Quê quán: ");
            this.QueQuan = Console.ReadLine();
            Console.Write("Năm sinh: ");
            this.NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Điểm tk: ");
            this.DTK = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Tên: {0}", this.Ten);
            Console.WriteLine("Quê quán: {0}", this.QueQuan);
            Console.WriteLine("Năm sinh: {0}", this.NamSinh);
            Console.WriteLine("Điểm tk: {0}", this.dtk);
        }
    }

    class program
    {
        public static void Nhap(sinhvien[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh viên thứ {0}", i + 1);
                a[i] = new sinhvien();
                a[i].Nhap();
            }
        }
        public static void Xuat(sinhvien[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh viên thứ {0}", i + 1);
                a[i].Xuat();
            }
        }
        public static sinhvien TimKiem(sinhvien[] a, int n, string x)
        {
            sinhvien b = new sinhvien();
            for (int i = 0; i < n; i++)
            {
                if (x.CompareTo(a[i].Ten) == 0)
                {
                    b = a[i];
                }
            }
            return b;
        }
        public static void Sua(sinhvien[] a, int n)
        {
            Console.Write("Nhập tên sinh viên cần sửa: ");
            string ten_can_tim = Console.ReadLine();
            sinhvien ket_qua = TimKiem(a, n, ten_can_tim);
            Console.Write("Muốn sửa gì: QueQuan/NamSinh/ĐTK? 1/2/3: ");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.Write("Nhập quê quán mới: ");
                ket_qua.QueQuan = Console.ReadLine();
            }
            else if (x == 2)
            {
                Console.Write("Nhập năm sinh mới: ");
                ket_qua.NamSinh = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Nhập ĐTK mới: ");
                ket_qua.DTK = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (ket_qua.Ten.CompareTo(a[i].Ten) == 0)
                {
                    a[i] = ket_qua;
                }
            }
        }
        public static void Xoa(sinhvien[] a, ref int n)
        {
            Console.Write("Nhâp tên sinh viên muốn xóa: ");
            string xoa_ten = Console.ReadLine();
            sinhvien ket_qua = TimKiem(a, n, xoa_ten);
            for (int i = 0; i < n; i++)
            {
                if (a[i].Ten.CompareTo(ket_qua.Ten) == 0)
                    n--;
                    a[i] = a[i + 1];
            }
        }
        public static sinhvien TimKiem1(sinhvien[] a, int n, string x)
        {
            sinhvien b = new sinhvien();
            for (int i = 0; i < n; i++)
            {
                if (x.CompareTo(a[i].QueQuan) == 0)
                {
                    b = a[i];
                }
            }
            return b;
        }
        public static void DTKMax(sinhvien[] a, int n)
        {
            double max = a[0].DTK;
            sinhvien x = new sinhvien();
            for(int i=1;i <n; i++)
            {
                if (max < a[i].DTK)
                {
                    max = a[i].DTK;
                    x = a[i];
                }
            }
            Console.WriteLine("Sinh viên có điểm lớn nhất: ");
            x.Xuat();
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Số lượng SV: ");
            int n = int.Parse(Console.ReadLine());
            sinhvien[] a = new sinhvien[n];
            Nhap(a, n);
            /*Console.WriteLine("------Danh sách sinh viên--------");
            Xuat(a, n);
            Console.WriteLine("-------Sửa thông tin------");
            Sua(a, n);
            Console.WriteLine("-------Sau khi sửa-------");
            Xuat(a, n);
            Console.WriteLine("-------Xóa thông tin------");
            Xoa(a,ref n);
            Console.WriteLine("-------Sau khi xóa--------");
            Xuat(a, n);
            Console.WriteLine("-------Sinh viên quê Nam Định--------");
            TimKiem1(a, n, "Nam Định").Xuat();*/
            DTKMax(a, n);
        }
    }
}