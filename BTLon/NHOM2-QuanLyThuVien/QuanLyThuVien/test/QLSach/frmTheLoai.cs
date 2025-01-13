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

namespace test
{
    public partial class frmTheLoai : Form
    {
        private frmHome frmHome;
        private TheLoai qltheloai = new TheLoai();
        public frmTheLoai(frmHome parent)
        {
            InitializeComponent();
            frmHome = parent;
            dgvHienThi.DataSource = qltheloai.getDS();
            dgvHienThi.Columns[0].HeaderText = "Mã thể loại";
            dgvHienThi.Columns[1].HeaderText = "Tên thể loại";
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            dgvHienThi.ClearSelection();
            setEnable(false);
        }

        private void clearText()
        {
            txtMaTheLoai.Clear();
            txtTenTheLoai.Clear();
            dgvHienThi.ClearSelection();
        }

        private void setEnable(bool enable)
        {
            txtTenTheLoai.Enabled = enable;
            txtMaTheLoai.Enabled = enable;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("Thêm"))
            {
                setEnable(true);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnHienThi.Enabled = false;
                btnThem.Text = "Lưu";
                btnThoat.Text = "Hủy";
            }
            else if (btnThem.Text.Equals("Lưu"))
            {
                string matheloai = txtMaTheLoai.Text;
                string tentheloai = txtTenTheLoai.Text;
                if (!string.IsNullOrEmpty(matheloai) && !string.IsNullOrEmpty(tentheloai))
                {
                    if (qltheloai.them(new TheLoai(matheloai, tentheloai)))
                    {
                        dgvHienThi.DataSource = qltheloai.getDS();
                        setEnable(false);
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                        btnHienThi.Enabled = true;
                        btnThem.Text = "Thêm";
                        btnThoat.Text = "Thoát";
                        clearText();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("Sửa"))
            {
                setEnable(true);
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnHienThi.Enabled = false;
                btnSua.Text = "Lưu";
                btnThoat.Text = "Hủy";
            }
            else if (btnSua.Text.Equals("Lưu"))
            {
                string matheloai = txtMaTheLoai.Text;
                string tentheloai = txtTenTheLoai.Text;
                if (!string.IsNullOrEmpty(matheloai) && !string.IsNullOrEmpty(tentheloai))
                {
                    if (qltheloai.sua(new TheLoai(matheloai, tentheloai)))
                    {
                        dgvHienThi.DataSource = qltheloai.getDS();
                        setEnable(false);
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnHienThi.Enabled = true;
                        btnSua.Text = "Sửa";
                        btnThoat.Text = "Thoát";
                        clearText();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count > 0)
            {
                if (qltheloai.xoa(txtMaTheLoai.Text))
                {
                    dgvHienThi.DataSource = qltheloai.getDS();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvHienThi.SelectedRows[0];
                txtMaTheLoai.Text = row.Cells[0].Value.ToString();
                txtTenTheLoai.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dt;
            string sql = "select * from theloai ";
            if (radMaTheLoai.Checked)
            {
                if (string.IsNullOrEmpty(txtTim.Text))
                {
                    MessageBox.Show("Nhập mã thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    sql += "where matheloai = @matheloai";
                    dt = qltheloai.timKiem(txtTim.Text, sql, "@matheloai");
                    if (dt.Rows.Count > 0)
                    {
                        dgvHienThi.DataSource = dt;
                        dgvHienThi.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Mã không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (radTenTheLoai.Checked)
            {
                if (string.IsNullOrEmpty(txtTim.Text))
                {
                    MessageBox.Show("Nhập tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    sql += "where tentheloai like '%' + @tentheloai + '%'";
                    dt = qltheloai.timKiem(txtTim.Text, sql, "@tentheloai");
                    if (dt.Rows.Count > 0)
                    {
                        dgvHienThi.DataSource = dt;
                        dgvHienThi.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Tên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvHienThi.DataSource = qltheloai.getDS();
            dgvHienThi.ClearSelection();
            clearText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnThoat.Text.Equals("Hủy"))
            {
                clearText();
                setEnable(false);
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHienThi.Enabled = true;
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnThoat.Text = "Thoát";

            }
            else if (btnThoat.Text.Equals("Thoát"))
            {
                frmHome.openChildForm(new frm_tab_QLS(frmHome));
            }
        }
    }
}
