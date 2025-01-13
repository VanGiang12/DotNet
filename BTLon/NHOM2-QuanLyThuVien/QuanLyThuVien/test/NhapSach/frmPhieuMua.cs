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

namespace test.NhapSach
{
    public partial class frmPhieuMua : Form
    {
        private frmHome frmHome;
        public static string laytennxb;
        public static string laymaphieu;
        public Form activeForm = null;

        int count = 0;
        MuaSach muasach = new MuaSach();

        public frmPhieuMua(frmHome parentHome)
        {
            InitializeComponent();
            frmHome = parentHome;
            dgvDSMua.DataSource = muasach.getDS();
            HienThiTenCot();
            setEnable(false);
            btnHuy.Enabled = false;
        }

        public frmPhieuMua()
        {
        }

        public void setEnable(bool enable)
        {
            txtMaPhieuMua.Enabled = enable;
            txtDonViMua.Enabled = enable;
            txtDonViMua.Text = "uneti";
            dtpNgayMua.Enabled = enable;
            txtTenNXB.Enabled = enable;
        }

        public void HienThiTenCot()
        {
            dgvDSMua.Columns[0].HeaderText = "Mã phiếu mua";
            dgvDSMua.Columns[1].HeaderText = "Đơn vị mua";
            dgvDSMua.Columns[2].HeaderText = " Tên nhà xuất bản";
            dgvDSMua.Columns[3].HeaderText = "Ngày mua";
        }

        public void ClearText()
        {
            txtMaPhieuMua.Text = "";
            txtDonViMua.Text = "";
            txtTenNXB.Text = "";
            dtpNgayMua.Value = DateTime.Now;
            dgvDSMua.ClearSelection();
        }

        private void frmPhieuMua_Load(object sender, EventArgs e)
        {
            dgvDSMua.ClearSelection();
        }

        private void dgvDSMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvDSMua.CurrentRow != null)
            {
                txtMaPhieuMua.Text = dgvDSMua.CurrentRow.Cells[0].Value.ToString();
                laymaphieu = txtMaPhieuMua.Text;
                txtDonViMua.Text = dgvDSMua.CurrentRow.Cells[1].Value.ToString();
                txtTenNXB.Text = dgvDSMua.CurrentRow.Cells[2].Value.ToString();
                dtpNgayMua.Text = dgvDSMua.CurrentRow.Cells[3].Value.ToString();
                laytennxb = txtTenNXB.Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MuaSach muaSach = new MuaSach();
            List<string> lst = muaSach.getMaPhieu();
            if (btnThem.Text.Equals("Thêm"))
            {
                setEnable(true);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = true;
                btnThem.Text = "Lưu";
                string maphieu = "MP";
                Random ran = new Random();
                while (true)
                {
                    maphieu += ran.Next(0, 100).ToString("D2");
                    if (!lst.Contains(maphieu))
                    {
                        break;
                    }
                }
                txtMaPhieuMua.Text = maphieu;
            }
            else if (btnThem.Text.Equals("Lưu"))
            {
                // Tạo mã phiếu mua ngẫu nhiên
                /*Random rd = new Random();
                int x = rd.Next(100);
                maphieu = x < 10 ? "MP0" + x : "MP" + x;*/

                // Lấy thông tin từ các điều khiển trên form
                string donvimua = txtDonViMua.Text;
                string manxb = muasach.getMaNXB(txtTenNXB.Text);
                string maphieu = txtMaPhieuMua.Text;
                DateTime ngaymua = dtpNgayMua.Value;

                // Kiểm tra đầu vào
                if (string.IsNullOrWhiteSpace(txtTenNXB.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng MuaSach mới
                MuaSach muaSachMoi = new MuaSach(maphieu, donvimua, manxb, ngaymua);

                // Thêm vào danh sách và kiểm tra kết quả
                if (muasach.them(muaSachMoi))
                {
                    // Cập nhật DataGridView
                    dgvDSMua.DataSource = null; // Xóa nguồn dữ liệu cũ
                    dgvDSMua.DataSource = muasach.getDS(); // Gán nguồn dữ liệu mới
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setEnable(false);
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;
                    btnThem.Text = "Thêm";
                    ClearText();

                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                btnHuy.Enabled = true;
                btnSua.Text = "Lưu";
            }
            else if (btnSua.Text.Equals("Lưu"))
            {
                if (dgvDSMua.SelectedRows.Count != 0)
                {
                    string maphieu = txtMaPhieuMua.Text;
                    //string tennxb = txtTenNXB.Text;
                    string maNXB = muasach.getMaNXB(txtTenNXB.Text);
                    DateTime ngaymua = dtpNgayMua.Value;

                    if (muasach.sua(new(maphieu, txtDonViMua.Text, maNXB, ngaymua)))
                    {
                        dgvDSMua.DataSource = null; // Xóa nguồn dữ liệu cũ
                        dgvDSMua.DataSource = muasach.getDS(); // Gán nguồn dữ liệu mới
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setEnable(false);
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnHuy.Enabled = false;
                        btnSua.Text = "Sửa";
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Chọn dòng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSMua.SelectedCells.Count != 0)
            {
                if (muasach.xoa(txtMaPhieuMua.Text))
                {
                    dgvDSMua.DataSource = null; // Xóa nguồn dữ liệu cũ
                    dgvDSMua.DataSource = muasach.getDS(); // Gán nguồn dữ liệu mới
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chọn dòng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnDatSach_Click(object sender, EventArgs e)
        {
            frmHome.openChildForm(new frmDatSach(frmHome));
        }

        private void txtTenNXB_Leave(object sender, EventArgs e)
        {
            if (count == 0)
            {
                string nxb = txtTenNXB.Text;

                if (muasach.getMaNXB(nxb) != null)
                {
                    // string maNXB = muasach.getMaNXB(nxb);
                    return;
                }
                else
                {
                    DialogResult res = MessageBox.Show("NXB chưa có, hãy thêm thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        new frmThemNXB().ShowDialog();
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            if (MuaSach.DemBanGhi(txtMaPhieuMua.Text) != 0)
            {
                frmXemThongTinDatSach f = new frmXemThongTinDatSach();
                f.Show();
            }
            else
            {
                DialogResult rs = MessageBox.Show("Chưa đặt sách. Bạn muốn đặt không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    frmHome.openChildForm(new frmDatSach(frmHome));
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearText();
            setEnable(false);
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Text = "Thêm";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            MuaSach muaSach = new MuaSach();
            DataTable dt;
            string sql = "select maphieumua, donvimua, nhaxuatban.tennhaxuatban, ngaymua " +
                    "from muasach join nhaxuatban on muasach.manhaxuatban = nhaxuatban.manhaxuatban ";
            sql += "where maphieumua = @maphieumua";
            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                dt = muaSach.timkiem(txtTimKiem.Text, sql, "@maphieumua");
                if (dt.Rows.Count > 0)
                {
                    dgvDSMua.DataSource = dt;
                    dgvDSMua.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Mã không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                dgvDSMua.DataSource = muaSach.getDS();
                dgvDSMua.ClearSelection();
            }
        }
    }
}
