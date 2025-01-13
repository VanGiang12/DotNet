using QLBanHang.Data.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai.banhang
{
    public partial class BH : Form
    {
        QLChiTIet qLChiTIet = new QLChiTIet();
        public BH()
        {
            InitializeComponent();
        }

        private void BH_Load(object sender, EventArgs e)
        {
            cboMH.DataSource = qLChiTIet.getTenMH();
            cboMH.DisplayMember = "TenMH";
            cboMH.ValueMember = "MaMH";

            cboKH.DataSource = qLChiTIet.getTenKH();
            cboKH.DisplayMember = "HoTen";
            cboKH.ValueMember = "MaKH";
        }

        int i = 1;
        private void btnThem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell { Value = i++ });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = cboMH.Text });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = txtSL.Text });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = txtDonGia.Text });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = int.Parse(txtSL.Text) * int.Parse(txtDonGia.Text) });

            dgvDS.Rows.Add(row);
        }

        bool ktradauvao()
        {
            if (string.IsNullOrWhiteSpace(txtSoHieu.Text))
                return true;
            return false;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!ktradauvao())
            {
                qLChiTIet.ThemBanHang(int.Parse(txtSoHieu.Text), cboKH.SelectedValue.ToString(), dtpNgayMua.Value);
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
            }

        }
    }
}
