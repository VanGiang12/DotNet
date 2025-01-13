namespace Cau2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void open()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "text file| *txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader rd = new StreamReader(fileDialog.FileName);
                richTextBox1.Text = rd.ReadToEnd();
                rd.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(fileDialog.FileName);
                writer.Write(richTextBox1.Text);
                writer.Close();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.O)
            {
                open();
            }
        }
    }
}