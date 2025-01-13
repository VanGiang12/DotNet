namespace NhanDangBanPhim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            for (int i = 48; i < 58; i++)
            {
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 48; i < 58; i++)
            {
                if (e.KeyChar == i)
                {
                    lbl0.ForeColor = Color.Red;
                    lbl1.ForeColor = Color.Red;

                }
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = 48; i < 58; i++)
            {
                if (e.KeyValue == i)
                {
                    lbl0.ForeColor = Color.Red;
                    lbl1.ForeColor = Color.Red;

                }
            }
        }
    }
}