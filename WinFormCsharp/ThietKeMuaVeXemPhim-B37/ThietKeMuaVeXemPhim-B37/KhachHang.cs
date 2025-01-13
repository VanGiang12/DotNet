using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThietKeMuaVeXemPhim_B37
{
    public class KhachHang
    {
        public List<int> Ghes { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime GioDatGhe { get; set; }
        public KhachHang()
        {
            Ghes = new List<int>();
        }
        public int TinhTien
        {
            get { return Ghes.Count * 100000; }
        }
        public override string ToString()
        {
            return this.Name + "-" + this.Phone;
        }
    }
}
