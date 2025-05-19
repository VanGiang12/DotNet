using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class HangHoa
    {
        [Required(ErrorMessage ="Mã hàng hóa không được trống")]
        [DisplayName("Mã hàng hóa")]
        public int Mahh { get; set; }

        [Required(ErrorMessage = "Tên hàng hóa không được trống")]
        [StringLength(30,MinimumLength =2,ErrorMessage ="Tên phải từ 2 đến 30 ký tự")]
        [DisplayName("Tên hàng hóa")]
        public string Tenhh { get; set; }

        [DisplayName("Ngày sản xuất")]
        [DataType(DataType.Date)]
        public DateTime Nsx { get; set; }

        [DisplayName("Đơn giá")]
        [Required(ErrorMessage = "Đơn giá hàng hóa không được trống")]
        public int Dongia { get; set; }

        [DisplayName("Số lượng")]
        [Required(ErrorMessage = "Số lượng hàng hóa không được trống")]
        public int Soluong { get; set; }

        [DisplayName("Thành tiền")]
        public int Thanhtien => Soluong * Dongia;

        [DisplayName("Loại hàng hóa")]
        [Required(ErrorMessage = "Loại hàng hóa không được trống")]
        public string Loaihang { get; set; }
    }
}