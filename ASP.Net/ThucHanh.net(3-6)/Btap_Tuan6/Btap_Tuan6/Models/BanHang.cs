using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Btap_Tuan6.Models
{
    public class BanHang
    {
        [Key]
        public int Id { get; set; }
        public string Manv { get; set; }
        public string Masp { get; set; }
        public int Dinhmuc { get; set; }
        public int Slban { get; set; }

        public virtual NhanVien NhanVien { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}