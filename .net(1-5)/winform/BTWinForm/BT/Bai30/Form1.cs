namespace Bai30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void EnableButton()
        {
            btnDemKTHoa.Enabled = false;
            btnDemKTThuong.Enabled = false;
            btnDemSoTu.Enabled = false;
            btnInChuHoa.Enabled = false;
            btnInChuThuong.Enabled = false;
            btnInPhuAmNguyenAm.Enabled = false;
            btnInTu1Dong.Enabled = false;
            btnXoaChuoi.Enabled = false;
            btnXoaKTTrangThua.Enabled = false;
        }
        public void DisEnableButton()
        {
            btnDemKTHoa.Enabled = true;
            btnDemKTThuong.Enabled = true;
            btnDemSoTu.Enabled = true;
            btnInChuHoa.Enabled = true;
            btnInChuThuong.Enabled = true;
            btnInPhuAmNguyenAm.Enabled = true;
            btnInTu1Dong.Enabled = true;
            btnXoaChuoi.Enabled = true;
            btnXoaKTTrangThua.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            DisEnableButton();
            txtNhap.Focus();
        }

        private void btnInChuHoa_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            string s = "";
            EnableButton();
            char[] chars = txtNhap.Text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (Char.IsUpper(chars[i]))
                    s += chars[i] + " ";
            }
            txtKQ.Text = "Chữ in hoa là: " + s;
        }

        private void btnInChuThuong_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            //string s = "";
            string s = txtNhap.Text;
            EnableButton();
            //char[] chars = txtNhap.Text.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLower(s[i]))
                    txtKQ.Text += s[i] + "";
                //if (Char.IsLower(chars[i]))
                //s += chars[i] + " ";
            }
            // txtKQ.Text = "Chữ in thường là: " + s;
        }

        private void btnDemKTThuong_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            int count = 0;
            EnableButton();
            char[] chars = txtNhap.Text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (Char.IsLower(chars[i]))
                    count++;
            }
            txtKQ.Text = "Số ký tự thường là: " + count;
        }

        private void btnDemKTHoa_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            int count = 0;
            EnableButton();
            string s = txtNhap.Text;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                    count++;
            }
            txtKQ.Text = "Số ký tự hoa là: " + count;
        }

        private void btnInTu1Dong_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            EnableButton();
            string[] s = txtNhap.Text.Trim().Split(' ');
            for (int i = 0; i < s.Length; i++)
            {
                txtKQ.AppendText(s[i] + "\r\n" /*+Environment.NewLine*/);
            }
        }

        private void btnDemSoTu_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            EnableButton();
            string[] s = txtNhap.Text.Trim().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            txtKQ.Text = "Số từ: " + s.Length;
        }

        private void btnInPhuAmNguyenAm_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            EnableButton();
            char[] chars = { 'u', 'e', 'o', 'a', 'i' };
            string s = txtNhap.Text.Trim();
            string nguyenam = "", phuam = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (Char.Equals(chars[j], s[i]))
                        nguyenam += s[i] + " ";
                    else
                        phuam += s[i] + "";
                }
            }
            txtKQ.Text += "Nguyên âm: " + nguyenam + "\r\n" + "Phụ âm: " + phuam;
        }

        private void btnXoaKTTrangThua_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            string s = txtNhap.Text.Trim();
            string[] tachs = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            char[] newword = tachs[0].ToCharArray();
            newword[0] = Char.ToUpper(newword[0]);
            string Newword=new string(newword);
            txtKQ.Text= Newword+" ";
            for(int i=1; i<tachs.Length; i++)
            {
                tachs[i]= tachs[i].ToLower();
                txtKQ.AppendText(tachs[i]+" ");
            }
        }
    }
}