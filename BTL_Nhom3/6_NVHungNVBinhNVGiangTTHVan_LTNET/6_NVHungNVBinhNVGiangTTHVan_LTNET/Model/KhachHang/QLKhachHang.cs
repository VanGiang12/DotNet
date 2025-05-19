using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;


namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.KhachHang
{
    internal class QLKhachHang
    {
        // get ds khách hàng
        public DataTable getDanhSacKH(string s)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = Connections.connect())
            {
                conn.Open();
                string sql = "select * from KhachHang" + s;
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);
            }
            return dt;
        }
        // thêm
        public bool Them(KhachHang khachHang)
        {
            try
            {
                using (SqlConnection conn = Connections.connect())
                {
                    conn.Open();
                    string sql = "INSERT INTO KhachHang VALUES(@ma,@ten,@cmnd,@diachi,@sdt)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("ma", khachHang.Makh);
                    cmd.Parameters.AddWithValue("ten", khachHang.Tenkh);
                    cmd.Parameters.AddWithValue("cmnd", khachHang.Cmnd);
                    cmd.Parameters.AddWithValue("diachi", khachHang.Diachi);
                    cmd.Parameters.AddWithValue("sdt", khachHang.Sdt);
                    int row = cmd.ExecuteNonQuery();
                    return row > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        // sửa
        public bool Sua(KhachHang khachHang)
        {
            try
            {
                using (SqlConnection conn = Connections.connect())
                {
                    conn.Open();
                    string sql = "UPDATE KhachHang SET HoTenKH = @ten, CMND = @cmnd, DiaChi = @diachi, SDT = @sdt WHERE MaKH = @ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("ma", khachHang.Makh);
                    cmd.Parameters.AddWithValue("ten", khachHang.Tenkh);
                    cmd.Parameters.AddWithValue("cmnd", khachHang.Cmnd);
                    cmd.Parameters.AddWithValue("diachi", khachHang.Diachi);
                    cmd.Parameters.AddWithValue("sdt", khachHang.Sdt);
                    int row = cmd.ExecuteNonQuery();
                    return row > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        // xóa

        public bool Xoa(string makh)
        {
            try
            {
                using (SqlConnection conn = Connections.connect())
                {
                    conn.Open();
                    string sql = "DELETE FROM KhachHang WHERE MaKH = @ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("ma", makh);
                    int row = cmd.ExecuteNonQuery();
                    return row > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public void XuatExcel(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                // Tạo hộp thoại lưu để người dùng chọn nơi lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
              
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = saveFileDialog.FileName;

                    // Khởi tạo đối tượng ExcelPackage để tạo file Excel
                    // nếu k dùng using để tự giải phóng thì sau p dùng package.Dispose
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        // Tạo một worksheet mới
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Khách Hàng");

                        // Thêm tiêu đề từ DataGridView vào dòng đầu tiên của Excel
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            //          hàng 1, cột i+1
                            worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                        }

                        // Thêm dữ liệu từ DataGridView vào Excel
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        // Tự động điều chỉnh kích thước cột cho vừa với nội dung
                        worksheet.Cells.AutoFitColumns();

                        // Lưu file Excel vào vị trí đã chọn
                        File.WriteAllBytes(filePath, package.GetAsByteArray());
                    }

                    MessageBox.Show("Xuất dữ liệu thành công!");
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
            }
        }

    }
}
