namespace QuanLySanPham
{
    public partial class frmSanPham : Form
    {
        public static List<DanhMuc> DanhSachDanhMuc = new List<DanhMuc>();
        public List<SanPham> DanhSachSanPham = new List<SanPham>();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnQuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            frmDanhMuc frmDM = new frmDanhMuc();
            frmDanhMuc.CoThayDoi = false;
            if (frmDM.ShowDialog() == DialogResult.OK)
            {
                HienThiDanhMucComboBox();
            }
        }

        private void HienThiDanhMucComboBox()
        {
            cboDanhMuc.Items.Clear();
            foreach (DanhMuc dm in DanhSachDanhMuc)
            {
                cboDanhMuc.Items.Add(dm);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboDanhMuc.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn danh mục!");
                return;
            }
            DanhMuc dm = cboDanhMuc.SelectedItem as DanhMuc;
            SanPham sp = new SanPham();
            sp.MaSP = txtMa.Text;
            sp.TenSp = txtTen.Text;
            sp.DonGia = double.Parse(txtDonGia.Text);
            sp.XuatXu = txtXuatXu.Text;
            sp.HSD = dtpHanSuDung.Value;
            dm.ThemSanPham(sp);
            DanhSachSanPham.Add(sp);

            HienThiSanPhamListBox();

            txtMa.Text = "";
            txtTen.Text = "";
            txtDonGia.Text = "";
            txtXuatXu.Text = "";
            txtMa.Focus();
        }
        void HienThiSanPhamListBox()
        {
            lstDanhSachSP.Items.Clear();
            foreach (SanPham sp in DanhSachSanPham)
            {
                lstDanhSachSP.Items.Add(sp);
            }
        }

        private void lstDanhSachSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhSachSP.SelectedIndex == -1)
                return;
            SanPham sp = lstDanhSachSP.SelectedItem as SanPham;
            cboDanhMuc.Text = sp.Nhom.TenDM;
            txtMa.Text = sp.MaSP;
            txtTen.Text = sp.TenSp;
            txtDonGia.Text = sp.DonGia + "";    //chuyển thành string
            txtXuatXu.Text = sp.XuatXu;
            dtpHanSuDung.Value = sp.HSD;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstDanhSachSP.SelectedIndex == -1)
                return;
            SanPham sp = lstDanhSachSP.SelectedItem as SanPham;
            DialogResult ret = MessageBox.Show(
                "Chắc chắn muốn xóa?",
                "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                DanhSachSanPham.Remove(sp);
                HienThiSanPhamListBox();
            }
            txtMa.Text = "";
            txtTen.Text = "";
            txtDonGia.Text = "";
            txtXuatXu.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Muốn thoát à?",
                "Hỏi thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                Close();
        }
    }
}