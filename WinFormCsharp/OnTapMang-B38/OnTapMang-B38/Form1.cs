namespace OnTapMang_B38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] M;
        Random rd = new Random();
        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            M = new int[10];
            txtMangGoc.Text = "";
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = rd.Next(101);
                txtMangGoc.Text += M[i] + "       ";
            }
        }

        private void btnTongMang_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < M.Length; i++)
            {
                sum += M[i];
            }
            txtKetQua.Text = "Tỏng mảng là: " + sum;
        }

        private void btnDemSoLe_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int i in M)
            {
                if (i % 2 != 0)
                    dem++;
            }
            txtKetQua.Text = "Số phần tử lẻ là: " + dem;
        }

        private void btnTongSoLe_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int i in M)
            {
                if (i % 2 != 0)
                    sum += i;
            }
            txtKetQua.Text = "Tổng phần tử lẻ là: " + sum;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int min = M[0];
            for (int i = 1; i < M.Length; i++)
            {
                if (min > M[i])
                    min = M[i];
            }
            txtKetQua.Text = "Min của mảng là: " + min;
        }

        private void btnTangPhanTuLen2_Click(object sender, EventArgs e)
        {
            txtMangGoc.Text = "";
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = M[i] + 2;
                txtMangGoc.Text += M[i] + "       ";
            }
        }

        private void btnSapXepTang_Click(object sender, EventArgs e)
        {
            Array.Sort(M);
            txtMangGoc.Text = "";
            for (int i = 0; i < M.Length; i++)
            {
                txtMangGoc.Text += M[i] + "       ";
            }
        }

        private void btnSapXepGiam_Click(object sender, EventArgs e)
        {
            Array.Sort(M);
            Array.Reverse(M);
            txtMangGoc.Text = "";
            for (int i = 0; i < M.Length; i++)
            {
                txtMangGoc.Text += M[i] + "       ";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Muốn thoát à?","Hỏi Thoát");
        }
    }
}