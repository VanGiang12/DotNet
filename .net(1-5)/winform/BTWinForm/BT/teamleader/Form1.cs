using Microsoft.Data.SqlClient;
using System.Data;

namespace teamleader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string path = "Data Source=LAPTOP-VGPG1GUS;Initial Catalog=Teamleader;Integrated Security=True; Encrypt =false";
        private SqlConnection conn = new SqlConnection(path);
        private void Form1_Load(object sender, EventArgs e)
        {
            hienThi();
        }
        public void hienThi()
        {
            conn.Open();
            string sql = "select * from teamleader";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvSinhVien.DataSource = dt;

            dgvSinhVien.ClearSelection();
            conn.Close();
            adapter.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = $"insert into teamleader values('N{txtMa.Text}', '{txtHoTen.Text.Trim()}', {txtNamSinh.Text}, {txtMucLuong.Text}, {txtTienTK.Text}, {txtLuongTN.Text}) ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();

            // hien thi lai
            MessageBox.Show("Them thanh cong");
            hienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = $"update teamleader set HoTen = N'{txtHoTen.Text.Trim()}'," +
                $" NamSinh = {txtNamSinh.Text}, MucLuong = {txtMucLuong.Text}, " +
                $"TienTK = {txtTienTK.Text}, LuongTN ={txtLuongTN.Text} where Ma = '{txtMa.Text}'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
            //MessageBox.Show("Sua thanh cong");
            hienThi();

            txtMa.Text = "";
            txtHoTen.Text = "";
            txtNamSinh.Text = "";
            txtMucLuong.Text = "";
            txtTienTK.Text = "";
            txtLuongTN.Text = "";

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = $"delete from teamleader where Ma = '{txtMa.Text}'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();

            //            MessageBox.Show("Xoa thanh cong");
            hienThi();

            txtMa.Text = "";
            txtHoTen.Text = "";
            txtNamSinh.Text = "";
            txtMucLuong.Text = "";
            txtTienTK.Text = "";
            txtLuongTN.Text = "";
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
                txtTienTK.Text = row.Cells[4].Value.ToString();
                txtLuongTN.Text = row.Cells[5].Value.ToString();

            }
            else
            {
                txtMa.Text = "";
                txtHoTen.Text = "";
                txtNamSinh.Text = "";
                txtMucLuong.Text = "";
                txtTienTK.Text = "";
                txtLuongTN.Text = "";
            }
        }
    }
}