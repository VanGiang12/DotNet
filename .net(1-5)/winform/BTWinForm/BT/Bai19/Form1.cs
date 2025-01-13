namespace Bai19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ThemPhanTu()
        {
            string key = txtSo.Text.Trim();
            if (lstDaySo.Items.IndexOf(key) < 0)
            {
                lstDaySo.Items.Add(key);
                txtSo.Text = "";
                txtSo.Focus();
            }
            else
            {
                MessageBox.Show("Phần tử " + key + " đã có trong danh sách!",
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo.SelectAll();
                txtSo.Focus();
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ThemPhanTu();
        }

        private void txtSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ThemPhanTu();
        }

        private void btnTongDS_Click(object sender, EventArgs e)
        {
            long s = 0;
            //cách 1
            //for (int i = 0; i < lstDaySo.Items.Count; i++)
            //    s = s + long.Parse(lstDaySo.Items[i].ToString());
            //txtSo.Text = "Tổng = " + s;

            //cách 2
            foreach (var item in lstDaySo.Items)
                s = s + long.Parse(item.ToString());
            txtSo.Text = "Tổng = " + s;
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            if (lstDaySo.Items.Count > 0)
                lstDaySo.Items.RemoveAt(0);

            if (lstDaySo.Items.Count > 0)
                lstDaySo.Items.RemoveAt(lstDaySo.Items.Count - 1);
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            lstDaySo.Items.Remove(lstDaySo.SelectedItem);
        }

        private void btnXoaChonALL_Click(object sender, EventArgs e)
        {
            while (lstDaySo.SelectedItems.Count > 0)
            {
                lstDaySo.Items.Remove(lstDaySo.SelectedItems[0]);
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDaySo.Items.Count; i++)
            {
                long v = long.Parse(lstDaySo.Items[i].ToString());
                v = v + 2;
                lstDaySo.Items[i] = v.ToString();
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDaySo.Items.Count; i++)
            {
                long v = long.Parse(lstDaySo.Items[i].ToString());
                v = v * v;
                lstDaySo.Items[i] = v.ToString();
            }
        }
        private void btnChonSoChan_Click(object sender, EventArgs e)
        {
            lstDaySo.SelectedItems.Clear();
            for (int i = 0; i < lstDaySo.Items.Count; i++)
            {
                long v = long.Parse(lstDaySo.Items[i].ToString());
                if (v % 2 == 0)
                    lstDaySo.SelectedItems.Add(lstDaySo.Items[i]);

            }
        }

        private void btnChonSoLe_Click(object sender, EventArgs e)
        {
            lstDaySo.SelectedItems.Clear();
            for (int i = 0; i < lstDaySo.Items.Count; i++)
            {
                long v = long.Parse(lstDaySo.Items[i].ToString());
                if (v % 2 == 1)
                    lstDaySo.SelectedItems.Add(lstDaySo.Items[i]);

            }
        }

    }
}