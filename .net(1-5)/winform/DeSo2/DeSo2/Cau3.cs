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
    public partial class Cau3 : Form
    {
        private DataTable dt;
        private int k = 0;
        public Cau3()
        {
            InitializeComponent();
        }


        private void HienThiBanGhi(int x)
        {
            txtMa.Text = dt.Rows[x][0].ToString();
            txtHoTen.Text = dt.Rows[x][1].ToString();
            txtNgaySinh.Text = dt.Rows[x][2].ToString();
            txtQueQuan.Text = dt.Rows[x][3].ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (k > 0)
                k = k - 1;
            HienThiBanGhi(k);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            k = 0;
            HienThiBanGhi(k);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (k < dt.Rows.Count - 1)
                k = k + 1;
            HienThiBanGhi(k);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            k = dt.Rows.Count - 1;
            HienThiBanGhi(k);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemCauThu frm = new ThemCauThu();
            frm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dt = Connection.getTable("select * from CauThu");
            k = dt.Rows.Count - 1;
            HienThiBanGhi(k);
        }

        private void Cau3_Load_1(object sender, EventArgs e)
        {
            dt = Connection.getTable("select * from CauThu");
            k = dt.Rows.Count - 1;
            HienThiBanGhi(k);
        }
    }

}

