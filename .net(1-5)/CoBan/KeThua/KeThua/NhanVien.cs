using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    public class NhanVien:ILamViec
    {
        public int Ma { get; set; }
        public string Ten { set; get; }

        public string LamViec(string mota)
        {
            string s = "Nhân viên đang làm [" + mota + "]";
            return s;
        }

        public void TinhLuong()
        {
            Console.WriteLine("Tinh luong!!!");
        }
        public virtual int TinhLuong(int ngaycong)  //có virtual mới override bên NVchinhthuc
        {
            return ngaycong * 100;
        }
    }
}
