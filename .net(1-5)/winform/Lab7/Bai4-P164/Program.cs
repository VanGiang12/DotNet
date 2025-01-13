using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

[Serializable]
//cho phép chúng ta serialize và deserialize các đối tượng SinhVien,
//tức là lưu trữ danh sách sinh viên vào tệp nhị phân và sau đó đọc lại từ tệp nhị phân.
class SinhVien
{
    public string MaSV { get; set; }
    public string TenSV { get; set; }
    public double DiemToan { get; set; }
    public double DiemVan { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding=Encoding.UTF8;
        Console.InputEncoding=Encoding.UTF8;
        List<SinhVien> danhSachSinhVien = NhapDanhSachSinhVien();
        LuuDanhSachSinhVien(danhSachSinhVien, @"D:\myfile\danh_sach_sinh_vien.bin");
        HienThiDanhSachSinhVien(@"D:\myfile\danh_sach_sinh_vien.bin");
    }

    static List<SinhVien> NhapDanhSachSinhVien()
    {
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        while (true)
        {
            Console.Write("Nhập mã sinh viên (nhập 'q' để kết thúc): ");
            string maSV = Console.ReadLine();
            if (maSV.ToLower() == "q")
                break;

            Console.Write("Nhập tên sinh viên: ");
            string tenSV = Console.ReadLine();

            Console.Write("Nhập điểm toán: ");
            double diemToan = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập điểm văn: ");
            double diemVan = Convert.ToDouble(Console.ReadLine());

            SinhVien sinhVien = new SinhVien { MaSV = maSV, TenSV = tenSV, DiemToan = diemToan, DiemVan = diemVan };
            danhSachSinhVien.Add(sinhVien);
        }
        return danhSachSinhVien;
    }

    static void LuuDanhSachSinhVien(List<SinhVien> danhSachSinhVien, string tenTep)
    {
        try
        {
            using (Stream stream = File.Open(tenTep, FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();//Đối tượng này sẽ được sử dụng để thực hiện quá trình serialization và deserialization
                bin.Serialize(stream, danhSachSinhVien);//Thực hiện serialization của danh sách sinh viên
                //(danhSachSinhVien) và ghi kết quả vào stream. Kết quả sẽ được lưu trữ dưới dạng nhị phân
                //trong tệp mà chúng ta đã mở hoặc tạo.
            }
            Console.WriteLine("Danh sách sinh viên đã được lưu vào tệp " + tenTep);
        }
        catch (IOException e)
        {
            Console.WriteLine("Lỗi khi lưu tệp: " + e.Message);
        }
    }

    static void HienThiDanhSachSinhVien(string tenTep)
    {
        try
        {
            //Khi phạm vi của khối using kết thúc, Stream sẽ tự động đóng
            //và giải phóng tài nguyên được sử dụng bởi nó.
            using (Stream stream = File.Open(tenTep, FileMode.Open))
            {
                BinaryFormatter bin = new BinaryFormatter();
                List<SinhVien> danhSachSinhVien = (List<SinhVien>)bin.Deserialize(stream);
                Console.WriteLine("Danh sách sinh viên trong tệp " + tenTep + ":");
                foreach (var sinhVien in danhSachSinhVien)
                {
                    Console.WriteLine($"Mã SV: {sinhVien.MaSV}, Tên SV: {sinhVien.TenSV}, Điểm Toán: {sinhVien.DiemToan}, Điểm Văn: {sinhVien.DiemVan}");
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Lỗi khi đọc tệp: " + e.Message);
        }
        catch (SerializationException)
        {
            Console.WriteLine("Không thể đọc tệp do định dạng không đúng.");
        }
    }
}
