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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rad1998.Checked && radPhap.Checked || rad2002.Checked && radBrazil.Checked
                || rad2006.Checked && radItalia.Checked || rad2010.Checked && radTBN.Checked
                || rad2014.Checked && radDuc.Checked)
            {
                txtKQ.Text = "Bạn trả lời trúng phóc!";
            }
            else
                txtKQ.Text = "Bạn trả lời sai bét!";
        }
    }
}
