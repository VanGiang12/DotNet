namespace quanLySanPham
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnQuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            frmDanhMuc frmDM = new frmDanhMuc();
            if (frmDM.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
