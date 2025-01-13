using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    public class SinhVien : ILamViec
    {
        public string MaSv { set; get; }
        public string TenSv { get; set; }
        public string LamViec(string mota)
        {
            string s = "Sinh viên đang làm [" + mota + "]";
            return s;
        }
    }
}
