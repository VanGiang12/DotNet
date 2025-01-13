namespace Bai3_Trang114
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Thông báo");
            }
            else
            {
                lstLopA.Items.Add(txtNhap.Text);
                txtNhap.Text = "";
                txtNhap.Focus();
            }
        }

        private void btnLeftRight_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count != 0)
            {
                List<object> selectedItems = new List<object>(lstLopA.SelectedItems.Cast<object>());

                foreach (object obj in selectedItems)
                {
                    lstLopB.Items.Add(obj);
                    lstLopA.Items.Remove(obj);
                }

            }
            else
            {
                MessageBox.Show("Chưa chọn", "Thông báo");
            }
        }

        private void btnRigthLeft_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItems.Count != 0)
            {
                List<object> selectedItems = new List<object>(lstLopB.SelectedItems.Cast<object>());

                foreach (object obj in selectedItems)
                {
                    lstLopA.Items.Add(obj);
                    lstLopB.Items.Remove(obj);
                }

            }
            else
            {
                MessageBox.Show("Chưa chọn", "Thông báo");
            }
        }

        private void btnAllRigthLeft_Click(object sender, EventArgs e)
        {
            lstLopA.Items.AddRange(lstLopB.Items);
            lstLopB.Items.Clear();
        }

        private void btnAllLeftRight_Click(object sender, EventArgs e)
        {
            lstLopB.Items.AddRange(lstLopA.Items);
            lstLopA.Items.Clear();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count != 0)
            {
                List<object> selectedItems = new List<object>(lstLopA.SelectedItems.Cast<object>());

                foreach (object obj in selectedItems)
                {
                    lstLopA.Items.Remove(obj);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn", "Thông báo");
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}