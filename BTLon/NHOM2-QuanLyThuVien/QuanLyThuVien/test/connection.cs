using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace test
{
    internal class connection
    {
        public static string connString = "Data Source=LAPTOP-VGPG1GUS;Initial Catalog=tbqltv;Integrated Security=True; Encrypt=false"; 

        public static SqlConnection getConnection()
        {
            return new SqlConnection(connString);
        }
    }
}
