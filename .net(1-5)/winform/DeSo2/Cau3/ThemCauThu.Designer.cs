namespace Cau3
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
            btnThoat = new Button();
            btnNhapLai = new Button();
            btnLuu = new Button();
            txtNS = new TextBox();
            txtTen = new TextBox();
            txtMa = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboQQ = new ComboBox();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(298, 213);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 30;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(191, 213);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(75, 23);
            btnNhapLai.TabIndex = 29;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            btnNhapLai.Click += btnNhapLai_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(96, 209);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 28;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtNS
            // 
            txtNS.Location = new Point(97, 125);
            txtNS.Name = "txtNS";
            txtNS.Size = new Size(352, 23);
            txtNS.TabIndex = 26;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(97, 94);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(352, 23);
            txtTen.TabIndex = 25;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(97, 55);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(352, 23);
            txtMa.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 170);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 23;
            label6.Text = "Quê quán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 133);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 22;
            label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 97);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 21;
            label4.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 54);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 20;
            label3.Text = "mã";
            // 
            // label2
            // 
            label2.BackColor = Color.Brown;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 23);
            label2.Name = "label2";
            label2.Size = new Size(466, 15);
            label2.TabIndex = 19;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(466, 23);
            label1.TabIndex = 18;
            label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ BÓNG ĐÁ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboQQ
            // 
            cboQQ.FormattingEnabled = true;
            cboQQ.Items.AddRange(new object[] { "Hưng yên", "Hà nội", "Nam định" });
            cboQQ.Location = new Point(97, 162);
            cboQQ.Name = "cboQQ";
            cboQQ.Size = new Size(352, 23);
            cboQQ.TabIndex = 36;
            // 
            // ThemCauThu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 349);
            Controls.Add(cboQQ);
            Controls.Add(btnThoat);
            Controls.Add(btnNhapLai);
            Controls.Add(btnLuu);
            Controls.Add(txtNS);
            Controls.Add(txtTen);
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

        private Button btnThoat;
        private Button btnNhapLai;
        private Button btnLuu;
        private TextBox txtNS;
        private TextBox txtTen;
        private TextBox txtMa;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboQQ;
    }
}