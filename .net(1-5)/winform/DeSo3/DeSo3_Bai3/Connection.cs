using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeSo3_Bai3
{
    internal class Connection
    {
        public static SqlConnection getConnection()
        {
            string path = "Data Source=LAPTOP-VGPG1GUS;Initial Catalog=qlsv_nguyenvangiang;Integrated Security=True";
            return new SqlConnection(path);
        }
        public static DataTable getDS(string sql)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
