namespace Bai28
{
    public partial class Form1 : Form
    {
        string path = @"D:\myfile\SinhVien.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHoTen.Text) &&
                !string.IsNullOrEmpty(txtMaSo.Text) && !string.IsNullOrEmpty(txtNgaySinh.Text))
            {
                string ma = txtMaSo.Text;
                string ten = txtHoTen.Text;
                string ngaysinh = txtNgaySinh.Text;
                DateTime date;
                string ns;
                if (DateTime.TryParse(ngaysinh, out date))
                {
                    ns = date.ToShortDateString(); 
                    StreamWriter writer = new StreamWriter(path, true);
                    writer.WriteLine($"{ma}\t\t{ten}\t\t{ns}");
                    writer.Close();
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    MessageBox.Show("Ngày không đúng định dạng(mm/dd/yyyy");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            lstHien.Items.Clear();
            StreamReader reader = new StreamReader(path);
            string line;
            while ((line = (reader.ReadLine())) != null && !string.IsNullOrEmpty(line))
            {
                lstHien.Items.Add(line);
            }
            reader.Close();
        }
    }
}