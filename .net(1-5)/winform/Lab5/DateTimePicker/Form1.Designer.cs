﻿namespace DateTimePicker
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
            txtQue = new TextBox();
            dtpNamSinh = new System.Windows.Forms.DateTimePicker();
            btnDangKi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÍ THÀNH VIÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 72);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 115);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Quê Quán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 156);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Năm sinh";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(104, 72);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(200, 23);
            txtTen.TabIndex = 4;
            // 
            // txtQue
            // 
            txtQue.Location = new Point(104, 115);
            txtQue.Name = "txtQue";
            txtQue.Size = new Size(200, 23);
            txtQue.TabIndex = 5;
            // 
            // dtpNamSinh
            // 
            dtpNamSinh.CustomFormat = "dd/MM/yyy";
            dtpNamSinh.Format = DateTimePickerFormat.Custom;
            dtpNamSinh.Location = new Point(104, 156);
            dtpNamSinh.Name = "dtpNamSinh";
            dtpNamSinh.Size = new Size(200, 23);
            dtpNamSinh.TabIndex = 6;
            // 
            // btnDangKi
            // 
            btnDangKi.Location = new Point(133, 203);
            btnDangKi.Name = "btnDangKi";
            btnDangKi.Size = new Size(75, 23);
            btnDangKi.TabIndex = 7;
            btnDangKi.Text = "Đăng kí";
            btnDangKi.UseVisualStyleBackColor = true;
            btnDangKi.Click += btnDangKi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 269);
            Controls.Add(btnDangKi);
            Controls.Add(dtpNamSinh);
            Controls.Add(txtQue);
            Controls.Add(txtTen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTen;
        private TextBox txtQue;
        private System.Windows.Forms.DateTimePicker dtpNamSinh;
        private Button btnDangKi;
    }
}