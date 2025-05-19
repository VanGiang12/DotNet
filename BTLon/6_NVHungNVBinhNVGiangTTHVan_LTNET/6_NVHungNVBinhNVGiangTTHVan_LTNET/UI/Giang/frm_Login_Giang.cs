using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET
{
    public partial class frm_Login_Giang : Form
    {
        public static bool instance;
        public static string Key;
        public frm_Login_Giang()
        {
            InitializeComponent();
        }

        private void frm_Login_Giang_Load(object sender, EventArgs e)
        {
            lbl_message_giang.Visible = false;
          

            tb_taikhoan_giang.Text = "NV001";
            tb_matkhau_giang.Text = "admin";
            rad_admin_giang.Checked = true;
        }

        private void btn_dangnhap_giang_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void rad_admin_giang_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_admin_giang.Checked)
                rad_nhanvien_giang.Checked = false;
            else
                rad_admin_giang.Checked = false;
        }

        private void btn_thoat_giang_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn thoát chứ?", "Thông báo", MessageBoxButtons.YesNo))
            {
                Application.Exit();
            }
        }

        void DangNhap()
        {
            string loainguoidung = rad_admin_giang.Checked ? "1" : "2";
            string taikhoan = Key = tb_taikhoan_giang.Text;
            string matkhau = tb_matkhau_giang.Text;

            if (Login.kiemtra(taikhoan, matkhau, loainguoidung))
            {
                instance = rad_admin_giang.Checked; // true: admin, fales: nhân viên

                new frm_Home_Giang().Show();
                this.Hide();
            }
            else
            {
                lbl_message_giang.Visible = true;
            }
        }

        #region hover
        private void btn_dangnhap_giang_MouseHover(object sender, EventArgs e)
        {
            btn_dangnhap_giang.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void btn_dangnhap_giang_MouseLeave(object sender, EventArgs e)
        {
            btn_dangnhap_giang.BackColor = Color.FromArgb(224, 224, 224);

        }

        private void btn_thoat_giang_MouseHover(object sender, EventArgs e)
        {
            btn_thoat_giang.BackColor = Color.FromArgb(128, 255, 128);

        }

        private void btn_thoat_giang_MouseLeave(object sender, EventArgs e)
        {
            btn_thoat_giang.BackColor = Color.FromArgb(224, 224, 224);

        }
        #endregion
    }
}
