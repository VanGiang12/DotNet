namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ẽitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            font();
        }
        void font()
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
                richTextBox1.ForeColor = fontDialog.Color;
            }
        }
        void open()
        {
            OpenFileDialog openFile=new OpenFileDialog();
            openFile.Filter = "text file|*.txt";
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFile.FileName);
                richTextBox1.Text=sr.ReadToEnd();
                sr.Close();
            }
            #region
            /*
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text file (*.txt)| *.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }*/
            #endregion
        }
        void save()
        {
            SaveFileDialog saveFile=new SaveFileDialog();
            if(saveFile.ShowDialog()==DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFile.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
            #region
            /*
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.Write(richTextBox1.Text);
                streamWriter.Close();
            }*/
            #endregion
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            open();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            font();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}