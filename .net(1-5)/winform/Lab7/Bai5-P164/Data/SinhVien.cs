using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_P164.Data
{
    [Serializable]
    public class SinhVien
    {
        private string masinhvien, hoten, quequan;
        private long namsinh;

        public SinhVien()
        {
        }

        public SinhVien(string masinhvien, string hoten, long namsinh)
        {
            this.masinhvien = masinhvien;
            this.hoten = hoten;
            this.namsinh = namsinh;
        }

        public string Masinhvien { get => masinhvien; set => masinhvien = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Quequan { get => quequan; set => quequan = value; }
        public long Namsinh { get => namsinh; set => namsinh = value; }


    }
}
