using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSach
{
    public class DocGia
    {
        string madocgia, tendocgia, coquan, diachi, tel;

        public DocGia(string madocgia, string tendocgia, string coquan, string diachi, string tel)
        {
            this.madocgia = madocgia;
            this.tendocgia = tendocgia;
            this.coquan = coquan;
            this.diachi = diachi;
            this.tel = tel;
        }

        public string Madocgia { get => madocgia; set => madocgia = value; }
        public string Tendocgia { get => tendocgia; set => tendocgia = value; }
        public string Coquan { get => coquan; set => coquan = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Tel { get => tel; set => tel = value; }
    }
}
