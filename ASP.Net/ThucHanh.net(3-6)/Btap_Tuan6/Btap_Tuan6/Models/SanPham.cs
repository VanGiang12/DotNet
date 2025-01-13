using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Btap_Tuan6.Models
{
    public class SanPham
    {
        [Key]
        public string Masp { get; set; }
        public string Tensp { get; set; }
        public virtual ICollection<BanHang> BanHangs { get; set; }
    }
}