using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSach
{
    public class Sach
    {
        string masach, tensach, tentacgia, nhaxb;
        int namxb, soluong;

        public Sach(string masach, string tensach, string tentacgia, string nhaxb, int namxb, int soluong)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.tentacgia = tentacgia;
            this.nhaxb = nhaxb;
            this.namxb = namxb;
            this.soluong = soluong;
        }

        public string Masach { get => masach; set => masach = value; }
        public string Tensach { get => tensach; set => tensach = value; }
        public string Tentacgia { get => tentacgia; set => tentacgia = value; }
        public string Nhaxb { get => nhaxb; set => nhaxb = value; }
        public int Namxb { get => namxb; set => namxb = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
