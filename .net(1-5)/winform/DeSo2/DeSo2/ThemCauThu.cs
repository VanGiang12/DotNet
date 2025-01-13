using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeSo2
{
    public partial class ThemCauThu : Form
    {
        public ThemCauThu()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection.TaoKetNoi())
            {
                conn.Open();
                string ma = txtMa.Text;
                string ten = txtHoTen.Text;
                DateTime ngaysinh = DateTime.Parse(txtNgaySinh.Text);
                string quequan = cboNgaySinh.Text;
                string sql = "insert into cauthu values(@ma,@ten,@ngaysinh,@quequan)";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ma", ma);
                        cmd.Parameters.AddWithValue("@ten", ten);
                        cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                        cmd.Parameters.AddWithValue("@quequan", quequan);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
            }
            this.Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtMa.Clear();
            txtNgaySinh.Clear();
            cboNgaySinh.SelectedIndex = -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
