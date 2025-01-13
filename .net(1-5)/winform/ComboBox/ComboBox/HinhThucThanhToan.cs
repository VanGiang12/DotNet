using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBox
{
    public class HinhThucThanhToan
    {
        public int Ma { get; set; }
        public String HinhThuc { get; set; }
        public int PhiThanhToan { get; set; }
        public override string ToString()
        {
            return HinhThuc;
        }
    }
}
