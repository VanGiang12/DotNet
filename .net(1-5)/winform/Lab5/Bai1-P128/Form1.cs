using System.Globalization;

namespace Bai1_P128
{
    public partial class Form1 : Form
    {
        string diemdi, diemden;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

            if (lstDiaDiemDi.SelectedItems.Count > 0)
            {
                diemdi = lstDiaDiemDi.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Chưa chọn điểm đi", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lstDiaDiemDen.SelectedItems.Count > 0)
            {
                diemden = lstDiaDiemDen.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Chưa chọn điểm đến", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            rtbDisplay.Text = "Khách hàng: " + txtKhachHang.Text
                + "\nNgày sinh: " + dtpNgaySinh.Text
                + "\nĐịa chỉ: " + txtDiaChi.Text
                + "\nĐiểm xuất phát: " + diemdi
                + "\nĐiểm đến: " + diemden;
            DateTime dt1 = DateTime.ParseExact(dtpNgayVe.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime dt2 = DateTime.ParseExact(dtpNgayDi.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            txtTongSoNgay.Text = dt1.Subtract(dt2).Days.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDiaChi.Clear();
            txtTongSoNgay.Clear();
            txtKhachHang.Clear();
            lstDiaDiemDi.ClearSelected();
            lstDiaDiemDen.ClearSelected();
            dtpNgaySinh.Value = DateTime.Now;
            dtpNgayVe.Value = DateTime.Now;
            dtpNgayDi.Value = DateTime.Now;
            txtKhachHang.Focus();
            rtbDisplay.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}