namespace Bai22
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
            groupBox1 = new GroupBox();
            txtNhap = new TextBox();
            groupBox2 = new GroupBox();
            txtKetQua = new TextBox();
            btnNhapMang = new Button();
            btnXuatMang = new Button();
            btnTongMang = new Button();
            btnMinMax = new Button();
            btnDemChan = new Button();
            btnXuatViTriChan = new Button();
            btnXuatVitriLe = new Button();
            btnDemLe = new Button();
            btnKetThuc = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNhap);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mảng nhập";
            // 
            // txtNhap
            // 
            txtNhap.Dock = DockStyle.Fill;
            txtNhap.Location = new Point(3, 19);
            txtNhap.Multiline = true;
            txtNhap.Name = "txtNhap";
            txtNhap.ReadOnly = true;
            txtNhap.Size = new Size(194, 78);
            txtNhap.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtKetQua);
            groupBox2.Location = new Point(221, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả tính toán";
            // 
            // txtKetQua
            // 
            txtKetQua.Dock = DockStyle.Fill;
            txtKetQua.Location = new Point(3, 19);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(194, 78);
            txtKetQua.TabIndex = 0;
            // 
            // btnNhapMang
            // 
            btnNhapMang.Location = new Point(12, 118);
            btnNhapMang.Name = "btnNhapMang";
            btnNhapMang.Size = new Size(197, 23);
            btnNhapMang.TabIndex = 2;
            btnNhapMang.Text = "Nhập mảng";
            btnNhapMang.UseVisualStyleBackColor = true;
            btnNhapMang.Click += btnNhapMang_Click;
            // 
            // btnXuatMang
            // 
            btnXuatMang.Location = new Point(12, 141);
            btnXuatMang.Name = "btnXuatMang";
            btnXuatMang.Size = new Size(197, 23);
            btnXuatMang.TabIndex = 3;
            btnXuatMang.Text = "Xuất mảng";
            btnXuatMang.UseVisualStyleBackColor = true;
            btnXuatMang.Click += btnXuatMang_Click;
            // 
            // btnTongMang
            // 
            btnTongMang.Location = new Point(12, 164);
            btnTongMang.Name = "btnTongMang";
            btnTongMang.Size = new Size(197, 23);
            btnTongMang.TabIndex = 4;
            btnTongMang.Text = "Tính tổng mảng";
            btnTongMang.UseVisualStyleBackColor = true;
            btnTongMang.Click += btnTongMang_Click;
            // 
            // btnMinMax
            // 
            btnMinMax.Location = new Point(12, 187);
            btnMinMax.Name = "btnMinMax";
            btnMinMax.Size = new Size(197, 23);
            btnMinMax.TabIndex = 5;
            btnMinMax.Text = "Tìm max-min của mảng";
            btnMinMax.UseVisualStyleBackColor = true;
            btnMinMax.Click += btnMinMax_Click;
            // 
            // btnDemChan
            // 
            btnDemChan.Location = new Point(221, 118);
            btnDemChan.Name = "btnDemChan";
            btnDemChan.Size = new Size(197, 23);
            btnDemChan.TabIndex = 6;
            btnDemChan.Text = "Đếm số phần tử chẵn";
            btnDemChan.UseVisualStyleBackColor = true;
            btnDemChan.Click += btnDemChan_Click;
            // 
            // btnXuatViTriChan
            // 
            btnXuatViTriChan.Location = new Point(221, 141);
            btnXuatViTriChan.Name = "btnXuatViTriChan";
            btnXuatViTriChan.Size = new Size(197, 23);
            btnXuatViTriChan.TabIndex = 7;
            btnXuatViTriChan.Text = "Xuất vị trí các phần tử chẵn";
            btnXuatViTriChan.UseVisualStyleBackColor = true;
            btnXuatViTriChan.Click += btnXuatViTriChan_Click;
            // 
            // btnXuatVitriLe
            // 
            btnXuatVitriLe.Location = new Point(221, 164);
            btnXuatVitriLe.Name = "btnXuatVitriLe";
            btnXuatVitriLe.Size = new Size(197, 23);
            btnXuatVitriLe.TabIndex = 8;
            btnXuatVitriLe.Text = "Xuất vị trí các phần tử lẻ";
            btnXuatVitriLe.UseVisualStyleBackColor = true;
            btnXuatVitriLe.Click += btnXuatVitriLe_Click;
            // 
            // btnDemLe
            // 
            btnDemLe.Location = new Point(221, 187);
            btnDemLe.Name = "btnDemLe";
            btnDemLe.Size = new Size(197, 23);
            btnDemLe.TabIndex = 9;
            btnDemLe.Text = "Đếm số phần tử lẻ";
            btnDemLe.UseVisualStyleBackColor = true;
            btnDemLe.Click += btnDemLe_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(125, 216);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(197, 23);
            btnKetThuc.TabIndex = 10;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 260);
            Controls.Add(btnKetThuc);
            Controls.Add(btnDemLe);
            Controls.Add(btnXuatVitriLe);
            Controls.Add(btnXuatViTriChan);
            Controls.Add(btnDemChan);
            Controls.Add(btnMinMax);
            Controls.Add(btnTongMang);
            Controls.Add(btnXuatMang);
            Controls.Add(btnNhapMang);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNhap;
        private GroupBox groupBox2;
        private TextBox txtKetQua;
        private Button btnNhapMang;
        private Button btnXuatMang;
        private Button btnTongMang;
        private Button btnMinMax;
        private Button btnDemChan;
        private Button btnXuatViTriChan;
        private Button btnXuatVitriLe;
        private Button btnDemLe;
        private Button btnKetThuc;
    }
}