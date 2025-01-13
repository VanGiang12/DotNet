using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlNhanVien
{
    internal class QuanLyNV
    {
        SqlDataAdapter _adapter;    //truy xuất dữ liệu bảng
        SqlCommand _command;    // truy vẫn và cập nhật csdl
        //public static QuanLyNV qlnv=new QuanLyNV();
        public QuanLyNV() { }

        //Dataset trả về nhiều bảng
        //Datatable trả về 1 bảng

        public DataTable getAllNhanVien()
        {
            DataTable dataTable = new DataTable();

            string query = "select * from tblNhanVien";
            //using khi mà thực hiện xong nó sẽ hủy đối tg đi nếu chẳng may quên k đóng sql
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                _adapter = new SqlDataAdapter(query, sqlConnection);
                _adapter.Fill(dataTable);

                sqlConnection.Close();
            }

            return dataTable;
        }

        public bool insert(NhanVien nhanvien)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into tblNhanVien values (@maNV, @tenNV, @gioitinh,@ngaysinh, @diachi,@sodienthoai)";

            try
            {
                sqlConnection.Open();

                _command = new SqlCommand(query, sqlConnection);
                _command.Parameters.Add("@maNV", SqlDbType.NVarChar).Value = nhanvien.Ma;
                _command.Parameters.Add("@tenNV", SqlDbType.NVarChar).Value = nhanvien.Name;
                _command.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = nhanvien.Sex;
                _command.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = nhanvien.Date.ToShortDateString();
                _command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = nhanvien.Address;
                _command.Parameters.Add("@sodienthoai", SqlDbType.NVarChar).Value = nhanvien.Phonenumber;
                _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool update(NhanVien nhanvien)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "update tblNhanVien set maNV=@maNV, tenNV=@tenNV, gioitinh=@gioitinh, ngaysinh=@ngaysinh, diachi=@diachi,sodienthoai=@sodienthoai where maNV=@maNV";
            try
            {
                sqlConnection.Open();

                _command = new SqlCommand(query, sqlConnection);
                _command.Parameters.Add("@maNV", SqlDbType.NVarChar).Value = nhanvien.Ma;
                _command.Parameters.Add("@tenNV", SqlDbType.NVarChar).Value = nhanvien.Name;
                _command.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = nhanvien.Sex;
                _command.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = nhanvien.Date.ToShortDateString();
                _command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = nhanvien.Address;
                _command.Parameters.Add("@sodienthoai", SqlDbType.NVarChar).Value = nhanvien.Phonenumber;
                _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool delete(string id)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "delete tblNhanVien where maNV=@maNV";
            try
            {
                sqlConnection.Open();

                _command = new SqlCommand(query, sqlConnection);
                _command.Parameters.Add("@maNV", SqlDbType.NVarChar).Value = id;
                _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }


    }
}
