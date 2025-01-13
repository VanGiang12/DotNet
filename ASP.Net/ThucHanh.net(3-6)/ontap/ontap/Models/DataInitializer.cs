using ontap.App_Start;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ontap.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<QLBanHangDataContext>
    {
        protected override void Seed(QLBanHangDataContext context)
        {
            base.Seed(context);
            context.SanPhams.Add(new SanPham { Masp = 1, Tensp = "Điện thoại Ihone 13", Soluong = 10, Loaisp = "Điện thoại", Gia = 20000000 });
            context.SanPhams.Add(new SanPham { Masp = 2, Tensp = "Laptop Dell XPS", Soluong = 5, Loaisp = "Lap Top", Gia = 30000000 });
            context.SanPhams.Add(new SanPham { Masp = 3, Tensp = "Tai nghe AirPods", Soluong = 20, Loaisp = "Phụ kiện", Gia = 5000000 });

            context.HoaDons.Add(new HoaDon { Mahd = 1, Masp = 1, Ngayban = DateTime.Parse("07/01/2024"), Soluongban = 2 });
            context.HoaDons.Add(new HoaDon { Mahd = 2, Masp = 2, Ngayban = DateTime.Parse("06/11/2024"), Soluongban = 1 });
            context.HoaDons.Add(new HoaDon { Mahd = 3, Masp = 3, Ngayban = DateTime.Parse("08/20/2024"), Soluongban = 5 });

            context.SaveChanges();
        }
    }
}