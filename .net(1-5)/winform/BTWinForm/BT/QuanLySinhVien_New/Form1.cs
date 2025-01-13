using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_New
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource =
                DataAccess.getTable("select MaSV as 'Mã SV',  HoTen as 'Họ Và Tên', NamSinh as 'Năm Sinh' from tbSinhVien");

            dgvSinhVien.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvSinhVien.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvSinhVien.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into tbSinhVien values('"+
                txtMaSV.Text+"', N'"+
                txtHoTen.Text+"', "+
                txtNamSinh.Text+")";

            DataAccess.inSertEditDelete(sql);
            // update dữ liệu
            dgvSinhVien.DataSource = DataAccess.getTable("select MaSV as 'Mã SV',  HoTen as 'Họ Và Tên', NamSinh as 'Năm Sinh' from tbSinhVien");
        }
    }
}
