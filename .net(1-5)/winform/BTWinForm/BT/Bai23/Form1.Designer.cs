namespace Bai23
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
            label5 = new Label();
            txtAB = new TextBox();
            txtA = new TextBox();
            txtTong = new TextBox();
            txtB = new TextBox();
            txtSapXep = new TextBox();
            btnTong = new Button();
            btnPhatSinh = new Button();
            btnThoat = new Button();
            btnSapXep = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 27);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "Dãy số vừa tạo từ A đến B";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 27);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Số A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 2;
            label3.Text = "Tổng các số trong dãy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 110);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Số B";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 185);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 4;
            label5.Text = "Dãy số sau khi sắp xếp";
            // 
            // txtAB
            // 
            txtAB.Location = new Point(20, 58);
            txtAB.Name = "txtAB";
            txtAB.ReadOnly = true;
            txtAB.Size = new Size(231, 23);
            txtAB.TabIndex = 5;
            // 
            // txtA
            // 
            txtA.Location = new Point(274, 58);
            txtA.Name = "txtA";
            txtA.Size = new Size(80, 23);
            txtA.TabIndex = 6;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(20, 135);
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.Size = new Size(231, 23);
            txtTong.TabIndex = 7;
            // 
            // txtB
            // 
            txtB.Location = new Point(274, 135);
            txtB.Name = "txtB";
            txtB.Size = new Size(80, 23);
            txtB.TabIndex = 8;
            // 
            // txtSapXep
            // 
            txtSapXep.Location = new Point(20, 229);
            txtSapXep.Name = "txtSapXep";
            txtSapXep.ReadOnly = true;
            txtSapXep.Size = new Size(231, 23);
            txtSapXep.TabIndex = 9;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(20, 281);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(75, 23);
            btnTong.TabIndex = 10;
            btnTong.Text = "Tổng";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnPhatSinh
            // 
            btnPhatSinh.Location = new Point(279, 228);
            btnPhatSinh.Name = "btnPhatSinh";
            btnPhatSinh.Size = new Size(75, 23);
            btnPhatSinh.TabIndex = 11;
            btnPhatSinh.Text = "Phát sinh";
            btnPhatSinh.UseVisualStyleBackColor = true;
            btnPhatSinh.Click += btnPhatSinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(279, 281);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSapXep
            // 
            btnSapXep.Location = new Point(148, 281);
            btnSapXep.Name = "btnSapXep";
            btnSapXep.Size = new Size(75, 23);
            btnSapXep.TabIndex = 13;
            btnSapXep.Text = "Sắp xếp";
            btnSapXep.UseVisualStyleBackColor = true;
            btnSapXep.Click += btnSapXep_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 323);
            Controls.Add(btnSapXep);
            Controls.Add(btnThoat);
            Controls.Add(btnPhatSinh);
            Controls.Add(btnTong);
            Controls.Add(txtSapXep);
            Controls.Add(txtB);
            Controls.Add(txtTong);
            Controls.Add(txtA);
            Controls.Add(txtAB);
            Controls.Add(label5);
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
        private Label label5;
        private TextBox txtAB;
        private TextBox txtA;
        private TextBox txtTong;
        private TextBox txtB;
        private TextBox txtSapXep;
        private Button btnTong;
        private Button btnPhatSinh;
        private Button btnThoat;
        private Button btnSapXep;
    }
}