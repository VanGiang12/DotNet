using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// thêm 2 thư viện này vào
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien_New
{
   static  class DataAccess
    {
        private static string path =  @"Data Source=.\sqlexpress;Initial Catalog=dbQuanLySinhVien_k15A19;Integrated Security=True";
        // phương thức tạo kết nối
        private static SqlConnection TaoKetNoi()
        {
            return new SqlConnection(path);
        }

        // Phương thức lấy ra một table/view
        public static DataTable getTable(string sql)
        {
            SqlConnection con = TaoKetNoi();
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            con.Close();
            ad.Dispose();
            return tb;
        }
        // phương thức thêm bản ghi mới
        public static void inSertEditDelete(string sql)
        {
            SqlConnection con = TaoKetNoi();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }



    }
}
