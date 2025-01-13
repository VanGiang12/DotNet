using Microsoft.Data.SqlClient;
using System.Data;

namespace testSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private static string path = @"Data Source=LAPTOP-VGPG1GUS;Initial Catalog=QLSV;Integrated Security=True;Encrypt = false";
        SqlConnection con = new SqlConnection(path);
        private void Form1_Load(object sender, EventArgs e)
        {

            con.Open();
            string sql = "select * from tblSinhVien";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvSinhVien.DataSource = dt;
            con.Close();
            ad.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "insert into tblSinhVien value(N'" + txtMa.Text + "', N'" + txtHoTen.Text + "', " + txtNamSinh.Text + ")";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();

            // hiển thị lại
            MessageBox.Show("Thêm thành công");
            con.Open();
            sql = "select * from tblSinhVien";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvSinhVien.DataSource = dt;
            con.Close();
            ad.Dispose();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update tblSinhVien set tenSV = N'" + txtHoTen.Text + "', namsinh = " + txtNamSinh.Text + " where maSv = N'" + txtMa.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();

            // hiển thị lại
            MessageBox.Show("Sửa thành công");
            con.Open();
            sql = "select * from tblSinhVien";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvSinhVien.DataSource = dt;
            con.Close();
            ad.Dispose();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblSinhVien where MaSv = N'" +
                txtMa.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();

            // hiển thị lại 
            MessageBox.Show("Đã xóa bản ghi!");
            con.Open();
            sql = "select * from tblSinhVien";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvSinhVien.DataSource = dt;
            con.Close();
            ad.Dispose();
        }
    }
}
