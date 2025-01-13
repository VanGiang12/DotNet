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
    public partial class frm_QLLoaiSo_Hung : Form
    {
        action ac = new action();
        string ma = "";
        string ten = "";
        decimal lstt = 0;
        int st = 0;
        bool dn = true;
        LoaiSo ls = new LoaiSo();

        public frm_QLLoaiSo_Hung()
        {
            InitializeComponent();
        }

        void vhh(bool x)
        {
            tb_maloaiso_hung.Enabled = x;
            cb_tenloaiso_hung.Enabled = x;
            tb_laisuattheothang_hung.Enabled = x;
            cb_sothang_hung.Enabled = x;
        }

        void ht()
        {
            dgv_hung.DataSource = ac.ht();
            dgv_hung.Columns["MaLoaiSo"].HeaderText = "Mã loại sổ";
            dgv_hung.Columns["TenLoaiSo"].HeaderText = "Tên loại sổ";
            dgv_hung.Columns["LaiSuatThang"].HeaderText = "Lãi xuất tháng";
            dgv_hung.Columns["SoThang"].HeaderText = "Số tháng";
        }

        void gt()
        {
            ma = tb_maloaiso_hung.Text;
            ten = cb_tenloaiso_hung.Text;
            lstt = decimal.Parse(tb_laisuattheothang_hung.Text);
            st = int.Parse(cb_sothang_hung.Text);
            ls = new LoaiSo(ma, ten, lstt, st);
        }

        void kt()
        {
            if ((ten.Equals("Không kỳ hạn") && st != 0) || (ten.Equals("3 tháng") && st != 3) || (ten.Equals("6 tháng") && st != 6 || (ten.Equals("9 tháng") && st != 9 || (ten.Equals("12 tháng") && st != 12))))
            {
                MessageBox.Show("Tên loại sổ phải tương ứng với số tháng");
            }
            else
            {
                dn = false;
            }
        }

        void themm()
        {
            if(bt_them_hung.Text == "Thêm")
            {
                bt_them_hung.Text = "Lưu";
                vhh(true);
                tb_maloaiso_hung.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(tb_maloaiso_hung.Text) || string.IsNullOrEmpty(cb_tenloaiso_hung.Text) || string.IsNullOrEmpty(tb_laisuattheothang_hung.Text) || string.IsNullOrEmpty(cb_sothang_hung.Text))
                {
                    MessageBox.Show("Bạn cần phải nhập đủ thông tin");
                }
                else
                {
                    gt();
                    kt();
                    if (dn == false)
                    {
                        if (ac.them(ls))
                        {
                            ht();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            vhh(false);
                            bt_them_hung.Text = "Thêm";
                        }
                        else
                        {
                            MessageBox.Show("Đã đạt số lượng tối đa 1 loại sổ có thể thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        void suaa()
        {
            if (bt_capnhat_hung.Text == "Cập nhật")
            {
                bt_capnhat_hung.Text = "Lưu";
                vhh(true);
                tb_maloaiso_hung.Enabled = false;
                cb_tenloaiso_hung.Focus();
            }
            else
            {
                gt();
                if (string.IsNullOrEmpty(tb_maloaiso_hung.Text) || string.IsNullOrEmpty(cb_tenloaiso_hung.Text) || string.IsNullOrEmpty(tb_laisuattheothang_hung.Text) || string.IsNullOrEmpty(cb_sothang_hung.Text))
                {
                    MessageBox.Show("Bạn cần phải nhập đủ thông tin");
                }
                else
                {
                    kt();

                    if (dn == false)
                    {
                        if (ac.sua(ls))
                        {
                            ht();
                            MessageBox.Show("Cập nhật thành công", "Thông báo");
                            vhh(false);
                            bt_capnhat_hung.Text = "Cập nhật";
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công!!! Vui lòng xem lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        void xoaa()
        {
            gt();
            if (ac.xoa(ls))
            {
                ht();
                MessageBox.Show("Xóa thành công", "Thông báo");

            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void timk()
        {
            var tt = ac.tk(tb_timkiem_hung.Text);
            if(tt == null)
            {
                MessageBox.Show("Không tìm thấy tên mà bạn yêu cầu","Thông báo");
                ht();
            }
            else
            {
                dgv_hung.DataSource = tt;
            }
        }


        private void frm_QLLoaiSo_Hung_Load(object sender, EventArgs e)
        {
            ht();
            vhh(false);
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_hung.SelectedRows.Count > 0)
            {
                tb_maloaiso_hung.Text = dgv_hung.SelectedRows[0].Cells[0].Value.ToString();
                cb_tenloaiso_hung.Text = dgv_hung.SelectedRows[0].Cells[1].Value.ToString();
                tb_laisuattheothang_hung.Text = dgv_hung.SelectedRows[0].Cells[2].Value.ToString();
                cb_sothang_hung.Text = dgv_hung.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void tk_Click(object sender, EventArgs e)
        {
            timk();
        }
    }
}
