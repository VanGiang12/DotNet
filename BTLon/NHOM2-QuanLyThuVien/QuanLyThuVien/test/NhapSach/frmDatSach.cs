using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using test.Model;

namespace test.NhapSach
{
    public partial class frmDatSach : Form
    {
        private frmHome frmHome;
        MuaSach muaSach = new MuaSach();
        public string laymadat = "";
        public frmDatSach(frmHome parent)
        {
            InitializeComponent();
            frmHome = parent;
        }

        public void Title()
        {
            dgvDSMua.Columns[0].HeaderText = "Mã đặt";
            dgvDSMua.Columns[1].Visible = false;
            dgvDSMua.Columns[2].HeaderText = "Mã sách";
            dgvDSMua.Columns[3].HeaderText = "Tên sách";
            dgvDSMua.Columns[4].HeaderText = "Số lượng";
        }
        public void ClearText()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtSoLuong.Text = "";
            dgvDSMua.ClearSelection();
        }
        
        public void HideText(bool x)
        {
            txtMaSach.Enabled = x;
            txtTenSach.Enabled = x;
            txtSoLuong.Enabled = x;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MuaSach muaSach = new MuaSach();
            List<string> lst = muaSach.getDSMaDat();
            if (btnThem.Text.Equals("Thêm"))
            {
                btnThem.Text = "Lưu";
                btnDat.Text = "Hủy";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                HideText(true);
                string madat = "MD";
                Random ran = new Random();
                while (true)
                {
                    madat += ran.Next(0, 100).ToString("D2");
                    if (!lst.Contains(madat))
                    {
                        break;
                    }
                }
                laymadat = madat;
            }
            else if (btnThem.Text.Equals("Lưu"))
            {
                String maSach = txtMaSach.Text;
                String maPhieuMua = frmPhieuMua.laymaphieu;
                String tenSach = txtTenSach.Text;
                int soLuong = int.Parse(txtSoLuong.Text);

                if (muaSach.themSach(laymadat, maSach, maPhieuMua, tenSach, soLuong))
                {
                    dgvDSMua.DataSource = muaSach.getDSDatSach();
                    HideText(false);
                    ClearText();
                    btnThem.Text = "Thêm";
                    btnDat.Text = "Đặt";
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmDatSach_Load(object sender, EventArgs e)
        {
            dgvDSMua.DataSource = muaSach.getDSDatSach();
            Title();
            dgvDSMua.ClearSelection();
            txtNXB.Text = frmPhieuMua.laytennxb;
            txtNXB.Enabled = false;
            HideText(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSMua.SelectedCells.Count > 0)
            {
                if (btnSua.Text.Equals("Sửa"))
                {
                    HideText(true);
                    btnSua.Text = "Lưu";
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                    btnDat.Text = "Hủy";
                }
                else if (btnSua.Text.Equals("Lưu"))
                {
                    String masach = txtMaSach.Text;
                    String maphieumua = frmPhieuMua.laymaphieu;
                    String tensach = txtTenSach.Text;
                    int soluong = int.Parse(txtSoLuong.Text);
                    if (muaSach.suaSach(laymadat, masach, maphieumua, tensach, soluong))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDSMua.DataSource = muaSach.getDSDatSach();
                        HideText(false);
                        ClearText();
                        btnSua.Text = "Sửa";
                        btnDat.Text = "Đặt";
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvDSMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSMua.CurrentRow != null)
            {
                if (dgvDSMua.CurrentRow.Cells[0].Value != null)
                {
                    laymadat = dgvDSMua.CurrentRow.Cells["madat"].Value.ToString();
                }
                if (dgvDSMua.CurrentRow.Cells[1].Value != null)
                {
                    txtMaSach.Text = dgvDSMua.CurrentRow.Cells["masach"].Value.ToString();
                }
                if (dgvDSMua.CurrentRow.Cells[2].Value != null)
                {
                    txtTenSach.Text = dgvDSMua.CurrentRow.Cells["tensach"].Value.ToString();
                }
                if (dgvDSMua.CurrentRow.Cells[3].Value != null)
                {
                    txtSoLuong.Text = dgvDSMua.CurrentRow.Cells["soluong"].Value.ToString();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSMua.SelectedCells.Count > 0)
            {
                String madat = laymadat.ToString();
                if (btnXoa.Text.Equals("Xóa"))
                {
                    if (muaSach.xoaSach(madat))
                    {
                        dgvDSMua.DataSource = muaSach.getDSDatSach();
                        ClearText();
                        HideText(false);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            if (btnDat.Text.Equals("Đặt"))
            {
                if ((dgvDSMua.Rows.Count - 1) > 0)
                {
                    MessageBox.Show("Đặt sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmHome.openChildForm(new frmPhieuMua(frmHome));
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Chưa đặt sách. Bạn muốn đặt không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.No)
                    {
                        frmHome.openChildForm(new frmPhieuMua(frmHome));
                    }
                }

                // quay về phiếu
            }
            else if (btnDat.Text.Equals("Hủy"))
            {
                ClearText();
                btnDat.Text = "Đặt";
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Text = "Xóa";
                btnDat.Text = "Đặt";
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            
        }
    }
}
