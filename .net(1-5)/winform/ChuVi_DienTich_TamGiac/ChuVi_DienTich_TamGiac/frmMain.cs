namespace ChuVi_DienTich_TamGiac
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtCanh1.Enabled = true;
            txtCanh2.Enabled = true;
            txtCanh3.Enabled = true;
            groupBox2.Enabled = true;
            txtCanh1.Focus();
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            txtCanh1.Enabled = false;
            txtCanh2.Enabled = false;
            txtCanh3.Enabled = false;
            groupBox2.Enabled = false;
            label5.Visible = false;
        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            return false;
        }
        bool ktra_dulieu()
        {
            double n;
            if (!double.TryParse(txtCanh1.Text, out n) || n < 0)
                return false;
            if (!double.TryParse(txtCanh2.Text, out n) || n < 0)
                return false;
            if (!double.TryParse(txtCanh3.Text, out n) || n < 0)
                return false;
            if (kiemtra(txtCanh1.Text) || kiemtra(txtCanh2.Text) || kiemtra(txtCanh3.Text))
                return false;
            return true;
        }
        bool ktra_tamgiac(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            return false;
        }

        private void rad_DienTich_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad_DienTich_MouseClick(object sender, MouseEventArgs e)
        {
            txtCanh1.Enabled = false;
            txtCanh2.Enabled = false;
            txtCanh3.Enabled = false;
            btnNhap.Enabled = false;
            label5.Visible = true;

            if (ktra_dulieu())
            {
                double a, b, c;
                a = double.Parse(txtCanh1.Text);
                b = double.Parse(txtCanh2.Text);
                c = double.Parse(txtCanh3.Text);
                if (ktra_tamgiac(a, b, c))
                {
                    double p = (a + b + c) / 2;
                    double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    label5.Text = "Kết Quả: Diện tích tam giác là "
                        + s.ToString("F2");
                }
                else
                {
                    DialogResult ret = MessageBox.Show(
                        "Ba cạnh không tạo thành tam giác",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ret == DialogResult.OK)
                    {
                        rad_DienTich.Checked = false;
                        btnNhap.Enabled = true;
                        groupBox2.Enabled = false;
                    }
                }
            }
            else
            {
                DialogResult ret = MessageBox.Show(
                        "Dữ liệu không hợp lệ",
                        "Thông báo", MessageBoxButtons.OK);
                if (ret == DialogResult.OK)
                {
                    rad_DienTich.Checked = false;
                    groupBox2.Enabled = false;
                    btnNhap.Enabled = true;
                }

            }
        }

        private void rad_ChuVi_MouseClick(object sender, MouseEventArgs e)
        {
            txtCanh1.Enabled = false;
            txtCanh2.Enabled = false;
            txtCanh3.Enabled = false;
            btnNhap.Enabled = false;
            label5.Visible = true;

            if (ktra_dulieu())
            {
                double a, b, c;
                a = double.Parse(txtCanh1.Text);
                b = double.Parse(txtCanh2.Text);
                c = double.Parse(txtCanh3.Text);
                if (ktra_tamgiac(a, b, c))
                {
                    double p = (a + b + c);
                    label5.Text = "Kết Quả: Chu vi tam giác là "
                        + p.ToString("F2");
                }
                else
                {
                    DialogResult ret = MessageBox.Show(
                        "Ba cạnh không tạo thành tam giác",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ret == DialogResult.OK)
                    {
                        rad_ChuVi.Checked = false;
                        btnNhap.Enabled = true;
                        groupBox2.Enabled = false;
                    }
                }
            }
            else
            {
                DialogResult ret = MessageBox.Show(
                        "Dữ liệu không hợp lệ",
                        "Thông báo", MessageBoxButtons.OK);
                if (ret == DialogResult.OK)
                {
                    rad_ChuVi.Checked = false;
                    groupBox2.Enabled = false;
                    btnNhap.Enabled = true;
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}