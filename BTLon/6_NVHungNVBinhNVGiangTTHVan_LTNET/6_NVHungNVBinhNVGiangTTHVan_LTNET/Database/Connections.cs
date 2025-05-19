using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.Database
{
    internal class Connections
    {
        public static SqlConnection connect()
        {
            string path = "Data Source=LAPTOP-VGPG1GUS;Initial Catalog=QUANLYTIETKIEM;Integrated Security=True";
            return new SqlConnection(path);
        }

        public DataTable GetSoTietKiemByThoiGian(string thoiGian)
        {
            DataTable dataTable = new DataTable();

            // Chuyển đổi thời gian thành số tháng
            int soThang = ThoiGianToMonths(thoiGian);

            using (SqlConnection connection = connect())
            {
                string query = @"
                SELECT * 
                FROM SoTietKiem
                WHERE DATEDIFF(MONTH, NgayMoSo, GETDATE()) <= @SoThang";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SoThang", soThang);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        private int ThoiGianToMonths(string thoiGian)
        {
            switch (thoiGian)
            {
                case "1 Tháng": return 1;
                case "3 Tháng": return 3;
                case "6 Tháng": return 6;
                case "1 Năm": return 12;
                case "2 Năm": return 24;
                case "3 Năm": return 36;
                default: return 0;
            }
        }

    }
}
