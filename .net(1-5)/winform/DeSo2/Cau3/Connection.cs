using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau3
{
    internal class Connection
    {
        static string path = "Data Source=LAPTOP-VGPG1GUS;Initial Catalog=qlcauth;Integrated Security=True";
        public static SqlConnection connection()
        {
            return new SqlConnection(path);
        }
        public static DataTable getDS(string sql)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = connection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

    }
}
