using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_P164.Data
{
    [Serializable]
    public class SinhVienCoKhi : SinhVien
    {
        private float diemkythuat, diemmCNC;
        public SinhVienCoKhi()
        {

        }

        public SinhVienCoKhi(string masinhvien, string hoten, long namsinh, float diemkythuat, float diemmCNC) : base(masinhvien, hoten, namsinh)
        {
            this.Diemkythuat = diemkythuat;
            this.DiemmCNC = diemmCNC;
        }

        public float Diemkythuat { get => diemkythuat; set => diemkythuat = value; }
        public float DiemmCNC { get => diemmCNC; set => diemmCNC = value; }

        public float DTB()
        {
            return (diemkythuat + diemmCNC) / 2;
        }
        

    }
}
