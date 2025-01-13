namespace PictureBox
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
            label1 = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            txtPass = new TextBox();
            checkBox1 = new CheckBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 42);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(93, 42);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(171, 23);
            txtTen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 83);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(93, 80);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(173, 23);
            txtPass.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(93, 109);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(158, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Lưu thông tin đăng nhập";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(93, 134);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(75, 23);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(189, 134);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2023_07_09_1606281;
            pictureBox1.Location = new Point(286, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(167, 9);
            label3.Name = "label3";
            label3.Size = new Size(217, 28);
            label3.TabIndex = 7;
            label3.Text = "Đăng Nhập Hệ Thống";
            label3.Click += label3_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(490, 199);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(checkBox1);
            Controls.Add(txtPass);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtPass;
        private CheckBox checkBox1;
        private Button btnDangNhap;
        private Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Label label3;
    }
}