namespace Bai1_2_Trang113
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "Bạn đã chọn Website \r\n";
            if (lstWeb.Items.Count != 0)
            {
                txtKetQua.Text +=   lstWeb.SelectedItem;
            }
            if(cboWeb.Items.Count != 0)
            {
                txtKetQua.Text +=  cboWeb.SelectedItem;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "";
        }
    }
}