namespace TinhTong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grLuaChon.Enabled = false;
            lblKetQUa.Enabled = false;
            txtNhap.Focus();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            grLuaChon.Enabled = true;
            radTongn.Checked = false;
            radTong1chiaN.Checked = false;
        }
        //kiểm tra chuỗi rỗng
        bool ktra(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            return false;
        }
        //kiểm tra dl nhập vào
        bool ktra_dulieu()
        {
            int n;
            if (ktra(txtNhap.Text)) //nếu rỗng
                return false;
            if (!int.TryParse(txtNhap.Text, out n) || n <= 0)
                return false;
            return true;
        }

        private void radTongn_CheckedChanged(object sender, EventArgs e)
        {
            if (radTongn.Checked)
            {
                if (ktra_dulieu())
                {
                    int s = 0,r;
                    int n = int.Parse(txtNhap.Text);
                    while (n != 0)
                    {
                        r = n % 10;
                        s += r;
                        n = n / 10;
                    }
                    lblKetQUa.Text = "Tổng từ 1->n là: " + s.ToString();
                    lblKetQUa.Enabled = true;
                }
                else
                {
                    DialogResult ret = MessageBox.Show("Nhập sai dữ liệu", "Thông báo"
                        , MessageBoxButtons.OK);
                    if (ret == DialogResult.OK)
                    {
                        txtNhap.Focus();
                    }
                }
            }
        }

        private void radTong1chiaN_CheckedChanged(object sender, EventArgs e)
        {
            if (radTong1chiaN.Checked)
            {
                if (ktra_dulieu())
                {
                    double s = 0;
                    for (int i = 1; i <= int.Parse(txtNhap.Text); i++)
                    {
                        s += 1.0 / i;
                    }
                    lblKetQUa.Text = "Tổng từ 1->1/n là: " + s.ToString("F2");
                    lblKetQUa.Enabled = true;
                }
                else
                {
                    DialogResult ret = MessageBox.Show("Nhập sai dữ liệu", "Thông báo"
                        , MessageBoxButtons.OK);
                    if (ret == DialogResult.OK)
                    {
                        txtNhap.Focus();
                    }
                }
            }
        }
    }
}