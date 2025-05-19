using Btap_Tuan6.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Btap_Tuan6.App_Start
{
    public class MyInit : DropCreateDatabaseAlways<_DbContext>
    {
        protected override void Seed(_DbContext context)
        {
            context.NhanViens.Add(new NhanVien { Manv = "NV01", Tenquay = "quầy 1", Hoten = "Anh" });
            context.NhanViens.Add(new NhanVien { Manv = "NV02", Tenquay = "quầy 2", Hoten = "Van" });

            context.SanPhams.Add(new SanPham { Masp = "SP01", Tensp = "áo thun" });
            context.SanPhams.Add(new SanPham { Masp = "SP02", Tensp = "áo khoác" });
            context.SanPhams.Add(new SanPham { Masp = "SP03", Tensp = "áo sơ mi" });

            context.BanHangs.Add(new BanHang { Id=1,Manv="NV01",Masp="SP01",Dinhmuc=30,Slban=25 });
            context.BanHangs.Add(new BanHang { Id=2,Manv="NV01",Masp="SP02",Dinhmuc=30,Slban=35 });
            context.BanHangs.Add(new BanHang { Id=3,Manv ="NV02",Masp="SP02",Dinhmuc=30,Slban=34 });
            context.BanHangs.Add(new BanHang { Id=4,Manv ="NV02",Masp="SP03",Dinhmuc=30,Slban =36 });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}