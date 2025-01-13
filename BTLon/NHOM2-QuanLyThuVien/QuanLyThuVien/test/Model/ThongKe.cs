using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.NhapSach;

namespace test.Model
{
    internal class ThongKe
    {
        public static int getSoLuong(string table)
        {
            int sl;
            using (SqlConnection conn = connection.getConnection())
            {
                conn.Open();
                string sql = $"select count(*) from {table}";
                SqlCommand cmd = new SqlCommand(sql, conn);
                sl = (int)cmd.ExecuteScalar();
            }
            return sl;
        }

        public static DataTable getDanhSach(string ktra)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "select maphieumuon,ten,sothe,tensach,soluongmuon,ngaymuon,ngayhentra,ngaytra from muontra m " +
                "join docgia d on m.madocgia = d.madocgia " +
                $"join sach s on m.masach=s.masach where ngaytra {ktra}";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static DataTable getDSQuaHan()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string currentDate = DateTime.Now.ToString("MM-dd-yyyy");
                string sql = "select maphieumuon, ten, sothe, tensach, soluongmuon, ngaymuon, ngayhentra, ngaytra " +
                             "from muontra m " +
                             "join docgia d on m.madocgia = d.madocgia " +
                             "join sach s on m.masach = s.masach " +
                             $"where ngayhentra < '{currentDate}' and (ngaytra is null or ngaytra <> ngayhentra)";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static DataTable getDSDatSach()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "select madat,maphieumua, masach, tensach, soluong from datsach";
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(sql, con))
                    {
                        ad.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public static int getTongSoLuong()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "SELECT sum(soluong) as soluong FROM muasach " +
                    "JOIN datsach ON datsach.maphieumua = muasach.maphieumua ";
                using (SqlDataAdapter ad = new SqlDataAdapter(sql, con))
                {
                    ad.Fill(dt);
                }
            }
            return int.Parse(dt.Rows[0]["soluong"].ToString());
        }
    }
}
