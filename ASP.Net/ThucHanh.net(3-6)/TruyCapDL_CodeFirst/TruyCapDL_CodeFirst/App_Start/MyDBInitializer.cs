using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TruyCapDL_CodeFirst.Models;

namespace TruyCapDL_CodeFirst.App_Start
{
    public class MyDBInitializer : DropCreateDatabaseAlways<ShopDataContext>
    //public class MyDBInitializer : DropCreateDatabaseIfModelChanges<ShopDataContext> // sau khi khởi tạo rồi thì sauwr lại thành dòng này để chạy sẽ k khởi tạo lại
    {
        protected override void Seed(ShopDataContext context)
        {
            context.Customers.Add(new Customer { CustomerId = 1, Name = "a" });
            context.Customers.Add(new Customer { CustomerId = 2, Name = "b" });
            context.Customers.Add(new Customer { CustomerId = 3, Name = "c" });
          

            context.Oders.Add(new Oders { CustomerId = 1, ProductName = "mì", Price = 20000, Quantity = 1 });
            context.Oders.Add(new Oders { CustomerId = 2, ProductName = "bún", Price = 30000, Quantity = 1 });
            context.Oders.Add(new Oders { CustomerId = 3, ProductName = "xôi", Price = 15000, Quantity = 1 });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}