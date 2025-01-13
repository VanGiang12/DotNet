using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HangHoas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            /* Hang_Hoa h1=new Hang_Hoa();
             Hang_Hoa h2= new Hang_Hoa("m1","a",2);
             h1.Xuat();
             h2.Xuat();
             h1.MaDon = "MH03";
             h1.TenDon = "Máy pha cà phê";
             h1.DonGia = 1000000;*/
            //h1.Xuat();
            /*
            Console.Write("Số lượng: ");
            int n = int.Parse(Console.ReadLine());
            May_Tinh[] MT = new May_Tinh[n];
            for (int i = 0; i < n; i++)
            {
                MT[i] = new May_Tinh();
                MT[i].NhapDL();
            }
            
            Console.WriteLine("Danh sách: ");
            foreach (May_Tinh i in MT)
            {
                i.HienThi();
            }
            Console.WriteLine("máy tính có giá max: ");
            May_Tinh max = new May_Tinh();
            for (int i = 1; i < n; i++)
            {
                max.DonGia = MT[0].DonGia;
                if (max.DonGia < MT[i].DonGia)
                    max = MT[i];
            }
            max.HienThi();
            */
            Hang_Hoa h = new May_Tinh();
            h.Nhap();
            h.Xuat();
        }
    }
}