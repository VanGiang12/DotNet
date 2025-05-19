using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Model
{
    internal class TacGia
    {
        private String maTacGia;
        private String tenTacGia;
        private String lienHe;

        public string MaTacGia { get => maTacGia; set => maTacGia = value; }
        public string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        public string LienHe { get => lienHe; set => lienHe = value; }

        SqlDataAdapter adapter;
        SqlCommand command;

        public TacGia() { }
        public TacGia(string maTacGia, string tenTacGia, string lienHe)
        {
            this.MaTacGia = maTacGia;
            this.TenTacGia = tenTacGia;
            this.LienHe = lienHe;
        }

        public DataTable getAllTacGia()
        {
            DataTable dt = new DataTable();
            string sql = "select * from tacgia";
            using (SqlConnection conn = connection.getConnection())
            {
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);
            }

            return dt;
        }

        public bool Insert(TacGia tg)
        {
            SqlConnection conn = connection.getConnection();
            string sql = "insert into tacgia values(@maTG,@tenTG,@lienhe)";

            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@maTG", tg.maTacGia);
                command.Parameters.AddWithValue("@tenTG", tg.tenTacGia);
                command.Parameters.AddWithValue("@lienhe", tg.lienHe);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tác giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public bool Update(TacGia tg)
        {
            SqlConnection conn = connection.getConnection();
            string sql = "update tacgia set tentacgia=@tentacgia,lienhe=@lienhe where matacgia=@matacgia";

            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@tentacgia", tg.tenTacGia);
                command.Parameters.AddWithValue("@lienhe", tg.lienHe);
                command.Parameters.AddWithValue("@matacgia", tg.maTacGia);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa tác giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SqlConnection conn = connection.getConnection();
            string sql = "delete from tacgia where matacgia=@matacgia";
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@matacgia", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa tacgia: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public DataTable Search(string id, string sql, string s)
        {
            DataTable dt;
            using (SqlConnection conn = connection.getConnection())
            {
                dt = new DataTable();

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(s, id);
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                        {
                            dataAdapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm tác giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            return dt;
        }
    }
}
