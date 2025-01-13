namespace Bai5_Trang115
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                richTextBox1.Font = new Font("Times New Roman", 9);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                richTextBox1.Font = new Font("Arial", 9);
            }
            else
            {
                richTextBox1.Font = new Font("Tahoma", 9);
            }
        }
    }
}