using Microsoft.VisualBasic;
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
    public partial class frmMuonSach : Form
    {
        public frmMuonSach()
        {
            InitializeComponent();
            loadData();
            dgvDSMuonTra.Columns[0].HeaderText = "Mã phiếu";
            dgvDSMuonTra.Columns[1].HeaderText = "Tên độc giả";
            dgvDSMuonTra.Columns[2].HeaderText = "Số thẻ";
            dgvDSMuonTra.Columns[3].HeaderText = "Tên sách";
            dgvDSMuonTra.Columns[4].HeaderText = "Số lượng mượn";
            dgvDSMuonTra.Columns[5].HeaderText = "Ngày mượn";
            dgvDSMuonTra.Columns[6].HeaderText = "Ngày hẹn trả";
            dgvDSMuonTra.Columns[7].HeaderText = "Ngày trả";
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            addNameReader();
            addItemCode();
            addItemName();
            setEnable(false, false);
            dgvDSMuonTra.ClearSelection();
            // btnXoa.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void loadData()
        {
            dgvDSMuonTra.DataSource = MuonTra.getborrowPay();
            dgvDSMuonTra.ClearSelection();
        }

        private void addItemCode()
        {
            cboMaSach.Items.Clear();
            var item = MuonTra.getCodeBook();
            foreach (var masach in item)
            {
                cboMaSach.Items.Add(masach);
            }
        }

        private void addItemName()
        {
            var name = MuonTra.getNameBook();
            foreach (var tensach in name)
            {
                cboTenSach.Items.Add(tensach);
            }
        }

        private void addNameReader()
        {
            var name = MuonTra.getNameReader();
            foreach (var ten in name)
            {
                cboTenDocGia.Items.Add(ten);
            }
        }

        private void setEnable(bool enable, bool enable_2)
        {
            txtMaPhieuMuon.Enabled = enable;
            txtSoThe.Enabled = enable;
            cboTenDocGia.Enabled = enable;
            txtSLMuon.Enabled = enable;
            dtpNgayMuon.Enabled = enable;
            dtpNgayHenTra.Enabled = enable;
            dtpNgayTra.Enabled = enable_2;
        }

        private void clearText()
        {
            txtMaPhieuMuon.Clear();
            txtSoThe.Clear();
            cboTenDocGia.Text = "";
            txtSLMuon.Clear();
            dtpNgayMuon.Text = DateTime.Now.ToString();
            dtpNgayHenTra.Text = DateTime.Now.ToString();
            dtpNgayTra.Text = DateTime.Now.ToString();
        }

        private void dgvDSMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSMuonTra.CurrentRow != null)
            {

                txtMaPhieuMuon.Text = dgvDSMuonTra.CurrentRow.Cells[0].Value.ToString();
                txtSoThe.Text = dgvDSMuonTra.CurrentRow.Cells["sothe"].Value.ToString();
                string ten = dgvDSMuonTra.CurrentRow.Cells["ten"].Value.ToString();
                int index = cboTenDocGia.FindStringExact(ten);
                if (index != -1)
                {
                    cboTenDocGia.SelectedIndex = index;
                }
                txtSLMuon.Text = dgvDSMuonTra.CurrentRow.Cells["soluongmuon"].Value.ToString();
                dtpNgayMuon.Value = Convert.ToDateTime(dgvDSMuonTra.CurrentRow.Cells["ngaymuon"].Value);
                dtpNgayHenTra.Value = Convert.ToDateTime(dgvDSMuonTra.CurrentRow.Cells["ngayhentra"].Value);
                Object ngaytra = dgvDSMuonTra.CurrentRow.Cells["ngaytra"].Value;
                if (ngaytra == DBNull.Value)
                {
                    btnTra.Enabled = true;
                    dtpNgayTra.Value = DateTime.Today;
                }
                else
                {
                    dtpNgayTra.Value = Convert.ToDateTime(ngaytra);
                    btnTra.Enabled = false;
                }
                string tensach = dgvDSMuonTra.CurrentRow.Cells["tensach"].Value.ToString();
                int index1 = cboTenSach.FindStringExact(tensach);
                if (index1 != -1)
                {
                    cboTenSach.SelectedIndex = index1;

                }
            }
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            if (btnMuon.Text.Equals("Mượn"))
            {
                setEnable(true, false);
                txtSLMuon.Enabled = true;
                dtpNgayMuon.Enabled = true;
                dtpNgayHenTra.Enabled = true;
                btnMuon.Text = "Lưu";
                btnTra.Enabled = false;
                btnSua.Enabled = false;
                btnHuy.Enabled = true;
            }
            else if (btnMuon.Text.Equals("Lưu"))
            {
                string maphieu = txtMaPhieuMuon.Text;
                int sl = int.Parse(txtSLMuon.Text);
                DateTime ngaymuon = dtpNgayMuon.Value.Date;
                DateTime ngayhentra = dtpNgayHenTra.Value.Date;
                string madocgia = MuonTra.getMaDocGia(txtSoThe.Text);
                string masach = cboMaSach.Text;

                if (sl > int.Parse(txtSLCon.Text))
                {
                    MessageBox.Show("Số lượng mượn không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    MuonTra.muon(maphieu, madocgia, masach, sl, ngaymuon, ngayhentra);
                    loadData();
                    //cập nhật lại sl sách trong kho
                    int sl1 = int.Parse(txtSLCon.Text) - int.Parse(txtSLMuon.Text);
                    MuonTra.updateSLSach(sl1, cboMaSach.Text);
                    txtSLCon.Text = sl1.ToString();


                    clearText();
                    setEnable(false, false);
                    txtSLCon.Clear();
                    txtTenTacGia.Clear();
                    cboMaSach.SelectedIndex = -1;
                    cboTenSach.SelectedIndex = -1;
                    btnMuon.Text = "Mượn";
                    btnTra.Enabled = true;
                    btnSua.Enabled = true;
                    btnHuy.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (btnTra.Text.Equals("Trả"))
            {
                setEnable(false, true);
                btnTra.Text = "Lưu";
                btnMuon.Enabled = false;
                btnSua.Enabled = false;
                btnHuy.Enabled = true;
            }
            else if (btnTra.Text.Equals("Lưu"))
            {
                string ma = txtMaPhieuMuon.Text;
                DateTime ngaytras = dtpNgayTra.Value;

                MuonTra.Update(ma, ngaytras);
                loadData();
                //cập nhật lại sl sách trong kho
                int sl1 = int.Parse(txtSLCon.Text) + int.Parse(txtSLMuon.Text);
                MuonTra.updateSLSach(sl1, cboMaSach.Text);
                txtSLCon.Text = sl1.ToString();

                setEnable(false, false);
                clearText();
                txtSLCon.Clear();
                txtTenTacGia.Clear();
                cboMaSach.SelectedIndex = -1;
                cboTenSach.SelectedIndex = -1;

                btnTra.Text = "Trả";
                btnMuon.Enabled = true;
                btnSua.Enabled = true;
                dtpNgayTra.Enabled = false;
                btnHuy.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("Sửa"))
            {
                txtSLMuon.Enabled = true;
                dtpNgayMuon.Enabled = true;
                dtpNgayHenTra.Enabled = true;
                btnSua.Text = "Lưu";
                btnTra.Enabled = false;
                btnMuon.Enabled = false;
                btnHuy.Enabled = true;
            }
            else if (btnSua.Text.Equals("Lưu"))
            {
                string ma = txtMaPhieuMuon.Text;
                int sl = int.Parse(txtSLMuon.Text);
                DateTime ngaymuon = dtpNgayMuon.Value.Date;
                DateTime ngayhentra = dtpNgayHenTra.Value.Date;

                if (sl > int.Parse(txtSLCon.Text))
                {
                    MessageBox.Show("Số lượng mượn không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MuonTra.sua(ma, sl, ngaymuon, ngayhentra);
                loadData();


                clearText();
                setEnable(false, false);
                txtSLCon.Clear();
                txtTenTacGia.Clear();
                cboMaSach.SelectedIndex = -1;
                cboTenSach.SelectedIndex = -1;
                btnSua.Text = "Sửa";
                btnTra.Enabled = true;
                btnMuon.Enabled = true;
                btnHuy.Enabled = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tk = txtTimKiem.Text;

            dgvDSMuonTra.DataSource = MuonTra.search(tk);
            dgvDSMuonTra.ClearSelection();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string map = txtMaPhieuMuon.Text;
            MuonTra.Delete(map);
            loadData();
        }

        private void cboMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaSach.SelectedIndex != -1)
            {
                string ma = cboMaSach.SelectedItem.ToString();

                var sach = MuonTra.getInformationBook(ma);
                if (sach != null)
                {
                    cboTenSach.SelectedItem = sach.tens.ToString();
                    txtSLCon.Text = sach.sl.ToString();
                    txtTenTacGia.Text = sach.tentg.ToString();
                }
            }
        }

        private void cboTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenSach.SelectedIndex != -1)
            {
                string ten = cboTenSach.SelectedItem.ToString();

                var tsach = MuonTra.getNameBook(ten);
                if (tsach != null)
                {
                    cboMaSach.SelectedItem = tsach.ms.ToString();
                    txtSLCon.Text = tsach.sl.ToString();
                    txtTenTacGia.Text = tsach.tentg.ToString();
                }
            }
        }

        private void cboTenDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenDocGia.SelectedIndex != -1)
            {
                string tendg = cboTenDocGia.SelectedItem.ToString();
                var tdg = MuonTra.getsoThe(tendg);
                if (tdg != null)
                {
                    txtSoThe.Text = tdg.st.ToString();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            clearText();
            setEnable(false, false);
            btnHuy.Enabled = false;
            btnMuon.Enabled = true;
            btnTra.Enabled = true;
            btnSua.Enabled = true;
            btnMuon.Text = "Mượn";
            btnSua.Text = "Sửa";
            txtSLCon.Clear();
            txtTenTacGia.Clear();
            cboMaSach.SelectedIndex = -1;
            cboTenSach.SelectedIndex = -1;
        }
    }
}
