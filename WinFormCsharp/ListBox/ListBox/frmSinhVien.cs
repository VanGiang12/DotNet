using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien x = new SinhVien();
            x.Ma = int.Parse(txtMa.Text);
            x.Ten = txtTen.Text;
            lstSinhVien.Items.Add(x);
        }

        private void lstSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex != -1)
            {
                SinhVien sv = lstSinhVien.SelectedItem as SinhVien;
                txtMa.Text = sv.Ma.ToString();
                txtTen.Text = sv.Ten;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while (lstSinhVien.SelectedIndices.Count > 0)
            {
                lstSinhVien.Items.RemoveAt(lstSinhVien.SelectedIndices[0]);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
