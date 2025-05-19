using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sach_phieumuon.Models
{
    public class ViewSach
    {
        public int? Masach { get; set; }
        public int SoLuong { get; set; }
        public List<Sach> Sachs { get; set; }
    }
}