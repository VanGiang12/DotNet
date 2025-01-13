using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    public class NhanVienChinhThuc:NhanVien
    {
        public new void TinhLuong()
        {
            base.TinhLuong();
            Console.WriteLine("Thằng con1 nó");
        }
        public override int TinhLuong(int ngaycong)
        {
            if (ngaycong == 20)
                return 10000000;
            return base.TinhLuong(ngaycong);
        }
    }
}
