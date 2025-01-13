using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau2
{
    public partial class Cau2 : Form
    {
        public Cau2()
        {
            InitializeComponent();
        }

        private void cbopt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbopt.SelectedItem.ToString() == "+")
            {
                txtkq.Text = (float.Parse(txtso1.Text)+float.Parse(txtso2.Text)).ToString();
            }
            else if (cbopt.SelectedItem.ToString() == "-")
            {
                txtkq.Text = (float.Parse(txtso1.Text) - float.Parse(txtso2.Text)).ToString();
            }
            else if (cbopt.SelectedItem.ToString() == "*")
            {
                txtkq.Text = (float.Parse(txtso1.Text) * float.Parse(txtso2.Text)).ToString();
            }
            else 
            {
                txtkq.Text = (float.Parse(txtso1.Text) / float.Parse(txtso2.Text)).ToString();
            }
        }
    }
}
