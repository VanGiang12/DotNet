using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace TruyCapDL_CodeFirst.Models
{
    public partial class ShopDataContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Oders> Oders { get; set; }

        public ShopDataContext()
            : base("name=ShopDataContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
