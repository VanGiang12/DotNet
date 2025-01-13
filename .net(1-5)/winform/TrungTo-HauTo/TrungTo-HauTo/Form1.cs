namespace TrungTo_HauTo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnChuyenHauTo.Enabled = false;
            rtxtTrungto.Focus();
        }

        private void rtxtTrungto_TextChanged(object sender, EventArgs e)
        {
            btnChuyenHauTo.Enabled = true;
        }
    }
}