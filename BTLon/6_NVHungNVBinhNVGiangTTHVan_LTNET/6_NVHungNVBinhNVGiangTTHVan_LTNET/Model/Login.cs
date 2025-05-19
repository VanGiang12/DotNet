using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model
{
    internal class Login
    {
        static SqlConnection conn = Connections.connect();
        static void open() { conn.Open(); }
        static void close() { conn.Close(); }
        public static bool kiemtra(string taikhoan, string matkhau,string loainguoidung)
        {
            open();
            string manv = "";
            string mk = "";
            string lnd = "";
            string query = "select MaNV,MatKhau,LoaiNguoiDung from NhanVien where MaNV=@tk";
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("tk", taikhoan);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                manv = reader["MaNV"].ToString();
                mk = reader["MatKhau"].ToString();
                lnd = reader["LoaiNguoiDung"].ToString();
            }
            close();
            if (taikhoan == manv && matkhau == mk && loainguoidung == lnd)
                return true;
            else return false;
            
        }
    }
}
