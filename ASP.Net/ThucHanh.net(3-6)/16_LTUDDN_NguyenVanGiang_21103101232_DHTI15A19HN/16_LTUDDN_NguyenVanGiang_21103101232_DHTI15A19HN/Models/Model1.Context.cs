﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _16_LTUDDN_NguyenVanGiang_21103101232_DHTI15A19HN.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NguyenVanGiangEntities : DbContext
    {
        public NguyenVanGiangEntities()
            : base("name=NguyenVanGiangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<LichSuDieuTri> LichSuDieuTris { get; set; }
    }
}
