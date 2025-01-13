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
    public partial class CapNhat : Form
    {
        public CapNhat()
        {
            InitializeComponent();
        }

        private void CapNhat_Load(object sender, EventArgs e)
        {
            string sql = "select * from sinhvien";
            dataGridView1.DataSource = Connection.getDS(sql);
            dataGridView1.Columns[0].HeaderText = "Mã SV";
            dataGridView1.Columns[1].HeaderText = "Tên SV";
            dataGridView1.Columns[2].HeaderText = "Khoa ";
            dataGridView1.Columns[3].HeaderText = "Quê quán";
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
                string sql = $"update sinhvien set tensv=N'{ten}',khoa=N'{khoa}',quequan=N'{qq}' where  masv='{ma}'";
                SqlConnection conn = Connection.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Nhập đủ dữ liệu");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;

            if (!string.IsNullOrEmpty(ma))
            {
                string sql = $"delete from sinhvien where masv='{ma}'";
                SqlConnection conn = Connection.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Nhập đủ dữ liệu");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                cboKhoa.SelectedItem = row.Cells[2].Value.ToString();
                txtQueQuan.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
