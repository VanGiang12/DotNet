using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace test.Model
{
    internal class MuonTra
    {
        public string ms, tens, sl, tentg, st;

        public string maPhieuMuon { get; set; }
        public string maDocGia { get; set; }

        public int soLuongMuon { get; set; }
        public DateTime ngayMuon { get; set; }
        public DateTime ngayHenTra { get; set; }
        public DateTime ngayTra { get; set; }

        MuonTra()
        {

        }

        public static DataTable getborrowPay()
        {
            string sql = "select maphieumuon,ten,sothe,tensach,soluongmuon,ngaymuon,ngayhentra,ngaytra from muontra m " +
                "join docgia d on m.madocgia = d.madocgia " +
                "join sach s on m.masach=s.masach";
            DataTable dt = new DataTable();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            return dt;
        }

        public static List<string> getCodeBook()
        {
            List<string> ds = new List<string>();
            string sql = "select masach from sach";

            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                SqlCommand da = new SqlCommand(sql, con);
                SqlDataReader dr = da.ExecuteReader();
                while (dr.Read())
                {
                    string ma = dr["masach"].ToString();
                    ds.Add(ma);
                }
            }
            return ds;
        }

        public static List<string> getNameBook()
        {
            List<string> name = new List<string>();
            string sql = "select tensach from sach";

            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                SqlCommand cd = new SqlCommand(sql, con);
                SqlDataReader dr = cd.ExecuteReader();
                while (dr.Read())
                {
                    string ten = dr["tensach"].ToString();
                    name.Add(ten);
                }
            }

            return name;
        }

        public static List<string> getNameReader()
        {
            List<string> name = new List<string>();
            string sql = "select * from docgia";

            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    string ten = dr["ten"].ToString();
                    name.Add(ten);
                }
            }
            return name;
        }

        public static MuonTra getInformationBook(string ma)
        {
            MuonTra mt = null;
            string sql = "select s.tensach,s.soluong,t.tentacgia from sach s join tacgia t on s.matacgia=t.matacgia where s.masach = @Masach";
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@Masach", ma);
                SqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    mt = new MuonTra();
                    mt.tens = dr["tensach"].ToString();
                    mt.sl = dr["soluong"].ToString();
                    mt.tentg = dr["tentacgia"].ToString();
                }
            }
            return mt;
        }

        public static MuonTra getNameBook(string ten)
        {
            MuonTra mt = null;
            string sql = "select s.masach,s.soluong,t.tentacgia from sach s join tacgia t on s.matacgia=t.matacgia where s.tensach = @Tensach";
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@Tensach", ten);
                SqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    mt = new MuonTra();
                    mt.ms = dr["masach"].ToString();
                    mt.sl = dr["soluong"].ToString();
                    mt.tentg = dr["tentacgia"].ToString();
                }
            }
            return mt;
        }

        public static MuonTra getsoThe(string tendg)
        {
            MuonTra mt = null;
            string sql = "select * from docgia where ten = @Ten ";
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@Ten", tendg);
                SqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    mt = new MuonTra();
                    mt.st = dr["sothe"].ToString();
                }
            }
            return mt;
        }

        public static void Update(string ma, DateTime date)
        {
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "update muontra set ngaytra = @Ngaytra where maphieumuon =@Ma";
                SqlCommand cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@Ngaytra", date);
                cm.Parameters.AddWithValue("@Ma", ma);
                cm.ExecuteNonQuery();
            }
        }

        public static void sua(string ma, int sl, DateTime ngaymuon, DateTime ngayhentra)
        {

            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "update muontra set soluongmuon = @Sl , ngaymuon = @Ngaymuon, ngayhentra = @Ngayhentra where maphieumuon =@Ma";
                SqlCommand cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@Sl", sl);
                cm.Parameters.AddWithValue("@Ngaymuon", ngaymuon);
                cm.Parameters.AddWithValue("@Ngayhentra", ngayhentra);
                cm.Parameters.AddWithValue("@Ma", ma);
                cm.ExecuteNonQuery();
            }
        }

        public static void Delete(string map)
        {
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "delete from muontra where maphieumuon = '" + map + "'";
                SqlCommand cm = new SqlCommand(sql, con);

                cm.ExecuteNonQuery();
            }
        }

        public static void muon(string maphieu, string madocgia, string masach, int sl, DateTime ngaymuon, DateTime ngayhentra)
        {
            try
            {
                using (SqlConnection con = connection.getConnection())
                {
                    con.Open();
                    string sql = "INSERT INTO muontra(maphieumuon, madocgia, masach, soluongmuon, ngaymuon, ngayhentra) VALUES (@Ma, @Madocgia, @Masach, @Sl, @Ngaymuon, @Ngayhentra)";
                    using (SqlCommand cmInsert = new SqlCommand(sql, con))
                    {
                        cmInsert.Parameters.AddWithValue("@Ma", maphieu);
                        cmInsert.Parameters.AddWithValue("@Madocgia", madocgia);
                        cmInsert.Parameters.AddWithValue("@Masach", masach);
                        cmInsert.Parameters.AddWithValue("@Sl", sl);
                        cmInsert.Parameters.AddWithValue("@Ngaymuon", ngaymuon);
                        cmInsert.Parameters.AddWithValue("@Ngayhentra", ngayhentra);
                        cmInsert.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static DataTable search(string key)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "select maphieumuon,ten,sothe,tensach,soluongmuon,ngaymuon,ngayhentra,ngaytra from muontra m " +
                "join docgia d on m.madocgia = d.madocgia " +
                "join sach s on m.masach=s.masach where maphieumuon=@maphieu or ten like @ten" ;
                SqlCommand cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@maphieu",key);
                cm.Parameters.AddWithValue("@ten", "%" + key + "%");
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);
            }
            return dt;
        }

        public static void updateSLSach(int sl, string ms)
        {
            using (SqlConnection conn = connection.getConnection())
            {
                conn.Open();
                string sql = "update sach set soluong = @soluong where masach=@masach";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@soluong", sl);
                cmd.Parameters.AddWithValue("@masach", ms);
                cmd.ExecuteNonQuery();
            }
        }

        public static string getMaDocGia(string sothe)
        {
            string ma = "";
            using (SqlConnection conn = connection.getConnection())
            {
                conn.Open();
                string sql = "select madocgia from docgia where sothe=@sothe";
                using(SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@sothe", sothe);
                    SqlDataReader reader= cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        ma= reader["madocgia"].ToString();
                    }
                    reader.Close();
                }
            }
            return ma;
        }
    }
}
