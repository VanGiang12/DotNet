using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace btvn_Tuan3.Models
{
    public class SinhVien
    {
        public int Msv { get; set; }
        public string Name { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public string Lop { get; set; }
    }
}