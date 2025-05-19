using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test.Model
{
    internal class Sach
    {
        private string maSach;
        private string tenSach;
        private string khoa;
        private string maTacGia;
        private string maTheLoai;
        private string maNhaXuatBan;
        private int soLuong;
        private string namXuatBan;

        private SqlDataAdapter adapter;
        private SqlCommand command;

        public Sach() { }
        public Sach(string maSach, string tenSach, string khoa, string maTacGia, string maTheLoai, string maNhaXuatBan, int soLuong, string namXuatBan)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.khoa = khoa;
            this.maTacGia = maTacGia;
            this.maTheLoai = maTheLoai;
            this.maNhaXuatBan = maNhaXuatBan;
            this.soLuong = soLuong;
            this.namXuatBan = namXuatBan;
        }

        public DataTable getAllSach()
        {
            DataTable dt = new DataTable();
            string sql = "select masach, tensach, khoa, tentacgia, tentheloai, tennhaxuatban, soluong, namxuatban FROM sach " +
                 "join tacgia on sach.matacgia = tacgia.matacgia " +
                 "join theloai on sach.matheloai = theloai.matheloai " +
                 "join nhaxuatban on sach.manhaxuatban = nhaxuatban.manhaxuatban";
            using (SqlConnection conn = connection.getConnection())
            {
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public bool Insert(Sach s)
        {
            SqlConnection conn = connection.getConnection();
            string sql = "insert into sach(masach,tensach,khoa,matacgia,matheloai,manhaxuatban,soluong,namxuatban) values(@maSach,@tenSach,@khoa,@maTacGia,@maTheLoai,@maNXB,@soLuong,@namXB)";

            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@maSach", s.maSach);
                command.Parameters.AddWithValue("@tenSach", s.tenSach);
                command.Parameters.AddWithValue("@khoa", s.khoa);
                command.Parameters.AddWithValue("@maTacGia", s.maTacGia);
                command.Parameters.AddWithValue("@maTheLoai", s.maTheLoai);
                command.Parameters.AddWithValue("@maNXB", s.maNhaXuatBan);
                command.Parameters.AddWithValue("@soLuong", s.soLuong);
                command.Parameters.AddWithValue("@namXB", s.namXuatBan);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public bool Update(Sach s)
        {
            SqlConnection conn = connection.getConnection();
            string sql = "update sach set tensach=@tenSach,khoa=@khoa," +
                "matacgia=@maTacGia,matheloai=@maTheLoai,manhaxuatban=@maNXB,soluong=@soLuong,namxuatban=@namXB where masach=@maSach";

            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@maSach", s.maSach);
                command.Parameters.AddWithValue("@tenSach", s.tenSach);
                command.Parameters.AddWithValue("@khoa", s.khoa);
                command.Parameters.AddWithValue("@maTacGia", s.maTacGia);
                command.Parameters.AddWithValue("@maTheLoai", s.maTheLoai);
                command.Parameters.AddWithValue("@maNXB", s.maNhaXuatBan);
                command.Parameters.AddWithValue("@soLuong", s.soLuong);
                command.Parameters.AddWithValue("@namXB", s.namXuatBan);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public bool Delete(string id)
        {
            SqlConnection conn = connection.getConnection();
            string sql = "delete from sach where masach=@maSach";
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@maSach", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public DataTable Search(string id, string sql, string s)
        {
            DataTable dt;
            using (SqlConnection conn = connection.getConnection())
            {
                dt = new DataTable();
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(s, id);
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                        {
                            dataAdapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            return dt;
        }

        public string GetMaFromTable(string tableName, string columnMa,string columeName, string name)
        {
            string ma = "";
            string sql = $"SELECT {columnMa} FROM {tableName} WHERE {columeName} = @name";

            try
            {
                using (SqlConnection conn = connection.getConnection())
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@name", name);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        ma = reader[columnMa].ToString();
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
               MessageBox.Show("Lỗi"+ ex.Message);
            }
            
            return ma;
        }

        public void Truyen_DLCombobox(string columnName,string tableName,ComboBox cbo,List<string> lst)
        {
            using(SqlConnection conn = connection.getConnection())
            {
                conn.Open();
                string sql = $"select {columnName} from {tableName}";
                adapter =new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach(DataRow row in dt.Rows)
                {
                    cbo.Items.Add(row[columnName].ToString());
                    lst.Add(row[columnName].ToString());
                }
            }
        }
    }
}
