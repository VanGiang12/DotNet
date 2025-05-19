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
    public partial class frm_tab_BaoCaoTK : Form
    {
        public frm_tab_BaoCaoTK()
        {
            InitializeComponent();
            dgvDanhSachThongKe.ForeColor = Color.Black;
            dgvDanhSachThongKe.DefaultCellStyle.Font = new Font(dgvDanhSachThongKe.DefaultCellStyle.Font, FontStyle.Regular);
        }

        private void frm_tab_BaoCaoTK_Load(object sender, EventArgs e)
        {
            lblSoLuongTheLoai.Text = ThongKe.getSoLuong("theloai").ToString();
            lblSoLuongSach.Text = ThongKe.getSoLuong("sach").ToString();
            lblSoLuongNXB.Text = ThongKe.getSoLuong("nhaxuatban").ToString();
           lblSoLuongMua.Text = ThongKe.getTongSoLuong().ToString();

            int slMuon = ThongKe.getSoLuong("muontra");
            lblTongMuon.Text = "Tổng mượn: " + slMuon.ToString();
        }

        public void TitleMuonTra()
        {
            dgvDanhSachThongKe.Columns[0].HeaderText = "Mã phiếu";
            dgvDanhSachThongKe.Columns[1].HeaderText = "Tên độc giả";
            dgvDanhSachThongKe.Columns[2].HeaderText = "Số thẻ";
            dgvDanhSachThongKe.Columns[3].HeaderText = "Tên sách";
            dgvDanhSachThongKe.Columns[4].HeaderText = "Số lượng mượn";
            dgvDanhSachThongKe.Columns[4].Width = 120;
            dgvDanhSachThongKe.Columns[5].HeaderText = "Ngày mượn";
            dgvDanhSachThongKe.Columns[6].HeaderText = "Ngày hẹn trả";
            dgvDanhSachThongKe.Columns[7].HeaderText = "Ngày trả";
        }

        private void btnDanhSachDaTra_Click(object sender, EventArgs e)
        {
            dgvDanhSachThongKe.DataSource = ThongKe.getDanhSach("is not null");
            TitleMuonTra();
            dgvDanhSachThongKe.ClearSelection();
        }

        private void btnDanhSachChuaTra_Click(object sender, EventArgs e)
        {
            dgvDanhSachThongKe.DataSource = ThongKe.getDanhSach("is null");
            TitleMuonTra();
            dgvDanhSachThongKe.ClearSelection();
        }

        private void lblSoLuongTheLoai_Click(object sender, EventArgs e)
        {
            TheLoai tl = new TheLoai();
            dgvDanhSachThongKe.DataSource = tl.getDS();
            dgvDanhSachThongKe.Columns[0].HeaderText = "Mã thể loại";
            dgvDanhSachThongKe.Columns[1].HeaderText = "Tên thể loại";
            dgvDanhSachThongKe.ClearSelection();
        }

        private void lblSoLuongSach_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            dgvDanhSachThongKe.DataSource = sach.getAllSach();
            dgvDanhSachThongKe.Columns[0].HeaderText = "Mã sách";
            dgvDanhSachThongKe.Columns[1].HeaderText = "Tên sách";
            dgvDanhSachThongKe.Columns[2].HeaderText = "Khoa";
            dgvDanhSachThongKe.Columns[3].HeaderText = "Tác giả";
            dgvDanhSachThongKe.Columns[4].HeaderText = "Thể loại";
            dgvDanhSachThongKe.Columns[5].HeaderText = "Nhà xuất bản";
            dgvDanhSachThongKe.Columns[6].HeaderText = "Số lượng";
            dgvDanhSachThongKe.Columns[7].HeaderText = "Năm xuất bản";
            dgvDanhSachThongKe.ClearSelection();
        }

        private void lblSoLuongNXB_Click(object sender, EventArgs e)
        {
            NhaXuatBan nxb = new NhaXuatBan();
            dgvDanhSachThongKe.DataSource = nxb.getDS();
            dgvDanhSachThongKe.Columns[0].HeaderText = "Mã nhà xuẩt bản";
            dgvDanhSachThongKe.Columns[1].HeaderText = "Tên nhà xuẩt bản";
            dgvDanhSachThongKe.Columns[2].HeaderText = "Liên hệ";
            dgvDanhSachThongKe.ClearSelection();
        }

        private void lblSoLuongMua_Click(object sender, EventArgs e)
        {
            dgvDanhSachThongKe.DataSource= ThongKe.getDSDatSach();
            dgvDanhSachThongKe.Columns[0].HeaderText = "Mã đặt";
            dgvDanhSachThongKe.Columns[1].Visible = false;
            dgvDanhSachThongKe.Columns[2].HeaderText = "Mã sách";
            dgvDanhSachThongKe.Columns[3].HeaderText = "Tên sách";
            dgvDanhSachThongKe.Columns[4].HeaderText = "Số lượng";
            dgvDanhSachThongKe.ClearSelection();
        }

        private void btnDSQuaHan_Click(object sender, EventArgs e)
        {
            dgvDanhSachThongKe.DataSource = ThongKe.getDSQuaHan();
            TitleMuonTra();
            dgvDanhSachThongKe.ClearSelection();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            dgvDanhSachThongKe.DataSource = MuonTra.getborrowPay();
            TitleMuonTra();
            dgvDanhSachThongKe.ClearSelection();
        }

        

        private void lblSoLuongTheLoai_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LimeGreen;
        }

        private void lblSoLuongTheLoai_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.YellowGreen;
        }

        private void lblSoLuongSach_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.LightBlue;
        }

        private void lblSoLuongSach_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Blue;
        }

        private void lblSoLuongNXB_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Tomato;
        }

        private void lblSoLuongNXB_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Red;
        }

        private void lblSoLuongMua_MouseHover(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Wheat;
        }

        private void lblSoLuongMua_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Orange;
        }

       
    }
}
