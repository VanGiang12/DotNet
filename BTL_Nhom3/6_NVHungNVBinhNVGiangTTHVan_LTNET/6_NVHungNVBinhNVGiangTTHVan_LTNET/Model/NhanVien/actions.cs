using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Database;
using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.NhanVien;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.So
{
    internal class actions
    {  

        public bool kt(string x)
        {
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                string sql = "select count(*) from NhanVien where MaNV='"+x+"'";
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

        public DataTable dlloai()
        {
            DataTable dt = new DataTable();
            using(SqlConnection con = Connections.connect())
            {
                con.Open();
                string sql = "select MaND from PhanLoaiNguoiDung";
                using(SqlDataAdapter sda = new SqlDataAdapter(sql, con))
                {
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable ht()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                string sql = "select * from NhanVien";
                using (SqlDataAdapter cmd = new SqlDataAdapter(sql, con))
                {
                    cmd.Fill(dt);
                    return dt;
                }
            }
        }

        public bool them(nhanVien x)
        {
            if(kt(x.Manhanvien) == false)
            {
                using (SqlConnection con = Connections.connect())
                {
                    con.Open();
                    string sql = "insert into NhanVien values(@ma,@ten,@ngaysinh,@sdt,@mk,@lnd)";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("ma", x.Manhanvien);
                        cmd.Parameters.AddWithValue("ten", x.Tennhanvien);
                        cmd.Parameters.AddWithValue("ngaysinh", x.Ngaysinh);
                        cmd.Parameters.AddWithValue("sdt", x.Sdt);
                        cmd.Parameters.AddWithValue("mk", x.Matkhau);
                        cmd.Parameters.AddWithValue("lnd", x.Loainguoidung);
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

        public bool sua(nhanVien x)
        {
            if (kt(x.Manhanvien) == true)
            {
                using (SqlConnection con = Connections.connect())
                {
                    con.Open();
                    string sql = "update NhanVien set HoTenNV=@ten,NgaySinh=@ngaysinh,SDT=@sdt,MatKhau=@mk,LoaiNguoiDung=@loai where MaNV=@ma";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("ten", x.Tennhanvien);
                        cmd.Parameters.AddWithValue("ngaysinh", x.Ngaysinh);
                        cmd.Parameters.AddWithValue("sdt", x.Sdt);
                        cmd.Parameters.AddWithValue("mk", x.Matkhau);
                        cmd.Parameters.AddWithValue("loai", x.Loainguoidung);
                        cmd.Parameters.AddWithValue("ma", x.Manhanvien);
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

        public bool xoa(nhanVien x)
        {
            if (kt(x.Manhanvien) == true)
            {
                using (SqlConnection con = Connections.connect())
                {
                    con.Open();
                    string sql = "delete from NhanVien where MaNV=@ma";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("ma", x.Manhanvien);
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
                string sql = "select * from NhanVien where HoTenNV like @ten";
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
