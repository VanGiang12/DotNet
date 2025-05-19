using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Database;
using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.KhachHang;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.Model.GiaoDich
{
    public class QLGiaoDich
    {
        decimal LAI = 0.001m;
        public decimal getLaiKhongHan()
        {
            string sql = $@"select LaiSuatThang from LoaiSoTietKiem where TenLoaiSo like N'Không kì hạn'";
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    object result = cmd.ExecuteScalar();
                    return decimal.Parse(result.ToString());
                }
            }

        }
        public DataTable ShowLoaiSo()
        {
            DataTable dt = new DataTable();
            string sql = "select TenLoaiSo, LaiSuatThang, SoThang from LoaiSoTietKiem";
            using (SqlConnection conn = Connections.connect())
            {
                conn.Open();
                using (SqlDataAdapter ad = new SqlDataAdapter(sql, conn))
                {
                    ad.Fill(dt);

                }
            }
            return dt;
        }
        public DataTable getThang(string ten)
        {
            DataTable dt = new DataTable();
            string sql = $"select SoThang from LoaiSoTietKiem where TenLoaiSo =  N'{ten}'";
            using (SqlConnection conn = Connections.connect())
            {
                conn.Open();
                using (SqlDataAdapter ad = new SqlDataAdapter(sql, conn))
                {
                    ad.Fill(dt);

                }
            }
            return dt;
        }
        public DataTable ShowAllData()
        {
            DataTable dt = new DataTable();

            string sql = @"select stk.MaSTK, stk.MaNV, kh.HoTenKH, kh.CMND, l.TenLoaiSo, l.LaiSuatThang, stk.NgayMoSo, stk.NgayDenHan, stk.SoTienGui, 
               case when stk.TrangThaiSo = 1 then N'Mở'
                            else N'Đóng'
                            end as TrangThaiSo
                        from SoTietKiem stk 
                        join KhachHang kh on kh.MaKH = stk.MaKH 
                        join LoaiSoTietKiem l on l.MaLoaiSo = stk.MaLoaiSo";
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                using (SqlDataAdapter ad = new SqlDataAdapter(sql, con))
                {
                    ad.Fill(dt);
                }
            }
            return dt;
        }
        public String RanDomMaSTK()
        {
            int maSTK = 0;
            DataTable dt = new DataTable();
            string sql = @"SELECT MAX(CONVERT(INT, 
                     CASE 
                         WHEN LEN(MaSTK) > 3 THEN SUBSTRING(MaSTK, 4, LEN(MaSTK) - 3)
                         ELSE '0'
                     END)) AS MaxNumber
                     FROM SoTietKiem";

            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        maSTK = Convert.ToInt32(result);
                    }
                }
            }
            return "STK" + (maSTK + 1).ToString("D3");
        }

        public String RanDomMaKH()
        {
            int maKH = 0;
            DataTable dt = new DataTable();
            string sql = @"SELECT MAX(CONVERT(INT, SUBSTRING(MaKH, 4, LEN(MaKH) - 3))) AS MaxNumber
                            FROM KhachHang";
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        maKH = Convert.ToInt32(result);
                    }
                }
            }
            return "KH" + (maKH + 1).ToString("D3");
        }
        public DataTable? CheckCMND(String s)
        {
            DataTable dt = new DataTable();
            string sql = $"select * from KhachHang where CMND = '{s}'";
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                using (SqlDataAdapter ad = new SqlDataAdapter(sql, con))
                {
                    ad.Fill(dt);
                }
            }
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
                return null;

        }
        public String getMaLoaiSo(string ten)
        {
            string sql = $@"select MaLoaiSo from LoaiSoTietKiem where TenLoaiSo like N'{ten}'";
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return result.ToString();
                    }
                }
            }
            return null;

        }
        public void ThemKH(String ma, string ten, string cmnd, string dc, string sdt)
        {
            using (SqlConnection conn = Connections.connect())
            {
                conn.Open();
                string sql = "INSERT INTO KhachHang VALUES(@ma,@ten,@cmnd,@diachi,@sdt)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ma", ma);
                cmd.Parameters.AddWithValue("ten", ten);
                cmd.Parameters.AddWithValue("cmnd", cmnd);
                cmd.Parameters.AddWithValue("diachi", dc);
                cmd.Parameters.AddWithValue("sdt", sdt);
                cmd.ExecuteNonQuery();

            }
        }
        public void ThemSTK(GiaoDich gd)
        {
            string ngaydenhan;
            if (gd.NgayDenHan.HasValue)
            {
                ngaydenhan = "'" + gd.NgayDenHan.Value + "'";
            }
            else
            {
                ngaydenhan = "null";
            }
            string sql = @$"insert into SoTietKiem values('{gd.MaSo}',    
                            '{gd.MaNV}', '{gd.MaKH}', '{gd.MaLoaiSo}', '{gd.NgayMoSo}', {ngaydenhan}, '{gd.SoTienGui}',null, null, '{gd.TrangThaiSo}'
                    )";
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                }

            }
        }
        public void SuaSTK(string mastk, string makh)
        {
            GiaoDich gd = new GiaoDich();
            bool b;
            if (gd.TrangThaiSo.Equals("Mở"))
            {
                b = true;
            }
            else
                b = false;
            string sql = @$"update SoTietKiem set MaKH = '{makh}' where MaSTK = '{mastk}' ";
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ShowKH(string cmnd)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = Connections.connect())
            {
                conn.Open();
                string sql = $"SELECT * FROM  KhachHang WHERE CMND = '{cmnd}'";
                using (SqlDataAdapter ad = new SqlDataAdapter(sql, conn))
                {
                    ad.Fill(dt);
                }
            }
            return dt;
        }

        public void XoaSTK(string mastk)
        {
            string sql = @$"delete from SoTietKiem where MaSTK = '{mastk}' ";
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable FindMaKH(string makh)
        {
            DataTable dt = new DataTable();

            string sql = $@"select stk.MaSTK, stk.MaNV, kh.HoTenKH, kh.CMND, l.TenLoaiSo, l.LaiSuatThang, stk.NgayMoSo, stk.NgayDenHan, stk.SoTienGui, 
               case when stk.TrangThaiSo = 1 then N'Mở'
                            else N'Đóng'
                            end as TrangThaiSo
                        from SoTietKiem stk 
                        join KhachHang kh on kh.MaKH = stk.MaKH 
                        join LoaiSoTietKiem l on l.MaLoaiSo = stk.MaLoaiSo
                        where stk.MaKH = '{makh}' ";
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                using (SqlDataAdapter ad = new SqlDataAdapter(sql, con))
                {
                    ad.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable ShowSTK()
        {
            DataTable dt = new DataTable();

            string sql = @"select distinct stk.MaSTK, stk.MaNV, stk.MaKH, kh.CMND, kh.HoTenKH, l.TenLoaiSo, l.LaiSuatThang, stk.NgayMoSo, stk.NgayDenHan, stk.SoTienGui, stk.NgayRut, stk.SoTienRut,
               case when stk.TrangThaiSo = 1 then N'Mở'
                            else N'Đóng'
                            end as TrangThaiSo
                        from SoTietKiem stk 
                        join KhachHang kh on kh.MaKH = stk.MaKH 
                        join LoaiSoTietKiem l on l.MaLoaiSo = stk.MaLoaiSo";
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                using (SqlDataAdapter ad = new SqlDataAdapter(sql, con))
                {
                    ad.Fill(dt);
                }
            }
            return dt;
        }
      
        public decimal TienTheoThang(decimal LAIKHONGHAN, int tienGui, int thang, decimal laiSuat, DateTime ngayGui, DateTime ngayDenHan, DateTime ngayRut, bool tt)
        {
            decimal tong = 0;

            // Xác định số ngày trong tháng của ngayGui để tính lãi suất theo tháng
            int soNgayTrongThang = DateTime.DaysInMonth(ngayGui.Year, ngayGui.Month);

            // Nếu ngày rút bằng ngày đến hạn, tính toàn bộ tiền gửi và lãi suất
            if (ngayRut.Date == ngayDenHan.Date)
            {
                tong = tienGui + (decimal)(tienGui * laiSuat * thang);
                tt = false;
            }
            // Nếu ngày rút trước ngày đến hạn
            else if (ngayRut.Date < ngayDenHan.Date)
            {
                int soNgayGui = (ngayRut - ngayGui).Days;
                tong = tienGui + (decimal)(tienGui * (LAI *12 /365)  * soNgayGui);
                tt = false;
            }
            // Nếu ngày rút sau ngày đến hạn
            else
            {
                int t = (ngayRut.Year - ngayDenHan.Year) * 12 + (ngayRut.Month - ngayDenHan.Month);

                if ((ngayDenHan.Day - ngayRut.Day) == 0)
                {
                    tong = tienGui + (tienGui * laiSuat * thang) + ((tienGui + (tienGui * laiSuat * thang)) * LAI * t);

                }
                else
                {
                    int ngayLe = ngayRut.Day;
                    if(ngayRut.Day < ngayDenHan.Day)
                    {
                        t -= 1;
                    }
                    else
                    {
                        ngayLe = ngayRut.Day - ngayDenHan.Day;
                    }
                    decimal denHan = tienGui + (tienGui * laiSuat * thang);
                    
                    soNgayTrongThang = DateTime.DaysInMonth(ngayRut.Year, ngayRut.Month);
                    tong =   denHan  + denHan * LAI * t + denHan * LAI * (decimal)(ngayLe / soNgayTrongThang);
                }
            }

            tong = Math.Round(tong, 2, MidpointRounding.AwayFromZero);  // Làm tròn đến 2 chữ số thập phân

            return tong;

        }
        public static string msg;
      
        public decimal TienKhongHan(decimal LAIKHONGHAN, int tienGui, decimal tienRut, decimal laiSuat, DateTime ngayGui, DateTime ngayRut, bool tt, DateTime ngayHienTai)
        {
            decimal tong = 0;
            int soNgayTrongThang = DateTime.DaysInMonth(ngayGui.Year, ngayGui.Month);

            int soNgayGui = (ngayHienTai - ngayGui).Days;
            
            if (tienRut == 0)
            {
                tienRut = tienGui * laiSuat * 12 / 365 * soNgayGui ;
                tong = tienRut + tienGui;
                tt = true;
            }
            else if (tienRut == tienGui)
            {
                tong = tienGui + tienGui * laiSuat * 12 / 365 * soNgayGui;
                tt = false;
            }
            tong = Math.Round(tong, 2, MidpointRounding.AwayFromZero);
            return tong;
        }


        public DataTable FindSTK(string maSTK)
        {
            DataTable dt = new DataTable();

            string sql = $@"select stk.MaSTK, stk.MaNV, stk.MaKH, 
                        kh.CMND, kh.HoTenKH, 
                    l.TenLoaiSo, l.LaiSuatThang, 
                stk.NgayMoSo, stk.NgayDenHan, stk.SoTienGui, stk.NgayRut, stk.SoTienRut,
               case when stk.TrangThaiSo = 1 then N'Mở'
                            else N'Đóng'
                            end as TrangThaiSo, 
                    kh.DiaChi, kh.SDT
                        from SoTietKiem stk 
                        join KhachHang kh on kh.MaKH = stk.MaKH 
                        join LoaiSoTietKiem l on l.MaLoaiSo = stk.MaLoaiSo
                        where stk.MaSTK = '{maSTK}' ";
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                using (SqlDataAdapter ad = new SqlDataAdapter(sql, con))
                {
                    ad.Fill(dt);
                }
            }
            return dt;
        }

        public void UpdateSoTienRut(string mastk, DateTime ngayrut, decimal sotienrut, bool trangthai)
        {
            int tt = trangthai ? 1 : 0;
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                string sql = $"update SoTietKiem set NgayRut = '{ngayrut}', SoTienRut = {sotienrut}, TrangThaiSo = {tt} where MaSTK = '{mastk}'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSTK(string mastk)
        {
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                string sql = $"delete from SoTietKiem where MaSTK = '{mastk}'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
