using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace btvn_Tuan4.Models
{
    public class NhanVien
    {
        [Required(ErrorMessage ="Mã không được để trống")]
        [DisplayName("Mã nhân viên")]
        public int Manhanvien { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        [DisplayName("Họ tên")]
        public string Hoten { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        [DisplayName("Ngày sinh")]
        public DateTime Ngaysinh { get; set; }

        [DisplayName("Giới tính")]
        public bool Gioitinh { get; set; }

        [Required(ErrorMessage = "Điện thoại không được để trống")]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Điện thoại")]
        public string Dienthoai { get; set; }

        [Required(ErrorMessage = "Hệ số lương không được để trống")]
        [DisplayName("Hệ số lương")]
        public double Hesoluong { get; set; }

        [Required(ErrorMessage = "Tên phòng không được để trống")]
        [DisplayName("Tên phòng")]
        public string Tenphong { get; set; }

        [Required(ErrorMessage = "Lương không được để trống")]
        [DisplayName("Lương")]
        public double Luong { get; set; }
    }
}