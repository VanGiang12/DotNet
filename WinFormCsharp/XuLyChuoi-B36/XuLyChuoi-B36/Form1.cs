namespace XuLyChuoi_B36
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSoKyTuChuoi_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = txtDuLieuGoc.Text.Length + "";
        }

        private void btnInHoa_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = txtDuLieuGoc.Text.ToUpper();
        }

        private void btnInThuong_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = txtDuLieuGoc.Text.ToLower();
        }

        private void btnDemInHoa_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            int dem = 0;
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                    dem++;
            }
            txtKetQua.Text = "Có " + dem + " ký tự in hoa";
        }

        private void btnDemInThuong_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            int dem = 0;
            foreach (char c in s)
            {
                if (char.IsLower(c))
                    dem++;
            }
            txtKetQua.Text = "Có " + dem + " ký tự in thường";
        }

        private void btnDemKyTuSo_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            int dem = 0;
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                    dem++;
            }
            txtKetQua.Text = "Có " + dem + " ký tự là số";
        }

        private void btnDaoChuoi_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            List<char> s2 = s.Reverse().ToList();
            txtKetQua.Text = "";
            foreach (char c in s2)
                txtKetQua.Text += c;
        }

        private void btnToiUuChuoi_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text.Trim();    //xóa khoảng trắng dư thừa bên trái và phải
            string[] arr = s.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            //tách theo ký tự khoảng trắng mỗi từ chỉ có 1 ký tự
            //khoảng trắng nếu nhiều hơn thì xóa đi
            string s1 = "";
            for (int i = 0; i < arr.Length; i++)
            {
                string word = arr[i];
                word = word.ToLower();
                char[] newword = word.ToCharArray();
                newword[0] = char.ToUpper(newword[0]);
                string Newword = new string(newword);
                s1 += Newword + " ";
            }
            txtKetQua.Text = s1.Trim();  //Xóa ký tự trắng cuối cùng khi nối
        }

        private void btnTimViTriXuatHienDauTien_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            int i = 0;
            i = s.IndexOf(txtVTXuatHienDauTien.Text);
            txtKetQua.Text = "Vị trí đầu tiên mà ký tự [" +
                txtVTXuatHienDauTien.Text +
                "] xuất hiện là: " + i.ToString();
            txtVTXuatHienDauTien.Text = "";
        }

        private void btnTimViTriXuatHienCuoiCung_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            int i = 0;
            i = s.LastIndexOf(txtVTXuatHienCuoiCung.Text);
            txtKetQua.Text = "Vị trí cuối cùng mà ký tự [" +
                txtVTXuatHienCuoiCung.Text +
                "] xuất hiện là: " + i.ToString();
            txtVTXuatHienCuoiCung.Text = "";
        }

        private void btnDemSoLanXuatHien_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            int dem = 0;
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == char.Parse(txtDemSoLanXuatHien.Text))
                    dem++;
            }
            txtKetQua.Text = "Ký tự [" + txtDemSoLanXuatHien.Text + "] xuất hiện " + dem + " lần";
            txtDemSoLanXuatHien.Text = "";
        }

        private void btnTachTu_Click(object sender, EventArgs e)
        {
            char[] arrKT = txtTachTu.Text.ToCharArray();
            string[] arrWord = txtDuLieuGoc.Text.Split(arrKT);
            txtKetQua.Text = " ";
            foreach (string s in arrWord)
                txtKetQua.Text += s + "\r\n";
            // \r đưa con trỏ chuột về đầu dòng nhưng k xuống dòng
            // \n xuống dòng nhưng con trỏ chuột k về đầu dòng
        }

        private void btnThayChuoiCon_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            txtKetQua.Text = s.Replace(txtChuoiCu.Text, txtChuoiMoi.Text);
        }

        private void btnXoaChuoiCon_Click(object sender, EventArgs e)
        {
            /*int vt = txtDuLieuGoc.Text.IndexOf(txtXoaChuoiCon.Text);
            
            if (vt != -1)
            {
                string s = txtDuLieuGoc.Text;
                s=s.Remove(vt, txtXoaChuoiCon.Text.Length);
                txtKetQua.Text = s;
            }*/
            string s = txtDuLieuGoc.Text;
            string[] arr = s.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            string s1 = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == txtXoaChuoiCon.Text)
                {

                    arr[i] = arr[i].Replace(arr[i], "");
                }
                s1 += arr[i] + " ";
            }
            txtKetQua.Text = s1.Trim();
        }

        private void btnChenChuoi_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            s = s.Insert(int.Parse(txtChenChuoiTaiVT.Text), txtChenChuoi.Text);
            txtKetQua.Text = s;
        }

        private void btnTrichLoc_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Muốn thoát à?",
                "Hỏi thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            e.Cancel = (ret == DialogResult.No);
        }
    }
}