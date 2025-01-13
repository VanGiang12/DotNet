namespace HoaDonBanXe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DanSachKhachHang dskh = new DanSachKhachHang();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.HoTen = txtHoTen.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.Phone = txtPhone.Text;
            kh.Thue = 2;
            kh.GiaTien = int.Parse(txtGiaTien.Text);
            kh.MuaXeDen = rdBtnMauDen.Checked;
            kh.MuaXeMauKhac = rdBtnMauKhac.Checked;
            if (kh.MuaXeDen)
            {
                txtPhuThu.Text = 5 + "%";
                txtThue.Text = 200 + "%";
                kh.PhuThu = 0.05;
                txtThanhTien.Text = kh.ThanhTien + "VND";
            }
            else if (kh.MuaXeMauKhac)
            {
                txtPhuThu.Text = 0 + "%";
                txtThue.Text = 200 + "%";
                kh.PhuThu = 0;
                txtThanhTien.Text = kh.ThanhTien + "VND";
            }
            dskh.Mua(kh);
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtPhone.Text = "";
            txtGiaTien.Text = "";
            txtPhuThu.Text = "";
            txtThue.Text = "";
            txtThanhTien.Text = "";
            rdBtnMauDen.Checked = false;
            rdBtnMauKhac.Checked = false;
            txtHoTen.Focus();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            lblTongKhachHang.Text = dskh.TongSoSoKH + " khách hàng";
            lblTongDoanhThu.Text = dskh.TongDoanhThu + "VNĐ";
            lblTongKhachHangMuaXeDen.Text = dskh.TongSoKHMuaXeDen + " khách hàng";
        }

        private void lblTongKhachHang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form frmKH = new Form();    //tạo 1 form
            frmKH.Width = frmKH.Height = 300;
            frmKH.Text = "Tổng số khách hàng";
            ListBox lstKH = new ListBox();  //tạo 1 listbox
            frmKH.Controls.Add(lstKH);      //add vô form
            lstKH.Dock = DockStyle.Fill;
            foreach (KhachHang i in dskh.Khachs)    //dskh.Khachs:trả về list dsKH
            {
                lstKH.Items.Add(i.HoTen);
            }
            frmKH.StartPosition = FormStartPosition.CenterScreen;
            frmKH.Show();
        }

        private void lblTongKhachHangMuaXeDen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form frmKH = new Form();
            frmKH.Width = frmKH.Height = 300;
            frmKH.Text = "Tổng số khách hàng mua xe đen";
            ListBox lstKH = new ListBox();
            frmKH.Controls.Add(lstKH);
            lstKH.Dock = DockStyle.Fill;
            foreach (KhachHang i in dskh.Khachs)
            {
                if(i.MuaXeDen)
                lstKH.Items.Add(i.HoTen);
            }
            frmKH.StartPosition = FormStartPosition.CenterScreen;
            frmKH.Show();
        }
    }
}