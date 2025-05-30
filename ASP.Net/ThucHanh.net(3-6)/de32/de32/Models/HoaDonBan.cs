//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace de32.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class HoaDonBan
    {
        [Key]
        public int MaHD { get; set; }
        [ForeignKey("Sach")]
        public int MaSach { get; set; }
        [ForeignKey("KhachHang")]
        public int MaKH { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> NgayBan { get; set; }
        [Range(1,int.MaxValue)]
        public Nullable<int> SoLuong { get; set; }
            
        public virtual Sach Sach { get; set; }
        
        public virtual KhachHang KhachHang { get; set; }
    }
}
