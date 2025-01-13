namespace bai19
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtSo.Text);
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
                sum += (int)lstSo.Items[i];

            }
            MessageBox.Show("Tổng các phần tử = " + sum);
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            // ta phải luôn kiểm tra người dùng có đang chọn dòng nào không
            //if(lstSo.SelectedIndex != -1)
            //{
            //    lstSo.Items.RemoveAt(lstSo.SelectedIndex);
            //}

            while (lstSo.SelectedIndices.Count > 0) // trong khi đang còn được chọn
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndices[0]);
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; ++i)
            {
                int x = (int)lstSo.Items[i];
                lstSo.Items[i] = x + 2;
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                int x2 = (int)Math.Pow(x, 2);
                lstSo.Items[i] = x2;
                //x = x * x;
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            // trước khi chọn số chẵn thì phải bỏ chọn toàn bộ số đã chọn
            // ta dùng lệnh
            lstSo.SelectedIndex = -1; // tự bỏ chọn toàn bộ các dòng

            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                if (x % 2 == 0)
                {
                    lstSo.SelectedIndex = i;

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // trước khi chọn số chẵn thì phải bỏ chọn toàn bộ số đã chọn
            // ta dùng lệnh
            lstSo.SelectedIndex = -1; // tự bỏ chọn toàn bộ các dòng

            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                if (x % 2 != 0)
                {
                    lstSo.SelectedIndex = i;


                }
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}