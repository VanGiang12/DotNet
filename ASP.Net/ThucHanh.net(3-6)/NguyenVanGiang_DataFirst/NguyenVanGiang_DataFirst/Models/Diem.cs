//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NguyenVanGiang_DataFirst.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Diem
    {
        [Key,Column(Order = 0)]
        public int MaSV { get; set; }
        [Key, Column(Order = 1)]
        public int MaMH { get; set; }
        [Range(0,10)]
        public Nullable<decimal> DiemTBM { get; set; }
    
        public virtual SinhVien SinhVien { get; set; }
    }
}
