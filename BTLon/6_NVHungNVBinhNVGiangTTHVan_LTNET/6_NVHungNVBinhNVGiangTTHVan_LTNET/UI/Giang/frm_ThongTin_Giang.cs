using _6_NVHungNVBinhNVGiangTTHVan_LTNET.Database;
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

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.UI.Giang
{
    public partial class frm_ThongTin_Giang : Form
    {
        public frm_ThongTin_Giang()
        {
            InitializeComponent();
        }

        private void frm_ThongTin_Giang_Load(object sender, EventArgs e)
        {
            tb_manv_giang.Text = frm_Login_Giang.Key;
            tb_tennv_giang.Text = getTenNV();

        }
        string getTenNV()
        {
            DataTable dt;
            using (SqlConnection con = Connections.connect())
            {
                con.Open();
                string sql = $"SELECT HoTenNV FROM NhanVien where MaNV = '{frm_Login_Giang.Key}'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                adapter.Fill(dt);
            }

            return (dt.Rows.Count > 0) ? dt.Rows[0]["HoTenNV"].ToString() : "";
        }

        private void btn_dangxuat_giang_Click(object sender, EventArgs e)
        {
            frm_Home_Giang.parent.Hide();
            new frm_Login_Giang().Show();
        }
    }
}
