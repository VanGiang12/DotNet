using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.GiaoDich;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.UI.Van
{

    public partial class frm_QLGiaoDichTatToan_Van : Form
    {
        QLGiaoDich gd = new QLGiaoDich();
        int month;

        public frm_QLGiaoDichTatToan_Van()
        {
            InitializeComponent();
        }
        public bool Validation(string s)
        {
            int n;
            if (!string.IsNullOrEmpty(s) || int.TryParse(s, out n))
                return true;
            return false;
        }

        private void frm_QLGiaoDichTatToan_Van_Load(object sender, EventArgs e)
        {
            dgv_DanhSach_Van.DataSource = gd.ShowSTK();
        }

        private void btnTatToan_Click(object sender, EventArgs e)
        {
            decimal LAIKHONGHAN = gd.getLaiKhongHan();
            decimal tong;
            bool tt = cb_TrangThaiSo_Van.Text == "Mở";

            if (cb_TrangThaiSo_Van.Text == "Đóng")
            {
                MessageBox.Show("Sổ đã đóng, không thể tất toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txt_TenLoaiSo_Van.Text != "Không kì hạn")
            {
                month = (int)gd.getThang(txt_TenLoaiSo_Van.Text).Rows[0][0];
                int thang = month;
                txt_SoTienRut_Van.Text = txt_SoTienGui_Van.Text;

                tong = gd.TienTheoThang(LAIKHONGHAN,
                    int.Parse(txt_SoTienGui_Van.Text),
                    thang,
                    decimal.Parse(txt_LaiSuat_Van.Text),
                    dtp_NgayMoSo_Van.Value,
                    dtp_NgayDenHan_Van.Value,
                    dtp_NgayRut_Van.Value,
                    tt
                );

                txt_SoTienLai_Van.Text = (tong - int.Parse(txt_SoTienGui_Van.Text)).ToString();
                txt_TongThanhToan_Van.Text = tong.ToString();

                if (txt_SoTienRut_Van.Text == "")
                {
                    txt_TongThanhToan_Van.Text = (tong - int.Parse(txt_SoTienGui_Van.Text)).ToString();
                }
                else
                {
                    cb_TrangThaiSo_Van.Text = "Đóng";
                }
            }
            else
            {
                if (dtp_NgayHienTai_Van.Value.Year >= (dtp_NgayMoSo_Van.Value.Year + 1)) // nếu chưa rút bao giờ 
                {
                    dtp_NgayRut_Van.Value = dtp_NgayHienTai_Van.Value;
                    if (string.IsNullOrEmpty(txt_SoTienRut_Van.Text))
                    {
                        tong = gd.TienKhongHan(LAIKHONGHAN,
                            int.Parse(txt_SoTienGui_Van.Text),
                            0,
                            decimal.Parse(txt_LaiSuat_Van.Text),
                            dtp_NgayMoSo_Van.Value,
                            dtp_NgayRut_Van.Value,
                            tt,
                            dtp_NgayHienTai_Van.Value
                        );
                        txt_SoTienLai_Van.Text = (tong - int.Parse(txt_SoTienGui_Van.Text)).ToString();
                        txt_SoTienRut_Van.Text = txt_SoTienLai_Van.Text;
                        txt_TongThanhToan_Van.Text = txt_SoTienLai_Van.Text;

                    }
                    if (txt_SoTienRut_Van.Text == txt_SoTienGui_Van.Text) // rút hết
                    {
                        txt_SoTienRut_Van.Text = txt_SoTienGui_Van.Text;
                        decimal tienRut = decimal.Parse(txt_SoTienRut_Van.Text);
                        tong = gd.TienKhongHan(LAIKHONGHAN,
                            int.Parse(txt_SoTienGui_Van.Text),
                           tienRut,
                            decimal.Parse(txt_LaiSuat_Van.Text),
                            dtp_NgayMoSo_Van.Value,
                            dtp_NgayRut_Van.Value,
                            tt,
                           dtp_NgayHienTai_Van.Value
                        );

                        txt_SoTienLai_Van.Text = (tong - int.Parse(txt_SoTienGui_Van.Text)).ToString();
                        txt_TongThanhToan_Van.Text = tong.ToString();
                        cb_TrangThaiSo_Van.Text = "Đóng";
                    }
                }
                else // đã từng rút lãi
                {
                    if (dtp_NgayHienTai_Van.Value.Year < (dtp_NgayRut_Van.Value.Year + 1))
                    {
                        MessageBox.Show("Bạn chưa đến kì rút lãi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txt_SoTienRut_Van.Text)) // rút lãi
                        {
                            tong = gd.TienKhongHan(LAIKHONGHAN,
                            int.Parse(txt_SoTienGui_Van.Text),
                         0,
                            decimal.Parse(txt_LaiSuat_Van.Text),
                            dtp_NgayRut_Van.Value,
                            dtp_NgayHienTai_Van.Value,
                            tt,
                            dtp_NgayHienTai_Van.Value
                        );
                            txt_SoTienLai_Van.Text = (tong - int.Parse(txt_SoTienGui_Van.Text)).ToString();
                            txt_SoTienRut_Van.Text = txt_SoTienLai_Van.Text;
                            txt_TongThanhToan_Van.Text = txt_SoTienLai_Van.Text;
                        }
                        if (txt_SoTienRut_Van.Text == txt_SoTienGui_Van.Text) // rút hết
                        {
                            txt_SoTienRut_Van.Text = txt_SoTienGui_Van.Text;
                            decimal tienRut = decimal.Parse(txt_SoTienRut_Van.Text);
                            tong = gd.TienKhongHan(LAIKHONGHAN,
                                int.Parse(txt_SoTienGui_Van.Text),
                               tienRut,
                                decimal.Parse(txt_LaiSuat_Van.Text),
                                dtp_NgayRut_Van.Value,
                                dtp_NgayDenHan_Van.Value,
                                tt,
                               dtp_NgayHienTai_Van.Value
                            );

                            txt_SoTienLai_Van.Text = (tong - int.Parse(txt_SoTienGui_Van.Text)).ToString();
                            txt_TongThanhToan_Van.Text = tong.ToString();
                            cb_TrangThaiSo_Van.Text = "Đóng";
                        }
                    }
                }
            }

            string mastk = txt_MaSTK_Van.Text;
            DateTime ngayrut = dtp_NgayRut_Van.Value.Date;
            decimal sotienrut = decimal.Parse(txt_TongThanhToan_Van.Text);
            bool trangthai = cb_TrangThaiSo_Van.Text == "Mở" ? true : false;

            gd.UpdateSoTienRut(mastk, ngayrut, sotienrut, trangthai);
            dgv_DanhSach_Van.DataSource = gd.ShowSTK();
        }

    
        

        private void txtMaSTK_MouseLeave(object sender, EventArgs e)
        {
            DataTable dt = gd.FindSTK(txt_MaSTK_Van.Text);
            if (dt.Rows.Count > 0)
            {
                txt_MaSTK_Van.Text = dt.Rows[0][0].ToString();
                txt_MaNV_Van.Text = dt.Rows[0][1].ToString();
                txt_MaKH_Van.Text = dt.Rows[0][2].ToString();
                txt_CMND_Van.Text = dt.Rows[0][3].ToString();
                txt_TenKH_Van.Text = dt.Rows[0][4].ToString();
                txt_TenLoaiSo_Van.Text = dt.Rows[0][5].ToString();
                txt_LaiSuat_Van.Text = dt.Rows[0][6].ToString();
                dtp_NgayMoSo_Van.Text = dt.Rows[0][7].ToString();
                dtp_NgayDenHan_Van.Text = dt.Rows[0][8].ToString();
                txt_SoTienGui_Van.Text = dt.Rows[0][9].ToString();
                dtp_NgayRut_Van.Text = dt.Rows[0][10].ToString();
                txt_SoTienRut_Van.Text = dt.Rows[0][11].ToString();
                cb_TrangThaiSo_Van.Text = dt.Rows[0][12].ToString();
                txt_DiaChi_Van.Text = dt.Rows[0][13].ToString();
                txt_SDT_Van.Text = dt.Rows[0][14].ToString();
            }
            else
            {
                MessageBox.Show("Kiểm tra mã sổ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_DanhSach_Van.SelectedRows.Count > 0)
            {
                txt_MaSTK_Van.Text = dgv_DanhSach_Van.SelectedRows[0].Cells[0].Value.ToString();
                if (!string.IsNullOrWhiteSpace(txt_MaSTK_Van.Text))
                {
                    DataTable dt = gd.FindSTK(txt_MaSTK_Van.Text);
                    txt_MaNV_Van.Text = dt.Rows[0][1].ToString();
                    txt_MaKH_Van.Text = dt.Rows[0][2].ToString();
                    txt_CMND_Van.Text = dt.Rows[0][3].ToString();
                    txt_TenKH_Van.Text = dt.Rows[0][4].ToString();
                    txt_TenLoaiSo_Van.Text = dt.Rows[0][5].ToString();
                    txt_LaiSuat_Van.Text = dt.Rows[0][6].ToString();
                    dtp_NgayMoSo_Van.Text = dt.Rows[0][7].ToString();

                    if (txt_TenLoaiSo_Van.Text.Equals("Không kì hạn"))
                    {
                        dtp_NgayDenHan_Van.CustomFormat = " ";
                        dtp_NgayDenHan_Van.Format = DateTimePickerFormat.Custom;
                    }
                    else
                    {
                        dtp_NgayDenHan_Van.CustomFormat = "dd/MM/yyyy";
                        dtp_NgayDenHan_Van.Format = DateTimePickerFormat.Custom;
                        dtp_NgayDenHan_Van.Text = dt.Rows[0][8].ToString();
                    }

                    txt_SoTienGui_Van.Text = dt.Rows[0][9].ToString();
                    dtp_NgayRut_Van.Text = dt.Rows[0][10].ToString();
                    txt_SoTienRut_Van.Text = dt.Rows[0][11].ToString();
                    cb_TrangThaiSo_Van.Text = dt.Rows[0][12].ToString();
                    txt_DiaChi_Van.Text = dt.Rows[0][13].ToString();
                    txt_SDT_Van.Text = dt.Rows[0][14].ToString();
                }
                else { return; }
            }
            else
            {
                MessageBox.Show("Chưa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_clear_van_Click(object sender, EventArgs e)
        {
            txt_MaSTK_Van.ResetText();
            txt_MaNV_Van.ResetText();
            txt_MaKH_Van.ResetText();
            txt_CMND_Van.ResetText();
            txt_TenKH_Van.ResetText();
            txt_TenLoaiSo_Van.ResetText();
            txt_LaiSuat_Van.ResetText();
            dtp_NgayMoSo_Van.Value = DateTime.Now;
            dtp_NgayDenHan_Van.Value = DateTime.Now;
            txt_SoTienGui_Van.ResetText();
            dtp_NgayRut_Van.Value = DateTime.Now;
            txt_SoTienRut_Van.ResetText();
            cb_TrangThaiSo_Van.SelectedIndex = -1;
            txt_DiaChi_Van.ResetText();
            txt_SDT_Van.ResetText();
            txt_SoTienLai_Van.ResetText();
            txt_TongThanhToan_Van.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSach_Van.SelectedRows.Count > 0)
            {
                if (cb_TrangThaiSo_Van.Text == "Đóng")
                {
                    gd.XoaSTK(txt_MaSTK_Van.Text);
                    dgv_DanhSach_Van.DataSource = gd.ShowSTK();
                }
                else
                {
                    MessageBox.Show("Sổ chưa tất toán, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            dgv_DanhSach_Van.DataSource = gd.FindSTK(txt_MaSTK_Van.Text);
        }

    }
}

