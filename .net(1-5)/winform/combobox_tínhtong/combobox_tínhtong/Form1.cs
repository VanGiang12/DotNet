namespace combobox_tínhtong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboPhepToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSo1.Text == "" || txtSo2.Text == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Thông báo");
                txtSo1.Focus();
            }
            else
            {
                double tong, hieu, tich, thuong;
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                int sl = cboPhepToan.SelectedIndex;
                switch (sl)
                {
                    case 0:
                        {
                            txtKetQua.Text = (so1 + so2).ToString();
                        }
                        break;
                    case 1:
                        {
                            txtKetQua.Text = (so1 - so2).ToString();
                        }
                        break;
                    case 2:
                        {
                            txtKetQua.Text = (so1 * so2).ToString();
                        }
                        break;
                    case 3:
                        {
                            if (so2 != 0)
                                txtKetQua.Text = (so1 / so2).ToString();
                            else
                            {
                                MessageBox.Show("Không chia được cho 0", "Thông báo");
                                txtSo2.Focus();
                            }
                        }
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}