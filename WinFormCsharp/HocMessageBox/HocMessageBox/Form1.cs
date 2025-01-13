namespace HocMessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",   //Câu hỏi
                "Hỏi thoát",                            //Tiêu đề
                MessageBoxButtons.YesNo,                //buttons yes/no
                MessageBoxIcon.Question);               //icon câu hỏi
            if (ret == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello", "tiêu đề 1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello", "Tiêu đề 2", MessageBoxButtons.YesNo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello", "Tiêu đề 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hay không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if(ret == DialogResult.Yes)
            {
                this.Text = "Bạn chọn yes";     //tiêu đề form thay đổi
            }
            else if(ret==DialogResult.No)
            {
                this.Text = "bạn chọn no";
            }
            else if (ret == DialogResult.Cancel)
            {
                this.Text = "bạn chọn cancel";
            }
        }
    }
}