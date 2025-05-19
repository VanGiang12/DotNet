using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace test.Model
{
    internal class DocGia
    {
        private string maDocGia, tenDocGia, gioiTinh, diaChi, loaiDocGia, khoa, soThe, password;
        private DateTime ngaySinh;

        public DocGia()
        {
        }

        public DocGia(string maDocGia, string tenDocGia, string gioiTinh, string diaChi, string loaiDocGia, string khoa, string soThe, DateTime ngaySinh)
        {
            this.maDocGia = maDocGia;
            this.tenDocGia = tenDocGia;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.loaiDocGia = loaiDocGia;
            this.khoa = khoa;
            this.soThe = soThe;
            this.ngaySinh = ngaySinh;
        }

        public string MaDocGia { get => maDocGia; set => maDocGia = value; }
        public string TenDocGia { get => tenDocGia; set => tenDocGia = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string LoaiDocGia { get => loaiDocGia; set => loaiDocGia = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public string SoThe { get => soThe; set => soThe = value; }
        public string Password { get => password; set => password = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public static DataTable getListReader()
        {
            DataTable dt = new DataTable();

            string sql = "select madocgia,sothe,password,ten,ngaysinh,gioitinh,loaidocgia,khoa,diachi from docgia";
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);

            }
            return dt;
        }

        public static void addReader(string maDocGia,string password, string tenDocGia, DateTime ngaySinh, string gioiTinh, string loaiDocGia, string khoa, string diaChi, string soThe)
        {
            string sql = "insert into docgia(madocgia,password,ten,ngaysinh,gioitinh,loaidocgia,khoa,diachi,sothe) values(@MaDocGia,@Password,@TenDocGia,@NgaySinh,@GioiTinh,@LoaiDocGia,@Khoa,@DiaChi,@SoThe)";
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@MaDocGia", maDocGia);
                cm.Parameters.AddWithValue("@Password", password);
                cm.Parameters.AddWithValue("@TenDocGia", tenDocGia);
                cm.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cm.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cm.Parameters.AddWithValue("@LoaiDocGIa", loaiDocGia);
                cm.Parameters.AddWithValue("@Khoa", khoa);
                cm.Parameters.AddWithValue("@DiaChi", diaChi);
                cm.Parameters.AddWithValue("@SoThe", soThe);
                cm.ExecuteNonQuery();

            }
        }

        public static void editReader(string maDocGia,string password, string tenDocGia, DateTime ngaySinh, string gioiTinh, string loaiDocGia, string khoa, string diaChi, string soThe)
        {
            string sql = "update docgia set password=@Password, ten = @TenDocGIa, ngaysinh = @NgaySinh, gioitinh = @GioiTinh, loaidocgia = @LoaiDocGia, khoa = @Khoa, diachi = @DiaChi, sothe = @SoThe  where madocgia = @MaDocGia";
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@MaDocGia", maDocGia);
                cm.Parameters.AddWithValue("@Password", password);
                cm.Parameters.AddWithValue("@TenDocGia", tenDocGia);
                cm.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cm.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cm.Parameters.AddWithValue("@LoaiDocGia", loaiDocGia);
                cm.Parameters.AddWithValue("@Khoa", khoa);
                cm.Parameters.AddWithValue("@DiaChi", diaChi);
                cm.Parameters.AddWithValue("@SoThe", soThe);

                cm.ExecuteNonQuery();
            }
        }

        public static void deleteReader(string maDocGia)
        {
            string sql = "delete from docgia where madocgia = @MaDocGia";
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@MaDocGia", maDocGia);
                cm.ExecuteNonQuery();
            }
        }

        public static List<DocGia> searchReader(string code, string name, string card)
        {
            List<DocGia> list = new List<DocGia>();
            using (SqlConnection con = connection.getConnection())
            {
                con.Open();
                string sql = "select * from docgia where ";
                SqlCommand cm = new SqlCommand(sql,con);
                if (!string.IsNullOrEmpty(code))
                {
                    sql+="madocgia = @Code";
                    cm.Parameters.AddWithValue("@Code", code);
                }

                 if (!string.IsNullOrEmpty(name))
                {
                    sql += "ten LIKE @Name";
                    cm.Parameters.AddWithValue("@Name", "%" + name + "%");
                }

                 if (!string.IsNullOrEmpty(card))
                {
                    sql += "sothe LIKE @Card";
                    cm.Parameters.AddWithValue("@Card", "%" + card + "%");
                }

                cm.CommandText = sql;
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    DocGia reader = new DocGia();

                    reader.maDocGia = dr["madocgia"].ToString();
                    reader.tenDocGia = dr["ten"].ToString();
                    reader.ngaySinh = Convert.ToDateTime(dr["ngaysinh"]);
                    reader.gioiTinh = dr["gioitinh"].ToString();
                    reader.loaiDocGia = dr["loaidocgia"].ToString();
                    reader.khoa = dr["khoa"].ToString();
                    reader.diaChi = dr["diachi"].ToString();
                    reader.soThe = dr["sothe"].ToString();
                    reader.password = dr["password"].ToString();

                    list.Add(reader);
                }
            }
            return list;
        }

        public static List<string> getSoThe()
        {
            List<string> lst=new List<string>();    
            DataTable dt = new DataTable();
            string sql = "select sothe from docgia";
            using (SqlConnection conn = connection.getConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    lst.Add(row.ToString());
                }
            }
            return lst;
        }
    }
}
