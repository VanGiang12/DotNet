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
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }

        private void bai4_Load(object sender, EventArgs e)
        {

        }
        private void cboPhepToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSo1.Text == "" || txtSo2.Text == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Thông báo");
                txtSo1.Focus();
            }
            else
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                int sl = cboPhepToan.SelectedIndex;
                switch (sl)
                {
                    case 0:
                        {
                            txtKetQua.Text = (so1 + so2).ToString();
                        }
                        break;
                    case 1:
                        {
                            txtKetQua.Text = (so1 - so2).ToString();
                        }
                        break;
                    case 2:
                        {
                            txtKetQua.Text = (so1 * so2).ToString();
                        }
                        break;
                    case 3:
                        {
                            if (so2 != 0)
                                txtKetQua.Text = (so1 / so2).ToString();
                            else
                            {
                                MessageBox.Show("Không chia được cho 0", "Thông báo");
                                txtSo2.Focus();
                            }
                        }
                        break;
                }
            }
        }

    }
}
