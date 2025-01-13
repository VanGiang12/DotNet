using System.Data;
using System.Data.SqlClient;

namespace KtraDoAn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable HienThi()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                string sql = "select * from docgia";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDS.DataSource = HienThi();
            dgvDS.Columns[0].HeaderText = "Mã ĐG";
            dgvDS.Columns[1].HeaderText = "Tên ĐG";
            dgvDS.Columns[2].HeaderText = "Cơ quan";
            dgvDS.Columns[3].HeaderText = "Địa chỉ";
            dgvDS.Columns[4].HeaderText = "SĐT";
            dgvDS.ClearSelection();
        }

        private void hem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string cq = txtCoQuan.Text;
            string dc = txtDC.Text;
            string sdt = txtsdt.Text;

            if (!string.IsNullOrEmpty(ma) && !string.IsNullOrEmpty(ten) && !string.IsNullOrEmpty(cq)
                && !string.IsNullOrEmpty(dc) && !string.IsNullOrEmpty(sdt))
            {
                using (SqlConnection conn = Connection.getConnection())
                {
                    conn.Open();
                    string sql = $"insert into docgia values('{ma}',N'{ten}',N'{cq}',N'{dc}','{sdt}')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                dgvDS.DataSource = HienThi();
                dgvDS.ClearSelection();
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string cq = txtCoQuan.Text;
            string dc = txtDC.Text;
            string sdt = txtsdt.Text;

            if (!string.IsNullOrEmpty(ma) && !string.IsNullOrEmpty(ten) && !string.IsNullOrEmpty(cq)
                && !string.IsNullOrEmpty(dc) && !string.IsNullOrEmpty(sdt))
            {
                using (SqlConnection conn = Connection.getConnection())
                {
                    conn.Open();
                    string sql = $"update docgia set tendg=N'{ten}',coquan=N'{cq}',diachi=N'{dc}',sdt='{sdt}' where madg='{ma}'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                dgvDS.DataSource = HienThi();
                dgvDS.ClearSelection();
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;

            if (!string.IsNullOrEmpty(ma))
            {
                using (SqlConnection conn = Connection.getConnection())
                {
                    conn.Open();
                    string sql = $"delete from docgia where madg='{ma}'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                } 
                dgvDS.DataSource = HienThi();
                dgvDS.ClearSelection();
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
            }
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDS.SelectedRows[0];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtCoQuan.Text = row.Cells[2].Value.ToString();
                txtDC.Text = row.Cells[3].Value.ToString();
                txtsdt.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}