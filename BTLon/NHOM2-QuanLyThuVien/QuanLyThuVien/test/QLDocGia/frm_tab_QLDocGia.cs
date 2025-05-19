using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Model;

namespace test
{
    public partial class frm_tab_QLDocGia : Form
    {
        public frm_tab_QLDocGia()
        {
            InitializeComponent();
            loadData();
        }

        private void frm_tab_QLDocGia_Load(object sender, EventArgs e)
        {
            setEnable(false);
            dgvlistReader.ClearSelection();
            dgvlistReader.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void loadData()
        {
            dgvlistReader.DataSource = DocGia.getListReader();
            dgvlistReader.Columns[0].HeaderText = "Mã độc giả";
            dgvlistReader.Columns[2].HeaderText = "Password";
            dgvlistReader.Columns[1].HeaderText = "Số thẻ";
            dgvlistReader.Columns[3].HeaderText = "Tên độc giả";
            dgvlistReader.Columns[4].HeaderText = "Ngày Sinh";
            dgvlistReader.Columns[5].HeaderText = "Giới Tính";
            dgvlistReader.Columns[6].HeaderText = "Loại độc giả";
            dgvlistReader.Columns[7].HeaderText = "Khoa";
            dgvlistReader.Columns[8].HeaderText = "Địa chỉ";
        }

        private void clearText()
        {
            tbaddress.Clear();
            tbcardNumber.Clear();
            tbcodeReader.Clear();
            tbdepartment.Clear();
            tbname.Clear();
            txtPass.Clear();
            dtpdate.Value = DateTime.Now;
            rbfemale.Checked = false;
            rbmale.Checked = false;
            cbtypeReader.SelectedIndex = -1;
            dgvlistReader.ClearSelection();
        }

        private void setEnable(bool x)
        {
            tbaddress.Enabled = x;
            tbcardNumber.Enabled = x;
            tbcodeReader.Enabled = x;
            tbdepartment.Enabled = x;
            txtPass.Enabled = x;
            tbname.Enabled = x;
            dtpdate.Enabled = x;
            rbfemale.Enabled = x;
            rbmale.Enabled = x;
            cbtypeReader.Enabled = x;
        }

        private void btadd_Click(object sender, EventArgs e)
        {

            List<string> lst = DocGia.getSoThe();
            if (btadd.Text.Equals("Thêm"))
            {
                setEnable(true);
                btadd.Text = "Lưu";
                btdelete.Enabled = false;
                btedit.Enabled = false;
                btnHienThi.Enabled = false;
                string soThe = "";
                Random ran = new Random();
                while (true)
                {
                    soThe = ran.Next(0, 9999).ToString("D4");
                    if (!lst.Contains(soThe))
                    {
                        break;
                    }
                }
                tbcardNumber.Text = soThe;
            }
            else if (btadd.Text.Equals("Lưu"))
            {
                string maDocGia = tbcodeReader.Text;
                string tenDocGia = tbname.Text;
                DateTime ngaySinh = dtpdate.Value;
                string gioiTinh = rbmale.Checked ? "nam" : "nữ";
                string loaiDocGia = cbtypeReader.SelectedItem?.ToString();
                string khoa = tbdepartment.Text;
                string diaChi = tbaddress.Text;
                string sothe = tbcardNumber.Text;
                string pass = txtPass.Text;
                if (!string.IsNullOrEmpty(maDocGia) && !string.IsNullOrEmpty(tenDocGia) &&
                    !string.IsNullOrEmpty(gioiTinh) && !string.IsNullOrEmpty(loaiDocGia)
                    && !string.IsNullOrEmpty(khoa) && !string.IsNullOrEmpty(diaChi) && !string.IsNullOrEmpty(pass))
                {
                    try
                    {
                        DocGia.addReader(maDocGia, pass, tenDocGia, ngaySinh, gioiTinh, loaiDocGia, khoa, diaChi, sothe);
                        loadData();
                        setEnable(false);
                        btadd.Text = "Thêm";
                        btdelete.Enabled = true;
                        btedit.Enabled = true;
                        btnHienThi.Enabled = true;
                        clearText();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvlistReader_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dg = dgvlistReader.Rows[e.RowIndex];
                tbcodeReader.Text = dg.Cells[0].Value.ToString();
                txtPass.Text = dg.Cells[2].Value.ToString();
                tbcardNumber.Text = dg.Cells[1].Value.ToString();
                tbname.Text = dg.Cells[3].Value.ToString();
                dtpdate.Value = Convert.ToDateTime(dg.Cells[4].Value);
                string sex = dg.Cells[5].Value.ToString();
                if (sex == "nam")
                    rbmale.Checked = true;
                else if (sex == "nữ")
                    rbfemale.Checked = true;
                string typeReader = dg.Cells[6].Value.ToString();
                int index = cbtypeReader.FindStringExact(typeReader);
                if (index != -1)
                    cbtypeReader.SelectedIndex = index;
                tbdepartment.Text = dg.Cells[7].Value.ToString();
                tbaddress.Text = dg.Cells[8].Value.ToString();
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (dgvlistReader.SelectedRows.Count > 0)
            {
                try
                {
                    string maDocGia = tbcodeReader.Text;
                    DocGia.deleteReader(maDocGia);
                    loadData();
                    clearText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            setEnable(false);
            btadd.Text = "Thêm";
            btdelete.Enabled = true;
            btedit.Enabled = true;
            btnHienThi.Enabled = true;
            clearText();
        }

        private void btedit_Click_1(object sender, EventArgs e)
        {
            List<string> lst = DocGia.getSoThe();
            if (btedit.Text.Equals("Sửa"))
            {
                setEnable(true);
                btedit.Text = "Lưu";
                btdelete.Enabled = false;
                btadd.Enabled = false;
                btnHienThi.Enabled = false;

            }
            else if (btedit.Text.Equals("Lưu"))
            {
                string maDocGia = tbcodeReader.Text;
                string tenDocGia = tbname.Text;
                DateTime ngaySinh = dtpdate.Value;
                string gioiTinh = rbmale.Checked ? "nam" : "nữ";
                string loaiDocGia = cbtypeReader.SelectedItem.ToString();
                string khoa = tbdepartment.Text;
                string diaChi = tbaddress.Text;
                string soThe = tbcardNumber.Text;
                string pass = txtPass.Text;

                if (!string.IsNullOrEmpty(maDocGia) && !string.IsNullOrEmpty(tenDocGia) &&
                    !string.IsNullOrEmpty(gioiTinh) && !string.IsNullOrEmpty(loaiDocGia)
                    && !string.IsNullOrEmpty(khoa) && !string.IsNullOrEmpty(diaChi) && !string.IsNullOrEmpty(pass))
                {
                    try
                    {
                        DocGia.editReader(maDocGia, pass, tenDocGia, ngaySinh, gioiTinh, loaiDocGia, khoa, diaChi, soThe);
                        loadData();
                        setEnable(false);
                        btedit.Text = "Sửa";
                        btdelete.Enabled = true;
                        btadd.Enabled = true;
                        btnHienThi.Enabled = true;
                        clearText();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbsearch_Click(object sender, EventArgs e)
        {
            string code = rbcodeReader.Checked ? tbsearch.Text : null;
            string name = rbname.Checked ? tbsearch.Text : null;
            string card = rbcardNumber.Checked ? tbsearch.Text : null;
            if (string.IsNullOrEmpty(code) && string.IsNullOrEmpty(name) && string.IsNullOrEmpty(card))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm hoặc chọn một trong các trường tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<DocGia> search = DocGia.searchReader(code, name, card);
            dgvlistReader.DataSource = search;
            dgvlistReader.ClearSelection();

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvlistReader.DataSource = DocGia.getListReader();
            dgvlistReader.ClearSelection();
        }

        private void btnLamThe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa phát triển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
