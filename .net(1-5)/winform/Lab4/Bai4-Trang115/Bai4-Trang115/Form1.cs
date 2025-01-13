namespace Bai4_Trang115
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            lstHienThi.Items.Add(txtNhap.Text);
            txtNhap.Text = "";
            txtNhap.Focus();
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstHienThi.Items.Count; i++)
            {
                /*int n = int.Parse(lstHienThi.Items[i].ToString());
                lstHienThi.Items[i] = (n + 2) + "";*/
                if (int.TryParse(lstHienThi.Items[i].ToString(), out int n))
                {
                    lstHienThi.Items[i] = (n + 2) + "";
                }

            }
        }

        private void btnChonChanDau_Click(object sender, EventArgs e)
        {
            int firstnum = -1;
            for (int i = 0; i < lstHienThi.Items.Count; i++)
            {
                if (int.TryParse(lstHienThi.Items[i].ToString(), out int n))
                {
                    if (n % 2 == 0)
                    {
                        firstnum = i;
                        break;
                    }
                }
            }
            if (firstnum != -1)
            {
                lstHienThi.SetSelected(firstnum, true);
            }
            else
            {
                MessageBox.Show("Không có số chẵn", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnChonLeCuoi_Click(object sender, EventArgs e)
        {
            int lastnum = -1;
            for (int i = lstHienThi.Items.Count - 1; i >= 0; i--)
            {
                if (int.TryParse(lstHienThi.Items[i].ToString(), out int n))
                {
                    if (n % 2 != 0)
                    {
                        lastnum = i;
                        break;
                    }
                }
            }
            if (lastnum != -1)
            {
                lstHienThi.SetSelected(lastnum, true);
            }
            else
            {
                MessageBox.Show("Không có số chẵn", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            lstHienThi.Items.Remove(lstHienThi.SelectedItems[0]);
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            lstHienThi.Items.RemoveAt(0);
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            lstHienThi.Items.RemoveAt(lstHienThi.Items.Count - 1);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

