using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Model
{
    internal class DangNhap
    {

        public static DataTable getDS()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = connection.getConnection())
            {
                conn.Open();
                string sql = "select username,pass from Admin";
                SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static bool Login(string user,string pass)
        {
            Dictionary<string,string> dic= new Dictionary<string,string>();
            
            DataTable dt = getDS();
            foreach (DataRow dr in dt.Rows)
            {
                dic.Add(dr["username"].ToString().Trim(), dr["pass"].ToString().Trim());
            }
            //kiểm tra xem trong dic có key user không, nếu có thì gán value vào Pass
            return dic.TryGetValue(user, out string Pass) && Pass == pass;
        }
    }
}
