namespace B1_Trang1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLot_Click(object sender, EventArgs e)
        {
            lblLot.Text = txtLot.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblTen.Text = txtTen.Text;
        }

        private void btnHVT_Click(object sender, EventArgs e)
        {
            lblHVT.Text = txtLot.Text + " " + txtTen.Text;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}