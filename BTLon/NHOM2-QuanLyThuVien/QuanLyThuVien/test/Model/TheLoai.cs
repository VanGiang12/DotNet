using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Model
{
    internal class TheLoai
    {
        private string maTheLoai;
        private string tenTheLoai;

        public string MaTheLoai { get => maTheLoai; set => maTheLoai = value; }
        public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }

        public TheLoai() { }
        public TheLoai(string maTheLoai, string tenTheLoai)
        {
            this.MaTheLoai = maTheLoai;
            this.TenTheLoai = tenTheLoai;
        }
        public SqlDataAdapter ad;
        public SqlCommand cmd;
        public DataTable getDS()
        {

            DataTable dt = new DataTable();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "select * from theloai";
                ad = new SqlDataAdapter(sql, con);
                ad.Fill(dt);
            }
            return dt;
        }
        public bool them(TheLoai theLoai)
        {
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                try
                {
                    string sql = "insert into theloai values(@matheloai, @tentheloai)";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@matheloai", theLoai.maTheLoai);
                    cmd.Parameters.AddWithValue("@tentheloai", theLoai.tenTheLoai);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        public bool sua(TheLoai theLoai)
        {
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                try
                {
                    string sql = "update theloai set tentheloai = @tentheloai where matheloai = @matheloai";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@tentheloai", theLoai.tenTheLoai);
                    cmd.Parameters.AddWithValue("@matheloai", theLoai.maTheLoai);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thất bại" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        public bool xoa(string matheloai)
        {
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                try
                {
                    string sql = "delete from theloai where matheloai = @matheloai";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@matheloai", matheloai);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        public DataTable timKiem(string id, string sql, string s)
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
    }
}
