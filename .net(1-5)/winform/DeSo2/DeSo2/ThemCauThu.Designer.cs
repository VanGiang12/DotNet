namespace DeSo2
{
    partial class ThemCauThu
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
            btnSau = new Button();
            btnNhapLai = new Button();
            btnLuu = new Button();
            txtHoTen = new TextBox();
            txtMa = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboNgaySinh = new ComboBox();
            txtNgaySinh = new TextBox();
            SuspendLayout();
            // 
            // btnSau
            // 
            btnSau.Location = new Point(268, 203);
            btnSau.Name = "btnSau";
            btnSau.Size = new Size(59, 23);
            btnSau.TabIndex = 31;
            btnSau.Text = "Thoát";
            btnSau.UseVisualStyleBackColor = true;
            btnSau.Click += btnThoat_Click;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(179, 203);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(59, 23);
            btnNhapLai.TabIndex = 30;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            btnNhapLai.Click += btnNhapLai_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(95, 203);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(59, 23);
            btnLuu.TabIndex = 29;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(95, 91);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(232, 23);
            txtHoTen.TabIndex = 26;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(95, 56);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(232, 23);
            txtMa.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 168);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 24;
            label6.Text = "Quê quán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 129);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 23;
            label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 94);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 22;
            label4.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 59);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 21;
            label3.Text = "Mã cầu thủ";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 0, 0);
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 28);
            label2.Name = "label2";
            label2.Size = new Size(353, 15);
            label2.TabIndex = 20;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(353, 28);
            label1.TabIndex = 19;
            label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ BÓNG ĐÁ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboNgaySinh
            // 
            cboNgaySinh.FormattingEnabled = true;
            cboNgaySinh.Items.AddRange(new object[] { "An Giang", "Bà Rịa - Vũng Tàu", "Bắc Giang", "Bắc Kạn", "Bạc Liêu", "Bắc Ninh", "Bến Tre", "Bình Định", "Bình Dương", "Bình Phước", "Bình Thuận", "Cà Mau", "Cần Thơ", "Cao Bằng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Đà Nẵng", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Tĩnh", "Hải Dương", "Hậu Giang", "Hòa Bình", "Hà Nội", "Hải Phòng", "Hồ Chí Minh (TP.HCM)", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lâm Đồng", "Lạng Sơn", "Lào Cai", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên - Huế", "Tiền Giang", "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái" });
            cboNgaySinh.Location = new Point(95, 165);
            cboNgaySinh.Name = "cboNgaySinh";
            cboNgaySinh.Size = new Size(232, 23);
            cboNgaySinh.TabIndex = 37;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(95, 126);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(232, 23);
            txtNgaySinh.TabIndex = 38;
            // 
            // ThemCauThu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 243);
            Controls.Add(txtNgaySinh);
            Controls.Add(cboNgaySinh);
            Controls.Add(btnSau);
            Controls.Add(btnNhapLai);
            Controls.Add(btnLuu);
            Controls.Add(txtHoTen);
            Controls.Add(txtMa);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThemCauThu";
            Text = "ThemCauThu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSau;
        private Button btnNhapLai;
        private Button btnLuu;
        private TextBox txtHoTen;
        private TextBox txtMa;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboNgaySinh;
        private TextBox txtNgaySinh;
    }
}