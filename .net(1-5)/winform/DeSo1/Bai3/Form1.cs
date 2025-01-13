using System.Data;
using System.Data.SqlClient;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void HienThi()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = Connections.getConnection())
            {

                conn.Open();
                string sql = "select Ma,HoTen,NamSinh,MucLuong,LuongTN from teamleader";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);
                dgvSinhVien.DataSource = dt;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connections.getConnection())
            {
                conn.Open();
                string sql = "insert into teamleader values(@ma,@ten,@namsinh,@mucluong,NULL,@luongtn)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", txtMa.Text);
                //cmd.Parameters.AddWithValue("@ten","N" +txtHoTen.Text);
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtHoTen.Text.Trim();
                cmd.Parameters.AddWithValue("@namsinh", txtNamSinh.Text.Trim());
                cmd.Parameters.AddWithValue("@mucluong", txtMucLuong.Text.Trim());
                cmd.Parameters.AddWithValue("@luongtn", txtLuongTN.Text.Trim());
                cmd.ExecuteNonQuery();
            }
            HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connections.getConnection())
            {
                conn.Open();
                string sql = "update teamleader set HoTen=@ten,NamSinh=@namsinh,MucLuong=@mucluong,LuongTN=@luongtn where Ma=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", txtMa.Text.Trim());
                // cmd.Parameters.AddWithValue("@ten", "N" + txtHoTen.Text);
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtHoTen.Text.Trim();
                cmd.Parameters.AddWithValue("@namsinh", txtNamSinh.Text.Trim());
                cmd.Parameters.AddWithValue("@mucluong", txtMucLuong.Text.Trim());
                cmd.Parameters.AddWithValue("@luongtn", txtLuongTN.Text.Trim());
                cmd.ExecuteNonQuery();
            }

            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connections.getConnection())
            {
                conn.Open();
                string sql = "delete from teamleader where Ma=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", txtMa.Text);
                cmd.ExecuteNonQuery();
            }

            HienThi();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSinhVien.SelectedRows[0];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtNamSinh.Text = row.Cells[2].Value.ToString();
                txtMucLuong.Text = row.Cells[3].Value.ToString();
                txtLuongTN.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}