namespace comboBox
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
            groupBox1 = new GroupBox();
            lstSanPham = new ListBox();
            cbThanhToan = new ComboBox();
            label4 = new Label();
            txtTen = new TextBox();
            btnDatHang = new Button();
            btnThoat = new Button();
            groupBox2 = new GroupBox();
            txtChiTiet = new TextBox();
            txtSDT = new TextBox();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(227, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 28);
            label1.TabIndex = 0;
            label1.Text = "PHIEU DAT HANG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstSanPham);
            groupBox1.Location = new Point(33, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 202);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // lstSanPham
            // 
            lstSanPham.FormattingEnabled = true;
            lstSanPham.Items.AddRange(new object[] { "Samsung Galaxy J7", "Kẹo kéo", "Redmi note 7", "Coca" });
            lstSanPham.Location = new Point(6, 30);
            lstSanPham.Name = "lstSanPham";
            lstSanPham.Size = new Size(282, 164);
            lstSanPham.TabIndex = 0;
            // 
            // cbThanhToan
            // 
            cbThanhToan.FormattingEnabled = true;
            cbThanhToan.Items.AddRange(new object[] { "Chuyển khoản", "Tiền mặt", "Thanh toán sau khi nhận hàng" });
            cbThanhToan.Location = new Point(33, 381);
            cbThanhToan.Name = "cbThanhToan";
            cbThanhToan.Size = new Size(253, 28);
            cbThanhToan.TabIndex = 4;
            cbThanhToan.SelectedIndexChanged += cbThanhToan_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 347);
            label4.Name = "label4";
            label4.Size = new Size(207, 20);
            label4.TabIndex = 5;
            label4.Text = "Chọn phương thức thanh toán";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(126, 43);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(214, 27);
            txtTen.TabIndex = 6;
            // 
            // btnDatHang
            // 
            btnDatHang.Location = new Point(107, 456);
            btnDatHang.Name = "btnDatHang";
            btnDatHang.Size = new Size(94, 29);
            btnDatHang.TabIndex = 7;
            btnDatHang.Text = "Đặt hàng";
            btnDatHang.UseVisualStyleBackColor = true;
            btnDatHang.Click += btnDatHang_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(447, 456);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtChiTiet);
            groupBox2.Location = new Point(361, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 343);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin đặt hàng";
            // 
            // txtChiTiet
            // 
            txtChiTiet.Location = new Point(6, 21);
            txtChiTiet.Multiline = true;
            txtChiTiet.Name = "txtChiTiet";
            txtChiTiet.Size = new Size(260, 314);
            txtChiTiet.TabIndex = 0;
            txtChiTiet.TextChanged += txtChiTiet_TextChanged;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(126, 87);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(214, 27);
            txtSDT.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(33, 422);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(253, 28);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 497);
            Controls.Add(comboBox1);
            Controls.Add(txtSDT);
            Controls.Add(groupBox2);
            Controls.Add(btnThoat);
            Controls.Add(btnDatHang);
            Controls.Add(txtTen);
            Controls.Add(label4);
            Controls.Add(cbThanhToan);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
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
        private GroupBox groupBox1;
        private ComboBox cbThanhToan;
        private Label label4;
        private TextBox txtTen;
        private Button btnDatHang;
        private Button btnThoat;
        private GroupBox groupBox2;
        private TextBox txtSDT;
        private ListBox lstSanPham;
        private TextBox txtChiTiet;
        private ComboBox comboBox1;
    }
}
