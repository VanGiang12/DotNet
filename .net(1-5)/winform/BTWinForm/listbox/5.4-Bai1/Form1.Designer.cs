namespace _5._4_Bai1
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
            txtTen = new TextBox();
            ngaySinh = new DateTimePicker();
            txtDiaChi = new TextBox();
            groupBox1 = new GroupBox();
            lstDiemDi = new ListBox();
            groupBox2 = new GroupBox();
            cbDiemDen = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            ngay2 = new DateTimePicker();
            ngay3 = new DateTimePicker();
            label7 = new Label();
            txtDemNgay = new TextBox();
            btnNhap = new Button();
            btnReset = new Button();
            btnThoat = new Button();
            txtDetail = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(214, 18);
            label1.Name = "label1";
            label1.Size = new Size(274, 32);
            label1.TabIndex = 0;
            label1.Text = "CÔNG TY DU LỊCH ABC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 93);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 1;
            label2.Text = "Khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 160);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 218);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(154, 93);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(254, 30);
            txtTen.TabIndex = 4;
            // 
            // ngaySinh
            // 
            ngaySinh.Location = new Point(154, 154);
            ngaySinh.Margin = new Padding(3, 4, 3, 4);
            ngaySinh.Name = "ngaySinh";
            ngaySinh.Size = new Size(254, 30);
            ngaySinh.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(154, 215);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(254, 30);
            txtDiaChi.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstDiemDi);
            groupBox1.Location = new Point(56, 278);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(151, 155);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Địa điểm đi";
            // 
            // lstDiemDi
            // 
            lstDiemDi.FormattingEnabled = true;
            lstDiemDi.ItemHeight = 23;
            lstDiemDi.Items.AddRange(new object[] { "Hà Nội", "TP HCM", "Hải Phòng" });
            lstDiemDi.Location = new Point(6, 29);
            lstDiemDi.Name = "lstDiemDi";
            lstDiemDi.Size = new Size(133, 119);
            lstDiemDi.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbDiemDen);
            groupBox2.Location = new Point(257, 278);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(151, 155);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Địa điểm đến";
            // 
            // cbDiemDen
            // 
            cbDiemDen.FormattingEnabled = true;
            cbDiemDen.Items.AddRange(new object[] { "Hạ Long", "Vũng Tàu", "Đà Nẵng" });
            cbDiemDen.Location = new Point(9, 26);
            cbDiemDen.Name = "cbDiemDen";
            cbDiemDen.Size = new Size(136, 31);
            cbDiemDen.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 454);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 9;
            label5.Text = "Ngày đi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 454);
            label6.Name = "label6";
            label6.Size = new Size(72, 23);
            label6.TabIndex = 10;
            label6.Text = "Ngày về";
            // 
            // ngay2
            // 
            ngay2.Location = new Point(56, 496);
            ngay2.Name = "ngay2";
            ngay2.Size = new Size(151, 30);
            ngay2.TabIndex = 11;
            // 
            // ngay3
            // 
            ngay3.Location = new Point(257, 496);
            ngay3.Name = "ngay3";
            ngay3.Size = new Size(151, 30);
            ngay3.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(489, 333);
            label7.Name = "label7";
            label7.Size = new Size(113, 23);
            label7.TabIndex = 16;
            label7.Text = "Tổng số ngày";
            // 
            // txtDemNgay
            // 
            txtDemNgay.Location = new Point(620, 326);
            txtDemNgay.Name = "txtDemNgay";
            txtDemNgay.Size = new Size(88, 30);
            txtDemNgay.TabIndex = 17;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(493, 385);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(215, 32);
            btnNhap.TabIndex = 18;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(493, 436);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(215, 32);
            btnReset.TabIndex = 19;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(493, 486);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(215, 32);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtDetail
            // 
            txtDetail.Location = new Point(481, 75);
            txtDetail.Multiline = true;
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(228, 200);
            txtDetail.TabIndex = 21;
         
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 553);
            Controls.Add(txtDetail);
            Controls.Add(btnThoat);
            Controls.Add(btnReset);
            Controls.Add(btnNhap);
            Controls.Add(txtDemNgay);
            Controls.Add(label7);
            Controls.Add(ngay3);
            Controls.Add(ngay2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtDiaChi);
            Controls.Add(ngaySinh);
            Controls.Add(txtTen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTen;
        private DateTimePicker ngaySinh;
        private TextBox txtDiaChi;
        private GroupBox groupBox1;
        private ListBox lstDiemDi;
        private GroupBox groupBox2;
        protected ComboBox cbDiemDen;
        private Label label5;
        private Label label6;
        private DateTimePicker ngay2;
        private DateTimePicker ngay3;
        private Label label7;
        private TextBox txtDemNgay;
        private Button btnNhap;
        private Button btnReset;
        private Button btnThoat;
        private TextBox txtDetail;
    }
}
