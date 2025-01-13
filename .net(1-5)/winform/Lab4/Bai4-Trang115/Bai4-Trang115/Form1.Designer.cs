namespace Bai4_Trang115
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
            txtNhap = new TextBox();
            lstHienThi = new ListBox();
            groupBox1 = new GroupBox();
            btnXoaCuoi = new TextBox();
            btnXoaDau = new TextBox();
            btnXoaChon = new TextBox();
            btnChonChanDau = new TextBox();
            btnChonLeCuoi = new TextBox();
            btnTang2 = new TextBox();
            btnKetThuc = new TextBox();
            btnCapNhat = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập số nguyên";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(125, 19);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(171, 23);
            txtNhap.TabIndex = 1;
            // 
            // lstHienThi
            // 
            lstHienThi.FormattingEnabled = true;
            lstHienThi.ItemHeight = 15;
            lstHienThi.Location = new Point(12, 48);
            lstHienThi.Name = "lstHienThi";
            lstHienThi.Size = new Size(165, 214);
            lstHienThi.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoaCuoi);
            groupBox1.Controls.Add(btnXoaDau);
            groupBox1.Controls.Add(btnXoaChon);
            groupBox1.Controls.Add(btnChonChanDau);
            groupBox1.Controls.Add(btnChonLeCuoi);
            groupBox1.Controls.Add(btnTang2);
            groupBox1.Location = new Point(183, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 214);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnXoaCuoi
            // 
            btnXoaCuoi.Location = new Point(6, 167);
            btnXoaCuoi.Name = "btnXoaCuoi";
            btnXoaCuoi.ReadOnly = true;
            btnXoaCuoi.Size = new Size(182, 23);
            btnXoaCuoi.TabIndex = 5;
            btnXoaCuoi.Text = "Xóa phần tử cuối";
            btnXoaCuoi.TextAlign = HorizontalAlignment.Center;
            btnXoaCuoi.Click += btnXoaCuoi_Click;
            // 
            // btnXoaDau
            // 
            btnXoaDau.Location = new Point(6, 138);
            btnXoaDau.Name = "btnXoaDau";
            btnXoaDau.ReadOnly = true;
            btnXoaDau.Size = new Size(182, 23);
            btnXoaDau.TabIndex = 4;
            btnXoaDau.Text = "Xóa phần tử đầu";
            btnXoaDau.TextAlign = HorizontalAlignment.Center;
            btnXoaDau.Click += btnXoaDau_Click;
            // 
            // btnXoaChon
            // 
            btnXoaChon.Location = new Point(6, 109);
            btnXoaChon.Name = "btnXoaChon";
            btnXoaChon.ReadOnly = true;
            btnXoaChon.Size = new Size(182, 23);
            btnXoaChon.TabIndex = 3;
            btnXoaChon.Text = "Xóa phần tử đang chọn";
            btnXoaChon.TextAlign = HorizontalAlignment.Center;
            btnXoaChon.Click += btnXoaChon_Click;
            // 
            // btnChonChanDau
            // 
            btnChonChanDau.Location = new Point(6, 51);
            btnChonChanDau.Name = "btnChonChanDau";
            btnChonChanDau.ReadOnly = true;
            btnChonChanDau.Size = new Size(182, 23);
            btnChonChanDau.TabIndex = 2;
            btnChonChanDau.Text = "Chọn số chẵn đầu";
            btnChonChanDau.TextAlign = HorizontalAlignment.Center;
            btnChonChanDau.Click += btnChonChanDau_Click;
            // 
            // btnChonLeCuoi
            // 
            btnChonLeCuoi.Location = new Point(6, 80);
            btnChonLeCuoi.Name = "btnChonLeCuoi";
            btnChonLeCuoi.ReadOnly = true;
            btnChonLeCuoi.Size = new Size(182, 23);
            btnChonLeCuoi.TabIndex = 1;
            btnChonLeCuoi.Text = "Chọn số lẻ cuối";
            btnChonLeCuoi.TextAlign = HorizontalAlignment.Center;
            btnChonLeCuoi.Click += btnChonLeCuoi_Click;
            // 
            // btnTang2
            // 
            btnTang2.Location = new Point(6, 22);
            btnTang2.Name = "btnTang2";
            btnTang2.ReadOnly = true;
            btnTang2.Size = new Size(182, 23);
            btnTang2.TabIndex = 0;
            btnTang2.Text = "Tăng mỗi phần tử lên 2";
            btnTang2.TextAlign = HorizontalAlignment.Center;
            btnTang2.Click += btnTang2_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(12, 268);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.ReadOnly = true;
            btnKetThuc.Size = new Size(365, 23);
            btnKetThuc.TabIndex = 6;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.TextAlign = HorizontalAlignment.Center;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(302, 19);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.ReadOnly = true;
            btnCapNhat.Size = new Size(75, 23);
            btnCapNhat.TabIndex = 7;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.TextAlign = HorizontalAlignment.Center;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 298);
            Controls.Add(btnCapNhat);
            Controls.Add(btnKetThuc);
            Controls.Add(groupBox1);
            Controls.Add(lstHienThi);
            Controls.Add(txtNhap);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhap;
        private ListBox lstHienThi;
        private GroupBox groupBox1;
        private TextBox btnXoaCuoi;
        private TextBox btnXoaDau;
        private TextBox btnXoaChon;
        private TextBox btnChonChanDau;
        private TextBox btnChonLeCuoi;
        private TextBox btnTang2;
        private TextBox btnKetThuc;
        private TextBox btnCapNhat;
    }
}