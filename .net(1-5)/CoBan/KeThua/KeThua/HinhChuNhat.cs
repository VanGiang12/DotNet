﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    public class HinhChuNhat
    {
        public int CanhA { set; get; }
        public int CanhB { get; set; }
        public HinhChuNhat(int canhA, int canhB)
        {
            CanhA = canhA;
            CanhB = canhB;
        }
        public virtual int DienTich()
        {
            return CanhA * CanhB;
        }
        public virtual int ChuVi()
        {
            return (CanhA + CanhB) * 2;
        }
    }
}
