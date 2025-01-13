using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Login;
using test.NhapSach;

namespace test
{
    public partial class frmHome : Form
    {
        public static Form? currentFormChild;

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            SetCircularImage(pictureBox1);
            SetCircularImage(pictureBox3);
            openChildForm(new frm_tab_Home());
            label7.Text = "Trang chủ";
        }

        private void SetCircularImage(PictureBox p)
        {
            // Đảm bảo hình ảnh trong PictureBox là hình vuông
            if (p.Image.Width != p.Image.Height)
            {
                MessageBox.Show("Hình ảnh không phải là hình vuông. Vui lòng chỉ sử dụng hình ảnh vuông để làm hình tròn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo bitmap mới có kích thước bằng với hình ảnh
            Bitmap bmp = new Bitmap(p.Image.Width, p.Image.Height);

            // Vẽ hình tròn bằng cách cắt hình ảnh theo hình tròn
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Vẽ hình tròn
                g.Clear(Color.Transparent);
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, bmp.Width, bmp.Height);
                g.SetClip(path);
                g.DrawImage(p.Image, 0, 0);
            }

            // Hiển thị hình ảnh tròn trong PictureBox
            p.Image = bmp;
        }

        public void openChildForm(Form childForm)
        {
            //nếu có form khác đang mở thì đóng nó lại r mới mở form mới
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;//Để có thểm thêm vào điều khiển khác, không thể kéo di chuyển tùy ý như 1 form độc lập
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            //panel_body.Tag = childForm;
            panel_body.BringToFront();
            childForm.Show();
        }

        #region Trang chủ
        private void lblTrangChu_MouseLeave(object sender, EventArgs e)
        {
            lblTrangChu.BackColor = Color.Teal;
        }
        private void lblTrangChu_MouseHover(object sender, EventArgs e)
        {
            lblTrangChu.BackColor = Color.Red;
        }
        private void lblTrangChu_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_tab_Home());
            label7.Text = "Trang chủ";
        }
        #endregion

        #region Quản lý sách
        private void lblQuanLySach_MouseHover(object sender, EventArgs e)
        {
            lblQuanLySach.BackColor = Color.Red;
        }
        private void lblQuanLySach_MouseLeave(object sender, EventArgs e)
        {
            lblQuanLySach.BackColor = Color.Teal;
        }
        private void lblQuanLySach_Click(object sender, EventArgs e)
        {
            frm_tab_QLS frm = new frm_tab_QLS(this);
            //form hiện tại: frmHome
            openChildForm(frm);// mở form frm_tab_qls trong form hiện tại
            label7.Text = lblQuanLySach.Text;
        }
        #endregion

        #region Mượn trả
        private void lblMuonTra_MouseHover(object sender, EventArgs e)
        {
            lblMuonTra.BackColor = Color.Red;
        }
        private void lblMuonTra_MouseLeave(object sender, EventArgs e)
        {
            lblMuonTra.BackColor = Color.Teal;
        }
        private void lblMuonTra_Click(object sender, EventArgs e)
        {
            //frm_tab__MuonTra frm = new frm_tab__MuonTra(this);
            openChildForm(new frmMuonSach());
            label7.Text = "Mượn trả sách";
        }
        #endregion

        #region Độc giả
        private void lblDocGia_MouseHover(object sender, EventArgs e)
        {
            lblDocGia.BackColor = Color.Red;
        }

        private void lblDocGia_MouseLeave(object sender, EventArgs e)
        {
            lblDocGia.BackColor = Color.Teal;
        }
        private void lblDocGia_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_tab_QLDocGia());
            label7.Text = "Quản lý độc giả";
        }
        #endregion

        #region Mua sách

        private void lblMuaSach_MouseHover(object sender, EventArgs e)
        {
            lblMuaSach.BackColor = Color.Red;
        }

        private void lblMuaSach_MouseLeave(object sender, EventArgs e)
        {
            lblMuaSach.BackColor = Color.Teal;
        }
        private void lblMuaSach_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhieuMua(this));
            label7.Text = "Mua sách";
        }
        #endregion

        #region Báo cáo thống kê
        private void lblBaoCaoTK_MouseHover(object sender, EventArgs e)
        {
            lblBaoCaoTK.BackColor = Color.Red;
        }

        private void lblBaoCaoTK_MouseLeave(object sender, EventArgs e)
        {
            lblBaoCaoTK.BackColor = Color.Teal;
        }
        private void lblBaoCaoTK_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_tab_BaoCaoTK());
            label7.Text = "Báo cáo-Thống kê";
        }
        #endregion

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void lblDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                this.Hide();
                new frmDangNhap().Show();
            }
        }

        private void lblDangXuat_MouseHover(object sender, EventArgs e)
        {
            lblDangXuat.ForeColor=Color.Red;
        }

        private void lblDangXuat_MouseLeave(object sender, EventArgs e)
        {
            lblDangXuat.ForeColor = Color.White;
        }
    }
}
