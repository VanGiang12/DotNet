namespace Bai4_Trang110
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Thông báo");
                txtTen.Focus();
            }
            else
            {
                long total = 0;
                if (chkCaoVoi.Checked)
                {
                    total += 100000;
                }
                if (chkTayRang.Checked)
                {
                    total += 1200000;
                }
                if (chkChupHinh.Checked)
                {
                    total += 200000;
                }
                total += (Convert.ToUInt32(numTramrang.Value)) * 80000;
                txtTong.Text = total.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}