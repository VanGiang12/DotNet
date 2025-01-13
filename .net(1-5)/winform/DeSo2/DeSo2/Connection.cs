using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using System.IO;

namespace DeSo2
{
    internal class Connection
    {
        static string path = "Data Source=LAPTOP-VGPG1GUS;Initial Catalog=qlcauth;Integrated Security=True; encrypt=false";
        

        public static SqlConnection TaoKetNoi()
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
        // Lấy một giá trị

        public static string getAValule(string sql)
        {
            SqlConnection con = TaoKetNoi();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            object kq = cmd.ExecuteScalar();
            con.Close();
            cmd.Dispose();
            if (kq == null)
                return "";
            else
                return kq.ToString();
        }


    }
}
