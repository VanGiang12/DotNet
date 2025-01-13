namespace bai20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbChonNhom.Text = "Nhóm 1";
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "")
            {
                //if(cbChonNhom.text=="Nhóm 1")
                if (cbChonNhom.SelectedIndex != -1)
                {
                    if (cbChonNhom.SelectedItem.ToString() == "Nhóm 1")
                    {
                        lstNhom1.Items.Add(txtTen.Text);
                        txtTen.Text = "";
                        txtTen.Focus();
                    }
                    else
                    {
                        lstNhom2.Items.Add(txtTen.Text);
                        txtTen.Text = "";
                        txtTen.Focus();
                    }
                }
                else
                    MessageBox.Show("Bạn chưa chọn nhóm");
            }
            else
                MessageBox.Show("Bạn chưa nhập tên");
            txtTen.Text = "";
            txtTongNhom1.Text = "Tổng số: " + lstNhom1.Items.Count;
            txtTongNhom2.Text = "Tổng số: " + lstNhom2.Items.Count;

        }

        private void btnMove1Right_Click(object sender, EventArgs e)
        {
            if (lstNhom1.SelectedItem != null)
            {
                lstNhom2.Items.Add(lstNhom1.SelectedItem);
                lstNhom1.Items.RemoveAt(lstNhom1.SelectedIndex);

                txtTongNhom1.Text = "Tổng số: " + lstNhom1.Items.Count;
                txtTongNhom2.Text = "Tổng số: " + lstNhom2.Items.Count;
            }

        }

        private void btnMove1Left_Click(object sender, EventArgs e)
        {
            if (lstNhom2.SelectedItem != null)
            {
                lstNhom1.Items.Add(lstNhom2.SelectedItem);
                lstNhom2.Items.RemoveAt(lstNhom2.SelectedIndex);

                txtTongNhom1.Text = "Tổng số: " + lstNhom1.Items.Count;
                txtTongNhom2.Text = "Tổng số: " + lstNhom2.Items.Count;
            }
        }

        private void btnMoveAllRight_Click(object sender, EventArgs e)
        {
            /*for(int i = 0; i < lstNhom1.Items.Count; i++)
            {
                lstNhom2.Items.Add(lstNhom1.Items[i]);
                lstNhom1.Items.RemoveAt(i);
            }*/

            lstNhom2.Items.AddRange(lstNhom1.Items);
            lstNhom1.Items.Clear();

            txtTongNhom1.Text = "Tổng số: " + lstNhom1.Items.Count;
            txtTongNhom2.Text = "Tổng số: " + lstNhom2.Items.Count;
        }


        private void btnMoveAllLeft_Click(object sender, EventArgs e)
        {
            lstNhom1.Items.AddRange(lstNhom2.Items);
            lstNhom2.Items.Clear();

            txtTongNhom1.Text = "Tổng số: " + lstNhom1.Items.Count;
            txtTongNhom2.Text = "Tổng số: " + lstNhom2.Items.Count;
        }



        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            while (lstNhom1.SelectedItem != null)
            {
                lstNhom1.Items.Remove(lstNhom1.SelectedItems[0]);

            }
            while (lstNhom2.SelectedItem != null)
            {
                lstNhom2.Items.RemoveAt(lstNhom2.SelectedIndex);
            }
            txtTongNhom1.Text = "Tổng số: " + lstNhom1.Items.Count;
            txtTongNhom2.Text = "Tổng số: " + lstNhom2.Items.Count;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}