namespace Tim_UCLN_BCNN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNhap1.Enabled = false;
            txtNhap2.Enabled = false;
            btnBCNN.Enabled = false;
            btnUCLN.Enabled = false;
            txtInUCLN.Enabled = false;
            txtInBCNN.Enabled = false;
        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            return false;
        }
        bool kiemtra_dulieu()
        {
            int n;
            if (kiemtra(txtNhap1.Text) || kiemtra(txtNhap2.Text))
                return false;
            if (!int.TryParse(txtNhap1.Text, out n) || n < 0)
                return false;
            if (!int.TryParse(txtNhap2.Text, out n) || n < 0)
                return false;
            return true;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtNhap1.Enabled = true;
            txtNhap2.Enabled = true;
            btnBCNN.Enabled = true;
            btnUCLN.Enabled = true;
            txtNhap1.Focus();
        }
        int ucln(int a, int b)
        {
            if (a == b)
                return a;
            else
            {
                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
                return a;
            }
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            btnNhap.Enabled = false;
            if (kiemtra_dulieu())
            {
                txtInUCLN.Text = ucln(int.Parse(txtNhap1.Text), int.Parse(txtNhap2.Text)).ToString();
            }
            else MessageBox.Show("nhập sai dữ liệu", "Thông báo");
        }

        private void btnBCNN_Click(object sender, EventArgs e)
        {
            btnNhap.Enabled = false;
            if (kiemtra_dulieu())
            {
                int s1 = ucln(int.Parse(txtNhap1.Text), int.Parse(txtNhap2.Text));
                int s2 = (int.Parse(txtNhap1.Text) * int.Parse(txtNhap2.Text)) / s1;
                txtInBCNN.Text = s2.ToString();
            }
            else MessageBox.Show("nhập sai dữ liệu", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}