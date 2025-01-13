namespace Bai27
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt file | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                textBox1.Text = path;
                //Path.GetFileName(path); trả về đoạn cuối tên file
                listBox1.Items.Add(path);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                string s = listBox1.SelectedItems[0].ToString();
                textBox1.Text = s;

                StreamReader sr = new StreamReader(s);
                textBox2.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Chưa chọn!");
            }
        }
    }
}