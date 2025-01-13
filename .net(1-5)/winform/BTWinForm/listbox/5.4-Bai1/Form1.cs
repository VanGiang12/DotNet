namespace _5._4_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "" && txtDiaChi.Text != "")
            {
                if (lstDiemDi.SelectedItems != null && cbDiemDen.SelectedIndex != -1)
                {
                    txtDetail.Clear();
                    txtDetail.Text += "\nKhách hàng: " + txtTen.Text + '\n';
                    txtDetail.Text += "Ngày sinh: " + ngaySinh.Value.Day + "/" + ngaySinh.Value.Month + "/" + ngaySinh.Value.Year + "\n";
                    txtDetail.Text += "Địa chỉ: " + txtDiaChi.Text + "\n";
                    txtDetail.Text += "Địa điểm xuất phát: " + lstDiemDi.SelectedItem + "\n";
                    txtDetail.Text += "Điểm đến: " + cbDiemDen.SelectedItem + "\n";
                    DateTime ngayDi = ngay2.Value;
                    DateTime ngayVe = ngay3.Value;

                    if (ngayVe >= ngayDi)
                    {
                        txtDemNgay.Text = ngayVe.Subtract(ngayDi).Days.ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Chọn đầy đủ điểm khởi hành, xuất phát");
                }
            }
            else
            {
                MessageBox.Show("Nhập đủ thông tin");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTen.Clear();
            txtDiaChi.Clear();
            txtDetail.Clear();
            txtDemNgay.Clear();
            txtTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
