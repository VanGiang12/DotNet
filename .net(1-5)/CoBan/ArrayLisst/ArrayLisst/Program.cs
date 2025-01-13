using System;
using System.Collections;
using System.Text;

namespace arraylist
{
    class SinhVien
    {
        string ma, hoten, diachi, lophoc;
        int namsinh;

        public SinhVien()
        {
            this.ma = "";
            this.hoten = "";
            this.diachi = "";
            this.lophoc = "";
            this.namsinh = 0;
        }

        public SinhVien(string ma, string hoten, string diachi, string lophoc, int namsinh)
        {
            this.ma = ma;
            this.hoten = hoten;
            this.diachi = diachi;
            this.lophoc = lophoc;
            this.namsinh = namsinh;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Lophoc { get => lophoc; set => lophoc = value; }
        public int Namsinh { get => namsinh; set => namsinh = value; }

        public SinhVien Nhap()
        {
            Console.Write("Mã sinh viên: ");
            this.ma = Console.ReadLine();
            Console.Write("Tên sinh viên: ");
            this.hoten = Console.ReadLine();
            Console.Write("Địa chỉ: ");
            this.diachi = Console.ReadLine();
            Console.Write("Lớp học:");
            this.lophoc = Console.ReadLine();
            Console.Write("Năm sinh: ");
            this.namsinh = int.Parse(Console.ReadLine());
            return this;
        }
        public void Xuat()
        {
            Console.WriteLine("Mã sinh viên: {0}", this.ma);
            Console.WriteLine("Tên sinh viên: {0}", this.hoten);
            Console.WriteLine("Địa chỉ sinh viên: {0}", this.diachi);
            Console.WriteLine("Lớp sinh viên: {0}", this.lophoc);
            Console.WriteLine("Năm sinh: {0}", this.namsinh);
        }
    }
    public class Program
    {
        static SinhVien TimKiem(ArrayList x, string s)
        {
            SinhVien a = new SinhVien();
            for (int i = 0; i < x.Count; i++)
            {
                SinhVien b = x[i] as SinhVien;
                if (b.Ma == s)
                {
                    a = b; break;
                }

            }
            return a;
        }

        static void Sua(ArrayList sv, string x, int i)
        {
            SinhVien a;
            a = TimKiem(sv, x);
            if (i == 1)
            {
                Console.Write("Nhập tên mới: ");
                a.Hoten = Console.ReadLine();
                for (int j = 0; j < sv.Count; j++)
                {
                    if (a.Ma == (sv[j] as SinhVien).Ma)
                        (sv[j] as SinhVien).Hoten = a.Hoten;
                    break;
                }
            }
            if (i == 2)
            {
                Console.Write("Nhập địa chỉ mới: ");
                a.Diachi = Console.ReadLine();
                for (int j = 0; j < sv.Count; j++)
                {
                    if (a.Ma == (sv[j] as SinhVien).Ma)
                        (sv[j] as SinhVien).Diachi = a.Diachi;
                    break;
                }
            }
            if (i == 3)
            {
                Console.Write("Nhập lớp mới: ");
                a.Lophoc = Console.ReadLine();
                for (int j = 0; j < sv.Count; j++)
                {
                    if (a.Ma == (sv[j] as SinhVien).Ma)
                        (sv[j] as SinhVien).Lophoc = a.Lophoc;
                    break;
                }
            }
            if (i == 4)
            {
                Console.Write("Nhập năm sinh mới: ");
                a.Namsinh = int.Parse(Console.ReadLine());
                for (int j = 0; j < sv.Count; j++)
                {
                    if (a.Ma == (sv[j] as SinhVien).Ma)
                        (sv[j] as SinhVien).Namsinh = a.Namsinh;
                    break;
                }
            }

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            ArrayList sv = new ArrayList();
            int n;
            do
            {
                Console.Write("Thêm/Sửa/Xóa/Thoát - 1/2/3/0:");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            sv.Add(new SinhVien().Nhap());
                        }
                        break;

                    case 2:
                        {
                            Console.Write("Mã sinh viên muốn sửa: ");
                            string x = Console.ReadLine();
                            int i;
                            do
                            {
                                Console.Write("Tên/Địa chỉ/Lớp học/Năm sinh/Thoát - 1/2/3/4/0: ");
                                i = int.Parse(Console.ReadLine());
                                switch (i)
                                {
                                    case 0: break;
                                    case 1:
                                        {
                                            Sua(sv, x, 1);   
                                        }
                                        break;
                                    case 2:
                                        {
                                            Sua(sv, x, 2);
                                        }
                                        break;
                                    case 3:
                                        {
                                            Sua(sv, x, 3);
                                        }
                                        break;
                                    case 4:
                                        {
                                            Sua(sv, x, 4);
                                        }
                                        break;
                                }
                            } while (i != 0);

                        }
                        break;

                    case 3:
                        {
                            Console.Write("Mã sinh viên muốn xóa: ");
                            string x = Console.ReadLine();
                            SinhVien s;
                            for (int i = 0; i < sv.Count; i++)
                            {
                                s = sv[i] as SinhVien;
                                if (s.Ma == x)
                                {
                                    sv.RemoveAt(i);
                                }

                            }
                        }
                        break;

                    case 0: break;
                }
            } while (n != 0);

            foreach(SinhVien i in sv)
            {
                i.Xuat();
            }
            Console.WriteLine("Số lượng sinh viên: {0}",sv.Count);
        }
    }
}