namespace QLSach
{
    public partial class Form1 : Form
    {
        DataAccess data = new DataAccess();
        public Form1()
        {
            InitializeComponent();
        }

        void TieuDe()
        {
            dgvDanhSach.Columns[0].HeaderText = "Mã độc giả";
            dgvDanhSach.Columns[1].HeaderText = "Tên độc giả";
            dgvDanhSach.Columns[2].HeaderText = "Cơ quan";
            dgvDanhSach.Columns[3].HeaderText = "Địa chỉ";
            dgvDanhSach.Columns[4].HeaderText = "Tel";

        }

        void setEnable(bool b1, bool b2)
        {
            txtMa.Enabled = b1;
            txtTen.Enabled = b2;
            txtDiaCHi.Enabled = b2;
            txtCoQuan.Enabled = b2;
            txtSDT.Enabled = b2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = data.getDSDocGia("");
            TieuDe();
            dgvDanhSach.ClearSelection();
            setEnable(false, false);
        }

        void clearText()
        {
            txtMa.ResetText();
            txtTen.ResetText();
            txtCoQuan.ResetText();
            txtDiaCHi.ResetText();
            txtSDT.ResetText();
        }

        bool ktradauvao()
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text)
                || string.IsNullOrEmpty(txtTen.Text)
                || string.IsNullOrEmpty(txtCoQuan.Text)
                || string.IsNullOrEmpty(txtDiaCHi.Text)
                || string.IsNullOrEmpty(txtSDT.Text))
            {
                return true;
            }
            else return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                setEnable(true, true);
                btnThem.Text = "Lưu";
            }
            else if (btnThem.Text == "Lưu")
            {
                if (!ktradauvao())
                {
                    if (data.ThemDG(new DocGia(txtMa.Text,
                        txtTen.Text,
                        txtCoQuan.Text,
                        txtDiaCHi.Text,
                        txtSDT.Text)))
                    {
                        dgvDanhSach.DataSource = data.getDSDocGia("");
                        dgvDanhSach.ClearSelection();
                        setEnable(false, false);
                        btnThem.Text = "Thêm";
                        clearText();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }

                }
                else
                {
                    MessageBox.Show("Dữ liệu chưa đúng");
                }

            }
        }

        #region
        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
        #endregion



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(btnTimKiem.Text== "Tìm Kiếm")
            {
                setEnable(true, false);
                btnTimKiem.Text = "Tìm";
            }else if (btnTimKiem.Text == "Tìm")
            {
                string ma = txtMa.Text;
                dgvDanhSach.DataSource = data.TimkiemDG(ma);
                setEnable(false, false);
                btnTimKiem.Text = "Tìm Kiếm";
            }
        }
    }
}