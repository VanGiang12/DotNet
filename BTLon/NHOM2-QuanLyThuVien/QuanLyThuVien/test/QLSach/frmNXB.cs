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
    public partial class frmNXB : Form
    {
        private frmHome frmHome;
        private NhaXuatBan qlNXB = new NhaXuatBan();
        public frmNXB(frmHome parent)
        {
            InitializeComponent();
            dgvHienThi.DataSource = qlNXB.getDS();
            dgvHienThi.Columns[0].HeaderText = "Mã nhà xuẩt bản";
            dgvHienThi.Columns[1].HeaderText = "Tên nhà xuẩt bản";
            dgvHienThi.Columns[2].HeaderText = "Liên hệ";
            frmHome = parent;
        }
        private void frmNXB_Load(object sender, EventArgs e)
        {
            dgvHienThi.ClearSelection();
            setEnable(false);
        }

        private void clearText()
        {
            txtMaNXB.Clear();
            txtTenNXB.Clear();
            txtLienHe.Clear();
            dgvHienThi.ClearSelection();
        }

        private void setEnable(bool enable)
        {
            txtMaNXB.Enabled = enable;
            txtTenNXB.Enabled = enable;
            txtLienHe.Enabled = enable;
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
                string manxb = txtMaNXB.Text;
                string tennxb = txtTenNXB.Text;
                string lienhe = txtLienHe.Text;
                if (!string.IsNullOrEmpty(manxb) && !string.IsNullOrEmpty(tennxb) && !string.IsNullOrEmpty(lienhe))
                {
                    if (qlNXB.them(new NhaXuatBan(manxb, tennxb, lienhe)))
                    {
                        dgvHienThi.DataSource = qlNXB.getDS();
                        setEnable(false);
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                        btnHienThi.Enabled = true;
                        btnThem.Text = "Thêm";
                        btnThoat.Text = "Thoát";
                        clearText();
                    }
                    else
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string manxb = txtMaNXB.Text;
                string tennxb = txtTenNXB.Text;
                string lienhe = txtLienHe.Text;
                if (!string.IsNullOrEmpty(manxb) && !string.IsNullOrEmpty(tennxb) && !string.IsNullOrEmpty(lienhe))
                {
                    if (qlNXB.sua(new NhaXuatBan(manxb, tennxb, lienhe)))
                    {
                        dgvHienThi.DataSource = qlNXB.getDS();
                        setEnable(false);
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnHienThi.Enabled = true;
                        btnSua.Text = "Sửa";
                        btnThoat.Text = "Thoát";
                        clearText();
                    }
                    else
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (qlNXB.xoa(txtMaNXB.Text))
                {
                    dgvHienThi.DataSource = qlNXB.getDS();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Chưa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvHienThi.SelectedRows[0];
                txtMaNXB.Text = row.Cells[0].Value.ToString();
                txtTenNXB.Text = row.Cells[1].Value.ToString();
                txtLienHe.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt;
            string sql = "select * from nhaxuatban ";
            if (radMaNXB.Checked)
            {
                if (string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    MessageBox.Show("Nhập mã nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    sql += "where manhaxuatban = @manhaxuatban";
                    dt = qlNXB.timKiem(txtTimKiem.Text, sql, "@manhaxuatban");
                    if (dt.Rows.Count > 0)
                    {
                        dgvHienThi.DataSource = dt;
                        txtTimKiem.Clear();
                        dgvHienThi.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Mã không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (radTenNXB.Checked)
            {
                if (string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    MessageBox.Show("Nhập tên nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    sql += "where tennhaxuatban like '%' + @tennhaxuatban + '%'";
                    dt = qlNXB.timKiem(txtTimKiem.Text, sql, "@tennhaxuatban");
                    if (dt.Rows.Count > 0)
                    {
                        dgvHienThi.DataSource = dt;
                        txtTimKiem.Clear();
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
            dgvHienThi.DataSource = qlNXB.getDS();
            dgvHienThi.ClearSelection();
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
