namespace DeSo2
{
    public partial class Cau1 : Form
    {
        public Cau1()
        {
            InitializeComponent();
        }

        private void câu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau2 cau2 = new Cau2();
            cau2.Show();
        }

        private void câu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau3 cau3 = new Cau3();
            cau3.Show();
        }

        private void câu2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cau2 cau2 = new Cau2();
            cau2.Show();
        }

        private void câu3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cau3 cau3 = new Cau3();
            cau3.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cau1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.D2)
            {
                Cau2 cau2 = new Cau2();
                cau2.Show();
            }
            else if(e.Control && e.KeyCode == Keys.D3)
            {
                Cau3 cau3 = new Cau3();
                cau3.Show();
            }
            else if (e.Alt && e.KeyCode == Keys.X)
            {
                MessageBox.Show("X");
                //Form1.Close();
            }
        }
    }
}