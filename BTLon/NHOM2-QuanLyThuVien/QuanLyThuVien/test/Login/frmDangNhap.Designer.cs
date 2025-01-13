namespace test.Login
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTaiKhoan = new TextBox();
            txtPass = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            lblQuenMK = new Label();
            imageList1 = new ImageList(components);
            label6 = new Label();
            radAdmin = new RadioButton();
            radDocGia = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 428);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(42, 267);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 211);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ THƯ VIỆN";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(431, 42);
            label2.Name = "label2";
            label2.Size = new Size(106, 105);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 206);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Tài khoản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 244);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(398, 203);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(210, 23);
            txtTaiKhoan.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(398, 242);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(210, 23);
            txtPass.TabIndex = 5;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Green;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangNhap.ImageIndex = 1;
            btnDangNhap.Location = new Point(397, 337);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(76, 32);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Green;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(532, 337);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(76, 32);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblQuenMK
            // 
            lblQuenMK.AutoSize = true;
            lblQuenMK.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblQuenMK.ForeColor = Color.Blue;
            lblQuenMK.Location = new Point(397, 312);
            lblQuenMK.Name = "lblQuenMK";
            lblQuenMK.Size = new Size(89, 15);
            lblQuenMK.TabIndex = 8;
            lblQuenMK.Text = "Quên mật khẩu";
            lblQuenMK.Click += lblQuenMK_Click;
            lblQuenMK.MouseLeave += lblQuenMK_MouseLeave;
            lblQuenMK.MouseHover += lblQuenMK_MouseHover;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cancel.png");
            imageList1.Images.SetKeyName(1, "login.png");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(431, 158);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 9;
            label6.Text = "Đăng Nhập";
            // 
            // radAdmin
            // 
            radAdmin.AutoSize = true;
            radAdmin.Location = new Point(425, 280);
            radAdmin.Name = "radAdmin";
            radAdmin.Size = new Size(61, 19);
            radAdmin.TabIndex = 10;
            radAdmin.TabStop = true;
            radAdmin.Text = "Admin";
            radAdmin.UseVisualStyleBackColor = true;
            // 
            // radDocGia
            // 
            radDocGia.AutoSize = true;
            radDocGia.Location = new Point(522, 280);
            radDocGia.Name = "radDocGia";
            radDocGia.Size = new Size(65, 19);
            radDocGia.TabIndex = 11;
            radDocGia.TabStop = true;
            radDocGia.Text = "Độc giả";
            radDocGia.UseVisualStyleBackColor = true;
            radDocGia.Click += radDocGia_Click;
            // 
            // frmDangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 428);
            Controls.Add(radDocGia);
            Controls.Add(radAdmin);
            Controls.Add(label6);
            Controls.Add(lblQuenMK);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtPass);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTaiKhoan;
        private TextBox txtPass;
        private Button btnDangNhap;
        private Button btnThoat;
        private Label lblQuenMK;
        private ImageList imageList1;
        private Label label6;
        private RadioButton radAdmin;
        private RadioButton radDocGia;
    }
}