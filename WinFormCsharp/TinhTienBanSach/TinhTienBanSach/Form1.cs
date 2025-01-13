namespace TinhTienBanSach
{
    public partial class Form1 : Form
    {
        DanhSachKhachHang dskh = new DanhSachKhachHang();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Ten = txtTen.Text;
            errorProvider1.SetError(txtTen, "");
            errorProvider1.SetError(txtSoLuong, "");

            if (txtTen.Text == "")
            {
                errorProvider1.SetError(txtTen, "Chưa nhập tên");
                return;
            }
            
            kh.SoLuong = int.Parse(txtSoLuong.Text);
            if (int.Parse(txtSoLuong.Text) < 0)
            {
                errorProvider1.SetError(txtSoLuong, "Số lượng phải >=0");
                return;
            }
            kh.LaSinhVien = chkSV.Checked;
            dskh.Mua(kh);   //thêm khách hàng vào dskh
            txtThanhTien.Text = kh.TinhTien + "";
            
            
        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
            chkSV.Checked = false;
            txtTen.Focus();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            txtTongDoanhThu.Text = dskh.TongDoanhDu + "";
            txtTongKH.Text = dskh.TongSoKH + "";
            txtTongSV.Text = dskh.TongSoKHSV + "";
        }

        private void txtTongKH_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form frmKH = new Form();    //tạo 1 form mới
            frmKH.Width = frmKH.Height = 300;   //độ rộng cao của form
            frmKH.Text = "Danh sách KH";
            ListBox lstKH = new ListBox();  //tạo 1 listbox mới
            frmKH.Controls.Add(lstKH);  //thêm listbox vô control
            lstKH.Dock = DockStyle.Fill;    //cho màn listbox full màn control
            foreach (KhachHang kh in dskh.KhachS)    //duyệt trong dskh
            {
                lstKH.Items.Add(kh.Ten);    //thêm vào listbox
            }
            frmKH.StartPosition = FormStartPosition.CenterScreen;
            frmKH.Show();
        }

        private void txtTongSV_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtTongSV_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Form frmKH = new Form();    //tạo 1 form mới
            frmKH.Width = frmKH.Height = 300;   //độ rộng cao của form
            frmKH.Text = "Danh sách KH là SV";
            ListBox lstKH = new ListBox();  //tạo 1 listbox mới
            frmKH.Controls.Add(lstKH);  //thêm listbox vô control
            lstKH.Dock = DockStyle.Fill;    //cho màn listbox full màn control
            foreach (KhachHang kh in dskh.KhachS)    //duyệt trong dskh
            {
                if (kh.LaSinhVien)
                    lstKH.Items.Add(kh.Ten);    //thêm vào listbox
            }
            frmKH.StartPosition = FormStartPosition.CenterScreen;
            frmKH.Show();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Muốn thoát à?",
                "Hỏi thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                Close();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}