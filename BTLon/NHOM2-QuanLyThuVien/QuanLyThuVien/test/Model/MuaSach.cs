using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using test.NhapSach;

namespace test.Model
{
    internal class MuaSach
    {
        private String maPhieuMua, donViMua, maNhaXuatBan;
        private DateTime ngayMua;
        public String layTenNXB;
        public MuaSach() { }
        public MuaSach(string maPhieuMua, string donViMua, string maNhaXuatBan, DateTime ngayMua)
        {
            this.MaPhieuMua = maPhieuMua;
            this.DonViMua = donViMua;
            this.MaNhaXuatBan = maNhaXuatBan;
            this.NgayMua = ngayMua;
        }

        public string MaPhieuMua { get => maPhieuMua; set => maPhieuMua = value; }
        public string DonViMua { get => donViMua; set => donViMua = value; }
        public string MaNhaXuatBan { get => maNhaXuatBan; set => maNhaXuatBan = value; }
        public DateTime NgayMua { get => ngayMua; set => ngayMua = value; }

        public SqlDataAdapter ad;
        public SqlCommand cmd;

        public DataTable getDS()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "select maphieumua, donvimua, nhaxuatban.tennhaxuatban, ngaymua " +
                    "from muasach join nhaxuatban on muasach.manhaxuatban = nhaxuatban.manhaxuatban";
                ad = new SqlDataAdapter(sql, con);
                ad.Fill(dt);
            }
            return dt;
        }

        public DataTable getNXB()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "select maphieumua, donvimua, nhaxuatban.tennhaxuatban, ngaymua from muasach join nhaxuatban on muasach.manhaxuatban = nhaxuatban.manhaxuatban";
                ad = new SqlDataAdapter(sql, con);
                ad.Fill(dt);
            }
            return dt;
        }

        public bool them(MuaSach muasach)
        {
            try
            {
                using (SqlConnection con = connection.getConnection())
                {
                    con.Open();
                    string sql = "insert into muasach values(@maphieumua, @donvimua, @manhaxuatban, @ngaymua)";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@maphieumua", muasach.maPhieuMua);
                    cmd.Parameters.AddWithValue("@donvimua", muasach.donViMua);
                    cmd.Parameters.AddWithValue("@manhaxuatban", muasach.maNhaXuatBan);
                    cmd.Parameters.AddWithValue("@ngaymua", muasach.ngayMua);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool sua(MuaSach muasach)
        {
            try
            {
                using (SqlConnection con = connection.getConnection())
                {
                    con.Open();
                    string sql = "update muasach set manhaxuatban = @manhaxuatban, ngaymua=@ngaymua where maphieumua = @maphieumua";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@maphieumua", muasach.maPhieuMua);
                    cmd.Parameters.AddWithValue("@manhaxuatban", muasach.maNhaXuatBan);
                    cmd.Parameters.AddWithValue("@ngaymua", muasach.ngayMua);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool xoa(String ma)
        {
            try
            {
                using (SqlConnection con = connection.getConnection())
                {
                    con.Open();
                    string sql = "delete from muasach where maphieumua = @maphieumua";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@maphieumua", ma);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public DataTable timkiem(string id, string sql, string s)
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

        public String getMaNXB(String tenNXB)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "select manhaxuatban from nhaxuatban where tennhaxuatban = @tenNXB";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@tenNXB", tenNXB);
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    ad.Fill(dt);
                }
            }
            // Kiểm tra nếu có kết quả trả về
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["manhaxuatban"].ToString();
            }
            else
            {
                // Trả về null hoặc một giá trị mặc định nếu không tìm thấy
                return null;
            }
        }

        public List<string> getDSTenNXB()
        {
            List<string> dsTenNXB = new List<string>(); // Chỉ định kiểu dữ liệu của danh sách
            DataTable dt = new DataTable();

            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "select tennhaxuatban from nhaxuatban";
                ad = new SqlDataAdapter(sql, con);
                ad.Fill(dt);
            }

            // Lặp qua các dòng trong DataTable và thêm giá trị của cột 'tennhaxuatban' vào danh sách
            foreach (DataRow row in dt.Rows)
            {
                dsTenNXB.Add(row["tennhaxuatban"].ToString());
            }

            return dsTenNXB;
        }

        public DataTable getDSDatSach()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "select madat,maphieumua, masach, tensach, soluong from datsach where maphieumua = @maphieu1";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maphieu1", frmPhieuMua.laymaphieu);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        ad.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public bool themSach(String madat, String masach, String maphieumua, String tensach, int soluong)
        {
            try
            {
                using (SqlConnection con = connection.getConnection())
                {
                    con.Open();
                    string sql = "insert into datsach values(@madat, @masach, @maphieumua, @tensach, @soluong)";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@madat", madat);
                    cmd.Parameters.AddWithValue("@masach", masach);
                    cmd.Parameters.AddWithValue("@maphieumua", maphieumua);
                    cmd.Parameters.AddWithValue("@tensach", tensach);
                    cmd.Parameters.AddWithValue("@soluong", soluong);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("  Thêm thất bại" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool suaSach(String madat, String masach, String maphieumua, String tensach, int soluong)
        {
            try
            {
                using (SqlConnection con = connection.getConnection())
                {
                    con.Open();
                    string sql = "update datsach set masach = @masach, maphieumua=@maphieumua, tensach = @tensach, soluong = @soluong where madat = @madat";
                    using (cmd = new SqlCommand(sql, con))
                    {
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@madat", madat);
                        cmd.Parameters.AddWithValue("@masach", masach);
                        cmd.Parameters.AddWithValue("@maphieumua", maphieumua);
                        cmd.Parameters.AddWithValue("@tensach", tensach);
                        cmd.Parameters.AddWithValue("@soluong", soluong);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool xoaSach(String madat)
        {
            try
            {
                using (SqlConnection con = connection.getConnection())
                {
                    con.Open();
                    string sql = "delete from datsach where madat = @madat";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@madat", madat);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool themNXB(String manxb, String tennxb, String lienhe)
        {
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                try
                {
                    string sql = "insert into nhaxuatban values(@manhaxuatban, @tennhaxuatban, @lienhe)";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@manhaxuatban", manxb);
                    cmd.Parameters.AddWithValue("@tennhaxuatban", tennxb);
                    cmd.Parameters.AddWithValue("@lienhe", lienhe);
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

        public List<string> getDSMaDat()
        {
            List<String> dsmadat = new List<String>();
            DataTable dt = new DataTable();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "select madat from datsach";
                ad = new SqlDataAdapter(sql, con);
                ad.Fill(dt);
            }
            foreach (DataRow dr in dt.Rows)
            {
                dsmadat.Add(dr["madat"].ToString());
            }
            return dsmadat;
        }

        public int getTongSoLuong()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "SELECT sum(soluong) as soluong \r\nFROM muasach\r\nJOIN datsach ON datsach.maphieumua = muasach.maphieumua \r\nWHERE muasach.maphieumua = @maphieumua";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maphieumua", frmPhieuMua.laymaphieu);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        ad.Fill(dt);
                    }
                }
            }
            return int.Parse(dt.Rows[0]["soluong"].ToString());
        }

        public void getDonViMua_NgayMua()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "SELECT maphieumua, donvimua, ngaymua\r\nFROM muasach WHERE muasach.maphieumua = @maphieumua";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maphieumua", frmPhieuMua.laymaphieu);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        ad.Fill(dt);
                    }
                }
            }
            DonViMua = dt.Rows[0]["donvimua"].ToString();
            ngayMua = DateTime.Parse(dt.Rows[0]["ngaymua"].ToString());
            maPhieuMua = dt.Rows[0]["maphieumua"].ToString();
        }

        public DataTable getDSPhieu()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "SELECT masach, tensach, soluong, tennhaxuatban FROM muasach " +
                    "JOIN datsach ON datsach.maphieumua = muasach.maphieumua " +
                    "JOIN nhaxuatban ON nhaxuatban.manhaxuatban = muasach.manhaxuatban " +
                    "WHERE muasach.maphieumua = @maphieumua " +
                    "GROUP BY masach, tensach, soluong, tennhaxuatban;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maphieumua", frmPhieuMua.laymaphieu);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        ad.Fill(dt);
                        layTenNXB = dt.Rows[0]["tennhaxuatban"].ToString();
                    }
                }
            }
            return dt;
        }

        public List<string> getMaPhieu()
        {
            List<string> lst = new List<string>();
            DataTable dt = new DataTable();
            string sql = "select maphieumua from muasach";
            using (SqlConnection conn = connection.getConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    lst.Add(row.ToString());
                }
            }
            return lst;
        }

        public static int DemBanGhi(string maphieu)
        {
            int dem = 0;
            string sql = $"select count(*) from datsach where maphieumua='{maphieu}'";
            using (SqlConnection conn = connection.getConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dem = (int)cmd.ExecuteScalar();
            }
            return dem;
        }
    }
}
