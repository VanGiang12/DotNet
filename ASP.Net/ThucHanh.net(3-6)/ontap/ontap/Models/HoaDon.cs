using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ontap.Models
{
    public class HoaDon
    {
        [Key]
        [Required]
        public int Mahd { get; set; }
        [Required]
        public int Masp { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ngayban { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Soluongban { get; set; }

        public virtual SanPham SanPhams { get; set; }
    }
}