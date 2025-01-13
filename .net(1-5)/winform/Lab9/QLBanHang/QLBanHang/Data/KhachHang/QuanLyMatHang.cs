using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Data.KhachHang
{
    internal class QuanLyMatHang
    {
        SqlConnection con = Connection.getConnection();
        public void MoCSDL()
        {
            con.Open();
        }
        public void DongCSDL()
        {
            con.Close();
        }
        public DataTable getDS()
        {
            MoCSDL();
            string query = "select * from tblMatHang";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(dt);
            DongCSDL();
            return dt;
        }
        public bool ktratrung(string ma)
        {
            MoCSDL();
            string query = "select * from tblMatHang where MaMH=@ma";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("ma", ma);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DongCSDL();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else return false;

        }
        public void Them(MatHang mh)
        {
            MoCSDL();
            string query = "insert into tblMatHang values(@ma,@ten,@donvi)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("ma", mh.Mamh);
            cmd.Parameters.AddWithValue("ten", mh.Tenmh);
            cmd.Parameters.AddWithValue("donvi", mh.Donvitinh);
            cmd.ExecuteNonQuery();
            DongCSDL();
        }
        public void Sua(MatHang mh)
        {
            MoCSDL();
            string query = "update tblMatHang set TenMH=@ten,DVT=@donvi where MaMH=@ma";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("ma", mh.Mamh);
            cmd.Parameters.AddWithValue("ten", mh.Tenmh);
            cmd.Parameters.AddWithValue("donvi", mh.Donvitinh);
            cmd.ExecuteNonQuery();
            DongCSDL();
        }
        public void Xoa(string ma)
        {
            MoCSDL();
            string query = "delete tblMatHang where MaMH=@ma";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.ExecuteNonQuery();
            DongCSDL();
        }

        public DataTable TimKiem(string id)
        {
            MoCSDL();
            DataTable dataTable = new DataTable();
            string query = "select * from tblMatHang where MaMH=@maMH";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@maMH", id);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            DongCSDL();
            return dataTable;
        }
    }
}
