using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bai3
{
    internal class Connections
    {
        public static SqlConnection getConnection()
        {
            string path = "Data Source=LAPTOP-VGPG1GUS;Initial Catalog=Teamleader;Integrated Security=True";
            return new SqlConnection(path);
        }
    }
}
