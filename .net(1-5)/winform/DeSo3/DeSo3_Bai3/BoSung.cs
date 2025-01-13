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

namespace DeSo3_Bai3
{
    public partial class BoSung : Form
    {
        public BoSung()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            cboKhoa.SelectedIndex = -1;
            txtQueQuan.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string? khoa = cboKhoa.SelectedItem.ToString();
            string qq = txtQueQuan.Text;

            if (!string.IsNullOrEmpty(ma) && !string.IsNullOrEmpty(ten) &&
                !string.IsNullOrEmpty(khoa) && !string.IsNullOrEmpty(qq))
            {
                string sql = $"insert into sinhvien values('{ma}',N'{ten}',N'{khoa}',N'{qq}')";
                SqlConnection conn = Connection.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập đủ dữ liệu");
            }
        }
    }
}
