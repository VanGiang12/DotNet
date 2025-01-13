using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Database;
using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.GiaoDich;
using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.UI.Van
{
    public partial class frm_QLGiaoDichGui_Van : Form
    {
        QLGiaoDich gd = new QLGiaoDich();
        QLKhachHang kh = new QLKhachHang();

        public frm_QLGiaoDichGui_Van()
        {
            InitializeComponent();
        }


        private void frm_QLGiaoDichGui_Van_Load(object sender, EventArgs e)
        {
            Display(false);
            dgv_LoaiSo_Van.DataSource = gd.ShowLoaiSo();
            dgv_DanhSach_Van.DataSource = gd.ShowAllData();
            cb_TenLoaiSo_Van.DataSource = gd.ShowLoaiSo(); ;
            cb_TenLoaiSo_Van.DisplayMember = "TenLoaiSo";
            cb_TenLoaiSo_Van.ValueMember = "TenLoaiSo";
            txt_MaNV_Van.Enabled = false;
            btn_Huy_Van.Enabled = false;

        }
        public void Display(bool b)
        {
            txt_CMND_Van.Enabled = b;
            txt_TenKH_Van.Enabled = b;
            txt_DC_Van.Enabled = b;
            txt_SDT_Van.Enabled = b;
            cb_TenLoaiSo_Van.Enabled = b;
            dtp_NgayMoSo_Van.Enabled = b;
            dtp_NgayDenHan_Van.Enabled = b;
            txt_SoTienGui_Van.Enabled = b;
            cb_TrangThaiSo_Van.Enabled = b;
        }
        public bool Validation(string s)
        {
            int n;
            if (!string.IsNullOrEmpty(s) || int.TryParse(s, out n))
                return true;
            return false;
        }
        public bool ValidationCMNDorSDT(string s)
        {
            if (!string.IsNullOrEmpty(s) && (s.Length == 10 || s.Length == 12))
            {
                foreach (char c in s)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        private void cbTenLoaiSo_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < dgv_LoaiSo_Van.Rows.Count; i++)
            {
                if (cb_TenLoaiSo_Van.Text == dgv_LoaiSo_Van.Rows[i].Cells[0].Value.ToString())
                {
                    txt_LaiSuat_Van.Text = dgv_LoaiSo_Van.Rows[i].Cells[1].Value.ToString();
                    int kyHan = 0;
                    if (int.TryParse(dgv_LoaiSo_Van.Rows[i].Cells[2].Value.ToString(), out kyHan))
                    {
                        dtp_NgayDenHan_Van.Value = dtp_NgayMoSo_Van.Value.AddMonths(kyHan);
                    }
                }
            }
        }

        private void dgvLoaiSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_LoaiSo_Van.SelectedRows.Count > 0)
            {
                cb_TenLoaiSo_Van.Text = dgv_LoaiSo_Van.SelectedRows[0].Cells[0].Value.ToString();
                txt_LaiSuat_Van.Text = dgv_LoaiSo_Van.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btn_Them_Van.Text == "Thêm")
            {
                btn_Them_Van.Text = "Lưu";
                Display(true);
                txt_MaNV_Van.Enabled = false;
                cb_TrangThaiSo_Van.SelectedIndex = 0;
                btn_Huy_Van.Enabled = true;
                txt_MaNV_Van.Text = frm_Login_Giang.Key;
            }
            else
            {

                txt_MaSTK_Van.Text = gd.RanDomMaSTK();

                if (Validation(txt_MaNV_Van.Text) &&
                    ValidationCMNDorSDT(txt_CMND_Van.Text.Trim()) &&
                    Validation(txt_TenKH_Van.Text) &&
                    Validation(txt_DC_Van.Text) &&
                    ValidationCMNDorSDT(txt_SDT_Van.Text.Trim()) &&
                    Validation(cb_TenLoaiSo_Van.Text) &&
                    Validation(cb_TrangThaiSo_Van.Text))
                {
                    string makh = txt_MaKH_Van.Text.Trim();
                    string tenkh = txt_TenKH_Van.Text.Trim();
                    string cmnd = txt_CMND_Van.Text.Trim();
                    string diachi = txt_DC_Van.Text.Trim();
                    string sdt = txt_SDT_Van.Text.Trim();

                    string mastk = txt_MaSTK_Van.Text.Trim();
                    string manv = txt_MaNV_Van.Text.Trim();
                    string maloaiso = gd.getMaLoaiSo(cb_TenLoaiSo_Van.Text);
                    int sotiengui = int.Parse(txt_SoTienGui_Van.Text.Trim());
                    DateTime ngaymoso = dtp_NgayMoSo_Van.Value;
                    DateTime? ngaydenhan;
                    if (cb_TenLoaiSo_Van.SelectedIndex == 0)
                    {
                        ngaydenhan = null;
                    }
                    else
                    {
                        ngaydenhan = dtp_NgayDenHan_Van.Value;
                    }
                    bool tt = (cb_TrangThaiSo_Van.Text == "Mở");
                    if (gd.CheckCMND(cmnd) == null)
                    {
                        gd.ThemKH(makh, tenkh, cmnd, diachi, sdt);
                        MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    GiaoDich giaoDich = new GiaoDich(mastk, manv, makh, sdt, maloaiso, ngaymoso, ngaydenhan, sotiengui, tt);
                    gd.ThemSTK(giaoDich);
                    btn_Them_Van.Text = "Thêm";
                    btn_Huy_Van.Enabled = false;
                    dgv_DanhSach_Van.DataSource = gd.ShowAllData();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void txtCMND_MouseLeave(object sender, EventArgs e)
        {
            if (ValidationCMNDorSDT(txt_CMND_Van.Text))
            {
                DataTable dt = gd.CheckCMND(txt_CMND_Van.Text);
                if (dt != null)
                {
                    txt_MaKH_Van.Text = dt.Rows[0]["MaKH"].ToString();
                    txt_TenKH_Van.Text = dt.Rows[0]["HoTenKH"].ToString();
                    txt_DC_Van.Text = dt.Rows[0]["DiaChi"].ToString();
                    txt_SDT_Van.Text = dt.Rows[0]["SDT"].ToString();

                }
                else
                {
                    MessageBox.Show("Chưa có thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TenKH_Van.Text = txt_DC_Van.Text = txt_SDT_Van.Text = "";
                    txt_MaKH_Van.Text = gd.RanDomMaKH();

                }
            }
            else
            {
                MessageBox.Show("Nhập đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSoTienGui_MouseMove(object sender, MouseEventArgs e)
        {
            int tien = 0;
            if (int.TryParse(txt_SoTienGui_Van.Text, out tien))
            {

                if (tien < 200000)
                {
                    MessageBox.Show("Số tiền gửi tối thiểu là 200000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSach_Van.Rows.Count > 0)
            {
                if (btn_Sua_Van.Text == "Sửa")
                {
                    btn_Sua_Van.Text = "Lưu";
                    Display(true);
                    btn_Huy_Van.Enabled = true;
                    txt_MaNV_Van.Enabled = dtp_NgayMoSo_Van.Enabled = dtp_NgayDenHan_Van.Enabled = txt_SoTienGui_Van.Enabled = cb_TrangThaiSo_Van.Enabled = cb_TenLoaiSo_Van.Enabled = false;
                }
                else
                {
                    gd.SuaSTK(txt_MaSTK_Van.Text, txt_MaKH_Van.Text);

                    if (kh.Sua(new KhachHang(txt_MaKH_Van.Text, txt_TenKH_Van.Text, txt_CMND_Van.Text, txt_DC_Van.Text, txt_SDT_Van.Text)))
                    {
                        MessageBox.Show("Cập nhật khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    btn_Sua_Van.Text = "Sửa";
                    btn_Huy_Van.Enabled = false;
                    Display(false);
                    Clear();
                    dgv_DanhSach_Van.DataSource = gd.ShowAllData();
                }
            }
            else
            {
                MessageBox.Show("Chọn sổ tiết kiệm cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void Clear()
        {
            txt_MaSTK_Van.Text = txt_MaNV_Van.Text = txt_CMND_Van.Text = txt_MaKH_Van.Text = txt_TenKH_Van.Text = txt_DC_Van.Text = txt_SDT_Van.Text = cb_TenLoaiSo_Van.Text = txt_SoTienGui_Van.Text = cb_TrangThaiSo_Van.Text = "";

        }
        private void dgvHT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_DanhSach_Van.SelectedRows.Count > 0)
            {
                txt_MaSTK_Van.Text = dgv_DanhSach_Van.SelectedRows[0].Cells[0].Value.ToString();
                txt_MaNV_Van.Text = dgv_DanhSach_Van.SelectedRows[0].Cells[1].Value.ToString();
                txt_TenKH_Van.Text = dgv_DanhSach_Van.SelectedRows[0].Cells[2].Value.ToString();
                txt_CMND_Van.Text = dgv_DanhSach_Van.SelectedRows[0].Cells[3].Value.ToString().Trim();
                DataTable dt = gd.ShowKH(txt_CMND_Van.Text);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txt_MaKH_Van.Text = dt.Rows[0]["MaKH"].ToString();
                    txt_DC_Van.Text = dt.Rows[0]["DiaChi"].ToString();
                    txt_SDT_Van.Text = dt.Rows[0]["SDT"].ToString().Trim();
                }
                else
                {
                    txt_MaKH_Van.Text = "";
                    txt_DC_Van.Text = "";
                    txt_SDT_Van.Text = "";
                }

                cb_TenLoaiSo_Van.Text = dgv_DanhSach_Van.SelectedRows[0].Cells[4].Value.ToString();
                txt_LaiSuat_Van.Text = dgv_DanhSach_Van.SelectedRows[0].Cells[5].Value.ToString();
                if (cb_TenLoaiSo_Van.Text.Equals("Không kì hạn"))
                {
                    dtp_NgayDenHan_Van.CustomFormat = " ";
                    dtp_NgayDenHan_Van.Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    dtp_NgayDenHan_Van.CustomFormat = "dd/MM/yyyy";
                    dtp_NgayDenHan_Van.Format = DateTimePickerFormat.Custom;
                    dtp_NgayDenHan_Van.Text = dgv_DanhSach_Van.SelectedRows[0].Cells[7].Value.ToString();
                }

                txt_SoTienGui_Van.Text = dgv_DanhSach_Van.SelectedRows[0].Cells[8].Value.ToString();
                cb_TrangThaiSo_Van.Text = dgv_DanhSach_Van.SelectedRows[0].Cells[9].Value.ToString();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSach_Van.SelectedRows.Count > 0)
            {
                gd.XoaSTK(txt_MaSTK_Van.Text);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_DanhSach_Van.DataSource = gd.ShowAllData();
                Clear();
            }
            else
            {
                MessageBox.Show("Chọn sổ tiết kiệm cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            //Clear();
            txt_MaKH_Van.Enabled = true;
            Display(false);
            if (txt_MaKH_Van.Text != null)
            {
                dgv_DanhSach_Van.DataSource = gd.FindMaKH(txt_MaKH_Van.Text);
            }
            else
            {
                MessageBox.Show("Nhập mã khách hàng cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (gd.FindMaKH(txt_MaKH_Van.Text).Rows.Count == 0)
            {
                MessageBox.Show("Không có khách hàng cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cb_TenLoaiSo_Van_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TenLoaiSo_Van.SelectedIndex == 0)
            {
                dtp_NgayDenHan_Van.Visible = false;
                label7.Visible = false;
            }
            else
            {
                dtp_NgayDenHan_Van.Visible = true;
                label7.Visible = true;
            }
        }

        private void btn_Huy_Van_Click(object sender, EventArgs e)
        {
            btn_Them_Van.Text = "Thêm";
            btn_Sua_Van.Text = "Sửa";

            Display(false);
            Clear();
            btn_Huy_Van.Enabled = false;
        }

        private void btnGuiThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này đang được phát triển");
        }
    }
}
