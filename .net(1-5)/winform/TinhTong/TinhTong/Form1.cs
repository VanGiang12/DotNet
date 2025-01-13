namespace TinhTong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhap.Text);
            long s = 0;
            for (int i = 0; i <= n; i++)
            {
                s += i;
            }
            txtTong.Text = s.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}