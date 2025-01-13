using QLBanHang.Data.KhachHang;

namespace QLBanHang
{
    public partial class frmKhachHang : Form
    {
        QuanLyKH qlkh;
        KhachHang kh;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtMaKH.Clear();
            txtTenKH.Clear();
            cboGioiTinh.Text = "";
        }

        private void setEnable(bool b)
        {
            txtDiaChi.Enabled = b;
            txtDienThoai.Enabled = b;

            txtTenKH.Enabled = b;
            cboGioiTinh.Enabled = b;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            qlkh = new QuanLyKH();
            setEnable(false);
            txtMaKH.Enabled = false;
            try
            {
                dgvKhachHang.DataSource = qlkh.getAllKhachHang();

                dgvKhachHang.Columns[0].HeaderText = "Mã KH";
                dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
                dgvKhachHang.Columns[2].HeaderText = "Giới tính";
                dgvKhachHang.Columns[3].HeaderText = "Địa chỉ";
                dgvKhachHang.Columns[4].HeaderText = "Điện thoại";

                dgvKhachHang.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }

        }

        private bool Kiemtrasdt(string sdt)
        {
            if (sdt.Length < 10 || sdt.Length > 10) return true;

            if (sdt[0] != '0') return true;
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                setEnable(true);
                txtMaKH.Enabled = true;
                txtMaKH.Focus();
                btnThem.Text = "Lưu";
            }
            else if (btnThem.Text == "Lưu")
            {
                if (string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtTenKH.Text) ||
                string.IsNullOrEmpty(txtDienThoai.Text) || string.IsNullOrEmpty(txtDiaChi.Text)
                || string.IsNullOrEmpty(cboGioiTinh.Text))
                {
                    MessageBox.Show("Nhập chưa đủ thông tin!");
                }
                else
                {
                    if (!Kiemtrasdt(txtDienThoai.Text))
                    {
                        string ma = txtMaKH.Text;
                        string ten = txtTenKH.Text;
                        string diachi = txtDiaChi.Text;
                        string dt = txtDienThoai.Text;
                        string gt = cboGioiTinh.Text;

                        kh = new KhachHang(ma, ten, diachi, gt, dt);
                        if (qlkh.Insert(kh))
                        {
                            dgvKhachHang.DataSource = qlkh.getAllKhachHang();
                            ClearText();
                            txtMaKH.Focus();
                            setEnable(false);
                            txtMaKH.Enabled = false;
                            btnThem.Text = "Thêm";
                        }
                        else
                        {
                            MessageBox.Show("Không chèn được");
                        }
                    }
                    else
                    {
                        MessageBox.Show("số điện thoại k hợp lệ");
                    }

                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                if (btnSua.Text == "Sửa")
                {
                    setEnable(true);

                    btnSua.Text = "Lưu";
                }
                else if (btnSua.Text == "Lưu")
                {

                    if (string.IsNullOrEmpty(txtTenKH.Text) ||
                    string.IsNullOrEmpty(txtDienThoai.Text) || string.IsNullOrEmpty(txtDiaChi.Text)
                    || string.IsNullOrEmpty(cboGioiTinh.Text))
                    {
                        MessageBox.Show("Nhập chưa đủ thông tin!");
                    }
                    else
                    {
                        string ma = txtMaKH.Text;
                        string ten = txtTenKH.Text;
                        string diachi = txtDiaChi.Text;
                        string dt = txtDienThoai.Text;
                        string gt = cboGioiTinh.Text;

                        kh = new KhachHang(ma, ten, diachi, gt, dt);
                        if (qlkh.Update(kh))
                        {
                            dgvKhachHang.DataSource = qlkh.getAllKhachHang();
                            ClearText();
                            dgvKhachHang.ClearSelection();
                            setEnable(false);
                            btnSua.Text = "Sửa";
                        }
                        else
                        {
                            MessageBox.Show("Không sửa được");
                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("Chưa chọn!");
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                txtMaKH.ReadOnly = true;

                int i = dgvKhachHang.CurrentRow.Index;
                txtMaKH.Text = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
                txtTenKH.Text = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
                txtDienThoai.Text = dgvKhachHang.Rows[i].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
                cboGioiTinh.Text = dgvKhachHang.Rows[i].Cells[2].Value.ToString();

                /*DataGridViewRow row = dgvKhachHang.SelectedRows[0];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtDienThoai.Text = row.Cells[4].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                cboGioiTinh.Text = row.Cells[2].Value.ToString();*/
            }
            else
            {
                ClearText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                if (DialogResult.OK == MessageBox.Show("Bạn có muốn xóa những người này không?", "Thông báo", MessageBoxButtons.OKCancel))
                {
                    bool flag = true;

                    foreach (DataGridViewRow row in dgvKhachHang.SelectedRows)
                    {
                        string id = row.Cells[0].Value.ToString();

                        if (!qlkh.Delete(id))
                        {
                            flag = false;
                            MessageBox.Show($"Không thể xóa khách hàng: {id}");
                        }
                    }
                    if (flag)
                    {
                        dgvKhachHang.DataSource = qlkh.getAllKhachHang();
                        ClearText();
                        MessageBox.Show("Xóa thành công.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string id = "";
            if (!string.IsNullOrEmpty(txtMaKH.Text) && !string.IsNullOrEmpty(txtTenKH.Text))
            {
                DialogResult result = MessageBox.Show("Tìm kiếm theo Mã hay Tên(Mã/Tên-Yes/No) ?", "Lựa chọn tìm kiếm", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    id = txtMaKH.Text;
                }
                else if (result == DialogResult.No)
                {
                    id = txtTenKH.Text;
                }
                else
                {
                    return;
                }
            }
            else if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                id = txtTenKH.Text;
            }
            else if (string.IsNullOrEmpty(txtTenKH.Text))
                id = txtMaKH.Text;
            try
            {
                dgvKhachHang.DataSource = qlkh.TimKiem(id);
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}