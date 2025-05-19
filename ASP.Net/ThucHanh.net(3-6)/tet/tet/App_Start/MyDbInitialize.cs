using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using tet.Models;

namespace tet.App_Start
{
    public class MyDbInitialize : DropCreateDatabaseIfModelChanges<ShopDbContext>
    {
        protected override void Seed(ShopDbContext context)
        {
            context.Customers.Add(new Customer { CustomerId = 1, Name = "A" });
            context.Customers.Add(new Customer { CustomerId = 2, Name = "B" });
            context.Customers.Add(new Customer { CustomerId = 3, Name = "C" });
            context.Customers.Add(new Customer { CustomerId = 4, Name = "D" });

            context.Orders.Add(new Order { CustomerId = 1, ProductName = "mì", });
            context.Orders.Add(new Order { CustomerId = 2, ProductName = "kẹo", });
            context.Orders.Add(new Order { CustomerId = 3, ProductName = "táo", });
            context.Orders.Add(new Order { CustomerId = 4, ProductName = "ngô", });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}