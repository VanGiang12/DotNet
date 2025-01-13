using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBox
{
    public class SinhVien
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public override string ToString()
        {
            return Ma+"-"+Ten;
        }
    }
}
