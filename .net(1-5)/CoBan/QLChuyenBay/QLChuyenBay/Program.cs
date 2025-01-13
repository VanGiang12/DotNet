using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Vemaybay
{
    public string tenchuyen { get; set; }
    public DateTime ngaybay { get; set; }
    public double giave { get; set; }

    public Vemaybay(string ten, DateTime ngay, double gia)
    {
        tenchuyen = ten;
        ngaybay = ngay;
        giave = gia;
    }

    public double getgiave()
    {
        return giave;
    }
}

class Nguoi
{
    public string hoten { get; set; }
    public string gioitinh { get; set; }
    public int tuoi { get; set; }

    public Nguoi(string ten, string gt, int age)
    {
        hoten = ten;
        gioitinh = gt;
        tuoi = age;
    }
}

class Hanhkhach : Nguoi
{
    public Vemaybay[] ve;
    public int soluong;

    public Hanhkhach(string ten, string gt, int age, Vemaybay[] v, int sl) : base(ten, gt, age)
    {
        ve = v;
        soluong = sl;
    }

    public double tongtien()
    {
        double total = 0;
        foreach (Vemaybay v in ve)
        {
            total += v.getgiave();
        }
        return total;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding=Encoding.UTF8;
        Console.InputEncoding=Encoding.UTF8;
        Console.Write("Nhập số lượng hành khách: ");
        int n = int.Parse(Console.ReadLine());

        List<Hanhkhach> danhSach = new List<Hanhkhach>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin cho hành khách thứ {i + 1}:");
            Console.Write("Họ và tên: ");
            string ten = Console.ReadLine();
            Console.Write("Giới tính: ");
            string gt = Console.ReadLine();
            Console.Write("Tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Số lượng vé: ");
            int sl = int.Parse(Console.ReadLine());

            Vemaybay[] ve = new Vemaybay[sl];
            for (int j = 0; j < sl; j++)
            {
                Console.WriteLine($"Nhập thông tin cho vé thứ {j + 1}:");
                Console.Write("Tên chuyến: ");
                string tenchuyen = Console.ReadLine();
                Console.Write("Ngày bay (yyyy-MM-dd): ");
                DateTime ngaybay = DateTime.Parse(Console.ReadLine());
                Console.Write("Giá vé: ");
                double giave = double.Parse(Console.ReadLine());

                ve[j] = new Vemaybay(tenchuyen, ngaybay, giave);
            }

            danhSach.Add(new Hanhkhach(ten, gt, tuoi, ve, sl));
        }

        // Hiển thị danh sách hành khách và số tiền phải trả
        Console.WriteLine("\nDanh sách hành khách và số tiền phải trả:");
        foreach (Hanhkhach hk in danhSach.OrderByDescending(x => x.tongtien()))
        {
            Console.WriteLine($"Họ tên: {hk.hoten}, Tổng tiền: {hk.tongtien()}");
        }
    }
}

