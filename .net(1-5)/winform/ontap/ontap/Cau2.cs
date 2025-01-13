using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ontap
{
    public partial class Cau2 : Form
    {
        public Cau2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "+")
            {
                float a = float.Parse(txtSo1.Text);
                float b = float.Parse(txtSo2.Text);

                txtkq.Text = (a + b).ToString();
            }
            else if(comboBox1.SelectedItem.ToString() == "-")
            {
                float a = float.Parse(txtSo1.Text);
                float b = float.Parse(txtSo2.Text);

                txtkq.Text = (a - b).ToString();
            }
            else if (comboBox1.SelectedItem.ToString() == "*")
            {
                float a = float.Parse(txtSo1.Text);
                float b = float.Parse(txtSo2.Text);

                txtkq.Text = (a * b).ToString();
            }
            else
            {
                float a = float.Parse(txtSo1.Text);
                float b = float.Parse(txtSo2.Text);

                txtkq.Text = (a / b).ToString();
            }
        }
    }
}
