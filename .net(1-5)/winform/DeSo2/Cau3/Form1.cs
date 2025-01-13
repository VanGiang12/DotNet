using System.Data;
using System.Data.SqlClient;

namespace Cau3
{
    public partial class Form1 : Form
    {
        DataTable dt;
        int k = 0;
        public Form1()
        {
            InitializeComponent();
            dt = Connection.getDS("select * from cauthu");
            Hienthi(k);
        }

        public void Hienthi(int k)
        {
            txtMa.Text = dt.Rows[k][0].ToString();
            txtTen.Text = dt.Rows[k][1].ToString();
            txtNS.Text = dt.Rows[k][2].ToString();
            txtQueQuan.Text = dt.Rows[k][3].ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            dt = Connection.getDS("select * from cauthu");
            Hienthi(0);
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (k > 0)
            {
                k--;
            }
            Hienthi(k);
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (k < dt.Rows.Count - 1)
            {
                k++;
            }
            Hienthi(k);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            k = dt.Rows.Count - 1;
            Hienthi(k);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new ThemCauThu().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string ns = txtNS.Text;
            string qq = txtQueQuan.Text;

            using (SqlConnection conn = Connection.connection())
            {
                conn.Open();
                string sql = $"update cauthu set hoten=N'{ten}',ngaysinh='{ns}',quequan=N'{qq}' where mact='{ma}'";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.ExecuteNonQuery();
            }
            dt = Connection.getDS("select * from cauthu");
            Hienthi(k);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}