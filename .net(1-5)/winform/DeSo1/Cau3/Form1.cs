using System.Data;
using System.Data.SqlClient;

namespace Cau3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = HienThi();
        }
        public DataTable HienThi()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = Connection.connection())
            {
                conn.Open();
                string sql = "select * from teamleader";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);

            }
            return dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            int ns = int.Parse(txtNS.Text);
            float mucluong = float.Parse(txtMucLuong.Text);
            float tientk = float.Parse(txtTienTK.Text);
            float luongtn = float.Parse(txtLuongTN.Text);

            string sql = $"insert into teamleader values('{ma}',N'{ten}',{ns},{mucluong},{tientk},{luongtn})";
            using (SqlConnection conn = Connection.connection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            dataGridView1.DataSource = HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            int ns = int.Parse(txtNS.Text);
            float mucluong = float.Parse(txtMucLuong.Text);
            float tientk = float.Parse(txtTienTK.Text);
            float luongtn = float.Parse(txtLuongTN.Text);

            string sql = $"update teamleader set HoTen=N'{ten}',NamSinh={ns},MucLuong={mucluong},TienTK={tientk},LuongTN={luongtn} where Ma='{ma}'";
            using (SqlConnection conn = Connection.connection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            dataGridView1.DataSource = HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;

            string sql = $"delete from teamleader where Ma='{ma}'";
            using (SqlConnection conn = Connection.connection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            dataGridView1.DataSource = HienThi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtNS.Text = row.Cells[2].Value.ToString();
                txtMucLuong.Text = row.Cells[3].Value.ToString();
                txtTienTK.Text = row.Cells[4].Value.ToString();
                txtLuongTN.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}