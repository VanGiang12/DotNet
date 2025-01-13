using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SqlNhanVien
{
    public class Connection
    {
        private static string stringConnection = "Data Source=LAPTOP-VGPG1GUS;Initial Catalog = QuanLyNhanVien; Integrated Security = True; Encrypt=False";

        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
