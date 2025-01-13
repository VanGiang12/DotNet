namespace DeSo3
{
    partial class Bai3
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
            groupBox1 = new GroupBox();
            txtY1 = new TextBox();
            txtX1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtY2 = new TextBox();
            txtX2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblHSG = new Label();
            lblKC = new Label();
            btnTinh = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtY1);
            groupBox1.Controls.Add(txtX1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(152, 103);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Điểm thứ 1";
            // 
            // txtY1
            // 
            txtY1.Location = new Point(35, 62);
            txtY1.Name = "txtY1";
            txtY1.Size = new Size(100, 23);
            txtY1.TabIndex = 3;
            // 
            // txtX1
            // 
            txtX1.Location = new Point(35, 28);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(100, 23);
            txtX1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 1;
            label2.Text = "Y";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 0;
            label1.Text = "X";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtY2);
            groupBox2.Controls.Add(txtX2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(170, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(152, 103);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Điểm thứ 2";
            // 
            // txtY2
            // 
            txtY2.Location = new Point(41, 62);
            txtY2.Name = "txtY2";
            txtY2.Size = new Size(100, 23);
            txtY2.TabIndex = 3;
            // 
            // txtX2
            // 
            txtX2.Location = new Point(41, 28);
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(100, 23);
            txtX2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 65);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 1;
            label4.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 31);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 0;
            label3.Text = "X";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 118);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 2;
            label5.Text = "Hệ số góc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(211, 118);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 3;
            label6.Text = "Khoảng cách";
            // 
            // lblHSG
            // 
            lblHSG.BorderStyle = BorderStyle.Fixed3D;
            lblHSG.Location = new Point(12, 142);
            lblHSG.Name = "lblHSG";
            lblHSG.Size = new Size(152, 23);
            lblHSG.TabIndex = 4;
            lblHSG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKC
            // 
            lblKC.BorderStyle = BorderStyle.Fixed3D;
            lblKC.Location = new Point(170, 142);
            lblKC.Name = "lblKC";
            lblKC.Size = new Size(152, 23);
            lblKC.TabIndex = 5;
            lblKC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(132, 177);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(75, 23);
            btnTinh.TabIndex = 6;
            btnTinh.Text = "Tính toán";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 215);
            Controls.Add(btnTinh);
            Controls.Add(lblKC);
            Controls.Add(lblHSG);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Bai3";
            Text = "Bai3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtY1;
        private TextBox txtX1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtY2;
        private TextBox txtX2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label lblHSG;
        private Label lblKC;
        private Button btnTinh;
    }
}