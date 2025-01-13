using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ontap2
{
    public partial class Cau3 : Form
    {
        int k;
        DataTable dt;
        public Cau3()
        {
            InitializeComponent();

        }

        public void HienThi(int k)
        {
            txtMa.Text = dt.Rows[k][0].ToString();
            txtTen.Text = dt.Rows[k][1].ToString();
            txtns.Text = dt.Rows[k][2].ToString();
            txtQQ.Text = dt.Rows[k][3].ToString();
        }
        private void Cau3_Load(object sender, EventArgs e)
        {
            dt = Connection.getds("");
            k = 0;
            HienThi(k);
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            dt = Connection.getds("");
            k = 0;
            HienThi(k);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            dt = Connection.getds("");
            k = dt.Rows.Count - 1;
            HienThi(k);
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            dt = Connection.getds("");
            if (k > 0)
            {
                k--;
                HienThi(k);
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            dt = Connection.getds("");
            if (k < dt.Rows.Count-1)
            {
                k++;
                HienThi(k);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new ThemCauThu().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Connection.kn())
            {
                con.Open();
                if (!string.IsNullOrEmpty(txtMa.Text) && !string.IsNullOrEmpty(txtTen.Text)
                    && DateTime.Parse(txtns.Text).Date != DateTime.Now.Date && !string.IsNullOrEmpty(txtns.Text))
                {
                    string ma = txtMa.Text;
                    string ten = txtTen.Text;
                    DateTime ns = DateTime.Parse(txtns.Text).Date;
                    string qq = txtQQ.Text;

                    string sql = "update cauthu set hoten=@ten,ngaysinh=@ns,quequan=@qq where mact=@ma";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@ma", ma);
                        cmd.Parameters.AddWithValue("@ten", ten);
                        cmd.Parameters.AddWithValue("@ns", ns);
                        cmd.Parameters.AddWithValue("@qq", qq);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ dữ liệu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoats_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string tk = txtMa.Text;
            dataGridView1.DataSource = Connection.getds("where mact like '%" + tk + "%'");
        }
    }
}
