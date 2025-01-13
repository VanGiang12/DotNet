using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Data.KhachHang
{
    public class QuanLyKH
    {
        SqlDataAdapter adapter;
        SqlCommand command;

        public QuanLyKH() { }
        
        public DataTable getAllKhachHang()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from tblKhachHang";
            using(SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public bool Insert(KhachHang kh)
        {
            SqlConnection conn = Connection.getConnection();
            string query = "insert into tblKhachHang values(@maKH,@tenKH,@gioiTinh,@diaChi,@dienThoai)";

            try
            {
                conn.Open();
                command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@maKH", kh.Makh);
                command.Parameters.AddWithValue("@tenKH", kh.Hoten);
                command.Parameters.AddWithValue("@gioiTinh", kh.Gioitinh);
                command.Parameters.AddWithValue("@diaChi", kh.Diachi);
                command.Parameters.AddWithValue("@dienThoai", kh.Dienthoai);

                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public bool Update(KhachHang kh)
        {
            SqlConnection conn = Connection.getConnection();
            string query = "update tblKhachHang set HoTen=@tenKH, GioiTinh=@gioiTinh, DiaChi=@diaChi, DienThoai=@dienThoai where MaKH=@maKH";

            try
            {
                conn.Open();
                command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@maKH", kh.Makh);
                command.Parameters.AddWithValue("@tenKH", kh.Hoten);
                command.Parameters.AddWithValue("@gioiTinh", kh.Gioitinh);
                command.Parameters.AddWithValue("@diaChi", kh.Diachi);
                command.Parameters.AddWithValue("@dienThoai", kh.Dienthoai);

                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
       
        public bool Delete(string id)
        {
            SqlConnection conn = Connection.getConnection();
            string query = "delete tblKhachHang where MaKH=@maKH";
            try
            {
                conn.Open();
                command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@maKH", id);
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public DataTable TimKiem(string id)
        {
            DataTable dataTable = new DataTable(); 
            string query = "select * from tblKhachHang where MaKH=@maKH or HoTen like '%' + @hoTen+ '%'";
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                command=new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@maKH", id);
                command.Parameters.AddWithValue("@hoTen", id);


                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
    }
}
