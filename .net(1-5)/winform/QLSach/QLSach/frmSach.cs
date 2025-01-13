using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSach
{
    public partial class frmSach : Form
    {
        DataAccess data = new DataAccess();
        public frmSach()
        {
            InitializeComponent();
        }

        void TieuDe()
        {
            dgvDanhSach.Columns[0].HeaderText = "Mã sách";
            dgvDanhSach.Columns[1].HeaderText = "Tên sách";
            dgvDanhSach.Columns[2].HeaderText = "Tên tác giả";
            dgvDanhSach.Columns[3].HeaderText = "Nhà Xuất bản";
            dgvDanhSach.Columns[4].HeaderText = "Năm XB";
            dgvDanhSach.Columns[5].HeaderText = "Số lượng";

        }

        void setEnable(bool b1, bool b2)
        {
            txtMaSach.Enabled = b1;
            txtTenSach.Enabled = b2;
            txtTacGia.Enabled = b2;
            txtNhaXB.Enabled = b2;
            txtNamXB.Enabled = b2;
            txtSoLuong.Enabled = b2;
        }

        void clearText()
        {
            txtMaSach.ResetText();
            txtTenSach.ResetText();
            txtTacGia.ResetText();
            txtNhaXB.ResetText();
            txtNamXB.ResetText();
            txtSoLuong.ResetText();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = data.getDSSach("");
            TieuDe();
            dgvDanhSach.ClearSelection();
            setEnable(false, false);
        }

        bool ktradauvao()
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text)
                || string.IsNullOrEmpty(txtTenSach.Text)
                || string.IsNullOrEmpty(txtTacGia.Text)
                || string.IsNullOrEmpty(txtNhaXB.Text)
                || string.IsNullOrEmpty(txtNamXB.Text)
                || string.IsNullOrEmpty(txtSoLuong.Text))
            {
                return true;
            }
            else return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                setEnable(true, true);
                btnThem.Text = "Lưu";
            }
            else if (btnThem.Text == "Lưu")
            {
                if (!ktradauvao())
                {
                    if (data.ThemSach(new Sach(txtMaSach.Text,
                        txtTenSach.Text,
                        txtTacGia.Text,
                        txtNhaXB.Text,
                        int.Parse(txtNamXB.Text),
                        int.Parse(txtSoLuong.Text))))
                    {
                        dgvDanhSach.DataSource = data.getDSSach("");
                        dgvDanhSach.ClearSelection();
                        setEnable(false, false);
                        btnThem.Text = "Thêm";
                        clearText();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }


                }
                else
                {
                    MessageBox.Show("Dữ liệu chưa đúng");
                }

            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                txtMaSach.Text = dgvDanhSach.SelectedRows[0].Cells[0].Value.ToString();
                txtTenSach.Text = dgvDanhSach.SelectedRows[0].Cells[1].Value.ToString();
                txtTacGia.Text = dgvDanhSach.SelectedRows[0].Cells[2].Value.ToString();
                txtNhaXB.Text = dgvDanhSach.SelectedRows[0].Cells[3].Value.ToString();
                txtNamXB.Text = dgvDanhSach.SelectedRows[0].Cells[4].Value.ToString();
                txtSoLuong.Text = dgvDanhSach.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                setEnable(false, true);
                btnSua.Text = "Lưu";
            }
            else if (btnSua.Text == "Lưu")
            {
                if (!ktradauvao())
                {
                    data.SuaSach(new Sach(txtMaSach.Text,
                        txtTenSach.Text,
                        txtTacGia.Text,
                        txtNhaXB.Text,
                        int.Parse(txtNamXB.Text),
                        int.Parse(txtSoLuong.Text)));

                    dgvDanhSach.DataSource = data.getDSSach("");
                    dgvDanhSach.ClearSelection();
                    setEnable(false, false);
                    btnSua.Text = "Sửa";
                    clearText();
                }
                else
                {
                    MessageBox.Show("Dữ liệu chưa đúng");
                }

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                data.XoaSach(txtMaSach.Text);
                clearText();
                dgvDanhSach.ClearSelection();
            }
            else
            {
                MessageBox.Show("Chưa chọn");
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (btnTimKiem.Text == "Tìm Kiếm")
            {
                txtTenSach.Enabled = true;
                btnTimKiem.Text = "Tìm";
                txtTenSach.Focus();
            }
            else if (btnTimKiem.Text == "Tìm")
            {
                DataTable dt = data.getDSSach($"where TenSach like '%{txtTenSach.Text}%'");
                if (dt.Rows.Count > 0)
                {
                    dgvDanhSach.DataSource = dt;
                    dgvDanhSach.ClearSelection() ;
                    btnTimKiem.Text = "Tìm Kiếm";
                }
                else
                {
                    MessageBox.Show("Không có sách này");
                }
            }

        }
    }
}
