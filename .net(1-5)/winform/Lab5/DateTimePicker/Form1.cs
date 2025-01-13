namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if(txtQue.Text!="" && txtTen.Text != "")
            {
                if(dtpNamSinh.Value.Year > (2024 - 18))
                {
                    MessageBox.Show("Chỉ được đăng kí khi đủ 18 tuổi", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đăng kí thành công","Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                txtTen.Focus();
            }
        }
    }
}