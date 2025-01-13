using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _16_10.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên bắt buộc phải nhập")]
        [StringLength(30, MinimumLength = 2)]
        [DisplayName("Họ tên")] // khi chạy hiện chữ họ tên thay vì Name
        public string Name { get; set; }

        [Required]
        [DisplayName("Địa chỉ")]
        //[DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password")] // pass p giống bên trên
        [Required]
        public string ReEnterPassword { get; set; }
        [Required]
        //[Range(18, 60)]
        // [ReadOnly(true)]  // không lấy tuổi(vẫn cho nhập)
         [ScaffoldColumn(false)] // không hiển thị trường ra cho nhập
        public int Age { get { return DateTime.Now.Year - Date.Year; } set { } }
        [Required]
        public bool Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }


    }
}