using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET
{
    public partial class frm_QLKhachHang_Giang : Form
    {
        QLKhachHang qlkh = new QLKhachHang();

        public frm_QLKhachHang_Giang()
        {
            InitializeComponent();
            dgv_danhsach_giang.DataSource = qlkh.getDanhSacKH("");

            dgv_danhsach_giang.Columns[0].HeaderText = "Mã Khách Hàng";
            dgv_danhsach_giang.Columns[1].HeaderText = "Tên Khách Hàng";
            dgv_danhsach_giang.Columns[2].HeaderText = "CMND";
            dgv_danhsach_giang.Columns[3].HeaderText = "Địa Chỉ";
            dgv_danhsach_giang.Columns[4].HeaderText = "Số Điện Thoại";
        }

        bool ktraDL(string s, TextBox tb)
        {
            bool valid = true;
            if (string.IsNullOrWhiteSpace(s))
            {
                valid = false;
                errorProvider1.SetError(tb, "Không được trống");
            }
            else
            {
                errorProvider1.SetError(tb, "");

            }
            return valid;
        }

        bool KtraDauVao()
        {
            string ma = txt_makh_giang.Text;
            string ten = txt_tenkh_giang.Text;
            string cmnd = txt_cmnd_giang.Text;
            string diachi = txt_diachi_giang.Text;
            string sdt = txt_sdt_giang.Text;

            if (ktraDL(ma, txt_makh_giang) && ktraDL(ten, txt_tenkh_giang)
                && ktraDL(cmnd, txt_cmnd_giang) && ktraDL(diachi, txt_diachi_giang)
                && ktraDL(sdt, txt_sdt_giang))
                return true;
            else
                return false;
        }

        bool ktraCMND()
        {
            bool valid = true;
            string cmnd = txt_cmnd_giang.Text;
            if (cmnd.Length != 12)
            {
                valid = false;
                errorProvider1.SetError(txt_cmnd_giang, "CMND phải 12 số");
            }
            else
            {
                errorProvider1.SetError(txt_cmnd_giang, "");

            }
            return valid;
        }

        bool ktraSDT()
        {
            bool valid = true;
            string sdt = txt_sdt_giang.Text;
            if (sdt.Length != 10)
            {
                valid = false;
                errorProvider1.SetError(txt_sdt_giang, "SĐT phải 10 số");
            }
            else if (sdt[0] != '0')
            {
                valid = false;
                errorProvider1.SetError(txt_sdt_giang, "Số đầu tiên là số 0");
            }
            else
            {
                errorProvider1.SetError(txt_sdt_giang, "");

            }
            return valid;
        }

        void setEnable(bool b1, bool b2)
        {
            txt_makh_giang.Enabled = b2;
            txt_tenkh_giang.Enabled = b1;
            txt_cmnd_giang.Enabled = b1;
            txt_diachi_giang.Enabled = b1;
            txt_sdt_giang.Enabled = b1;
        }

        void clearText()
        {
            txt_makh_giang.ResetText();
            txt_tenkh_giang.ResetText();
            txt_diachi_giang.ResetText();
            txt_cmnd_giang.ResetText();
            txt_sdt_giang.ResetText();
        }

        void clearTextTimKiem()
        {
            txt_timkiem_cmnd_giang.ResetText();
            txt_timkiem_ma_giang.ResetText();
            txt_timkiem_sdt_giang.ResetText();
            txt_timkiem_ten_giang.ResetText();
        }

        private void frm_QLKhachHang_Giang_Load(object sender, EventArgs e)
        {
            dgv_danhsach_giang.ClearSelection();
            setEnable(false, false);
            btn_huy_giang.Enabled = false;
        }

        private void btn_them_giang_Click(object sender, EventArgs e)
        {
            if (btn_them_giang.Text == "THÊM")
            {
                btn_them_giang.Text = "LƯU";
                setEnable(true, true);
                btn_huy_giang.Enabled = true;
            }
            else if (btn_them_giang.Text == "LƯU")
            {
                if (KtraDauVao())
                {
                    if (ktraCMND() && ktraSDT())
                    {
                        KhachHang kh = new KhachHang(
                            txt_makh_giang.Text.Trim(),
                            txt_tenkh_giang.Text.Trim(),
                            txt_cmnd_giang.Text.Trim(),
                            txt_diachi_giang.Text.Trim(),
                            txt_sdt_giang.Text.Trim());

                        if (qlkh.Them(kh))
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                            btn_them_giang.Text = "THÊM";
                            setEnable(false, false);
                            btn_huy_giang.Enabled = false;
                            dgv_danhsach_giang.DataSource = qlkh.getDanhSacKH("");
                            dgv_danhsach_giang.ClearSelection();
                            clearText();
                        }
                        else
                            MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK);
                    }

                }
            }
        }

        private void btn_sua_giang_Click(object sender, EventArgs e)
        {
            if (btn_sua_giang.Text == "SỬA")
            {
                btn_sua_giang.Text = "LƯU";
                setEnable(true, false);
                btn_huy_giang.Enabled = true;
            }
            else if (btn_sua_giang.Text == "LƯU")
            {
                if (KtraDauVao())
                {
                    if (ktraCMND() && ktraSDT())
                    {
                        KhachHang kh = new KhachHang(
                            txt_makh_giang.Text,
                            txt_tenkh_giang.Text,
                            txt_cmnd_giang.Text,
                            txt_diachi_giang.Text,
                            txt_sdt_giang.Text);

                        if (qlkh.Sua(kh))
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                            btn_sua_giang.Text = "SỬA";
                            btn_huy_giang.Enabled = false;
                            setEnable(false, false);
                            dgv_danhsach_giang.DataSource = qlkh.getDanhSacKH("");
                            dgv_danhsach_giang.ClearSelection();
                            clearText();
                        }
                        else
                            MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void dgv_danhsach_giang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_danhsach_giang.SelectedRows.Count > 0)
            {
                txt_makh_giang.Text = dgv_danhsach_giang.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_tenkh_giang.Text = dgv_danhsach_giang.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_cmnd_giang.Text = dgv_danhsach_giang.SelectedRows[0].Cells[2].Value.ToString().Trim();
                txt_diachi_giang.Text = dgv_danhsach_giang.SelectedRows[0].Cells[3].Value.ToString().Trim();
                txt_sdt_giang.Text = dgv_danhsach_giang.SelectedRows[0].Cells[4].Value.ToString().Trim();
            }
        }

        private void btn_xoa_giang_Click(object sender, EventArgs e)
        {
            if (dgv_danhsach_giang.SelectedRows.Count > 0)
            {
                if (DialogResult.OK == MessageBox.Show($"Bạn có muốn xóa khách hàng '{txt_tenkh_giang.Text}' không?", "Thông báo", MessageBoxButtons.OKCancel))
                {
                    if (qlkh.Xoa(txt_makh_giang.Text))
                    {
                        dgv_danhsach_giang.DataSource = qlkh.getDanhSacKH("");
                        dgv_danhsach_giang.ClearSelection();
                        clearText();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn khách hàng cần xóa.");
            }
        }

        private void btn_timkiem_giang_Click(object sender, EventArgs e)
        {
            string dieu_kien_tk = "";
            if (!string.IsNullOrEmpty(txt_timkiem_cmnd_giang.Text))
            {
                dieu_kien_tk = txt_timkiem_cmnd_giang.Text;
            }
            else if (!string.IsNullOrEmpty(txt_timkiem_ma_giang.Text))
            {
                dieu_kien_tk = txt_timkiem_ma_giang.Text;
            }
            else if (!string.IsNullOrEmpty(txt_timkiem_ten_giang.Text))
            {
                dieu_kien_tk = txt_timkiem_ten_giang.Text;
            }
            else if (!string.IsNullOrEmpty(txt_timkiem_sdt_giang.Text))
            {
                dieu_kien_tk = txt_timkiem_sdt_giang.Text;
            }

            string s = $" where MaKH = '{dieu_kien_tk}' or CMND='{dieu_kien_tk}' or SDT='{dieu_kien_tk}' or HoTenKH like '%{dieu_kien_tk}%'";
            dgv_danhsach_giang.DataSource = qlkh.getDanhSacKH(s);
            dgv_danhsach_giang.ClearSelection();
        }

        private void btn_lammoi_giang_Click(object sender, EventArgs e)
        {
            dgv_danhsach_giang.DataSource = qlkh.getDanhSacKH("");
            dgv_danhsach_giang.ClearSelection();
            clearTextTimKiem();
        }

        private void btn_xuatfile_giang_Click(object sender, EventArgs e)
        {
            qlkh.XuatExcel(dgv_danhsach_giang);
        }

        private void btn_huy_giang_Click(object sender, EventArgs e)
        {
            clearText();
            clearTextTimKiem();
            btn_them_giang.Text = "THÊM";
            btn_sua_giang.Text = "SỬA";
            setEnable(false, false);
            btn_huy_giang.Enabled = false;
        }
    }
}
