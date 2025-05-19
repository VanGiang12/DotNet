using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class frm_tab_QLS : Form
    {
        private frmHome frmHome;
        public frm_tab_QLS()
        {
            InitializeComponent();
        }
        public frm_tab_QLS(frmHome parentFrmHome)
        {
            InitializeComponent();
            frmHome = parentFrmHome;
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            frmHome.openChildForm(new frmQuanLySach(frmHome));
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            frmHome.openChildForm(new frmTacGia(frmHome));
            frmHome.Label7.Text = "Tác giả";
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            frmHome.openChildForm(new frmTheLoai(frmHome));
            frmHome.Label7.Text = "Thể loại";
        }

        private void btnNXB_Click(object sender, EventArgs e)
        {
            frmHome.openChildForm(new frmNXB(frmHome));
            frmHome.Label7.Text = "Nhà xuất bản";
        }

        private void frm_tab_QLS_Load(object sender, EventArgs e)
        {

        }
    }
}
