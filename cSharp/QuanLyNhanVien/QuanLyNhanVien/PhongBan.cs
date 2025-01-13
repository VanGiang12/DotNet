using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    public  class PhongBan
    {
        
        public string MaPhongBan { set; get; }
        public string TenPhongBan { get; set; }
        
        public void NhapPhongBan()
        {
            Console.WriteLine("Mã phòng ban: ");
            MaPhongBan =(Console.ReadLine());
            Console.WriteLine("Tên phòng ban: ");
            TenPhongBan =Console.ReadLine();
        }
        public override string ToString()
        {
            return "\nMã: "+this.MaPhongBan+"\tTên: "+this.TenPhongBan;
        }

    }
}
