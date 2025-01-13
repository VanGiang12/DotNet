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

namespace test.NhapSach
{
    public partial class frmXemThongTinDatSach : Form
    {
        MuaSach muasach = new MuaSach();
        public frmXemThongTinDatSach()
        {
            InitializeComponent();
        }

        private void frmXemThongTinDatSach_Load(object sender, EventArgs e)
        {
            dgvDSPhieu.DataSource = muasach.getDSPhieu();
            dgvDSPhieu.Columns[0].HeaderText = "Mã sách";
            dgvDSPhieu.Columns[1].HeaderText = "Tên sách";
            dgvDSPhieu.Columns[2].HeaderText = "Số lượng";
            dgvDSPhieu.Columns[3].HeaderText = "Tên NXB";
            dgvDSPhieu.ClearSelection();
            muasach.getDonViMua_NgayMua();
            lblMaPhieu.Text = "MÃ PHIẾU: " + muasach.MaPhieuMua;
            lblNXB.Text = "NHÀ XUẤT BẢN: " + muasach.layTenNXB;
            lblDonViMua.Text = "ĐƠN VỊ MUA: " + muasach.DonViMua;
            lblNgayDat.Text = "NGÀY ĐẶT: " + muasach.NgayMua.ToString("dd/MM/yyyy");
            lblTongSoLuong.Text = "TỔNG SỐ LƯỢNG: " + muasach.getTongSoLuong();
        }
    }
}
