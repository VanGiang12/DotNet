namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblDis.Text = "Xin chào " + txtName.Text + "\n" +
                txtMessage.Text;
        }

        private void rdRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRed.Checked)
                lblDis.ForeColor = Color.Red;
        }
        private void rdGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGreen.Checked)
                lblDis.ForeColor = Color.Green;
        }

        private void rdBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBlue.Checked)
                lblDis.ForeColor = Color.Blue;
        }

        private void rdBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBlack.Checked)
                lblDis.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdBlue.Checked = true;
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chBItalic.Checked)
                lblDis.Font = new Font(lblDis.Font,
                    lblDis.Font.Style ^ FontStyle.Italic);
            else
                lblDis.Font = new Font(lblDis.Font,
                     lblDis.Font.Style & ~FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (chBUnderline.Checked)
                lblDis.Font = new Font(lblDis.Font,
                    lblDis.Font.Style ^ FontStyle.Underline);
            else
                lblDis.Font = new Font(lblDis.Font,
                     lblDis.Font.Style & ~FontStyle.Underline);
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chBBold.Checked)
                lblDis.Font = new Font(lblDis.Font,
                    lblDis.Font.Style ^ FontStyle.Bold);
            else
                lblDis.Font = new Font(lblDis.Font,
                     lblDis.Font.Style & ~FontStyle.Bold);
        }

        private void pic2_DoubleClick(object sender, EventArgs e)
        {
            pic2.Visible = false;
            pic1.Visible = true;
        }

        private void pic1_DoubleClick(object sender, EventArgs e)
        {
            pic1.Visible = false;
            pic2.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtMessage.Text = "";
            lblDis.Text = "";
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}