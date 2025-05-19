using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Database;

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.UI.Binh
{
    public partial class frm_ThongKe_Binh : Form
    {
        Connections connections = new Connections();
        public frm_ThongKe_Binh()
        {
            InitializeComponent();
        }
        private void bt_thongke_binh_Click_1(object sender, EventArgs e)
        {
            string thoiGian = cb_tgmodc_binh.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(thoiGian))
            {
                MessageBox.Show("Vui lòng chọn khoảng thời gian!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ Connections.cs
            DataTable dataTable = connections.GetSoTietKiemByThoiGian(thoiGian);

            // Hiển thị dữ liệu lên DataGridView
            dgv_HthiDs_binh.DataSource = dataTable;

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có sổ tiết kiệm nào trong khoảng thời gian này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_xuat_binh_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Chọn nơi lưu file Excel",
                    Filter = "Excel Files|*.xlsx|All Files|*.*",
                    FileName = "DanhSachSoTietKiem.xlsx" // Tên mặc định
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file do người dùng chọn
                    string filePath = saveFileDialog.FileName;

                    // Khởi tạo ứng dụng Excel
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Application.Workbooks.Add(Type.Missing);

                    // Lấy đối tượng WorkSheet
                    Excel._Worksheet worksheet = (Excel.Worksheet)excelApp.ActiveSheet;

                    // Đặt tên cho sheet
                    worksheet.Name = "Danh sách sổ tiết kiệm";

                    // Xuất tiêu đề cột từ DataGridView sang Excel
                    for (int i = 1; i <= dgv_HthiDs_binh.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i] = dgv_HthiDs_binh.Columns[i - 1].HeaderText;
                    }

                    // Xuất dữ liệu từ DataGridView sang Excel
                    for (int i = 0; i < dgv_HthiDs_binh.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv_HthiDs_binh.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgv_HthiDs_binh.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // Lưu file Excel
                    worksheet.SaveAs(filePath);
                    excelApp.Quit();

                    MessageBox.Show("Dữ liệu đã được xuất ra file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
