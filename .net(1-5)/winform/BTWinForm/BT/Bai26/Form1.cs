using System.IO;
namespace Bai26
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
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "TXT File| *.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                path = openFile.FileName.ToString();
                textBox1.Text = path;
            }

            StreamReader sr = new StreamReader(path);
            textBox2.Text = sr.ReadToEnd();
            sr.Close();
        }


    }
}