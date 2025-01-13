namespace comboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            string detail = "";
            detail = "Thông tin khách hàng: \n";
            detail += "\nHọ tên khách hàng: \t" + txtTen.Text;
            detail += "\nSDT: \t" + txtSDT.Text;
            detail += "\nSản phẩm mua: \t" + lstSanPham.SelectedItem;
            detail += "\nHình thức thanh toán: \t" + cbThanhToan.SelectedItem;
            txtChiTiet.Text = detail;
        }

        private void cbThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThanhToan.SelectedIndex != -1)
            {
                MessageBox.Show("Bạn chọn hình thức thanh toán" + cbThanhToan.SelectedItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HinhThucThanhToan atm = new HinhThucThanhToan();
            atm.ma = 1;
            atm.hinhThuc = "Chuyển khoản";
            atm.phiThanhToan = 0;
            comboBox1.Items.Add(atm);

            HinhThucThanhToan tructiep = new HinhThucThanhToan();
            tructiep.ma = 2;
            tructiep.hinhThuc = "Thanh toán tại cửa hàng";
            tructiep.phiThanhToan = 0;
            comboBox1.Items.Add(tructiep);

            HinhThucThanhToan traSau = new HinhThucThanhToan();
            traSau.ma = 3;
            traSau.hinhThuc = "Thanh toán sau khi nhận hàng";
            traSau.phiThanhToan = 10;
            comboBox1.Items.Add(traSau);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                HinhThucThanhToan ht = comboBox1.SelectedItem as HinhThucThanhToan;
                MessageBox.Show(ht.ma + " - " + ht.hinhThuc + " => " + ht.phiThanhToan);
            }
        }

        private void txtChiTiet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
