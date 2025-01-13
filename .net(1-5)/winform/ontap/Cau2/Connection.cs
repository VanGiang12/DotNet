using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau2
{
    internal class Connection
    {
        static string path = "Data Source=LAPTOP-VGPG1GUS;Initial Catalog=ql_sv;Integrated Security=True";
        public static SqlConnection connection()
        {
            return new SqlConnection(path);
        }
        public static DataTable getDS(string s)
        {
            DataTable dt = new DataTable();
            using(SqlConnection con = connection())
            {
                con.Open();
                string sql = "select * from sv " + s;
                SqlDataAdapter adapter=new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
