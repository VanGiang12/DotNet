using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ontap.Models
{
    public class SanPham
    {
        [Key]
        public int Masp { get; set; }
        [Required]
        [StringLength(50,MinimumLength =5)]
        public string Tensp { get; set; }
        [Required]
        [Range(1,int.MaxValue)]
        public int Gia { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Soluong { get; set; }
        [Required]
        [StringLength(50)]
        public string Loaisp { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}