namespace BatPhuongTrinhBac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            if (a == 0)
            {
                if (b < 0)
                    lblKetQua.Text = "Bất phương trình vô số nghiệm";
                else
                    lblKetQua.Text = "Bất phương trình vô nghiệm";
                lblKetQua.Visible = true;
            }
            else
            {
                double x = -b / a;
                lblKetQua.Text = "Nghiệm bất phương trình là x < " + x.ToString("F2");
                lblKetQua.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblKetQua.Visible = false;
            btnGiai.Enabled = false;
        }
        bool ktra(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            return false;
        }
        bool ktra_dulieu()
        {
            double n;
            if (ktra(txtA.Text) || ktra(txtB.Text))
                return false;
            if (!double.TryParse(txtA.Text, out n))
                return false;
            if (!double.TryParse(txtB.Text, out n))
                return false;
            return true;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (ktra_dulieu())
            {
                DialogResult ret = MessageBox.Show("Dữ liệu hợp lệ", "Thông báo", MessageBoxButtons.OK);
                if (ret == DialogResult.OK)
                {
                    btnGiai.Enabled = true;
                    btnKiemTra.Enabled = false;
                }
            }
            else
            {
                DialogResult ret = MessageBox.Show("Dữ liệu chưa hợp lệ", "Thông báo", MessageBoxButtons.OK);
                if (ret == DialogResult.OK)
                {
                    txtA.Focus();
                }
            }
        }
    }
}