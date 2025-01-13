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
    public partial class frmSinhVien2 : Form
    {
        public frmSinhVien2()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ten = txtTen.Text;
            errorProvider1.SetError(txtTen, "");
            if (sv.Ten == "")
            {
                errorProvider1.SetError(txtTen, "Chưa nhập tên!");
            }
            else
            {
                lstLopA.Items.Add(sv.Ten);
                txtTen.Text = "";
            }
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            if (lstLopA != null)
            {
                //lstLopB.Items.Add(lstLopA.SelectedItem.ToString());
                //lstLopA.Items.RemoveAt(lstLopA.SelectedIndex);
                while (lstLopA.SelectedIndices.Count > 0)
                {
                    lstLopB.Items.Add(lstLopA.SelectedItem.ToString());
                    lstLopA.Items.RemoveAt(lstLopA.SelectedIndices[0]);
                }
            }
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            if (lstLopB != null)
            {

                while (lstLopB.SelectedIndices.Count > 0)
                {
                    lstLopA.Items.Add(lstLopB.SelectedItem.ToString());
                    lstLopB.Items.RemoveAt(lstLopB.SelectedIndices[0]);
                }
            }
        }

        private void btnPhai2_Click(object sender, EventArgs e)
        {
            if (lstLopA != null)
            {
                lstLopB.Items.AddRange(lstLopA.Items);
                lstLopA.Items.Clear();
            }
        }

        private void btnTrai2_Click(object sender, EventArgs e)
        {
            if (lstLopB != null)
            {
                lstLopA.Items.AddRange(lstLopB.Items);
                lstLopB.Items.Clear();
            }
        }

        private void btnXoaA_Click(object sender, EventArgs e)
        {
            while (lstLopA.SelectedIndices.Count > 0)
            {
                lstLopA.Items.RemoveAt(lstLopA.SelectedIndices[0]);
            }
        }

        private void btnXoaB_Click(object sender, EventArgs e)
        {
            while (lstLopB.SelectedIndices.Count > 0)
            {
                lstLopB.Items.RemoveAt(lstLopB.SelectedIndices[0]);
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Muốn thoát à?",
                "Hỏi thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                Close();
        }
    }
}
