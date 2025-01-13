using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau3
{
    internal class Connection
    {
        static string path = "Data Source=LAPTOP-VGPG1GUS;Initial Catalog=Teamleader;Integrated Security=True";
        public static SqlConnection connection()
        {
            return new SqlConnection(path);
        }
    }
}
