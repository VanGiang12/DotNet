using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ontap2
{
    public partial class filr : Form
    {
        public filr()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open=new OpenFileDialog();
            open.Filter = "text file |*txt";
            if(open.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr=new StreamReader(open.FileName);
                richTextBox1.Text=sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(save.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }
    }
}
