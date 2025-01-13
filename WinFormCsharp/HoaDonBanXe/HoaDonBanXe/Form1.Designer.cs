namespace HoaDonBanXe
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txtPhone = new TextBox();
            txtDiaChi = new TextBox();
            txtHoTen = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtThanhTien = new TextBox();
            txtThue = new TextBox();
            txtPhuThu = new TextBox();
            txtGiaTien = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            rdBtnMauKhac = new RadioButton();
            rdBtnMauDen = new RadioButton();
            btnTinhTien = new Button();
            btnTiepTuc = new Button();
            btnThongKe = new Button();
            btnKetThuc = new Button();
            groupBox4 = new GroupBox();
            lblTongDoanhThu = new Label();
            lblTongKhachHangMuaXeDen = new Label();
            lblTongKhachHang = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.tải_xuống;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 192, 255);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(211, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 129);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(55, 97);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(184, 23);
            txtPhone.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(55, 62);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(184, 23);
            txtDiaChi.TabIndex = 4;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(55, 26);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(184, 23);
            txtHoTen.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 100);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 192, 255);
            groupBox2.Controls.Add(txtThanhTien);
            groupBox2.Controls.Add(txtThue);
            groupBox2.Controls.Add(txtPhuThu);
            groupBox2.Controls.Add(txtGiaTien);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.ForeColor = Color.Blue;
            groupBox2.Location = new Point(12, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(298, 155);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa Đơn";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(75, 114);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(210, 23);
            txtThanhTien.TabIndex = 7;
            // 
            // txtThue
            // 
            txtThue.Location = new Point(75, 83);
            txtThue.Name = "txtThue";
            txtThue.ReadOnly = true;
            txtThue.Size = new Size(210, 23);
            txtThue.TabIndex = 6;
            // 
            // txtPhuThu
            // 
            txtPhuThu.Location = new Point(75, 54);
            txtPhuThu.Name = "txtPhuThu";
            txtPhuThu.ReadOnly = true;
            txtPhuThu.Size = new Size(210, 23);
            txtPhuThu.TabIndex = 5;
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(75, 25);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(210, 23);
            txtGiaTien.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 117);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 3;
            label7.Text = "Thành tiền";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 88);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 2;
            label6.Text = "Thuế";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 57);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 1;
            label5.Text = "Phụ thu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 0;
            label4.Text = "Giá tiền";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(192, 192, 255);
            groupBox3.Controls.Add(rdBtnMauKhac);
            groupBox3.Controls.Add(rdBtnMauDen);
            groupBox3.ForeColor = Color.Blue;
            groupBox3.Location = new Point(330, 181);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(120, 88);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chọn màu xe";
            // 
            // rdBtnMauKhac
            // 
            rdBtnMauKhac.AutoSize = true;
            rdBtnMauKhac.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdBtnMauKhac.Location = new Point(6, 46);
            rdBtnMauKhac.Name = "rdBtnMauKhac";
            rdBtnMauKhac.Size = new Size(78, 19);
            rdBtnMauKhac.TabIndex = 1;
            rdBtnMauKhac.TabStop = true;
            rdBtnMauKhac.Text = "Màu khác";
            rdBtnMauKhac.UseVisualStyleBackColor = true;
            // 
            // rdBtnMauDen
            // 
            rdBtnMauDen.AutoSize = true;
            rdBtnMauDen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdBtnMauDen.ForeColor = Color.Black;
            rdBtnMauDen.Location = new Point(6, 21);
            rdBtnMauDen.Name = "rdBtnMauDen";
            rdBtnMauDen.Size = new Size(74, 19);
            rdBtnMauDen.TabIndex = 0;
            rdBtnMauDen.TabStop = true;
            rdBtnMauDen.Text = "Màu đen";
            rdBtnMauDen.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            btnTinhTien.BackColor = Color.FromArgb(224, 224, 224);
            btnTinhTien.Location = new Point(65, 317);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(75, 23);
            btnTinhTien.TabIndex = 4;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = false;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.BackColor = Color.FromArgb(224, 224, 224);
            btnTiepTuc.Location = new Point(146, 317);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(75, 23);
            btnTiepTuc.TabIndex = 5;
            btnTiepTuc.Text = "Tiếp";
            btnTiepTuc.UseVisualStyleBackColor = false;
            btnTiepTuc.Click += btnTiepTuc_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(224, 224, 224);
            btnThongKe.Location = new Point(227, 317);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(75, 23);
            btnThongKe.TabIndex = 6;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.BackColor = Color.FromArgb(224, 224, 224);
            btnKetThuc.Location = new Point(308, 317);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(75, 23);
            btnKetThuc.TabIndex = 7;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(192, 192, 255);
            groupBox4.Controls.Add(lblTongDoanhThu);
            groupBox4.Controls.Add(lblTongKhachHangMuaXeDen);
            groupBox4.Controls.Add(lblTongKhachHang);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.ForeColor = Color.Blue;
            groupBox4.Location = new Point(12, 346);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(453, 144);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thống kê";
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.BorderStyle = BorderStyle.Fixed3D;
            lblTongDoanhThu.Location = new Point(188, 98);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(250, 23);
            lblTongDoanhThu.TabIndex = 5;
            // 
            // lblTongKhachHangMuaXeDen
            // 
            lblTongKhachHangMuaXeDen.BorderStyle = BorderStyle.Fixed3D;
            lblTongKhachHangMuaXeDen.Location = new Point(188, 61);
            lblTongKhachHangMuaXeDen.Name = "lblTongKhachHangMuaXeDen";
            lblTongKhachHangMuaXeDen.Size = new Size(250, 23);
            lblTongKhachHangMuaXeDen.TabIndex = 4;
            lblTongKhachHangMuaXeDen.MouseDoubleClick += lblTongKhachHangMuaXeDen_MouseDoubleClick;
            // 
            // lblTongKhachHang
            // 
            lblTongKhachHang.BorderStyle = BorderStyle.Fixed3D;
            lblTongKhachHang.Location = new Point(188, 27);
            lblTongKhachHang.Name = "lblTongKhachHang";
            lblTongKhachHang.Size = new Size(250, 23);
            lblTongKhachHang.TabIndex = 3;
            lblTongKhachHang.MouseDoubleClick += lblTongKhachHang_MouseDoubleClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 99);
            label10.Name = "label10";
            label10.Size = new Size(92, 15);
            label10.TabIndex = 2;
            label10.Text = "Tổng doanh thu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 66);
            label9.Name = "label9";
            label9.Size = new Size(179, 15);
            label9.TabIndex = 1;
            label9.Text = "Tổng số khách hàng mua xe đen";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 28);
            label8.Name = "label8";
            label8.Size = new Size(114, 15);
            label8.TabIndex = 0;
            label8.Text = "Tổng số khách hàng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(476, 503);
            Controls.Add(groupBox4);
            Controls.Add(btnKetThuc);
            Controls.Add(btnThongKe);
            Controls.Add(btnTiepTuc);
            Controls.Add(btnTinhTien);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn mua xe";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox txtPhone;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtThanhTien;
        private TextBox txtThue;
        private TextBox txtPhuThu;
        private TextBox txtGiaTien;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox3;
        private RadioButton rdBtnMauKhac;
        private RadioButton rdBtnMauDen;
        private Button btnTinhTien;
        private Button btnTiepTuc;
        private Button btnThongKe;
        private Button btnKetThuc;
        private GroupBox groupBox4;
        private Label lblTongDoanhThu;
        private Label lblTongKhachHangMuaXeDen;
        private Label lblTongKhachHang;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}