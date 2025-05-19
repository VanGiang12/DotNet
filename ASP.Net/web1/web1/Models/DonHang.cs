using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web1.Models
{
    public class DonHang
    {
        public int ID { get; set; } 
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public DateTime? NgayDat { get; set; }
        public List<MayTinh> MTDatMua = new List<MayTinh>();
    }
}