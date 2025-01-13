namespace Bai28
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
            txtNgaySinh = new TextBox();
            txtHoTen = new TextBox();
            txtMaSo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLuu = new Button();
            btnHien = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lstHien = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNgaySinh);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaSo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 156);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(85, 113);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(304, 23);
            txtNgaySinh.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(85, 72);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(304, 23);
            txtHoTen.TabIndex = 4;
            // 
            // txtMaSo
            // 
            txtMaSo.Location = new Point(85, 33);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(304, 23);
            txtMaSo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 116);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 72);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 33);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã số";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(127, 174);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHien
            // 
            btnHien.Location = new Point(252, 174);
            btnHien.Name = "btnHien";
            btnHien.Size = new Size(103, 23);
            btnHien.TabIndex = 2;
            btnHien.Text = "Hiện danh sách";
            btnHien.UseVisualStyleBackColor = true;
            btnHien.Click += btnHien_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 213);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Mã số";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 213);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Họ tên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 213);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 5;
            label6.Text = "Ngày sinh";
            // 
            // lstHien
            // 
            lstHien.FormattingEnabled = true;
            lstHien.ItemHeight = 15;
            lstHien.Location = new Point(12, 231);
            lstHien.Name = "lstHien";
            lstHien.Size = new Size(415, 169);
            lstHien.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 416);
            Controls.Add(lstHien);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnHien);
            Controls.Add(btnLuu);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNgaySinh;
        private TextBox txtHoTen;
        private TextBox txtMaSo;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLuu;
        private Button btnHien;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox lstHien;
    }
}