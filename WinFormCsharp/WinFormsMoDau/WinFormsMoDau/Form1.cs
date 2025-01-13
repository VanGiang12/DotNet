namespace WinFormsMoDau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            this.Text = "xanh rồi";
        }

        private void thoát_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("muốn thoát ư");
        }
    }
}