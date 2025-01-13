namespace DatetimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnĐangKy_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTen, "");  //xóa báo lỗi bên cạnh  
            errorProvider1.SetError(txtTuoi, "");
            errorProvider1.SetError(dtpNgayDangKy, "");
            if (txtTen.Text == "")
            {
                errorProvider1.SetError(txtTen, "Mày chưa nhập tên kìa!!!");
                return; //nếu có lỗi trả về không làm gì cả nếu không sẽ hiện messbox
            }
            int tuoi = 0;
            if (int.TryParse(txtTuoi.Text, out tuoi) == false)    //trả về false nếu không chuyển được về kiểu int
            {
                errorProvider1.SetError(txtTuoi, "Nhập lụi rồi");
                return;
            }
            else
            {
                if (tuoi < 18)
                {
                    errorProvider1.SetError(txtTuoi, "Tuổi phải lớn hơn 17");
                    return;
                }
            }
            if (dtpNgayDangKy.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                errorProvider1.SetError(dtpNgayDangKy, "Chủ nhật không thi");
                return;
            }
            DialogResult ret = MessageBox.Show("Đăng ký thành công!!", "",
                MessageBoxButtons.OK);
            if (ret == DialogResult.OK)
                Close();

        }
    }
}