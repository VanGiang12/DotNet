using Bai1;

namespace DeSo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void câu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau2 c2 = new Cau2();
            c2.Show();

        }

        private void câu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau3 c3 = new Cau3();
            c3.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D2)
            {
                Cau2 c2 = new Cau2();
                c2.Show();
            }
            else if (e.Control && e.KeyCode == Keys.D3)
            {
                Cau3 c3 = new Cau3();
                c3.Show();
            }
            else if (e.Alt && e.KeyCode == Keys.X)
            {
                MessageBox.Show("X");
                //Form1.Close();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}