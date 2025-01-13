using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap2
{
    internal class Connection
    {
        static string path="Data Source=LAPTOP-VGPG1GUS;Initial Catalog=qlcauth;Integrated Security=True";
        public static SqlConnection kn()
        {
            return new SqlConnection(path);
        }
        public static DataTable getds(string s)
        {
            DataTable dt = new DataTable();
            using(SqlConnection con = kn())
            {
                con.Open();
                string sql = "select * from cauthu "+s;
                SqlDataAdapter adapter = new SqlDataAdapter(sql,con);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
