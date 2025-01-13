using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QLBanHang.Data
{
    public class Connection
    {
        static string path = "Data Source=LAPTOP-VGPG1GUS;Initial Catalog=QLBH;Integrated Security=True; Encrypt=false";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(path);
        }
    }
}
