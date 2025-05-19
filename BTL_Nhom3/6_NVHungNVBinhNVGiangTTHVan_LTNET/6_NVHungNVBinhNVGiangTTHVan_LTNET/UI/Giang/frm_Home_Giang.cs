using _6_NVHungNVBinhNVGiangTTHVan_LTNET.UI.Binh;
using _6_NVHungNVBinhNVGiangTTHVan_LTNET.UI.Giang;
using _6_NVHungNVBinhNVGiangTTHVan_LTNET.UI.Hung;
using _6_NVHungNVBinhNVGiangTTHVan_LTNET.UI.Van;
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
    public partial class frm_Home_Giang : Form
    {
        public static frm_Home_Giang parent;

        frm_ThongTin_Giang form;
        bool menuQLGD = false;

        bool isClickAvarta = false;
        public frm_Home_Giang()
        {
            InitializeComponent();
        }
        void setVisible(bool b1, bool b2)
        {
            // admin
            pn_qlnhanvien_giang.Visible = b1;
            pn_qlloaiso_giang.Visible = b1;

            // nhân viên
            pn_qlkhachhang_giang.Visible = b2;
            pn_thongke_giang.Visible = b2;
            menuQuanlygiaodich_giang.Visible = b2;
        }

        private void frm_Home_Giang_Load(object sender, EventArgs e)
        {
            pn_ThongTin.Visible = false;
            btn_home_binh_Click(sender, e);
            if (frm_Login_Giang.instance)
                setVisible(true, true);
            else
                setVisible(false, true);

        }

        private void ExpandMenu(ref bool b, FlowLayoutPanel fp, System.Windows.Forms.Timer t, int i, int height, int width)
        {
            if (b == false)
            {
                fp.Height += i;
                if (fp.Height >= height)
                {
                    t.Stop();
                    b = true;
                }
            }
            else
            {
                fp.Height -= i;
                if (fp.Height <= width)
                {
                    t.Stop();
                    b = false;
                }
            }
        }

        private void setTextColor(Color home, Color nhanvien, Color loaiso, Color khachhang, Color gui, Color tattoan, Color thongke)
        {
            btn_home_binh.ForeColor = home;
            btn_qlnhanvien_hung.ForeColor = nhanvien;
            btn_qlloaiso_hung.ForeColor = loaiso;
            btn_qlkhachhang_giang.ForeColor = khachhang;
            btn_giaodichgui_van.ForeColor = gui;
            btn_giaodichtattoan_van.ForeColor = tattoan;
            btn_thongke_binh.ForeColor = thongke;
        }

        private void timeMenuQLGD_giang_Tick(object sender, EventArgs e)
        {
            ExpandMenu(ref menuQLGD, menuQuanlygiaodich_giang, timeMenuQLGD_giang, 10, 175, 41);
        }


        #region giang
        private void btn_qlkhachhang_giang_Click(object sender, EventArgs e)
        {
            OpenForm.openForm(new frm_QLKhachHang_Giang(), pnBody);
            setTextColor(
                Color.White,    // home
                Color.White,    // nhân viên
                Color.White,    // loại sổ
                Color.Red,    // khách hàng
                Color.White,    // giao dịch gửi
                Color.White,    // giao dịch tất toán
                Color.White    // thống kê
                );
        }

        private void frm_Home_Giang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region vân
        private void btn_qlgiaodich_van_Click(object sender, EventArgs e)
        {
            timeMenuQLGD_giang.Start();
        }

        private void btn_giaodichgui_van_Click(object sender, EventArgs e)
        {
            OpenForm.openForm(new frm_QLGiaoDichGui_Van(), pnBody);
            setTextColor(
                Color.White,    // home
                Color.White,    // nhân viên
                Color.White,    // loại sổ
                Color.White,    // khách hàng
                Color.Red,    // gửi
                Color.White,    // tất toán
                Color.White    // thống kê
                );
        }

        private void btn_giaodichtattoan_van_Click(object sender, EventArgs e)
        {
            OpenForm.openForm(new frm_QLGiaoDichTatToan_Van(), pnBody);
            setTextColor(
                Color.White,    // home
                Color.White,    // nhân viên
                Color.White,    // loại sổ
                Color.White,    // khách hàng
                Color.White,    // gửi
                Color.Red,    // tất toán
                Color.White    // thống kê
                );
        }


        #endregion

        #region Bình
        private void btn_thongke_binh_Click(object sender, EventArgs e)
        {
            OpenForm.openForm(new frm_ThongKe_Binh(), pnBody);
            setTextColor(
                Color.White,    // home
                Color.White,    // nhân viên
                Color.White,    // loại sổ
                Color.White,    // khách hàng
                Color.White,    // gửi
                Color.White,    // tất toán
                Color.Red    // thống kê
                );
        }

        private void btn_home_binh_Click(object sender, EventArgs e)
        {
            OpenForm.openForm(new frm_GioiThieu_Binh(), pnBody);
            setTextColor(
                Color.White,    // home
                Color.White,    // nhân viên
                Color.White,    // loại sổ
                Color.White,    // khách hàng
                Color.White,    // gửi
                Color.White,    // tất toán
                Color.White    // thống kê
                );
        }
        #endregion

        #region Hưng
        private void btn_qlnhanvien_hung_Click(object sender, EventArgs e)
        {
            OpenForm.openForm(new frm_QLNhanVien_Hung(), pnBody);
            setTextColor(
                Color.White,    // home
                Color.Red,    // nhân viên
                Color.White,    // loại sổ
                Color.White,    // khách hàng
                Color.White,    // gửi
                Color.White,    // tất toán
                Color.White    // thống kê
                );
        }

        private void btn_qlloaiso_hung_Click(object sender, EventArgs e)
        {
            OpenForm.openForm(new frm_QLLoaiSo_Hung(), pnBody);
            setTextColor(
                Color.White,    // home
                Color.White,    // nhân viên
                Color.Red,    // loại sổ
                Color.White,    // khách hàng
                Color.White,    // gửi
                Color.White,    // tất toán
                Color.White    // thống kê
                );
        }
        #endregion

        private void pic_avatar_giang_Click(object sender, EventArgs e)
        {
            if (!isClickAvarta)
            {
                form = new frm_ThongTin_Giang();
                form.FormBorderStyle = FormBorderStyle.None;
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                pn_ThongTin.Controls.Add(form);
                form.Show();
                parent = this;

                pn_ThongTin.Visible = true;
                isClickAvarta = true;
            }
            else
            {
                form.Close();
                pn_ThongTin.Visible = false;
                isClickAvarta = false;
            }
        }


    }
}
