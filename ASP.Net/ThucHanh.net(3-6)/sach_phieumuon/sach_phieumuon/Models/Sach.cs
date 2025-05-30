//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sach_phieumuon.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            this.PhieuMuons = new HashSet<PhieuMuon>();
        }
        [Key]
        public int MaSach { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string TenSach { get; set; }
        [Required]
        [MaxLength(50)]
        public string TacGia { get; set; }
        [Required]
        [MaxLength(50)]
        public string TheLoai { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public Nullable<int> SoLuongTon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuMuon> PhieuMuons { get; set; }
    }
}
