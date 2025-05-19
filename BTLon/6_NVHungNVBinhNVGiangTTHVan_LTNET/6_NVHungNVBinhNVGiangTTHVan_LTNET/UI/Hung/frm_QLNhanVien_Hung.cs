using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.NhanVien;
using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.So;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.UI.Hung
{
    public partial class frm_QLNhanVien_Hung : Form
    {
        actions ac = new actions();
        string ma = "";
        string ten = "";
        DateTime ns = DateTime.Now;
        string sdt = "";
        string mk = "";
        int lnd = 0;
        bool dn = true;
        nhanVien nv = new nhanVien();

        public frm_QLNhanVien_Hung()
        {
            InitializeComponent();
        }


        void vhh(bool x)
        {
            tb_manhanvien_hung.Enabled = x;
            tb_hotennhanvien_hung.Enabled = x;
            dgv_ngaysinh_hung.Enabled = x;
            tb_sodienthoai_hung.Enabled = x;
            tb_matkhau_hung.Enabled = x;
            cb_loainguoidung_hung.Enabled = x;
        }

        void ht()
        {
            dgv_hung.DataSource = ac.ht();
            dgv_hung.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgv_hung.Columns["HoTenNV"].HeaderText = "Họ tên nhân viên";
            dgv_hung.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgv_hung.Columns["SDT"].HeaderText = "Số điện thoại";
            dgv_hung.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dgv_hung.Columns["LoaiNguoiDung"].HeaderText = "Loại người dùng";
        }

        void gt()
        {
            ma = tb_manhanvien_hung.Text;
            ten = tb_hotennhanvien_hung.Text;
            ns = dgv_ngaysinh_hung.Value.Date;
            sdt = tb_sodienthoai_hung.Text;
            mk = tb_matkhau_hung.Text;
            lnd = int.Parse(cb_loainguoidung_hung.SelectedValue.ToString());
            nv = new nhanVien(ma, ten, ns, sdt, mk, lnd);
        }
        void gtcbb()
        {
            cb_loainguoidung_hung.DataSource = ac.dlloai();
            cb_loainguoidung_hung.DisplayMember = "TenLoaiNguoiDung";
            cb_loainguoidung_hung.ValueMember = "MaND";
        }

        void themm()
        {
            if (bt_them_hung.Text == "Thêm")
            {
                bt_them_hung.Text = "Lưu";
                vhh(true);
                tb_manhanvien_hung.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(tb_manhanvien_hung.Text) || string.IsNullOrEmpty(tb_hotennhanvien_hung.Text) || string.IsNullOrEmpty(tb_matkhau_hung.Text) || string.IsNullOrEmpty(cb_loainguoidung_hung.Text))
                {
                    MessageBox.Show("Bạn cần phải nhập đủ thông tin trước khí thêm!!!");
                }
                else
                {
                    gt();
                    if (ac.them(nv))
                    {
                        ht();
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        vhh(false);
                        bt_them_hung.Text = "Thêm";
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm, Vui lòng kiểm tra lại thông tin trước khi thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        void suaa()
        {
            if (nt_capnhat_hung.Text == "Cập nhật")
            {
                nt_capnhat_hung.Text = "Lưu";
                vhh(true);
                tb_manhanvien_hung.Enabled = false;
                tb_hotennhanvien_hung.Focus();
            }
            else
            {
                gt();
                if (string.IsNullOrEmpty(tb_manhanvien_hung.Text) || string.IsNullOrEmpty(tb_hotennhanvien_hung.Text) || string.IsNullOrEmpty(tb_matkhau_hung.Text) || string.IsNullOrEmpty(cb_loainguoidung_hung.Text))
                {
                    MessageBox.Show("Bạn cần phải nhập đủ thông tin trước khi Update");
                }
                else
                {

                    if (ac.sua(nv))
                    {
                        ht();
                        MessageBox.Show("Update win!!!", "Notion");
                        vhh(false);
                        nt_capnhat_hung.Text = "Cập nhật";
                    }
                    else
                    {
                        MessageBox.Show("Uppdate Erron", "Notion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        void xoaa()
        {
            gt();
            if (ac.xoa(nv))
            {
                ht();
                MessageBox.Show("Xóa thành công", "Thông báo");

            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa, vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void timk()
        {
            var tt = ac.tk(tb_timkiem_hung.Text);
            if (tt == null)
            {
                MessageBox.Show("Không tìm thấy tên mà bạn yêu cầu", "Thông báo");
                ht();
            }
            else
            {
                dgv_hung.DataSource = tt;
            }
        }


        private void frm_QLNhanVien_Hung_Load(object sender, EventArgs e)
        {
            ht();
            vhh(false);
            gtcbb();
        }

        private void them_Click(object sender, EventArgs e)
        {
            themm();
        }

        private void capnhat_Click(object sender, EventArgs e)
        {
            suaa();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            xoaa();
        }

        private void tk_Click(object sender, EventArgs e)
        {
            timk();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_hung.SelectedRows.Count > 0)
            {
                tb_manhanvien_hung.Text = dgv_hung.SelectedRows[0].Cells[0].Value.ToString();
                tb_hotennhanvien_hung.Text = dgv_hung.SelectedRows[0].Cells[1].Value.ToString();
                dgv_ngaysinh_hung.Value = DateTime.Parse(dgv_hung.SelectedRows[0].Cells[2].Value.ToString());
                tb_sodienthoai_hung.Text = dgv_hung.SelectedRows[0].Cells[3].Value.ToString();
                tb_matkhau_hung.Text = dgv_hung.SelectedRows[0].Cells[4].Value.ToString();
                cb_loainguoidung_hung.Text = dgv_hung.SelectedRows[0].Cells[5].Value.ToString();
            }
        }
    }
}
