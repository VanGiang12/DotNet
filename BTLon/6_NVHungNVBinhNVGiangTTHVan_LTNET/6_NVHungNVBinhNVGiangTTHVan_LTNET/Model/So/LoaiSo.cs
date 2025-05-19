using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.So
{
    internal class LoaiSo
    {
        private string maloaiso;
        private string? tenloaiso;
        private decimal? laisuattheothang;
        private int? sothang;

        public  string Maloaiso { get => maloaiso; set => maloaiso = value; }
        public string? Tenloaiso { get => tenloaiso; set => tenloaiso = value; }
        public decimal? Laisuattheothang { get => laisuattheothang; set => laisuattheothang = value; }
        public int? Sothang { get => sothang; set => sothang = value; }

        public LoaiSo()
        {

        }
        public LoaiSo(string maloaiso, string tenloaiso, decimal laisuattheothang, int sothang)
        {
            this.Maloaiso = maloaiso;
            this.Tenloaiso = tenloaiso;
            this.Laisuattheothang = laisuattheothang;
            this.Sothang = sothang;
        }

        
    }
}
