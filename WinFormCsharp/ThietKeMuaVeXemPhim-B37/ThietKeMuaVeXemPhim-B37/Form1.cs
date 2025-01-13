namespace ThietKeMuaVeXemPhim_B37
{
    public partial class Form1 : Form
    {
        List<KhachHang> dskh = new List<KhachHang>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ve100GheLenGiaoDien();
        }

        private void Ve100GheLenGiaoDien()
        {
            pnDatGhe.Controls.Clear();
            int ghe = 1;
            for (int i = 0; i < pnDatGhe.RowCount; i++)//  i< số dòng(10 dòng)
            {
                for (int j = 0; j < pnDatGhe.ColumnCount; j++)//   j<số cột(10 cột)
                {
                    Label lblGhe = new Label();
                    lblGhe.Text = ghe + "";
                    lblGhe.AutoSize = false;
                    lblGhe.Dock = DockStyle.Fill;
                    lblGhe.TextAlign = ContentAlignment.MiddleCenter;
                    lblGhe.Width = lblGhe.Height = 50;  //k có ý nghĩa lắm vì để dock fill r
                    lblGhe.BackColor = Color.White;
                    pnDatGhe.Controls.Add(lblGhe, j, i);
                    ghe++;
                    lblGhe.Click += LblGhe_Click;
                }
            }
        }

        private void LblGhe_Click(object? sender, EventArgs e)
        {
            Label lblGhe = sender as Label;
            if (lblGhe.BackColor == Color.White)
                lblGhe.BackColor = Color.Green;
            else if (lblGhe.BackColor == Color.Green)
                lblGhe.BackColor = Color.White;
            else if (lblGhe.BackColor == Color.Yellow)
                MessageBox.Show("Ghế số [" + lblGhe.Text + "] đã có người chọn rồi");
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            frmThongTinKhach frm = new frmThongTinKhach();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                KhachHang kh = new KhachHang();
                kh.Name = frm.txtHoTen.Text;    //phải để modifine của txtHoTen thành public
                kh.Phone = frm.txtPhone.Text;   //tương tự
                kh.GioDatGhe = DateTime.Now;
                for (int i = 0; i < pnDatGhe.Controls.Count; i++)
                {
                    Label lblGhe = pnDatGhe.Controls[i] as Label;
                    if (lblGhe.BackColor == Color.Green)
                    {
                        lblGhe.BackColor = Color.Yellow;
                        int ghe = int.Parse(lblGhe.Text);
                        kh.Ghes.Add(ghe);
                    }
                }
                lblThanhTien.Text = kh.TinhTien + "VND";
                dskh.Add(kh);
                HienThiTongTien();
                HienThiKHLenListBox();
            }
        }

        private void HienThiKHLenListBox()
        {
            lstDanhSach.Items.Clear();
            foreach (KhachHang i in dskh)
                lstDanhSach.Items.Add(i);
        }

        private void HienThiTongTien()
        {
            int sum = 0;
            foreach (KhachHang i in dskh)
                sum += i.TinhTien;
            lblTongThanhTien.Text = sum + "VND";
        }

        private void lstDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex != -1)
            {
                KhachHang kh = lstDanhSach.SelectedItem as KhachHang;
                lblThanhTien.Text = kh.TinhTien + "VND";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex != -1)
            {
                KhachHang kh = lstDanhSach.SelectedItem as KhachHang;
                //Kiểm tra xem giờ đặt ghế của khách với giờ hiện tại
                //nếu quá 30p thì k cho hủy
                DateTime hientai = DateTime.Now;
                TimeSpan c = hientai - kh.GioDatGhe;
                int tongsogiay = c.Seconds;
                if (tongsogiay < 1800)
                {
                    for (int i = 0; i < pnDatGhe.Controls.Count; i++)
                    {
                        Label lblGhe = pnDatGhe.Controls[i] as Label;   // lấy label ra
                        int maghe = int.Parse(lblGhe.Text); //lấy mã ghế trên label
                        int x = 0;
                        while (kh.Ghes.Count > 0 && x <= kh.Ghes.Count)   //nếu số ghế của khách đặt >0
                        {
                            int ghedat = kh.Ghes[0];    //chạy từ ghế đầu tiên khách đặt
                            if (maghe == ghedat)
                            {
                                lblGhe.BackColor = Color.White; //đổi màu lại
                                kh.Ghes.Remove(ghedat);     //xóa ghế đặt trong list Ghes
                            }
                            x++;
                        }
                    }
                    dskh.Remove(kh);
                    HienThiKHLenListBox();
                    HienThiTongTien();
                }
                else
                    MessageBox.Show("Thời gian hủy không quá 30p");
            }
            else
                MessageBox.Show("Bạn phải chọn khách thì mới được hủy!");
        }
    }
}