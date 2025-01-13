using ontap_de2.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ontap_de2.App_Start
{
    public partial class QLSinhVienDataContext : DbContext
    {
        public QLSinhVienDataContext()
            : base("name=QLSinhVienDataContext")
        {
        }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Diem> Diems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
