using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Model;

namespace test.Login
{
    public partial class frmDangNhap : Form
    {
        frmHome homeForm = new frmHome();
        public frmDangNhap()
        {
            InitializeComponent();
            txtTaiKhoan.Focus();
            txtTaiKhoan.Text = "admin";
            txtPass.Text = "123";
            radAdmin.Checked = true;
        }

        private void lblQuenMK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tạm khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblQuenMK_MouseHover(object sender, EventArgs e)
        {
            lblQuenMK.ForeColor = Color.Red;
        }

        private void lblQuenMK_MouseLeave(object sender, EventArgs e)
        {
            lblQuenMK.ForeColor = Color.Blue;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (radAdmin.Checked)
            {
                string user = txtTaiKhoan.Text.Trim();
                string pass = txtPass.Text.Trim();
                if (DangNhap.Login(user, pass))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    homeForm.Show();
                    homeForm.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radDocGia.Checked)
            {
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radDocGia_Click(object sender, EventArgs e)
        {
            if (radDocGia.Checked)
                MessageBox.Show("Tạm khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
