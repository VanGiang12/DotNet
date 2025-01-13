using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeSo3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(txtX1.Text);
            double y1 = double.Parse(txtY1.Text);
            double x2 = double.Parse(txtX2.Text);
            double y2 = double.Parse(txtY2.Text);

            lblHSG.Text = ((y2 - y1) / (x2 - x1)).ToString();

            lblKC.Text ="~"+ Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)).ToString("F3");
        }
    }
}
