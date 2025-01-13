namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtNhap.Text);
            lstSo.Items.Add(x);
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            lstSo.Items.RemoveAt(0);
            lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                sum += (int)lstSo.Items[i]; // mặc định trong listbox là các đối tượng nên cần ép kiểu
            }
            MessageBox.Show("Tổng các phần tử là: " + sum);
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            //ta phải luôn kiểm tra xem người sd có đang chọn dòng nào hay không
            /*if (lstSo.SelectedIndex != -1) //Nếu bằng -1 thì ng sd chưa chọn dòng nào
                                           //Nếu !=-1 thì trả về dòng(vị trí) đang chọn
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndex);
            }*/
            while (lstSo.SelectedIndices.Count > 0)  //trả về vị trí các phần tử trên dao diện đang đc chọn
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndices[0]);
                //xóa phần tử thứ 0 trong ds được chọn, lúc này ds sẽ giảm đi 1 và lại xóa phần tử thứ 0 cho đến khi k còn ptu nào
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                lstSo.Items[i] = x + 2;
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x1 = (int)lstSo.Items[i];
                int x2 = (int)Math.Pow(x1, 2);
                // x=x*x;
                //lstSo.Items[i] = x;
                lstSo.Items[i] = x2;
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            //trước khi chọn ta phải bỏ chọn hết các số đang được chọn(chẳng may có cả sô chẵn cả lẻ)
            lstSo.SelectedIndex = -1;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                if (x % 2 == 0)
                    lstSo.SelectedIndex = i;
            }
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                if (x % 2 != 0)
                    lstSo.SelectedIndex = i;
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Muốn thoát à?", "Hỏi thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                Close();
        }
    }
}