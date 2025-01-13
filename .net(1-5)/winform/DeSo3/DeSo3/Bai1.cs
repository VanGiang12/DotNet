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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);
            double d = double.Parse(txtD.Text);
            double m = double.Parse(txtM.Text);
            double n = double.Parse(txtN.Text);

            double y = (n * a - c * m) / (a * d - c * b);
            double x = (m - b * y) / a;

            lblKQ.Text ="x="+ x.ToString();
            lblkq2.Text ="y="+ y.ToString();

        }
    }
}
