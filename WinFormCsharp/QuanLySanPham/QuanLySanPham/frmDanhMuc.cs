using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPham
{
    public partial class frmDanhMuc : Form
    {
        public static bool CoThayDoi = false;
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnLuuDM_Click(object sender, EventArgs e)
        {
            DanhMuc dm = new DanhMuc();
            dm.MaDM = txtMaDM.Text;
            dm.TenDM = txtTenDM.Text;
            frmSanPham.DanhSachDanhMuc.Add(dm);
            HienThiDanhMucListBox();

            txtMaDM.Text = "";
            txtTenDM.Text = "";
            txtMaDM.Focus();    //trỏ con trỏ tại mã
            CoThayDoi = true;
        }
        void HienThiDanhMucListBox()
        {
            lstDanhMuc.Items.Clear();
            foreach (DanhMuc dm in frmSanPham.DanhSachDanhMuc)
            {
                lstDanhMuc.Items.Add(dm);
            }
        }

        private void lstDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedIndex != -1)
            {
                DanhMuc dm = lstDanhMuc.SelectedItem as DanhMuc;
                txtMaDM.Text = dm.MaDM;
                txtTenDM.Text = dm.TenDM;
            }
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedIndex != -1)
            {
                DanhMuc dm = lstDanhMuc.SelectedItem as DanhMuc;
                DialogResult ret = MessageBox.Show("Bạn chắc chắn muốn xóa?", "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    lstDanhMuc.Items.Remove(dm);    //xóa ở listDanhMuc
                    frmSanPham.DanhSachDanhMuc.Remove(dm);  //xóa ở dsdanhmuc
                }
                txtMaDM.Text = "";
                txtTenDM.Text = "";
                CoThayDoi = true;
            }
        }

        private void btnThoatDM_Click(object sender, EventArgs e)
        {
            if (CoThayDoi == true)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            HienThiDanhMucListBox();
        }
    }
}
