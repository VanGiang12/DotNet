using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Data.KhachHang
{
    internal class QLChiTIet
    {
        SqlConnection con = Connection.getConnection();
        void MoCSDL()
        {
            con.Open();
        }

        void DongCSDL()
        {
            con.Close();
        }

        public DataTable getTenKH()
        {
            MoCSDL();
            string sql = "select * from tblKhachHang";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(dt);
            DongCSDL();
            return dt;
        }
        public DataTable getTenMH()
        {
            MoCSDL();
            string sql = "select * from tblMatHang";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(dt);
            DongCSDL();
            return dt;

        }

        bool ktratrung(int sohieu)
        {
            MoCSDL();
            string sql = $"select * from tblBanHang where SoHieuID = {sohieu}";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            DongCSDL();
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        bool ktratrungCTBH(int sohieu, string mamh)
        {
            MoCSDL();
            string sql = $"select * from tblBanHang where SoHieuID = {sohieu} and MaMH={mamh}";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            DongCSDL();
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        public void ThemBanHang(int sohieu, string makh, DateTime ngaymua)
        {
            if (!ktratrung(sohieu))
            {
                MoCSDL();
                string sql = $"insert into tblBanHang values({sohieu},'{makh}','{ngaymua}')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                DongCSDL();
            }
            else
            {
                MessageBox.Show("Số hiệu ID bị trùng");
            }
        }
        public void ThemCTBanHang(int sohieu, string makh, int soluong, int dongia)
        {
            if (!ktratrungCTBH(sohieu,makh))
            {
                MoCSDL();
                string sql = $"insert into tblChiTietBanhang values({sohieu},'{makh}','{soluong}','{dongia}')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                DongCSDL();
            }
            else
            {
                MessageBox.Show("Số hiệu ID và mã mặt hàng bị trùng");
            }
        }
    }
}
