namespace OnTapMang_B38
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
            txtMangGoc = new TextBox();
            groupBox2 = new GroupBox();
            txtKetQua = new TextBox();
            btnXuatMang = new Button();
            btnTongMang = new Button();
            btnDemSoLe = new Button();
            btnTongSoLe = new Button();
            btnMin = new Button();
            btnTangPhanTuLen2 = new Button();
            btnSapXepTang = new Button();
            btnSapXepGiam = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMangGoc);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 79);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mảng Gốc";
            // 
            // txtMangGoc
            // 
            txtMangGoc.Dock = DockStyle.Fill;
            txtMangGoc.Location = new Point(3, 19);
            txtMangGoc.Multiline = true;
            txtMangGoc.Name = "txtMangGoc";
            txtMangGoc.Size = new Size(411, 57);
            txtMangGoc.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtKetQua);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(417, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết Quả";
            // 
            // txtKetQua
            // 
            txtKetQua.Dock = DockStyle.Fill;
            txtKetQua.Location = new Point(3, 19);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(411, 78);
            txtKetQua.TabIndex = 0;
            // 
            // btnXuatMang
            // 
            btnXuatMang.BackColor = Color.FromArgb(224, 224, 224);
            btnXuatMang.Location = new Point(12, 185);
            btnXuatMang.Name = "btnXuatMang";
            btnXuatMang.Size = new Size(186, 23);
            btnXuatMang.TabIndex = 2;
            btnXuatMang.Text = "Xuất mảng ngẫu nhiên";
            btnXuatMang.UseVisualStyleBackColor = false;
            btnXuatMang.Click += btnXuatMang_Click;
            // 
            // btnTongMang
            // 
            btnTongMang.BackColor = Color.FromArgb(224, 224, 224);
            btnTongMang.Location = new Point(12, 214);
            btnTongMang.Name = "btnTongMang";
            btnTongMang.Size = new Size(186, 23);
            btnTongMang.TabIndex = 3;
            btnTongMang.Text = "Tính tổng giá trị mảng";
            btnTongMang.UseVisualStyleBackColor = false;
            btnTongMang.Click += btnTongMang_Click;
            // 
            // btnDemSoLe
            // 
            btnDemSoLe.BackColor = Color.FromArgb(224, 224, 224);
            btnDemSoLe.Location = new Point(12, 243);
            btnDemSoLe.Name = "btnDemSoLe";
            btnDemSoLe.Size = new Size(186, 23);
            btnDemSoLe.TabIndex = 4;
            btnDemSoLe.Text = "Đếm số phần tử lẻ";
            btnDemSoLe.UseVisualStyleBackColor = false;
            btnDemSoLe.Click += btnDemSoLe_Click;
            // 
            // btnTongSoLe
            // 
            btnTongSoLe.BackColor = Color.FromArgb(224, 224, 224);
            btnTongSoLe.Location = new Point(12, 272);
            btnTongSoLe.Name = "btnTongSoLe";
            btnTongSoLe.Size = new Size(186, 23);
            btnTongSoLe.TabIndex = 5;
            btnTongSoLe.Text = "Tổng phần tử lẻ";
            btnTongSoLe.UseVisualStyleBackColor = false;
            btnTongSoLe.Click += btnTongSoLe_Click;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.FromArgb(224, 224, 224);
            btnMin.Location = new Point(219, 185);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(186, 23);
            btnMin.TabIndex = 6;
            btnMin.Text = "Tìm phần tử nhỏ nhất";
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnTangPhanTuLen2
            // 
            btnTangPhanTuLen2.BackColor = Color.FromArgb(224, 224, 224);
            btnTangPhanTuLen2.Location = new Point(219, 214);
            btnTangPhanTuLen2.Name = "btnTangPhanTuLen2";
            btnTangPhanTuLen2.Size = new Size(186, 23);
            btnTangPhanTuLen2.TabIndex = 7;
            btnTangPhanTuLen2.Text = "Tăng mỗi phần tử lên 2";
            btnTangPhanTuLen2.UseVisualStyleBackColor = false;
            btnTangPhanTuLen2.Click += btnTangPhanTuLen2_Click;
            // 
            // btnSapXepTang
            // 
            btnSapXepTang.BackColor = Color.FromArgb(224, 224, 224);
            btnSapXepTang.Location = new Point(219, 243);
            btnSapXepTang.Name = "btnSapXepTang";
            btnSapXepTang.Size = new Size(186, 23);
            btnSapXepTang.TabIndex = 8;
            btnSapXepTang.Text = "Sắp mảng tăng";
            btnSapXepTang.UseVisualStyleBackColor = false;
            btnSapXepTang.Click += btnSapXepTang_Click;
            // 
            // btnSapXepGiam
            // 
            btnSapXepGiam.BackColor = Color.FromArgb(224, 224, 224);
            btnSapXepGiam.Location = new Point(219, 272);
            btnSapXepGiam.Name = "btnSapXepGiam";
            btnSapXepGiam.Size = new Size(186, 23);
            btnSapXepGiam.TabIndex = 9;
            btnSapXepGiam.Text = "Săp mảng giảm";
            btnSapXepGiam.UseVisualStyleBackColor = false;
            btnSapXepGiam.Click += btnSapXepGiam_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 305);
            Controls.Add(btnSapXepGiam);
            Controls.Add(btnSapXepTang);
            Controls.Add(btnTangPhanTuLen2);
            Controls.Add(btnMin);
            Controls.Add(btnTongSoLe);
            Controls.Add(btnDemSoLe);
            Controls.Add(btnTongMang);
            Controls.Add(btnXuatMang);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMangGoc;
        private GroupBox groupBox2;
        private TextBox txtKetQua;
        private Button btnXuatMang;
        private Button btnTongMang;
        private Button btnDemSoLe;
        private Button btnTongSoLe;
        private Button btnMin;
        private Button btnTangPhanTuLen2;
        private Button btnSapXepTang;
        private Button btnSapXepGiam;
    }
}