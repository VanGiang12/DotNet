using System;
using System.Text;
/// Công ty XYZ muốn viết phần mềm quản lý nhân viên mô tả hệ thống như sau
/// Mỗi nhân viên sẽ thuộc về một phòng ban thông tin của phòng ban bao gồm(mã phòng ban, teenn phòng ban, trưởng phòng hiện tại)
/// Thông tin của mỗi nhân viên(mã nhân viên, tên nhân viên, ngày sinh, chức vụ.
/// Chức vụ gồm có: giám đốc, trưởng phòng, phó phòng, nhân viên.
/// Lương cơ bản của toàn bộ nhân viên là 10M/tháng
/// Giám đốc phụ cấp chức vụ 25%, trưởng phòng 15%, phó phòng 5%, nhân viên không có.
/// Chương trình cung cấp các chức năng:
/// -Thêm, xuất, sửa, xóa, sắp xếp, tìm Phòng ban, tìm Nhân viên
/// -Thống kê tổng số lượng lương phải trả cho nhân viên trong 1 tháng
namespace QuanLyNhanVien
{
    class program
    {
        static List<PhongBan> dsPB = new List<PhongBan>();
        static List<NhanVien> dsNV = new List<NhanVien>();
        static void NhapThongTin()
        {
            Console.Write("\nNhập số lượng phòng ban: ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                PhongBan x = new PhongBan();
                x.NhapPhongBan();
                dsPB.Add(x);
                Console.Write("\nNhập số lượng nhân viên: ");
                int m = int.Parse(Console.ReadLine());
                for(int j = 0; j < m; j++)
                {
                    NhanVien y = new NhanVien();
                    y.NhapNhanVien();
                    dsNV.Add(y);
                }
            }
        }
        static void XuatThongTin()
        {
            Console.WriteLine("\n===============");
            foreach (PhongBan x in dsPB)
            {
                Console.WriteLine(x);
                Console.WriteLine();
                foreach (NhanVien y in dsNV)
                {
                    if (x.TenPhongBan.ToLower() == y.Phong.ToLower())
                        Console.WriteLine(y);
                }
                Console.WriteLine("\n================");
            }
        }
        static void ThemNhanVien()
        {
            Console.Write("Nhập mã phòng ban để thêm nhân viên: ");
            string s = Console.ReadLine();
            foreach(PhongBan i in dsPB)
            {
                if (i.MaPhongBan == s)
                {
                    NhanVien x = new NhanVien();
                    x.NhapNhanVien();
                    dsNV.Add(x);
                }
            }

            XuatThongTin();
        }
        static void TimNhanVien()
        {
            Console.Write("\nNhập mã nhân viên muốn tìm:");
            string s =(Console.ReadLine());
            foreach (NhanVien x in dsNV)
            {
                if (x.MaNhanVien == s)
                {
                    Console.Write(x);
                }
            }
        }
        static void SuaNhanVien()
        {
            Console.Write("\nNhập mã nhân viên muốn tìm để sửa:");
            string s =(Console.ReadLine());

            Console.WriteLine("Sửa mã/Sửa tên/Ngày sinh/Chức vụ?(1/2/3/4)");
            string k = Console.ReadLine();

            foreach (NhanVien x in dsNV)
            {
                if (x.MaNhanVien == s)
                {
                    if (k == "1")
                    {
                        Console.WriteLine("Nhập mã mới của nhân viên : ");
                        string newma = Console.ReadLine();
                        
                        x.MaNhanVien = x.MaNhanVien.Replace(x.MaNhanVien, newma);
                    }
                    else if (k == "2")
                    {
                        Console.WriteLine("Nhập tên mới của nhân viên : ");
                        string newten = Console.ReadLine();
                        x.TenNhanVien = x.TenNhanVien.Replace(x.TenNhanVien, newten);
                    }
                    else if (k == "3")
                    {
                        Console.WriteLine("Nhập ngày sinh mới của nhân viên : ");
                        DateTime newngaysinh = DateTime.Parse( Console.ReadLine());
                        string NewNgaySinh = Convert.ToString(newngaysinh);
                        string X3 = Convert.ToString(x.NgaySinh);
                        X3 = X3.Replace(X3, NewNgaySinh);
                        x.NgaySinh = DateTime.Parse(X3);
                    }
                    else if (k == "4")
                    {
                        Console.WriteLine("Nhập Chức vụ mới của nhân viên : ");
                        string newCV = Console.ReadLine();
                        x.ChucVu = x.ChucVu.Replace(x.ChucVu, newCV);
                    }
                }

            }
            Console.WriteLine("\nDanh sách nhân viên sau khi sửa");
            XuatThongTin();
        }
        static void XoaNhanVien()
        {
            Console.Write("Nhập mã nhân viên muốn xóa:");
            string s = (Console.ReadLine());
            int cnt = 0;
            for(int i = 0; i < dsNV.Count; i++)
            {
                if (dsNV[i].MaNhanVien == s)
                {
                    dsNV.Remove(dsNV[i]);
                    cnt++;
                }
            }
            if (cnt == 0)
                Console.WriteLine("Mã nhân viên không tồn tại!");
            else
            {
                Console.WriteLine("Danh sách nhân viên sau khi xóa");
                XuatThongTin();
            }
            
        }
        static int compare1(NhanVien nv1, NhanVien nv2)
        {
            return nv1.MaNhanVien.ToLower().CompareTo(nv2.MaNhanVien.ToLower());
        }
        //sắp xếp theo mã nhân viên
        static void SapXepNhanVien()
        {
            for(int i=0;i<dsNV.Count; i++)
                dsNV.Sort(compare1); // truyền vào để sắp xếp theo tiêu chí nào đó
            Console.WriteLine("Danh sách nhân viên sau khi sắp xếp tăng dần theo mã nv");
            XuatThongTin();
        }

        static void ThemPhongBan()
        {
            PhongBan x = new PhongBan();
            x.NhapPhongBan();
            dsPB.Add(x);
            Console.Write("\nNhập số lượng nhân viên: ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                NhanVien y = new NhanVien();
                y.NhapNhanVien();
                dsNV.Add(y);
            }
            XuatThongTin();
        }
        static void TimPhongBan()
        {
            Console.Write("\nNhập mã phòng ban muốn tìm:");
            string s = (Console.ReadLine());
            foreach (PhongBan x in dsPB)
            {
                if (x.MaPhongBan == s)
                {
                    Console.WriteLine(x);
                    Console.WriteLine();
                    foreach (NhanVien y in dsNV)
                    {
                        if (x.TenPhongBan.ToLower() == y.Phong.ToLower())
                            Console.WriteLine(y);
                    }
                    Console.WriteLine("\n================");
                }
            }
        }
        static void SuaPhongBan()
        {
            Console.Write("\nNhập mã phòng ban muốn tìm để sửa:");
            string s = (Console.ReadLine());

            Console.WriteLine("Sửa mã/Sửa tên?(1/2)");
            string k = Console.ReadLine();

            foreach (PhongBan x in dsPB)
            {
                if (x.MaPhongBan == s)
                {
                    if (k == "1")
                    {
                        Console.WriteLine("Nhập mã mới của phòng ban : ");
                        string newma = Console.ReadLine();

                        x.MaPhongBan = x.MaPhongBan.Replace(x.MaPhongBan, newma);
                    }
                    else if (k == "2")
                    {
                        Console.WriteLine("Nhập tên mới của phòng ban : ");
                        string newten = Console.ReadLine();
                        x.TenPhongBan = x.TenPhongBan.Replace(x.TenPhongBan, newten);
                    }
                }
            }
            Console.WriteLine("\nDanh sách phòng ban sau khi sửa");
            XuatThongTin();
        }
        static void XoaPhongBan()
        {
            Console.Write("Nhập mã phòng ban muốn xóa:");
            string s = (Console.ReadLine());
            int cnt = 0;
            for (int i = 0; i < dsPB.Count; i++)
            {
                if (dsPB[i].MaPhongBan == s)
                {
                    
                    for (int j = 0; j < dsNV.Count; j++)
                    {
                        if (dsNV[j].Phong.ToLower() == dsPB[i].TenPhongBan.ToLower())
                        {
                            dsNV.Remove(dsNV[i]);
                        }
                    }
                    dsPB.Remove(dsPB[i]);
                    cnt++;
                }
            }
            if (cnt == 0)
                Console.WriteLine("Mã phòng ban không tồn tại!");
            else
            {
                Console.WriteLine("Danh sách phòng ban sau khi xóa");
                XuatThongTin();
            }
        }
        static int compare2(PhongBan pb1, PhongBan pb2)
        {
            return pb1.MaPhongBan.ToLower().CompareTo(pb2.MaPhongBan.ToLower());
        }
        //sắp xếp theo mã phòng ban
        static void SapXepPhongBan()
        {
            for (int i = 0; i < dsPB.Count; i++)
            {
                dsPB.Sort(compare2); // truyền vào để sắp xếp theo tiêu chí nào đó
            }
            Console.WriteLine("Danh sách phòng ban sau khi sắp xếp tăng dần theo mã pb");
            XuatThongTin();
        }

        static long TongLuongTra1Thang()
        {
            long s = 0;
            foreach(NhanVien i in dsNV)
            {
                s += i.TinhLuong();
            }
            return s;
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            NhapThongTin();
            XuatThongTin();
            while (true)
            {
                Console.WriteLine("1.Chọn phòng ban");
                Console.WriteLine("2.Chọn nhân viên");
                Console.WriteLine("3.Tính tổng lương trả 1 tháng");
                Console.WriteLine("0.Thoat");
                Console.Write("\nNhập lựa chọn: ");
                int lc = int.Parse(Console.ReadLine());
                if (lc == 0)
                {
                    break;
                }
                else
                {
                    switch (lc)
                    {
                        case 1:
                            {
                                while (true)
                                {
                                    Console.WriteLine("\n1.1.Thêm phòng ban");
                                    Console.WriteLine("\n1.2.Tìm phòng ban");
                                    Console.WriteLine("\n1.3.Sửa phòng ban");
                                    Console.WriteLine("\n1.4.Xóa phòng ban");
                                    Console.WriteLine("\n1.5.Sắp xếp phòng ban");
                                    Console.WriteLine("\n1.0.Thoát");
                                    Console.Write("\nNhập lựa chọn: ");
                                    string LC1 = Console.ReadLine();
                                    if (LC1 == "1.0")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        switch (LC1)
                                        {
                                            case "1.1":
                                                {
                                                    ThemPhongBan();
                                                }
                                                break;
                                            case "1.2":
                                                {
                                                    TimPhongBan();
                                                }
                                                break;
                                            case "1.3":
                                                {
                                                    SuaPhongBan();
                                                }
                                                break;
                                            case "1.4":
                                                {
                                                    XoaPhongBan();
                                                }
                                                break;
                                            case "1.5":
                                                {
                                                    SapXepPhongBan();
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Nhập sai!!");
                                                break;

                                        }
                                    }
                                }
                            }
                            break;
                        case 2:
                            {
                                while (true)
                                {
                                    Console.WriteLine("\n2.0.Thoát");
                                    Console.WriteLine("\n2.1.Thêm nhân viên");
                                    Console.WriteLine("\n2.2.Tìm nhân viên");
                                    Console.WriteLine("\n2.3.Sửa nhân viên");
                                    Console.WriteLine("\n2.4.Xóa nhân viên");
                                    Console.WriteLine("\n2.5.Sắp xếp nhân viên");
                                    Console.Write("\nNhập lựa chọn: ");
                                    string LC2 = Console.ReadLine();
                                    if (LC2 == "2.0")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        switch (LC2)
                                        {
                                            case "2.1":
                                                {
                                                    ThemNhanVien();
                                                }
                                                break;
                                            case "2.2":
                                                {
                                                    TimNhanVien();
                                                }
                                                break;
                                            case "2.3":
                                                {
                                                    SuaNhanVien();
                                                }
                                                break;
                                            case "2.4":
                                                {
                                                    XoaNhanVien();
                                                }
                                                break;
                                            case "2.5":
                                                {
                                                    SapXepNhanVien();
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Nhập sai!!");
                                                break;

                                        }
                                    }
                                }
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Tông lương phải trả cho nhân viên trong 1 thang: " + TongLuongTra1Thang());
                            }
                            break;
                        
                        default:
                            Console.WriteLine("Nhập sai!");
                            break;
                    }
                }
            }
        }
    }
}