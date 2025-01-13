namespace Bai1_P128
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtKhachHang = new TextBox();
            txtDiaChi = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            rtbDisplay = new RichTextBox();
            lstDiaDiemDi = new ListBox();
            lstDiaDiemDen = new ListBox();
            label9 = new Label();
            dtpNgayDi = new DateTimePicker();
            dtpNgayVe = new DateTimePicker();
            label10 = new Label();
            txtTongSoNgay = new TextBox();
            btnNhap = new Button();
            btnReset = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 28);
            label1.TabIndex = 0;
            label1.Text = "Công ty du lịch ABC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 282);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Ngày về";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 282);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Ngày đi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 176);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 4;
            label5.Text = "Địa điểm đến";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 176);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "Địa điểm đi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 140);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 6;
            label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 106);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 7;
            label8.Text = "Ngày sinh";
            // 
            // txtKhachHang
            // 
            txtKhachHang.Location = new Point(99, 63);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.Size = new Size(132, 23);
            txtKhachHang.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(99, 132);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(132, 23);
            txtDiaChi.TabIndex = 9;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.AccessibleDescription = "";
            dtpNgaySinh.CustomFormat = "dd/MM/yyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(99, 98);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(132, 23);
            dtpNgaySinh.TabIndex = 10;
            // 
            // rtbDisplay
            // 
            rtbDisplay.Location = new Point(251, 55);
            rtbDisplay.Name = "rtbDisplay";
            rtbDisplay.Size = new Size(167, 111);
            rtbDisplay.TabIndex = 11;
            rtbDisplay.Text = "";
            // 
            // lstDiaDiemDi
            // 
            lstDiaDiemDi.FormattingEnabled = true;
            lstDiaDiemDi.ItemHeight = 15;
            lstDiaDiemDi.Items.AddRange(new object[] { "Hà Nội", "TPHCM", "Hải Phòng" });
            lstDiaDiemDi.Location = new Point(12, 194);
            lstDiaDiemDi.Name = "lstDiaDiemDi";
            lstDiaDiemDi.Size = new Size(94, 64);
            lstDiaDiemDi.TabIndex = 12;
            // 
            // lstDiaDiemDen
            // 
            lstDiaDiemDen.FormattingEnabled = true;
            lstDiaDiemDen.ItemHeight = 15;
            lstDiaDiemDen.Items.AddRange(new object[] { "Hà Nội", "TPHCM", "Hải Phòng" });
            lstDiaDiemDen.Location = new Point(126, 194);
            lstDiaDiemDen.Name = "lstDiaDiemDen";
            lstDiaDiemDen.Size = new Size(105, 64);
            lstDiaDiemDen.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(251, 194);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 14;
            label9.Text = "Tổng số ngày";
            // 
            // dtpNgayDi
            // 
            dtpNgayDi.CustomFormat = "dd/MM/yyyy";
            dtpNgayDi.Format = DateTimePickerFormat.Custom;
            dtpNgayDi.Location = new Point(12, 300);
            dtpNgayDi.Name = "dtpNgayDi";
            dtpNgayDi.Size = new Size(94, 23);
            dtpNgayDi.TabIndex = 15;
            // 
            // dtpNgayVe
            // 
            dtpNgayVe.CustomFormat = "dd/MM/yyyy";
            dtpNgayVe.Format = DateTimePickerFormat.Custom;
            dtpNgayVe.Location = new Point(126, 300);
            dtpNgayVe.Name = "dtpNgayVe";
            dtpNgayVe.Size = new Size(105, 23);
            dtpNgayVe.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(335, 194);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 17;
            // 
            // txtTongSoNgay
            // 
            txtTongSoNgay.BorderStyle = BorderStyle.FixedSingle;
            txtTongSoNgay.Location = new Point(335, 191);
            txtTongSoNgay.Name = "txtTongSoNgay";
            txtTongSoNgay.ReadOnly = true;
            txtTongSoNgay.Size = new Size(83, 23);
            txtTongSoNgay.TabIndex = 18;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(254, 244);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(164, 23);
            btnNhap.TabIndex = 19;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(254, 273);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(164, 23);
            btnReset.TabIndex = 20;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(254, 302);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(164, 23);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 345);
            Controls.Add(btnThoat);
            Controls.Add(btnReset);
            Controls.Add(btnNhap);
            Controls.Add(txtTongSoNgay);
            Controls.Add(label10);
            Controls.Add(dtpNgayVe);
            Controls.Add(dtpNgayDi);
            Controls.Add(label9);
            Controls.Add(lstDiaDiemDen);
            Controls.Add(lstDiaDiemDi);
            Controls.Add(rtbDisplay);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtDiaChi);
            Controls.Add(txtKhachHang);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtKhachHang;
        private TextBox txtDiaChi;
        private DateTimePicker dtpNgaySinh;
        private RichTextBox rtbDisplay;
        private ListBox lstDiaDiemDi;
        private ListBox lstDiaDiemDen;
        private Label label9;
        private DateTimePicker dtpNgayDi;
        private DateTimePicker dtpNgayVe;
        private Label label10;
        private TextBox txtTongSoNgay;
        private Button btnNhap;
        private Button btnReset;
        private Button btnThoat;
    }
}