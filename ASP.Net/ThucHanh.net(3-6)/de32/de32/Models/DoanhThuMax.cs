using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace de32.Models
{
    public class DoanhThuMax
    {
        public int Masach { get; set; }
        public int? Doanhthu { get; set; }
        public List<Sach> Sachs { get; set; }
    }
}