namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pCloudy.Visible = false;
            pRainy.Visible = false;
            pSnow.Visible = false;
            pSunny.Visible = false;
            input.Focus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string s = "";
            if (chBCloudy.Checked)
            {

                pCloudy.Visible = true;
                s += " !Có mây";

            }
            if (chBRainy.Checked)
            {
                pRainy.Visible = true;
                s += " !Có mưa";
            }
            if (chBSnow.Checked)
            {
                pSnow.Visible = true;
                s += " !Có tuyết";
            }
            if (chBSunny.Checked)
            {
                pSunny.Visible = true;
                s += " !Có nắng";
            }
            lbDisplay.Text = input.Text + s;
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text[label1.Text.Length - 1] + label1.Text.Substring(0, label1.Text.Length - 1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Want exit", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (r == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}