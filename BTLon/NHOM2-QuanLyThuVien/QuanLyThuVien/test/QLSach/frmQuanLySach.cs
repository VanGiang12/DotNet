using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test
{
    public partial class frmQuanLySach : Form
    {
        private frmHome frmHome;
        private Sach qlsach = new Sach();
        private SqlDataAdapter adapter;
        private SqlCommand command;
        private List<string> lstTacGia = new List<string>();
        private List<string> lstNXB = new List<string>();
        private List<string> lstTheLoai = new List<string>();

        public frmQuanLySach()
        {
            InitializeComponent();
        }
        public frmQuanLySach(frmHome parent)
        {
            InitializeComponent();
            frmHome = parent;
            dgvDanhSachSach.DataSource = qlsach.getAllSach();

            Title();

            // DisplayDataOnDataGridView(qlsach.getAllSach());
            dgvDanhSachSach.DefaultCellStyle.ForeColor = Color.Black;

            qlsach.Truyen_DLCombobox("tentacgia", "tacgia", cboTacGia, lstTacGia);
            qlsach.Truyen_DLCombobox("tentheloai", "theloai", cboTheLoai, lstTheLoai);
            qlsach.Truyen_DLCombobox("tennhaxuatban", "nhaxuatban", cboNXB, lstNXB);
            setEnable(false);

        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            dgvDanhSachSach.ClearSelection();
        }

        #region hình ảnh
        /*
        // Hàm hiển thị dữ liệu từ DataTable lên DataGridView với cột hình ảnh
        private void DisplayDataOnDataGridView(DataTable dt)
        {
            // Xóa các cột hiện có trong DataGridView trước khi thêm mới
            dgvDanhSachSach.Columns.Clear();

            // Thêm các cột từ DataTable
            foreach (DataColumn column in dt.Columns)
            {
                dgvDanhSachSach.Columns.Add(column.ColumnName, column.ColumnName);
            }

            // Thêm cột hình ảnh vào DataGridView
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //imageColumn.HeaderText = "Hình ảnh";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Tùy chỉnh cách hiển thị hình ảnh trong ô

            dgvDanhSachSach.Columns.Add(imageColumn);

            // Thêm dữ liệu vào từng dòng và cột
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                // Lấy đường dẫn hình ảnh từ cột "hinhanh"
                string imagePath = row["hinhanh"].ToString(); // Đảm bảo rằng "hinhanh" là tên cột chứa đường dẫn hình ảnh
                                                              // Tải hình ảnh từ đường dẫn
                Image img = Image.FromFile(imagePath);

                // Thêm một hàng mới vào DataGridView
                dgvDanhSachSach.Rows.Add();
                // Thêm hình ảnh vào cột hình ảnh tại hàng thứ i
                dgvDanhSachSach.Rows[i].Cells["hinhanh"].Value = img;
            }
        }*/
        #endregion

        private void Title()
        {
            dgvDanhSachSach.Columns[0].HeaderText = "Mã sách";
            dgvDanhSachSach.Columns[1].HeaderText = "Tên sách";
            dgvDanhSachSach.Columns[2].HeaderText = "Khoa";
            dgvDanhSachSach.Columns[3].HeaderText = "Tác giả";
            dgvDanhSachSach.Columns[4].HeaderText = "Thể loại";
            dgvDanhSachSach.Columns[5].HeaderText = "Nhà xuất bản";
            dgvDanhSachSach.Columns[6].HeaderText = "Số lượng";
            dgvDanhSachSach.Columns[7].HeaderText = "Năm xuất bản";
        }

        private void clearText()
        {
            txtKhoa.Text = "";
            txtMaSach.Text = "";
            txtNamXuatBan.Text = "";
            txtSoLuong.Text = "";
            txtTenSach.Text = "";
            cboNXB.Text = "";
            cboTacGia.Text = "";
            cboTheLoai.Text = "";
            dgvDanhSachSach.ClearSelection();
        }

        private void setEnable(bool x)
        {
            txtKhoa.Enabled = x;
            txtMaSach.Enabled = x;
            txtNamXuatBan.Enabled = x;
            txtSoLuong.Enabled = x;
            txtTenSach.Enabled = x;
            cboNXB.Enabled = x;
            cboTacGia.Enabled = x;
            cboTheLoai.Enabled = x;
        }

        private void dgvDanhSachSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachSach.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDanhSachSach.SelectedRows[0];
                if (row != null)
                {
                    txtMaSach.Text = row.Cells[0].Value.ToString();
                    txtTenSach.Text = row.Cells[1].Value.ToString();
                    txtKhoa.Text = row.Cells[2].Value.ToString();
                    cboTacGia.Text = row.Cells[3].Value.ToString();
                    cboTheLoai.Text = row.Cells[4].Value.ToString();
                    cboNXB.Text = row.Cells[5].Value.ToString();
                    txtSoLuong.Text = row.Cells[6].Value.ToString();
                    txtNamXuatBan.Text = row.Cells[7].Value.ToString();
                }
            }
            else
            {
                txtMaSach.Text = "";
                txtTenSach.Text = "";
                txtKhoa.Text = "";
                cboTacGia.Text = "";
                cboTheLoai.Text = "";
                cboNXB.Text = "";
                txtSoLuong.Text = "";
                txtNamXuatBan.Text = "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaSach.Text;
            string ten = txtTenSach.Text;
            string khoa = txtKhoa.Text;
            string matacgia = qlsach.GetMaFromTable("tacgia", "matacgia", "tentacgia", cboTacGia.Text);
            string matheloai = qlsach.GetMaFromTable("theloai", "matheloai", "tentheloai", cboTheLoai.Text);
            string manxb = qlsach.GetMaFromTable("nhaxuatban", "manhaxuatban", "tennhaxuatban", cboNXB.Text);
            int sl;
            string nxb = txtNamXuatBan.Text;
            if (btnThem.Text.Equals("Thêm"))
            {
                setEnable(true);
                btnThem.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThoat.Text = "Hủy";

            }
            else if (btnThem.Text.Equals("Lưu"))
            {
                if (!string.IsNullOrEmpty(ma) && !string.IsNullOrEmpty(ten) && !string.IsNullOrEmpty(khoa) &&
                    !string.IsNullOrEmpty(matacgia) && !string.IsNullOrEmpty(matheloai) && !string.IsNullOrEmpty(manxb) &&
                    int.TryParse(txtSoLuong.Text, out sl) && !string.IsNullOrEmpty(nxb))
                {
                    if (qlsach.Insert(new Sach(ma, ten, khoa, matacgia, matheloai, manxb, sl, nxb)))
                    {
                        dgvDanhSachSach.DataSource = qlsach.getAllSach();
                        clearText();
                        btnThem.Text = "Thêm";
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnThoat.Text = "Thoát";
                        setEnable(false);
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("Sửa"))
            {
                setEnable(true);
                btnSua.Text = "Lưu";
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnThoat.Text = "Hủy";
            }
            else if (btnSua.Text.Equals("Lưu"))
            {
                string ma = txtMaSach.Text;
                string ten = txtTenSach.Text;
                string khoa = txtKhoa.Text;
                string matacgia = qlsach.GetMaFromTable("tacgia", "matacgia", "tentacgia", cboTacGia.Text);
                string matheloai = qlsach.GetMaFromTable("theloai", "matheloai", "tentheloai", cboTheLoai.Text);
                string manxb = qlsach.GetMaFromTable("nhaxuatban", "manhaxuatban", "tennhaxuatban", cboNXB.Text);
                int sl;
                string nxb = txtNamXuatBan.Text;
                if (dgvDanhSachSach.SelectedRows.Count > 0)
                {
                    if (!string.IsNullOrEmpty(ma) && !string.IsNullOrEmpty(ten) && !string.IsNullOrEmpty(khoa) &&
                    !string.IsNullOrEmpty(matacgia) && !string.IsNullOrEmpty(matheloai) && !string.IsNullOrEmpty(manxb) &&
                    int.TryParse(txtSoLuong.Text, out sl) && !string.IsNullOrEmpty(nxb))
                    {

                        if (qlsach.Update(new Sach(ma, ten, khoa, matacgia, matheloai, manxb, sl, nxb)))
                        {
                            dgvDanhSachSach.DataSource = qlsach.getAllSach();
                            clearText();
                            btnSua.Text = "Sửa";
                            btnThem.Enabled = true;
                            btnXoa.Enabled = true;
                            btnThoat.Text = "Thoát";
                            setEnable(false);
                        }
                        else
                        {
                            MessageBox.Show("Không sửa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSach.SelectedRows.Count > 0)
            {
                if (qlsach.Delete(txtMaSach.Text))
                {
                    dgvDanhSachSach.DataSource = qlsach.getAllSach();
                    clearText();
                }
                else
                {
                    MessageBox.Show("Không xóa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt;
            string sql = "select masach, tensach, khoa, tentacgia, tentheloai, tennhaxuatban, soluong, namxuatban from sach " +
                  "join tacgia on sach.matacgia = tacgia.matacgia " +
                  "join theloai on sach.matheloai = theloai.matheloai " +
                  "join nhaxuatban on sach.manhaxuatban = nhaxuatban.manhaxuatban ";

            if (cboTimKiem.SelectedItem != null)
            {
                if (cboTimKiem.SelectedItem.ToString().Equals("Mã sách"))
                {
                    sql += "where masach = @maSach";
                    if (!string.IsNullOrEmpty(txtTimKiem.Text))
                    {
                        dt = qlsach.Search(txtTimKiem.Text, sql, "@maSach");
                        if (dt.Rows.Count > 0)
                        {
                            dgvDanhSachSach.DataSource = dt;
                            dgvDanhSachSach.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("Mã không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cboTimKiem.SelectedItem.ToString().Equals("Tên sách"))
                {
                    sql += "where tensach like '%'+@tenSach+'%'";
                    if (!string.IsNullOrEmpty(txtTimKiem.Text))
                    {
                        dt = qlsach.Search(txtTimKiem.Text, sql, "@tenSach");
                        if (dt.Rows.Count > 0)
                        {
                            dgvDanhSachSach.DataSource = dt;
                            dgvDanhSachSach.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("Mã không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cboTimKiem.SelectedItem.ToString().Equals("Tác giả"))
                {

                    sql += "where tentacgia like '%' + @tenTacGia + '%'";
                    if (!string.IsNullOrEmpty(txtTimKiem.Text))
                    {
                        dt = qlsach.Search(txtTimKiem.Text, sql, "@tenTacGia");
                        if (dt.Rows.Count > 0)
                        {
                            dgvDanhSachSach.DataSource = dt;
                            dgvDanhSachSach.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("Mã không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cboTimKiem.SelectedItem.ToString().Equals("Thể loại"))
                {
                    sql += "where tentheloai like '%' + @tenTheLoai + '%'";
                    if (!string.IsNullOrEmpty(txtTimKiem.Text))
                    {
                        dt = qlsach.Search(txtTimKiem.Text, sql, "@tenTheLoai");
                        if (dt.Rows.Count > 0)
                        {
                            dgvDanhSachSach.DataSource = dt;
                            dgvDanhSachSach.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("Mã không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cboTimKiem.SelectedItem.ToString().Equals("Năm xuất bản"))
                {
                    sql += "where namxuatban = @namXB";
                    if (!string.IsNullOrEmpty(txtTimKiem.Text))
                    {
                        dt = qlsach.Search(txtTimKiem.Text, sql, "@namXB");

                        if (dt.Rows.Count > 0)
                        {
                            dgvDanhSachSach.DataSource = dt;
                            dgvDanhSachSach.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("Mã không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cboTimKiem.SelectedItem.ToString().Equals("Nhà xuất bản"))
                {
                    sql += "where tennhaxuatban like '%' + @NXB + '%'";
                    if (!string.IsNullOrEmpty(txtTimKiem.Text))
                    {
                        dt = qlsach.Search(txtTimKiem.Text, sql, "@NXB");
                        if (dt.Rows.Count > 0)
                        {
                            dgvDanhSachSach.DataSource = dt;
                            dgvDanhSachSach.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("Mã không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dgvDanhSachSach.DataSource = qlsach.getAllSach();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnThoat.Text.Equals("Hủy"))
            {
                btnThoat.Text = "Thoát";
                setEnable(false);
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                clearText();
            }
            else if (btnThoat.Text.Equals("Thoát"))
            {
                frmHome.openChildForm(new frm_tab_QLS(frmHome));
            }
        }

        #region cbo_TextChanged
        private void cboTacGia_TextChanged(object sender, EventArgs e)
        {
            /* string searchText = cboTacGia.Text.ToLower();
             cboTacGia.Items.Clear();
             foreach (string tg in lstTacGia)
             {
                 if (tg.ToLower().Contains(searchText))
                 {
                     cboTacGia.Items.Add(tg);
                 }
             }

             if (cboTacGia.Items.Count > 0)
             {
                 cboTacGia.DroppedDown = true;
                 //cboTacGia.SelectedIndex = -1; // Xóa chọn
                 //cboTacGia.SelectionStart = cboTacGia.Text.Length;
             }
             else
             {
                 cboTacGia.DroppedDown = true;
             }*/
        }

        private void cboTheLoai_TextChanged(object sender, EventArgs e)
        {
            /*cboTheLoai.Items.Clear();
            foreach (string tl in lstTheLoai)
            {
                if (tl.ToLower().Contains(cboTheLoai.Text.ToLower()))
                {
                    cboTheLoai.Items.Add(tl);
                }
            }

            if (cboTheLoai.Items.Count > 0)
            {
                cboTheLoai.DroppedDown = true;
                cboTheLoai.SelectionStart = cboTheLoai.Text.Length;
            }
            else
            {
                cboTheLoai.DroppedDown = false;
            }*/
        }

        private void cboNXB_TextChanged(object sender, EventArgs e)
        {
            /*cboNXB.Items.Clear();
            foreach (string nxb in lstNXB)
            {
                if (nxb.ToLower().Contains(cboNXB.Text.ToLower()))
                {
                    cboNXB.Items.Add(nxb);
                }
            }

            if (cboNXB.Items.Count > 0)
            {
                cboNXB.DroppedDown = true;
                cboNXB.SelectionStart = cboNXB.Text.Length;
            }
            else
            {
                cboNXB.DroppedDown = false;
            }*/
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa phát triển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}