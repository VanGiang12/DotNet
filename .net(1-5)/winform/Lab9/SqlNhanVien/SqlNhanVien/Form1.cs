namespace SqlNhanVien
{
    public partial class Form1 : Form
    {
        QuanLyNV qlnv;
        NhanVien nhanvien;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qlnv = new QuanLyNV();
            try
            {
                dataGridViewDisPlay.DataSource = qlnv.getAllNhanVien();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo");
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string ten = txtTenNV.Text;
            string sex = (radNam.Checked ? radNam.Text : radNu.Text);
            DateTime dt = dtpNgaySinh.Value;
            string dc = txtDiaChi.Text;
            string sdt = txtPhone.Text;
            nhanvien = new NhanVien(ma, ten, sex, dt, dc, sdt);
            if (qlnv.insert(nhanvien))
            {
                dataGridViewDisPlay.DataSource = qlnv.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Không chèn được", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string ten = txtTenNV.Text;
            string sex = (radNam.Checked ? radNam.Text : radNu.Text);
            DateTime dt = dtpNgaySinh.Value;
            string dc = txtDiaChi.Text;
            string sdt = txtPhone.Text;
            nhanvien = new NhanVien(ma, ten, sex, dt, dc, sdt);
            if (qlnv.update(nhanvien))
            {
                dataGridViewDisPlay.DataSource = qlnv.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Không sửa được", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {   
                                              // hàng        cột
            string id = dataGridViewDisPlay.SelectedRows[0].Cells[0].Value.ToString();
            if (qlnv.delete(id))
            {
                dataGridViewDisPlay.DataSource= qlnv.getAllNhanVien();  
            }
            else
            {
                MessageBox.Show("Không xóa được", "Thông báo");
            }
        }
    }
}