namespace TinhTong_KtraSoNguyenTo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNhap.Text = "";
            lblKetQua.Visible = false;
        }

        bool ktra(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            return false;
        }

        bool ktra_dulieu()
        {
            int n;
            if (ktra(txtNhap.Text)) return false;
            if (!int.TryParse(txtNhap.Text, out n) || n < 0)
                return false;
            return true;
        }
        private void btnTong_Click(object sender, EventArgs e)
        {
            if (ktra_dulieu())
            {
                int n = int.Parse(txtNhap.Text);
                int s = 0;
                for (int i = 1; i <= n; i++)
                {
                    s += i;
                }
                lblKetQua.Text = "Tổng từ 1 đến n là: " + s.ToString();
                lblKetQua.Visible = true;
            }
            else
            {
                DialogResult ret = MessageBox.Show("Dữ liệu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ret == DialogResult.OK)
                {
                    txtNhap.Focus();
                }
            }
        }

        private void btnktrasnt_Click(object sender, EventArgs e)
        {
            if (ktra_dulieu())
            {
                int n = int.Parse(txtNhap.Text);
                int dem = 0;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                        dem++;
                }
                if (dem == 0)
                {
                    string x = txtNhap.Text + " là số nguyên tố";
                    MessageBox.Show(x, "Kết quả", MessageBoxButtons.OK);
                }
                else
                {
                    string x = txtNhap.Text + " không phải là số nguyên tố";
                    MessageBox.Show(x, "Kết quả", MessageBoxButtons.OK);
                }
            }
            else
            {
                DialogResult ret = MessageBox.Show("Dữ liệu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ret == DialogResult.OK)
                {
                    txtNhap.Focus();
                }
            }
        }
    }
}