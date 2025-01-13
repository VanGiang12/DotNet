using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Btap_Tuan6.Models
{
    public class NhanVien
    {
        [Key]
        public string Manv { get; set; }
        public string Tenquay { get; set; }
        public string Hoten { get; set; }

        public virtual ICollection<BanHang> BanHangs { get;set; }
    }
}