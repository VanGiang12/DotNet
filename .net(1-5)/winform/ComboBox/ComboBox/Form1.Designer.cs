namespace ComboBox
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTen = new TextBox();
            txtPhone = new TextBox();
            groupBox1 = new GroupBox();
            lstSanPham = new ListBox();
            label4 = new Label();
            cboThanhtoan = new System.Windows.Forms.ComboBox();
            btnDatHang = new Button();
            groupBox2 = new GroupBox();
            txtChitiet = new TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "FORM ĐẶT HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(88, 35);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(127, 23);
            txtTen.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(88, 67);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(127, 23);
            txtPhone.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstSanPham);
            groupBox1.Location = new Point(12, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(203, 155);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // lstSanPham
            // 
            lstSanPham.Dock = DockStyle.Fill;
            lstSanPham.FormattingEnabled = true;
            lstSanPham.ItemHeight = 15;
            lstSanPham.Items.AddRange(new object[] { "Sam Sung Galaxy J6", "Redmi 10C", "POCO", "Bánh Mì", "Nước Mía" });
            lstSanPham.Location = new Point(3, 19);
            lstSanPham.Name = "lstSanPham";
            lstSanPham.Size = new Size(197, 133);
            lstSanPham.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 263);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Thanh toán";
            // 
            // cboThanhtoan
            // 
            cboThanhtoan.FormattingEnabled = true;
            cboThanhtoan.Items.AddRange(new object[] { "ATM", "Thanh toán khi nhận hàng", "MoMo", "Zalopay" });
            cboThanhtoan.Location = new Point(12, 281);
            cboThanhtoan.Name = "cboThanhtoan";
            cboThanhtoan.Size = new Size(203, 23);
            cboThanhtoan.TabIndex = 7;
            // 
            // btnDatHang
            // 
            btnDatHang.Location = new Point(12, 357);
            btnDatHang.Name = "btnDatHang";
            btnDatHang.Size = new Size(75, 23);
            btnDatHang.TabIndex = 8;
            btnDatHang.Text = "Đặt hàng";
            btnDatHang.UseVisualStyleBackColor = true;
            btnDatHang.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtChitiet);
            groupBox2.Location = new Point(238, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(235, 269);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin đơn hàng";
            // 
            // txtChitiet
            // 
            txtChitiet.Dock = DockStyle.Fill;
            txtChitiet.Location = new Point(3, 19);
            txtChitiet.Multiline = true;
            txtChitiet.Name = "txtChitiet";
            txtChitiet.Size = new Size(229, 247);
            txtChitiet.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 328);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(203, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 392);
            Controls.Add(comboBox1);
            Controls.Add(groupBox2);
            Controls.Add(btnDatHang);
            Controls.Add(cboThanhtoan);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(txtPhone);
            Controls.Add(txtTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt Hàng";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTen;
        private TextBox txtPhone;
        private GroupBox groupBox1;
        private ListBox lstSanPham;
        private Label label4;
        private System.Windows.Forms.ComboBox cboThanhtoan;
        private Button btnDatHang;
        private GroupBox groupBox2;
        private TextBox txtChitiet;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}