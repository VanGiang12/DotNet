namespace PictureBox
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if (picOff.Visible == true)     //Visible ẩn hiện(false/true)
            {
                btnOnorOff.Text = txtTen.Text + ".Turn on ";
            }
            else
            {
                btnOnorOff.Text = txtTen.Text + ".Turn off ";
            }
            lblHienthi.Text = txtTen.Text;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            BackColor = Color.Turquoise;
        }

        private void btnOnorOff_Click(object sender, EventArgs e)
        {
            if (picOn.Visible == false)
            {
                picOn.Visible = true;   //hiện ảnh lên
                picOff.Visible = false; //ẩn ảnh đi
                btnOnorOff.Text = btnOnorOff.Text.Replace("on", "off");
            }
            else
            {
                picOn.Visible = false;
                picOff.Visible = true;
                btnOnorOff.Text = btnOnorOff.Text.Replace("off", "on");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Muốn thoát à?",
                "Hỏi thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                Close();
        }


    }
}