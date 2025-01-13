using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLSach
{
    public class DataAccess
    {
        static string path = "Data Source=LAPTOP-VGPG1GUS;Initial Catalog=qlthu_vien;Integrated Security=True";
        SqlConnection conn = new SqlConnection(path);

        void Mo()
        {
            conn.Open();
        }
        void Dong()
        {
            conn.Close();
        }

        #region sách
        public DataTable getDSSach(string s)
        {
            DataTable dt = new DataTable();
            Mo();
            string sql = "select * from tblSach "+s;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(dt);
            Dong();
            return dt;
        }

        public bool ThemSach(Sach s)
        {

            if (ktratrungmasach(s.Masach))
            {
                MessageBox.Show("Trùng mã sách");
                return false;
            }
            else
            {
                Mo();
                string sql = $"insert into tblSach values('{s.Masach}','{s.Tensach}','{s.Tentacgia}','{s.Nhaxb}',{s.Namxb},{s.Soluong})";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Dong();
                return true;
            }

        }

        public void SuaSach(Sach s)
        {
            Mo();
            string sql = $"update tblSach set TenSach = '{s.Tensach}', TenTacGia = '{s.Tentacgia}', NhaXB = '{s.Nhaxb}', NamXB = {s.Namxb}, SoLuong = {s.Soluong} where MaSach = '{s.Masach}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Dong();
        }

        public void XoaSach(string s)
        {
            Mo();
            string sql = $"delete from tblSach where MaSach='{s}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Dong();
        }

        public bool ktratrungmasach(string ma)
        {
            DataTable dt = new DataTable();
            Mo();
            string sql = $"select * from tblSach where MaSach = '{ma}'";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.Fill(dt);
            Dong();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }

        #endregion

        #region Độc giả

        public bool ktratrungdocgia(string ma)
        {
            DataTable dt = new DataTable();
            Mo();
            string sql = $"select * from tblDocGia where MaDocGia = '{ma}'";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.Fill(dt);
            Dong();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }

        public DataTable getDSDocGia(string s)
        {
            DataTable dt = new DataTable();
            Mo();
            string sql = "select * from tblDocGia "+s;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(dt);
            Dong();
            return dt;
        }

        public bool ThemDG(DocGia dg)
        {
            if (ktratrungdocgia(dg.Madocgia))
            {
                MessageBox.Show("Trùng mã độc giả");
                return false;
            }
            else
            {
                Mo();
                string sql = $"insert into tblDocGia values('{dg.Madocgia}','{dg.Tendocgia}','{dg.Coquan}','{dg.Diachi}','{dg.Tendocgia}')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Dong();
                return true;
            }
        }

        public void SuaDG(DocGia dg)
        {
            Mo();
            string sql = $"update tblDocGia set TenDocGia = N'{dg.Tendocgia}', CoQuan = N'{dg.Coquan}', DiaChi = N'{dg.Diachi}', Tel = '{dg.Tel}' where MaDocGia = '{dg.Madocgia}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Dong();
        }

        public DataTable TimkiemDG(string ma)
        {
            DataTable dt=new DataTable();
            Mo();
            string sql = $"select * from tblDocGia where MaDocGia = '{ma}'";
            SqlDataAdapter sqlDataAdapter=new SqlDataAdapter(sql,conn);
            sqlDataAdapter.Fill(dt);
            Dong();
            return dt;
        }

        #endregion
    }
}
