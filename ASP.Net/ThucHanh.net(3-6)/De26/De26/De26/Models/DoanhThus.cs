using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace De26.Models
{
    public class DoanhThus
    {
        public int MaMon { get; set; }
        public long DoanhThu { get; set; }
        public List<MonAn> MonAns { get; set; }
    }
}