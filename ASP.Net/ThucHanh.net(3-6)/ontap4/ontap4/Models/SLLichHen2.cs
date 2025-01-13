using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ontap4.Models
{
    public class SLLichHen2
    {
        public string BenhNhan { get; set; }
        public int SoLuong { get; set; }
        public List<LichHen> LichHens { get; set; }
    }
}