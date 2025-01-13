using QLBanHang.Data.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class frmMatHang : Form
    {
        QuanLyMatHang qlmh;
        public frmMatHang()
        {
            InitializeComponent();
            qlmh = new QuanLyMatHang();
        }

        void loadDL()
        {
            dgvMatHang.DataSource = qlmh.getDS();
        }

        void setEnable(bool b, bool b2)
        {
            txtMaMH.Enabled = b2;
            txtTenMH.Enabled = b;
            txtDVT.Enabled = b;
        }

        void ClearText()
        {
            txtMaMH.ResetText(); txtTenMH.ResetText(); txtDVT.ResetText();
        }

        bool Ktra()
        {
            if (!string.IsNullOrWhiteSpace(txtMaMH.Text)
                && !string.IsNullOrWhiteSpace(txtTenMH.Text)
                && !string.IsNullOrWhiteSpace(txtDVT.Text))
            {
                return true;
            }
            else { return false; }
        }



        private void frmMatHang_Load(object sender, EventArgs e)
        {
            loadDL();

            dgvMatHang.Columns[0].HeaderText = "Mã mặt hàng";
            dgvMatHang.Columns[1].HeaderText = "Tên mặt hàng";
            dgvMatHang.Columns[2].HeaderText = "Đơn vị tính";

            dgvMatHang.ClearSelection();

            setEnable(false, false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                setEnable(true, true);
                txtMaMH.Focus();
                btnThem.Text = "Lưu";
            }
            else if (btnThem.Text == "Lưu")
            {
                if (Ktra())
                {
                    if (qlmh.ktratrung(txtMaMH.Text))
                    {
                        MessageBox.Show("Trùng mã", "Thông báo");
                    }
                    else
                    {
                        qlmh.Them(new MatHang(txtMaMH.Text, txtTenMH.Text, txtDVT.Text));
                        loadDL();
                        setEnable(false, false);
                        ClearText();
                        btnThem.Text = "Thêm";
                    }

                }
                else MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo");
            }
        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMatHang.Rows.Count > 0)
            {
                DataGridViewRow row = dgvMatHang.SelectedRows[0];
                txtMaMH.Text = row.Cells[0].Value.ToString();
                txtTenMH.Text = row.Cells[1].Value.ToString();
                txtDVT.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvMatHang.SelectedRows.Count > 0)
            {
                if (btnSua.Text == "Sửa")
                {
                    setEnable(true, false);
                    txtMaMH.Focus();
                    btnSua.Text = "Lưu";
                }
                else if (btnSua.Text == "Lưu")
                {
                    if (Ktra())
                    {
                        qlmh.Sua(new MatHang(txtMaMH.Text, txtTenMH.Text, txtDVT.Text));
                        loadDL();
                        setEnable(false, false);
                        ClearText();
                        btnSua.Text = "Sửa";
                    }
                    else MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Bạn muốn xóa những mặt hàng này?", "Thông báo", MessageBoxButtons.OKCancel))
            {
                if (dgvMatHang.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow r in dgvMatHang.SelectedRows)
                    {
                        qlmh.Xoa(r.Cells[0].Value.ToString());
                    }
                    loadDL();
                    ClearText();

                }
                else
                {
                    MessageBox.Show("Chưa chọn", "Thông báo");
                }
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (btnTimKiem.Text == "Tìm")
            {
                setEnable(true, true);
                btnTimKiem.Text = "Lưu";
            }
            else if (btnTimKiem.Text == "Lưu")
            {
                if (!string.IsNullOrWhiteSpace(txtMaMH.Text))
                {
                    dgvMatHang.DataSource = qlmh.TimKiem(txtMaMH.Text);
                    setEnable(false, false);
                    btnTimKiem.Text = "Tìm";
                }
                else
                {
                    MessageBox.Show("Chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK);
                }
            }


        }
    }
}
