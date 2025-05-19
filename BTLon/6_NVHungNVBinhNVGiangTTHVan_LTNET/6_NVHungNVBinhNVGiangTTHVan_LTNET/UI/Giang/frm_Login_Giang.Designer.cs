namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET
{
    partial class frm_Login_Giang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login_Giang));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_taikhoan_giang = new TextBox();
            tb_matkhau_giang = new TextBox();
            rad_admin_giang = new RadioButton();
            rad_nhanvien_giang = new RadioButton();
            btn_dangnhap_giang = new Button();
            imageList1 = new ImageList(components);
            btn_thoat_giang = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            lbl_message_giang = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 208);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = Properties.Resources.tien;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(224, 141);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 160);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 18);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ TIẾT KIỆM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(78, 188);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(82, 235);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // tb_taikhoan_giang
            // 
            tb_taikhoan_giang.BorderStyle = BorderStyle.FixedSingle;
            tb_taikhoan_giang.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_taikhoan_giang.Location = new Point(167, 185);
            tb_taikhoan_giang.Margin = new Padding(4, 3, 4, 3);
            tb_taikhoan_giang.Name = "tb_taikhoan_giang";
            tb_taikhoan_giang.Size = new Size(259, 23);
            tb_taikhoan_giang.TabIndex = 3;
            // 
            // tb_matkhau_giang
            // 
            tb_matkhau_giang.BorderStyle = BorderStyle.FixedSingle;
            tb_matkhau_giang.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_matkhau_giang.Location = new Point(167, 232);
            tb_matkhau_giang.Margin = new Padding(4, 3, 4, 3);
            tb_matkhau_giang.Name = "tb_matkhau_giang";
            tb_matkhau_giang.PasswordChar = '*';
            tb_matkhau_giang.Size = new Size(259, 23);
            tb_matkhau_giang.TabIndex = 4;
            // 
            // rad_admin_giang
            // 
            rad_admin_giang.AutoSize = true;
            rad_admin_giang.BackColor = Color.Transparent;
            rad_admin_giang.ForeColor = Color.White;
            rad_admin_giang.Location = new Point(191, 284);
            rad_admin_giang.Margin = new Padding(4, 3, 4, 3);
            rad_admin_giang.Name = "rad_admin_giang";
            rad_admin_giang.Size = new Size(61, 19);
            rad_admin_giang.TabIndex = 5;
            rad_admin_giang.TabStop = true;
            rad_admin_giang.Text = "Admin";
            rad_admin_giang.UseVisualStyleBackColor = false;
            rad_admin_giang.CheckedChanged += rad_admin_giang_CheckedChanged;
            // 
            // rad_nhanvien_giang
            // 
            rad_nhanvien_giang.AutoSize = true;
            rad_nhanvien_giang.BackColor = Color.Transparent;
            rad_nhanvien_giang.ForeColor = Color.White;
            rad_nhanvien_giang.Location = new Point(296, 284);
            rad_nhanvien_giang.Margin = new Padding(4, 3, 4, 3);
            rad_nhanvien_giang.Name = "rad_nhanvien_giang";
            rad_nhanvien_giang.Size = new Size(79, 19);
            rad_nhanvien_giang.TabIndex = 6;
            rad_nhanvien_giang.TabStop = true;
            rad_nhanvien_giang.Text = "Nhân viên";
            rad_nhanvien_giang.UseVisualStyleBackColor = false;
            // 
            // btn_dangnhap_giang
            // 
            btn_dangnhap_giang.BackColor = Color.FromArgb(224, 224, 224);
            btn_dangnhap_giang.FlatStyle = FlatStyle.Popup;
            btn_dangnhap_giang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dangnhap_giang.ImageIndex = 1;
            btn_dangnhap_giang.ImageList = imageList1;
            btn_dangnhap_giang.Location = new Point(167, 310);
            btn_dangnhap_giang.Margin = new Padding(4, 3, 4, 3);
            btn_dangnhap_giang.Name = "btn_dangnhap_giang";
            btn_dangnhap_giang.Size = new Size(126, 39);
            btn_dangnhap_giang.TabIndex = 7;
            btn_dangnhap_giang.Text = "      Đăng Nhập";
            btn_dangnhap_giang.UseVisualStyleBackColor = false;
            btn_dangnhap_giang.Click += btn_dangnhap_giang_Click;
            btn_dangnhap_giang.MouseLeave += btn_dangnhap_giang_MouseLeave;
            btn_dangnhap_giang.MouseHover += btn_dangnhap_giang_MouseHover;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cancel.png");
            imageList1.Images.SetKeyName(1, "login.png");
            // 
            // btn_thoat_giang
            // 
            btn_thoat_giang.BackColor = Color.FromArgb(224, 224, 224);
            btn_thoat_giang.DialogResult = DialogResult.Cancel;
            btn_thoat_giang.FlatAppearance.BorderColor = Color.Red;
            btn_thoat_giang.FlatStyle = FlatStyle.Popup;
            btn_thoat_giang.ForeColor = SystemColors.ControlText;
            btn_thoat_giang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_thoat_giang.ImageIndex = 0;
            btn_thoat_giang.ImageList = imageList1;
            btn_thoat_giang.Location = new Point(300, 310);
            btn_thoat_giang.Margin = new Padding(4, 3, 4, 3);
            btn_thoat_giang.Name = "btn_thoat_giang";
            btn_thoat_giang.Size = new Size(126, 39);
            btn_thoat_giang.TabIndex = 8;
            btn_thoat_giang.Text = "Thoát";
            btn_thoat_giang.UseVisualStyleBackColor = false;
            btn_thoat_giang.Click += btn_thoat_giang_Click;
            btn_thoat_giang.MouseLeave += btn_thoat_giang_MouseLeave;
            btn_thoat_giang.MouseHover += btn_thoat_giang_MouseHover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Magneto", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(128, 132);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(206, 32);
            label4.TabIndex = 9;
            label4.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.hinh4;
            pictureBox1.Location = new Point(191, 3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lbl_message_giang
            // 
            lbl_message_giang.AutoSize = true;
            lbl_message_giang.BackColor = Color.Transparent;
            lbl_message_giang.ForeColor = Color.Red;
            lbl_message_giang.Location = new Point(167, 262);
            lbl_message_giang.Margin = new Padding(4, 0, 4, 0);
            lbl_message_giang.Name = "lbl_message_giang";
            lbl_message_giang.Size = new Size(156, 15);
            lbl_message_giang.TabIndex = 11;
            lbl_message_giang.Text = "Sai tài khoản hoặc mật khẩu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btn_thoat_giang);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lbl_message_giang);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tb_taikhoan_giang);
            panel2.Controls.Add(btn_dangnhap_giang);
            panel2.Controls.Add(tb_matkhau_giang);
            panel2.Controls.Add(rad_nhanvien_giang);
            panel2.Controls.Add(rad_admin_giang);
            panel2.Location = new Point(231, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 359);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 366);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(769, 128);
            panel3.TabIndex = 13;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = Properties.Resources.nen1;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(769, 128);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // frm_Login_Giang
            // 
            AcceptButton = btn_dangnhap_giang;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg3;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btn_thoat_giang;
            ClientSize = new Size(769, 494);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_Login_Giang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Login_Giang";
            Load += frm_Login_Giang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_taikhoan_giang;
        private TextBox tb_matkhau_giang;
        private RadioButton rad_admin_giang;
        private RadioButton rad_nhanvien_giang;
        private Button btn_dangnhap_giang;
        private Button btn_thoat_giang;
        private Label label4;
        private PictureBox pictureBox1;
        private Label lbl_message_giang;
        private Panel panel2;
        private ImageList imageList1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox3;
    }
}