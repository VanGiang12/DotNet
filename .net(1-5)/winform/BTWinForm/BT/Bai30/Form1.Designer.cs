namespace Bai30
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
            groupBox1 = new GroupBox();
            txtNhap = new TextBox();
            groupBox2 = new GroupBox();
            txtKQ = new TextBox();
            btnNhap = new Button();
            btnInChuHoa = new Button();
            btnInChuThuong = new Button();
            btnDemKTThuong = new Button();
            btnInTu1Dong = new Button();
            btnDemSoTu = new Button();
            btnInPhuAmNguyenAm = new Button();
            btnXoaKTTrangThua = new Button();
            btnXoaChuoi = new Button();
            btnDemKTHoa = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(142, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 0;
            label1.Text = "Xử lý chuỗi";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNhap);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(187, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập dữ liệu";
            // 
            // txtNhap
            // 
            txtNhap.Dock = DockStyle.Fill;
            txtNhap.Location = new Point(3, 19);
            txtNhap.Multiline = true;
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(181, 78);
            txtNhap.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtKQ);
            groupBox2.Location = new Point(205, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            // 
            // txtKQ
            // 
            txtKQ.Dock = DockStyle.Fill;
            txtKQ.Location = new Point(3, 19);
            txtKQ.Multiline = true;
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(194, 78);
            txtKQ.TabIndex = 0;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(15, 167);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(181, 23);
            btnNhap.TabIndex = 3;
            btnNhap.Text = "Nhập liệu";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnInChuHoa
            // 
            btnInChuHoa.Location = new Point(15, 199);
            btnInChuHoa.Name = "btnInChuHoa";
            btnInChuHoa.Size = new Size(181, 23);
            btnInChuHoa.TabIndex = 4;
            btnInChuHoa.Text = "In chữ hoa";
            btnInChuHoa.UseVisualStyleBackColor = true;
            btnInChuHoa.Click += btnInChuHoa_Click;
            // 
            // btnInChuThuong
            // 
            btnInChuThuong.Location = new Point(15, 231);
            btnInChuThuong.Name = "btnInChuThuong";
            btnInChuThuong.Size = new Size(181, 23);
            btnInChuThuong.TabIndex = 5;
            btnInChuThuong.Text = "In chữ thường";
            btnInChuThuong.UseVisualStyleBackColor = true;
            btnInChuThuong.Click += btnInChuThuong_Click;
            // 
            // btnDemKTThuong
            // 
            btnDemKTThuong.Location = new Point(15, 263);
            btnDemKTThuong.Name = "btnDemKTThuong";
            btnDemKTThuong.Size = new Size(181, 23);
            btnDemKTThuong.TabIndex = 6;
            btnDemKTThuong.Text = "Đếm KT thường";
            btnDemKTThuong.UseVisualStyleBackColor = true;
            btnDemKTThuong.Click += btnDemKTThuong_Click;
            // 
            // btnInTu1Dong
            // 
            btnInTu1Dong.Location = new Point(205, 199);
            btnInTu1Dong.Name = "btnInTu1Dong";
            btnInTu1Dong.Size = new Size(197, 23);
            btnInTu1Dong.TabIndex = 7;
            btnInTu1Dong.Text = "In mỗi từ trên 1 dòng";
            btnInTu1Dong.UseVisualStyleBackColor = true;
            btnInTu1Dong.Click += btnInTu1Dong_Click;
            // 
            // btnDemSoTu
            // 
            btnDemSoTu.Location = new Point(205, 231);
            btnDemSoTu.Name = "btnDemSoTu";
            btnDemSoTu.Size = new Size(197, 23);
            btnDemSoTu.TabIndex = 8;
            btnDemSoTu.Text = "Đếm số từ";
            btnDemSoTu.UseVisualStyleBackColor = true;
            btnDemSoTu.Click += btnDemSoTu_Click;
            // 
            // btnInPhuAmNguyenAm
            // 
            btnInPhuAmNguyenAm.Location = new Point(205, 263);
            btnInPhuAmNguyenAm.Name = "btnInPhuAmNguyenAm";
            btnInPhuAmNguyenAm.Size = new Size(197, 23);
            btnInPhuAmNguyenAm.TabIndex = 9;
            btnInPhuAmNguyenAm.Text = "In nguyên âm phụ âm";
            btnInPhuAmNguyenAm.UseVisualStyleBackColor = true;
            btnInPhuAmNguyenAm.Click += btnInPhuAmNguyenAm_Click;
            // 
            // btnXoaKTTrangThua
            // 
            btnXoaKTTrangThua.Location = new Point(205, 295);
            btnXoaKTTrangThua.Name = "btnXoaKTTrangThua";
            btnXoaKTTrangThua.Size = new Size(197, 23);
            btnXoaKTTrangThua.TabIndex = 10;
            btnXoaKTTrangThua.Text = "Xóa KT trắng dư thừa";
            btnXoaKTTrangThua.UseVisualStyleBackColor = true;
            btnXoaKTTrangThua.Click += btnXoaKTTrangThua_Click;
            // 
            // btnXoaChuoi
            // 
            btnXoaChuoi.Location = new Point(15, 295);
            btnXoaChuoi.Name = "btnXoaChuoi";
            btnXoaChuoi.Size = new Size(181, 23);
            btnXoaChuoi.TabIndex = 11;
            btnXoaChuoi.Text = "Xóa chuỗi";
            btnXoaChuoi.UseVisualStyleBackColor = true;
            // 
            // btnDemKTHoa
            // 
            btnDemKTHoa.Location = new Point(205, 167);
            btnDemKTHoa.Name = "btnDemKTHoa";
            btnDemKTHoa.Size = new Size(197, 23);
            btnDemKTHoa.TabIndex = 12;
            btnDemKTHoa.Text = "Đếm số KT hoa";
            btnDemKTHoa.UseVisualStyleBackColor = true;
            btnDemKTHoa.Click += btnDemKTHoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(117, 324);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(181, 23);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 363);
            Controls.Add(btnThoat);
            Controls.Add(btnDemKTHoa);
            Controls.Add(btnXoaChuoi);
            Controls.Add(btnXoaKTTrangThua);
            Controls.Add(btnInPhuAmNguyenAm);
            Controls.Add(btnDemSoTu);
            Controls.Add(btnInTu1Dong);
            Controls.Add(btnDemKTThuong);
            Controls.Add(btnInChuThuong);
            Controls.Add(btnInChuHoa);
            Controls.Add(btnNhap);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtNhap;
        private GroupBox groupBox2;
        private TextBox txtKQ;
        private Button btnNhap;
        private Button btnInChuHoa;
        private Button btnInChuThuong;
        private Button btnDemKTThuong;
        private Button btnInTu1Dong;
        private Button btnDemSoTu;
        private Button btnInPhuAmNguyenAm;
        private Button btnXoaKTTrangThua;
        private Button btnXoaChuoi;
        private Button btnDemKTHoa;
        private Button btnThoat;
    }
}