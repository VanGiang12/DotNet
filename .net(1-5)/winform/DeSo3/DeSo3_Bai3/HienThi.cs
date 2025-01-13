using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DeSo3_Bai3
{
    public partial class HienThi : Form
    {
        public HienThi()
        {
            InitializeComponent();
        }

        private void HienThi_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            new BoSung().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CapNhat().ShowDialog();
        }

        public void title()
        {
            dataGridView1.Columns[0].HeaderText = "Mã SV";
            dataGridView1.Columns[1].HeaderText = "Tên SV";
            dataGridView1.Columns[2].HeaderText = "Khoa ";
            dataGridView1.Columns[3].HeaderText = "Quê quán";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int lc = cboKhoa.SelectedIndex;
            string sql = "";
            switch (lc)
            {
                case 0:
                    {
                        sql = "select * from sinhvien where khoa = N'cơ khí'";
                        dataGridView1.DataSource = Connection.getDS(sql);
                        title();
                    }
                    break;
                case 1:
                    {
                        sql = "select * from sinhvien where khoa=N'cntt'";
                        dataGridView1.DataSource = Connection.getDS(sql);
                        title();
                    }
                    break;
                case 2:
                    {
                        sql = "select * from sinhvien where khoa=N'điện tử'";
                        dataGridView1.DataSource = Connection.getDS(sql);
                        title();
                    }
                    break;
            }
        }
    }
}
