//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanHang.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TruLuong
    {
        public int ID { get; set; }
        public Nullable<int> idBangLuong { get; set; }
        public string LyDoTru { get; set; }
        public Nullable<double> SoTienTru { get; set; }
    
        public virtual BangLuong BangLuong { get; set; }
    }
}
