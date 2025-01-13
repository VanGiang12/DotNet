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

namespace Cau3
{
    public partial class ThemCauThu : Form
    {
        public ThemCauThu()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string ns = txtNS.Text;
            string qq = cboQQ.SelectedItem.ToString();

            using (SqlConnection conn = Connection.connection())
            {
                conn.Open();
                string sql = $"insert into cauthu values('{ma}',N'{ten}','{ns}',N'{qq}')";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.ExecuteNonQuery();
            }
            this.Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtNS.Clear();
            cboQQ.SelectedIndex = -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
