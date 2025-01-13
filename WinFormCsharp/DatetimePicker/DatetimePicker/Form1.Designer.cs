namespace DatetimePicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnĐangKy = new Button();
            label3 = new Label();
            dtpNgayDangKy = new DateTimePicker();
            txtTuoi = new TextBox();
            txtTen = new TextBox();
            label2 = new Label();
            lblTen = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 128);
            groupBox1.Controls.Add(btnĐangKy);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpNgayDangKy);
            groupBox1.Controls.Add(txtTuoi);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblTen);
            groupBox1.Location = new Point(28, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 168);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng ký bằng lái xe";
            // 
            // btnĐangKy
            // 
            btnĐangKy.Location = new Point(100, 139);
            btnĐangKy.Name = "btnĐangKy";
            btnĐangKy.Size = new Size(75, 23);
            btnĐangKy.TabIndex = 6;
            btnĐangKy.Text = "Đăng ký";
            btnĐangKy.UseVisualStyleBackColor = true;
            btnĐangKy.Click += btnĐangKy_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Date";
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.CustomFormat = "dd/MM/yyy";
            dtpNgayDangKy.Format = DateTimePickerFormat.Custom;
            dtpNgayDangKy.Location = new Point(49, 97);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(212, 23);
            dtpNgayDangKy.TabIndex = 4;
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(49, 60);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(212, 23);
            txtTuoi.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(49, 28);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(212, 23);
            txtTen.TabIndex = 2;
            txtTen.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Tuổi";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(12, 31);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(25, 15);
            lblTen.TabIndex = 0;
            lblTen.Text = "Tên";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 192);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(28, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(322, 116);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ghi chú";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(13, 68);
            label5.Name = "label5";
            label5.Size = new Size(233, 15);
            label5.TabIndex = 2;
            label5.Text = "-Không cho đăng ký thi vào ngày chủ nhật";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(13, 44);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 1;
            label4.Text = "-Tuổi lớn hơn 17";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(13, 22);
            label1.Name = "label1";
            label1.Size = new Size(193, 15);
            label1.TabIndex = 0;
            label1.Text = "-Tên học viên không được để trống";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(372, 334);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký lái xe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private DateTimePicker dtpNgayDangKy;
        private TextBox txtTuoi;
        private TextBox txtTen;
        private Label label2;
        private Label lblTen;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button btnĐangKy;
        private ErrorProvider errorProvider1;
    }
}