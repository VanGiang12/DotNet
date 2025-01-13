namespace Cau1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void câu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cau2().ShowDialog();
        }

        private void câu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cau3().ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.D2)
            {
                new Cau2().ShowDialog();
            }
            else if(e.Control && e.KeyCode == Keys.D3)
            {
                new Cau3().ShowDialog();
            }
            else if(e.Alt && e.KeyCode == Keys.X)
            {
                Application.Exit();
            }
        }
    }
}