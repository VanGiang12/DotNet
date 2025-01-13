namespace Bai2
{
    public partial class Form1 : Form
    {
        private string currentFilePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra xem có phím Ctrl và phím S được nhấn cùng lúc không
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Ngăn chặn sự kiện mặc định xảy ra khi nhấn Ctrl+S (ví dụ: không di chuyển con trỏ xuống dòng mới)
                e.SuppressKeyPress = true;

                // Tiến hành lưu tập tin
                SaveToFile(currentFilePath);
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                e.SuppressKeyPress = true;
                OpenFileDialog open = new OpenFileDialog();
                DialogResult kq = open.ShowDialog();
                if (kq == DialogResult.OK)
                {
                    StreamReader r = new StreamReader(open.FileName);
                    richTextBox1.Text = r.ReadToEnd();
                    r.Close();
                }
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = currentFilePath;
            }

        }
        private void saveCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    SaveToFile(currentFilePath);
                }
            }
            else
            {
                SaveToFile(currentFilePath);
            }
        }

        private void SaveToFile(string filePath)
        {
            // Kiểm tra xem đã có đường dẫn tập tin hay không
            if (!string.IsNullOrEmpty(filePath))
            {
                using (StreamWriter f = new StreamWriter(filePath, true))
                {
                    foreach (string line in richTextBox1.Lines)
                    {
                        f.WriteLine(line.Trim());
                    }
                }
            }
            else
            {
                // Nếu chưa có đường dẫn tập tin, mở hộp thoại lưu tập tin và lưu đường dẫn của tập tin đã chọn
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    SaveToFile(currentFilePath);
                }
            }
        }


        private void openCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult kq = open.ShowDialog();
            if (kq == DialogResult.OK)
            {
                currentFilePath = open.FileName;
                StreamReader r = new StreamReader(open.FileName);
                richTextBox1.Text = r.ReadToEnd();
                r.Close();
            }
        }

        private void clearCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void exitAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Dùng cho formclose (Control.ModifierKeys & Keys.Alt) == Keys.Alt && e.CloseReason == CloseReason.UserClosing
            if ((e.Modifiers & Keys.Alt) == Keys.Alt && e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}