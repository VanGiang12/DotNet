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

namespace ontap2
{
    public partial class ThemCauThu : Form
    {
        public ThemCauThu()
        {
            InitializeComponent();
        }

        private void btnThoats_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtns.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = Connection.kn())
            {
                con.Open();
                if(!string.IsNullOrEmpty(txtMa.Text) && !string.IsNullOrEmpty(txtTen.Text)
                    && DateTime.Parse(txtns.Text).Date!=DateTime.Now.Date && comboBox1.SelectedIndex!=-1)
                {
                    string ma = txtMa.Text;
                    string ten=txtTen.Text;
                    DateTime ns=DateTime.Parse(txtns.Text).Date;
                    string qq=comboBox1.SelectedItem.ToString();

                    string sql = "insert into cauthu values(@ma,@ten,@ns,@qq)";
                    using(SqlCommand cmd=new SqlCommand(sql, con))
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
                    MessageBox.Show("Chưa nhập đủ dữ liệu","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            this.Close();
        }
    }
}
