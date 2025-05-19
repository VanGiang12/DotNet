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
    public partial class frm_tab__MuonTra : Form
    {
        private frmHome frmHome;
        public frm_tab__MuonTra()
        {
            InitializeComponent();
        }
        public frm_tab__MuonTra(frmHome parentHome)
        {
            InitializeComponent();
            frmHome = parentHome;
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            frmHome.openChildForm(new frmMuonSach());
        }
    }
}
