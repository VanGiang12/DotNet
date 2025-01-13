using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _16_LTUDDN_NguyenVanGiang_21103101232_DHTI15A19HN.Models
{
    public class BenhNhanTongPhi
    {
        public int MaBN { get; set; }
        public int Tong { get; set; }
        public List<BenhNhan> BenhNhans { get; set; }
    }
}