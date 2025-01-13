namespace Bai21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ktra()
        {
            int n;
            if (string.IsNullOrEmpty(txtNhap.Text)) return false;

            if (!int.TryParse(txtNhap.Text, out n) || n < 0 || n > 1000) return false;
            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (ktra())
            {
                if (!comboBoxCapNhat.Items.Contains(txtNhap.Text)) // nếu k chứa thì mới cho add
                {
                    comboBoxCapNhat.Items.Add(txtNhap.Text);
                }
                else
                {
                    MessageBox.Show("Giá trị đã tồn tại.", "Thông báo");
                    txtNhap.Focus();
                }
                txtNhap.Clear();
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập không đúng", "Thông báo");
                txtNhap.Focus();
            }
        }

        private void comboBoxCapNhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();
            int n;
            if (comboBoxCapNhat.SelectedItem != null)
            {
                n = int.Parse(comboBoxCapNhat.SelectedItem.ToString());

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        listBoxDisplay.Items.Add(i);
                    }
                }

            }
            else
            {
                MessageBox.Show("Chưa chọn sô", "Thông báo");
            }
        }

        private void btnTongUoc_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int n = listBoxDisplay.Items.Count;
            for (int i = 0; i < n; i++)
            {
                sum += int.Parse(listBoxDisplay.Items[i].ToString());
            }
            MessageBox.Show($"Tổng các ước số {sum}", "Thông báo");
        }

        private void btnSoLuongUocSoChan_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int n = listBoxDisplay.Items.Count;
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(listBoxDisplay.Items[i].ToString()) % 2 == 0)
                {
                    sum++;
                }
            }
            MessageBox.Show($"Tổng các ước số chẵn: {sum}", "Thông báo");
        }

        private void btnKtraSoNguyenTo_Click(object sender, EventArgs e)
        {
            if (ktraSoNguyenTo(int.Parse(comboBoxCapNhat.SelectedItem.ToString()))){
                MessageBox.Show("Đây là số nguyên tố", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đây không phải là số nguyên tố", "Thông báo");
            }
        }

        private bool ktraSoNguyenTo(int n)
        {
            int count=0;
            for(int i=2;i < n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if(count == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}