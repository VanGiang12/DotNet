using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    public class DanhMuc
    {
        private Dictionary<string, SanPham> dsSP = new Dictionary<string, SanPham>();
        public string MaDM { get; set; }
        public string TenDM { get; set; }
        public void ThemSanPham(SanPham sp)
        {
            if (dsSP.ContainsKey(sp.MaSP) == false) //ktra xem mã đã tồn tại hay chưa
            {
                dsSP.Add(sp.MaSP, sp);
                sp.Nhom = this;
            }
        }
        public Dictionary<string, SanPham> SanPhams
        {
            get { return dsSP; }
            set { dsSP = value; }
        }
        public override string ToString()
        {
            return this.TenDM;
        }
    }
}
