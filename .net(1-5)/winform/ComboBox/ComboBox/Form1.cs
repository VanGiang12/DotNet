namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtChitiet.Text = "\nThông tin khách hàng:" +
                "\nKhách hàng: " + txtTen.Text +
                "\nPhone: " + txtPhone.Text +
                "\nSản phẩm mua: " + lstSanPham.SelectedItem +
                "\nHình thức thanh toán: " + cboThanhtoan.SelectedItem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HinhThucThanhToan atm = new HinhThucThanhToan();
            atm.Ma = 1;
            atm.HinhThuc = "Chuyển qua ATM";
            atm.PhiThanhToan = 0;
            comboBox1.Items.Add(atm);

            HinhThucThanhToan tructiep = new HinhThucThanhToan();
            tructiep.Ma = 2;
            tructiep.HinhThuc = "Trả tại cửa hàng";
            tructiep.PhiThanhToan = 0;
            comboBox1.Items.Add(tructiep);

            HinhThucThanhToan trasau = new HinhThucThanhToan();
            trasau.Ma = 3;
            trasau.HinhThuc = "Thanh toán khi nhận hàng";
            trasau.PhiThanhToan = 10;
            comboBox1.Items.Add(trasau);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                HinhThucThanhToan ht = comboBox1.SelectedItem as HinhThucThanhToan;
                MessageBox.Show(ht.Ma + "-" + ht.HinhThuc + "=>" + ht.PhiThanhToan);
            }
        }
    }
}