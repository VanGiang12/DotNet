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
    public partial class frmTacGia : Form
    {
        private frmHome frmHome;

        frm_tab_QLS frmqls = new frm_tab_QLS();
        private TacGia qlTacGia = new TacGia();

        public frmTacGia(frmHome parentFrmHome)
        {
            InitializeComponent();
            frmHome = parentFrmHome;
            dgvTacGia.DataSource = qlTacGia.getAllTacGia();
            dgvTacGia.Columns[0].HeaderText = "Mã tác giả";
            dgvTacGia.Columns[1].HeaderText = "Tên tác giả";
            dgvTacGia.Columns[2].HeaderText = "Liên hệ";
        }

        public frmTacGia()
        {
            InitializeComponent();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            dgvTacGia.ClearSelection();
            setEnable(false);
        }

        public void clearText()
        {
            txtLienhe.Text = "";
            txtMaTG.Text = "";
            txtTenTG.Text = "";
            dgvTacGia.ClearSelection();
        }

        public void setEnable(bool x)
        {
            txtMaTG.Enabled = x;
            txtTenTG.Enabled = x;
            txtLienhe.Enabled = x;
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTacGia.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvTacGia.SelectedRows[0];
                txtMaTG.Text = row.Cells[0].Value.ToString();
                txtTenTG.Text = row.Cells[1].Value.ToString();
                txtLienhe.Text = row.Cells[2].Value.ToString();
            }
            else
            {
                clearText();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("Thêm"))
            {
                btnThem.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThoat.Text = "Hủy";
                setEnable(true);
            }
            else if (btnThem.Text.Equals("Lưu"))
            {
                string ma = txtMaTG.Text;
                string ten = txtTenTG.Text;
                string lienhe = txtLienhe.Text;
                if (!string.IsNullOrEmpty(lienhe) && !string.IsNullOrEmpty(ma) && !string.IsNullOrEmpty(ten))
                {

                    if (qlTacGia.Insert(new TacGia(ma, ten, lienhe)))
                    {
                        dgvTacGia.DataSource = qlTacGia.getAllTacGia();
                        clearText();
                        btnThem.Text = "Thêm";
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                        btnThoat.Text = "Thoát";
                        setEnable(false);
                        dgvTacGia.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                btnSua.Text = "Lưu";
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnThoat.Text = "Hủy";
                setEnable(true);
            }
            else if (btnSua.Text.Equals("Lưu"))
            {
                string ma = txtMaTG.Text;
                string ten = txtTenTG.Text;
                string lienhe = txtLienhe.Text;
                if (!string.IsNullOrEmpty(lienhe) && !string.IsNullOrEmpty(ma) && !string.IsNullOrEmpty(ten))
                {

                    if (qlTacGia.Update(new TacGia(ma, ten, lienhe)))
                    {
                        dgvTacGia.DataSource = qlTacGia.getAllTacGia();
                        clearText();
                        btnSua.Text = "Sửa";
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnThoat.Text = "Thoát";
                        setEnable(false);
                        dgvTacGia.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Không sửa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvTacGia.SelectedRows.Count > 0)
            {
                if (qlTacGia.Delete(txtMaTG.Text))
                {
                    dgvTacGia.DataSource = qlTacGia.getAllTacGia();
                    clearText();
                }
                else
                {
                    MessageBox.Show("Không xóa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt;
            string sql = "select * from tacgia ";
            if (radMaTG.Checked)
            {
                if (!string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    sql += "where matacgia = @matacgia";
                    dt = qlTacGia.Search(txtTimKiem.Text, sql, "@matacgia");
                    if (dt.Rows.Count > 0)
                    {
                        dgvTacGia.DataSource = dt;
                        txtTimKiem.Clear();
                        dgvTacGia.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Mã không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập mã", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            else if (radTenTG.Checked)
            {
                if (!string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    sql += "where tentacgia like '%'+@tentacgia+'%'";
                    dt = qlTacGia.Search(txtTimKiem.Text, sql, "@tentacgia");
                    if (dt.Rows.Count > 0)
                    {
                        dgvTacGia.DataSource = dt;
                        txtTimKiem.Clear();
                        dgvTacGia.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Tên không tồn tại", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radTatCa.Checked)
            {
                dgvTacGia.DataSource = qlTacGia.getAllTacGia();
                dgvTacGia.ClearSelection();
            }
            else
            {
                MessageBox.Show("Chưa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnThoat.Text.Equals("Hủy"))
            {
                setEnable(false);
                clearText();
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThoat.Text = "Thoát";
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
            }
            else if (btnThoat.Text.Equals("Thoát"))
            {
                frmHome.openChildForm(new frm_tab_QLS(frmHome));
            }
        }

    }
}


