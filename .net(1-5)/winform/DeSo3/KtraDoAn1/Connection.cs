using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtraDoAn1
{
    internal class Connection
    {
        public static SqlConnection getConnection()
        {
            string path = "Data Source=LAPTOP-VGPG1GUS;Initial Catalog=DocGia;Integrated Security=True";
            return new SqlConnection(path);
        }
    }
}
