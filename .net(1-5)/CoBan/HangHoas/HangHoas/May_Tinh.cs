using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangHoas
{
    public class May_Tinh:Hang_Hoa
    {
            private string hangSX;
            private int CPU;
            private int RAM;
            // hàm tạo không có tham số
            public May_Tinh() : base()
            {

            }
            // hàm tạo có tham số
            public May_Tinh(string maHang, string tenHang, long donGia, string hangSX, int CPU, int RAM) :
                base(maHang, tenHang, donGia)
            {
                this.hangSX = hangSX;
                this.CPU = CPU;
                this.RAM = RAM;
            }
            // phương thức nhập dữ liệu
            public override void Nhap()
            {
                base.Nhap();
                Console.Write(" Hãng sản xuất: ");
                hangSX = Console.ReadLine();
                Console.Write(" CPU: ");
                CPU = int.Parse(Console.ReadLine());
                Console.Write(" RAM: ");
                RAM = int.Parse(Console.ReadLine());

            }

            // phương thức hiển thị
            public override void Xuat()
            {
                base.Xuat();
                Console.WriteLine(", Hãng: {0},CPU: {1},RAM: {2}",
                    hangSX, CPU, RAM);
            }

    }
}
