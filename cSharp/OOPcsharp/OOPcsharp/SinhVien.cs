using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcsharp
{
    public class SinhVien
    {
        #region các biến lớp
        private int ma; //hoặc public int Ma {get;set}
        private string ten; //hoặc public string Ten {get;set}
        #endregion
        #region các constructor
        public SinhVien()
        {
            this.ma = 1;
            this.ten = " ";
        }
        public SinhVien(int ma, string ten)
        {
            this.ma = ma;
            this.ten = ten;
        }
        #endregion
        #region các properties
        public int Ma
        {
            get { return this.ma; }
            set { this.ma = value; }
        }
        public string Ten
        {
            get { return this.ten; }
            set { this.ten = value; }
        }
        #endregion
        #region các method
        public override string ToString()
        {
            return this.Ma + "\t" + this.Ten;
                
        }
        #endregion
    }
}
