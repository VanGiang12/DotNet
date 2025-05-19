using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.So
{
    internal class action
    {  

        public bool kt(string x)
        {
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                string sql = "select count(*) from LoaiSoTietKiem where MaLoaiSo='"+x+"'";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    int kq = (int)cmd.ExecuteScalar();
                    if(kq > 0)
                    {
                        return true;
                    }
                }
            }
                return false;
        }

        public DataTable ht()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                string sql = "select * from LoaiSoTietKiem";
                using (SqlDataAdapter cmd = new SqlDataAdapter(sql, con))
                {
                    cmd.Fill(dt);
                    return dt;
                }
            }
        }

        public bool them(LoaiSo x)
        {
            if(kt(x.Maloaiso) == false)
            {
                using (SqlConnection con = Connections.connect())
                {
                    con.Open();
                    string sql = "insert into LoaiSoTietKiem values(@ma,@ten,@laisuat,@sothang)";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("ma", x.Maloaiso);
                        cmd.Parameters.AddWithValue("ten", x.Tenloaiso);
                        cmd.Parameters.AddWithValue("laisuat", x.Laisuattheothang);
                        cmd.Parameters.AddWithValue("sothang", x.Sothang);
                        int kq = cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            return true;
                        }

                    }
                }
            }
            else
            {
                return false;
            }
            
            return false;
        }

        public bool sua(LoaiSo x)
        {
            if (kt(x.Maloaiso) == true)
            {
                using (SqlConnection con = Connections.connect())
                {
                    con.Open();
                    string sql = "update LoaiSoTietKiem set TenLoaiSo=@ten,LaiSuatThang=@laisuat,SoThang=@sothang where MaLoaiSo=@ma";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("ten", x.Tenloaiso);
                        cmd.Parameters.AddWithValue("laisuat", x.Laisuattheothang);
                        cmd.Parameters.AddWithValue("sothang", x.Sothang);
                        cmd.Parameters.AddWithValue("ma", x.Maloaiso);
                        int kq = cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            return true;
                        }

                    }
                }
            }
            else
            {
                return false;
            }
            
             
            return false;
        }

        public bool xoa(LoaiSo x)
        {
            if (kt(x.Maloaiso) == true)
            {
                using (SqlConnection con = Connections.connect())
                {
                    con.Open();
                    string sql = "delete from LoaiSoTietKiem where MaLoaiSo=@ma";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("ma", x.Maloaiso);
                        int kq = cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            return true;
                        }

                    }
                }
            }
            else
            {
                return false;
            }
            return false;
        }

        public DataTable tk(string x)
        {
            using (SqlConnection con = Connections.connect())
            {
                DataTable dt = new DataTable();
                con.Open();
                string sql = "select * from LoaiSoTietKiem where TenLoaiSo like @ten";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("ten", "%"+x+"%");
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

    }
}
