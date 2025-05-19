using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Model;

namespace test.NhapSach
{
    public partial class frmThemNXB : Form
    {
        MuaSach muasach = new MuaSach();

        // Constructor nhận đối tượng MainForm
        public frmThemNXB()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String ma = txtMaNXB.Text;
            String ten = txtTenNXB.Text;
            String lienhe = txtLienHe.Text;
            if (muasach.themNXB(ma, ten, lienhe))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            Close();

        }
    }

    internal class MainForm
    {
    }
}
