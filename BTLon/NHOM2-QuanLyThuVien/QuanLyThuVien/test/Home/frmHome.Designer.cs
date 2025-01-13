namespace test
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            lblBaoCaoTK = new Label();
            imageList1 = new ImageList(components);
            lblMuaSach = new Label();
            lblMuonTra = new Label();
            lblDocGia = new Label();
            lblQuanLySach = new Label();
            lblTrangChu = new Label();
            panel4 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel_body = new Panel();
            panel5 = new Panel();
            label7 = new Label();
            lblDangXuat = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(lblDangXuat);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 69);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(992, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(927, 30);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 3;
            label9.Text = "Hi, admin";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sylfaen", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(158, 12);
            label8.Name = "label8";
            label8.Size = new Size(196, 44);
            label8.TabIndex = 1;
            label8.Text = "THƯ VIỆN";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(lblBaoCaoTK);
            panel2.Controls.Add(lblMuaSach);
            panel2.Controls.Add(lblMuonTra);
            panel2.Controls.Add(lblDocGia);
            panel2.Controls.Add(lblQuanLySach);
            panel2.Controls.Add(lblTrangChu);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(178, 538);
            panel2.TabIndex = 1;
            // 
            // lblBaoCaoTK
            // 
            lblBaoCaoTK.BackColor = Color.Teal;
            lblBaoCaoTK.Dock = DockStyle.Top;
            lblBaoCaoTK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaoCaoTK.ForeColor = SystemColors.Control;
            lblBaoCaoTK.ImageAlign = ContentAlignment.MiddleLeft;
            lblBaoCaoTK.ImageIndex = 8;
            lblBaoCaoTK.ImageList = imageList1;
            lblBaoCaoTK.Location = new Point(0, 413);
            lblBaoCaoTK.Name = "lblBaoCaoTK";
            lblBaoCaoTK.Padding = new Padding(10, 0, 13, 0);
            lblBaoCaoTK.Size = new Size(178, 65);
            lblBaoCaoTK.TabIndex = 6;
            lblBaoCaoTK.Text = "Báo cáo thống kê";
            lblBaoCaoTK.TextAlign = ContentAlignment.MiddleRight;
            lblBaoCaoTK.Click += lblBaoCaoTK_Click;
            lblBaoCaoTK.MouseLeave += lblBaoCaoTK_MouseLeave;
            lblBaoCaoTK.MouseHover += lblBaoCaoTK_MouseHover;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "CaRo - Copy.png");
            imageList1.Images.SetKeyName(1, "home.png");
            imageList1.Images.SetKeyName(2, "home.png");
            imageList1.Images.SetKeyName(3, "books.png");
            imageList1.Images.SetKeyName(4, "books-stack-of-three.png");
            imageList1.Images.SetKeyName(5, "man.png");
            imageList1.Images.SetKeyName(6, "multiple-users-silhouette.png");
            imageList1.Images.SetKeyName(7, "book.png");
            imageList1.Images.SetKeyName(8, "statistics.png");
            imageList1.Images.SetKeyName(9, "grocery-store.png");
            // 
            // lblMuaSach
            // 
            lblMuaSach.BackColor = Color.Teal;
            lblMuaSach.Dock = DockStyle.Top;
            lblMuaSach.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMuaSach.ForeColor = SystemColors.Control;
            lblMuaSach.ImageAlign = ContentAlignment.MiddleLeft;
            lblMuaSach.ImageIndex = 9;
            lblMuaSach.ImageList = imageList1;
            lblMuaSach.Location = new Point(0, 348);
            lblMuaSach.Name = "lblMuaSach";
            lblMuaSach.Padding = new Padding(10, 0, 58, 0);
            lblMuaSach.Size = new Size(178, 65);
            lblMuaSach.TabIndex = 5;
            lblMuaSach.Text = "Mua sách";
            lblMuaSach.TextAlign = ContentAlignment.MiddleRight;
            lblMuaSach.Click += lblMuaSach_Click;
            lblMuaSach.MouseLeave += lblMuaSach_MouseLeave;
            lblMuaSach.MouseHover += lblMuaSach_MouseHover;
            // 
            // lblMuonTra
            // 
            lblMuonTra.BackColor = Color.Teal;
            lblMuonTra.Dock = DockStyle.Top;
            lblMuonTra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMuonTra.ForeColor = SystemColors.Control;
            lblMuonTra.ImageAlign = ContentAlignment.MiddleLeft;
            lblMuonTra.ImageIndex = 7;
            lblMuonTra.ImageList = imageList1;
            lblMuonTra.Location = new Point(0, 283);
            lblMuonTra.Name = "lblMuonTra";
            lblMuonTra.Padding = new Padding(10, 0, 0, 0);
            lblMuonTra.Size = new Size(178, 65);
            lblMuonTra.TabIndex = 2;
            lblMuonTra.Text = "Mượn-Trả";
            lblMuonTra.TextAlign = ContentAlignment.MiddleCenter;
            lblMuonTra.Click += lblMuonTra_Click;
            lblMuonTra.MouseLeave += lblMuonTra_MouseLeave;
            lblMuonTra.MouseHover += lblMuonTra_MouseHover;
            // 
            // lblDocGia
            // 
            lblDocGia.BackColor = Color.Teal;
            lblDocGia.Dock = DockStyle.Top;
            lblDocGia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocGia.ForeColor = SystemColors.Control;
            lblDocGia.ImageAlign = ContentAlignment.MiddleLeft;
            lblDocGia.ImageIndex = 6;
            lblDocGia.ImageList = imageList1;
            lblDocGia.Location = new Point(0, 218);
            lblDocGia.Name = "lblDocGia";
            lblDocGia.Padding = new Padding(10, 0, 15, 0);
            lblDocGia.Size = new Size(178, 65);
            lblDocGia.TabIndex = 4;
            lblDocGia.Text = "Độc giả";
            lblDocGia.TextAlign = ContentAlignment.MiddleCenter;
            lblDocGia.Click += lblDocGia_Click;
            lblDocGia.MouseLeave += lblDocGia_MouseLeave;
            lblDocGia.MouseHover += lblDocGia_MouseHover;
            // 
            // lblQuanLySach
            // 
            lblQuanLySach.BackColor = Color.Teal;
            lblQuanLySach.Dock = DockStyle.Top;
            lblQuanLySach.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuanLySach.ForeColor = SystemColors.Control;
            lblQuanLySach.ImageAlign = ContentAlignment.MiddleLeft;
            lblQuanLySach.ImageIndex = 3;
            lblQuanLySach.ImageList = imageList1;
            lblQuanLySach.Location = new Point(0, 153);
            lblQuanLySach.Name = "lblQuanLySach";
            lblQuanLySach.Padding = new Padding(10, 0, 42, 0);
            lblQuanLySach.Size = new Size(178, 65);
            lblQuanLySach.TabIndex = 3;
            lblQuanLySach.Text = "Quản lý sách";
            lblQuanLySach.TextAlign = ContentAlignment.MiddleRight;
            lblQuanLySach.Click += lblQuanLySach_Click;
            lblQuanLySach.MouseLeave += lblQuanLySach_MouseLeave;
            lblQuanLySach.MouseHover += lblQuanLySach_MouseHover;
            // 
            // lblTrangChu
            // 
            lblTrangChu.BackColor = Color.Teal;
            lblTrangChu.Dock = DockStyle.Top;
            lblTrangChu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTrangChu.ForeColor = SystemColors.Control;
            lblTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            lblTrangChu.ImageIndex = 1;
            lblTrangChu.ImageList = imageList1;
            lblTrangChu.Location = new Point(0, 88);
            lblTrangChu.Name = "lblTrangChu";
            lblTrangChu.Padding = new Padding(10, 0, 0, 0);
            lblTrangChu.Size = new Size(178, 65);
            lblTrangChu.TabIndex = 1;
            lblTrangChu.Text = "Trang chủ";
            lblTrangChu.TextAlign = ContentAlignment.MiddleCenter;
            lblTrangChu.Click += lblTrangChu_Click;
            lblTrangChu.MouseLeave += lblTrangChu_MouseLeave;
            lblTrangChu.MouseHover += lblTrangChu_MouseHover;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(178, 88);
            panel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(60, 35);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "CHÀO MỪNG";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel_body);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.ForeColor = SystemColors.Control;
            panel3.Location = new Point(178, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(961, 538);
            panel3.TabIndex = 2;
            // 
            // panel_body
            // 
            panel_body.BackgroundImageLayout = ImageLayout.Stretch;
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(0, 35);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(961, 503);
            panel_body.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 192, 192);
            panel5.Controls.Add(label7);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(961, 35);
            panel5.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 6);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 0;
            label7.Text = "HOME";
            // 
            // lblDangXuat
            // 
            lblDangXuat.AutoSize = true;
            lblDangXuat.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point);
            lblDangXuat.ForeColor = Color.White;
            lblDangXuat.Location = new Point(1040, 25);
            lblDangXuat.Name = "lblDangXuat";
            lblDangXuat.Size = new Size(77, 20);
            lblDangXuat.TabIndex = 4;
            lblDangXuat.Text = "Đăng xuất";
            lblDangXuat.Click += lblDangXuat_Click;
            lblDangXuat.MouseLeave += lblDangXuat_MouseLeave;
            lblDangXuat.MouseHover += lblDangXuat_MouseHover;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 607);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(1155, 646);
            MinimumSize = new Size(1155, 646);
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ THƯ VIỆN";
            FormClosing += frmHome_FormClosing;
            Load += frmHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label lblTrangChu;
        private Label lblMuaSach;
        private Label lblDocGia;
        private Label lblQuanLySach;
        private Label lblMuonTra;
        private PictureBox pictureBox2;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label9;
        private Panel panel5;
        private Label label7;
        private ImageList imageList1;
        private Panel panel_body;
        private Label lblBaoCaoTK;
        private Label lblDangXuat;

        public Panel Panel_body { get => panel_body; set => panel_body = value; }
        public Label Label7 { get => label7; set => label7 = value; }
    }
}