using Bai5_P164.Data;

namespace Bai5_P164
{
    public partial class Form1 : Form
    {
        List<SinhVienCoKhi> dsSinhvienCK;
        QuanLySinhVien quanLySV = new QuanLySinhVien();
        ListViewItem selectedItem;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dsSinhvienCK = quanLySV.DocDanhSach();

            HienThiDanhSach(dsSinhvienCK);
        }


        private void btnDSSVTruot_Click(object sender, EventArgs e)
        {
            dsSinhvienCK = quanLySV.DocDanhSach();
            listViewDSSV.Items.Clear();

            int count = 0;
            foreach (SinhVienCoKhi sv in dsSinhvienCK)
            {
                if (sv.DTB() < 5)
                {
                    count++;
                    ListViewItem item = new ListViewItem(sv.Masinhvien);
                    item.SubItems.Add(sv.Hoten);
                    item.SubItems.Add(sv.Namsinh.ToString());
                    item.SubItems.Add(sv.Diemkythuat.ToString());
                    item.SubItems.Add(sv.DiemmCNC.ToString());
                    listViewDSSV.Items.Add(item);

                }
            }
            if (count == 0)
            {
                MessageBox.Show("Không có sinh viên nào trượt!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisableTextBoxes();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (btnSua.Text == "Sửa")
            {
                if (listViewDSSV.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Chưa chọn sinh viên cần sửa!");
                    return;
                }
                selectedItem = listViewDSSV.SelectedItems[0];
                txtMaSinhVien.Text = selectedItem.SubItems[0].Text;
                txtTenSinhVien.Text = selectedItem.SubItems[1].Text;
                txtNamSinh.Text = selectedItem.SubItems[2].Text;
                txtDiemVeKyThuat.Text = selectedItem.SubItems[3].Text;
                txtDiemCNC.Text = selectedItem.SubItems[4].Text;

                EnableTextBoxes();
                txtMaSinhVien.Enabled = false;
                btnSua.Text = "Cập nhật";
            }
            else if (btnSua.Text == "Cập nhật")
            {
                if (!ktradulieu())
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ! Vui lòng kiểm tra lại.");
                    return;
                }
                else
                {
                    // Cập nhật lại các SubItems của ListViewItem
                    selectedItem.SubItems[1].Text = txtTenSinhVien.Text;
                    selectedItem.SubItems[2].Text = txtNamSinh.Text;
                    selectedItem.SubItems[3].Text = txtDiemVeKyThuat.Text;
                    selectedItem.SubItems[4].Text = txtDiemCNC.Text;

                    foreach (SinhVienCoKhi sv in dsSinhvienCK)
                    {
                        if (sv.Masinhvien == txtMaSinhVien.Text)
                        {
                            sv.Hoten = selectedItem.SubItems[1].Text;
                            sv.Namsinh = long.Parse(selectedItem.SubItems[2].Text);
                            sv.Diemkythuat = float.Parse(selectedItem.SubItems[3].Text);
                            sv.DiemmCNC = float.Parse(selectedItem.SubItems[4].Text);

                            //MessageBox.Show($"{ sv.Hoten},{sv.Masinhvien}");
                            break;
                        }
                    }

                    quanLySV.GhiDanhSach(dsSinhvienCK);
                    HienThiDanhSach(dsSinhvienCK);

                    btnSua.Text = "Sửa";
                    DisableTextBoxes();
                    ClearTextBoxes();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listViewDSSV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn sinh viên cần xóa");
                return;
            }

            selectedItem = listViewDSSV.SelectedItems[0];
            txtMaSinhVien.Text = selectedItem.SubItems[0].Text;
            txtTenSinhVien.Text = selectedItem.SubItems[1].Text;
            txtNamSinh.Text = selectedItem.SubItems[2].Text;
            txtDiemVeKyThuat.Text = selectedItem.SubItems[3].Text;
            txtDiemCNC.Text = selectedItem.SubItems[4].Text;

            DialogResult ret = MessageBox.Show("Bạn có muốn xóa sinh viên này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (ret == DialogResult.Yes)
            {
                foreach (SinhVienCoKhi sv in dsSinhvienCK)
                {
                    if (sv.Masinhvien == txtMaSinhVien.Text)
                    {
                        dsSinhvienCK.Remove(sv);
                        break;
                    }
                }
                quanLySV.GhiDanhSach(dsSinhvienCK);
                HienThiDanhSach(dsSinhvienCK);
            }
            else
            {
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                //đọc dữ liệu

                dsSinhvienCK = quanLySV.DocDanhSach();

                EnableTextBoxes();

                txtMaSinhVien.Focus();
                btnThem.Text = "Lưu";
            }
            else if (btnThem.Text == "Lưu")
            {
                if (ktradulieu())
                {
                    foreach (SinhVienCoKhi sv in dsSinhvienCK)
                    {
                        if (sv.Masinhvien == txtMaSinhVien.Text)
                        {
                            MessageBox.Show("Mã sinh viên tồn tại. Nhập lại!");
                            return;
                        }
                    }

                    //Thêm sinh viên vào tệp
                    SinhVienCoKhi svck = new SinhVienCoKhi(txtMaSinhVien.Text, txtTenSinhVien.Text,
                        long.Parse(txtNamSinh.Text), float.Parse(txtDiemVeKyThuat.Text), float.Parse(txtDiemCNC.Text));
                    dsSinhvienCK.Add(svck);
                    quanLySV.GhiDanhSach(dsSinhvienCK);

                    btnThem.Text = "Thêm";
                    ClearTextBoxes();
                    DisableTextBoxes();
                }
                else
                {
                    MessageBox.Show("Dữ liệu nhập chưa đúng!");
                    return;
                }
            }
        }
        #region textbox
        private void EnableTextBoxes()
        {
            txtDiemCNC.Enabled = true;
            txtDiemVeKyThuat.Enabled = true;
            txtMaSinhVien.Enabled = true;
            txtNamSinh.Enabled = true;
            txtTenSinhVien.Enabled = true;

        }

        private void DisableTextBoxes()
        {
            txtDiemCNC.Enabled = false;
            txtDiemVeKyThuat.Enabled = false;
            txtMaSinhVien.Enabled = false;
            txtNamSinh.Enabled = false;
            txtTenSinhVien.Enabled = false;
        }

        private void ClearTextBoxes()
        {
            txtMaSinhVien.Clear();
            txtTenSinhVien.Clear();
            txtNamSinh.Clear();
            txtDiemVeKyThuat.Clear();
            txtDiemCNC.Clear();
        }
        #endregion


        #region kiểm tra dữ liệu
        private bool ktra(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            return false;
        }
        private bool ktradulieu()
        {
            long n; float m;
            if (ktra(txtNamSinh.Text) || ktra(txtTenSinhVien.Text) ||
                ktra(txtMaSinhVien.Text) || ktra(txtDiemVeKyThuat.Text) || ktra(txtDiemCNC.Text))
                return false;
            if (!long.TryParse(txtNamSinh.Text, out n) || txtNamSinh.Text.Length != 4) return false;
            if (!float.TryParse(txtDiemCNC.Text, out m)) return false;
            if (!float.TryParse(txtDiemVeKyThuat.Text, out m)) return false;
            return true;

        }
        #endregion

        private void HienThiDanhSach(List<SinhVienCoKhi> dsSV)
        {
            listViewDSSV.Items.Clear();

            foreach (SinhVienCoKhi sv in dsSV)
            {
                ListViewItem item = new ListViewItem(sv.Masinhvien);
                item.SubItems.Add(sv.Hoten);
                item.SubItems.Add(sv.Namsinh.ToString());
                item.SubItems.Add(sv.Diemkythuat.ToString());
                item.SubItems.Add(sv.DiemmCNC.ToString());
                listViewDSSV.Items.Add(item);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}