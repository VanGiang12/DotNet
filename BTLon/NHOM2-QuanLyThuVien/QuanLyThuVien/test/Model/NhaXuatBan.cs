using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Model
{
    internal class NhaXuatBan
    {
        private String maNhaXuatBan;
        private String tenNhaXuatBan;
        private String lienHe;

        public string MaNhaXuatBan { get => maNhaXuatBan; set => maNhaXuatBan = value; }
        public string TenNhaXuatBan { get => tenNhaXuatBan; set => tenNhaXuatBan = value; }
        public string LienHe { get => lienHe; set => lienHe = value; }

        public NhaXuatBan() { }
        public NhaXuatBan(string maNhaXuatBan, string tenNhaXuatBan, string lienHe)
        {
            this.MaNhaXuatBan = maNhaXuatBan;
            this.TenNhaXuatBan = tenNhaXuatBan;
            this.LienHe = lienHe;
        }
        public SqlDataAdapter ad;
        public SqlCommand cmd;

        public DataTable getDS()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "select * from nhaxuatban";
                ad = new SqlDataAdapter(sql, con);
                ad.Fill(dt);
            }
            return dt;
        }
        public bool them(NhaXuatBan nxb)
        {
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                try
                {
                    string sql = "insert into nhaxuatban values(@manhaxuatban, @tennhaxuatban, @lienhe)";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@manhaxuatban", nxb.maNhaXuatBan);
                    cmd.Parameters.AddWithValue("@tennhaxuatban", nxb.tenNhaXuatBan);
                    cmd.Parameters.AddWithValue("@lienhe", nxb.lienHe);
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
        public bool sua(NhaXuatBan nxb)
        {
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                try
                {
                    string sql = "update nhaxuatban set tennhaxuatban = @tennhaxuatban, lienhe = @lienhe where manhaxuatban = @manhaxuatban";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@manhaxuatban", nxb.maNhaXuatBan);
                    cmd.Parameters.AddWithValue("@tennhaxuatban", nxb.tenNhaXuatBan);
                    cmd.Parameters.AddWithValue("@lienhe", nxb.lienHe);
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
        public bool xoa(string manhaxuatban)
        {
            using (SqlConnection con = connection.getConnection())
            {
                try
                {
                    con.Open();
                    string sql = "delete from nhaxuatban where manhaxuatban = @manhaxuatban";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@manhaxuatban", manhaxuatban);
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
            using (SqlConnection con = connection.getConnection())
            {
                dt = new DataTable();
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue(s, id);
                        cmd.ExecuteNonQuery();
                        using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                        {
                            ad.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm nhà xuất bản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }
    }

}
;