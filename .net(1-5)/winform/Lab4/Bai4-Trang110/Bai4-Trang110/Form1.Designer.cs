namespace Bai4_Trang110
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtTen = new TextBox();
            txtTong = new TextBox();
            chkCaoVoi = new CheckBox();
            chkTayRang = new CheckBox();
            chkChupHinh = new CheckBox();
            numTramrang = new NumericUpDown();
            btnThoat = new Button();
            btnTinh = new Button();
            ((System.ComponentModel.ISupportInitialize)numTramrang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(87, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Dental Payment Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 199);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Trám răng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 41);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên Khách Hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 199);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 11;
            label4.Text = "$80000/cái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 165);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 8;
            label5.Text = "$200000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 125);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 6;
            label6.Text = "$1.200.000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(262, 88);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 4;
            label7.Text = "$100.000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(164, 238);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 12;
            label8.Text = "Total";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(135, 41);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(179, 23);
            txtTen.TabIndex = 2;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(214, 235);
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.Size = new Size(100, 23);
            txtTong.TabIndex = 13;
            // 
            // chkCaoVoi
            // 
            chkCaoVoi.AutoSize = true;
            chkCaoVoi.Location = new Point(36, 88);
            chkCaoVoi.Name = "chkCaoVoi";
            chkCaoVoi.Size = new Size(66, 19);
            chkCaoVoi.TabIndex = 3;
            chkCaoVoi.Text = "Cạo vôi";
            chkCaoVoi.UseVisualStyleBackColor = true;
            // 
            // chkTayRang
            // 
            chkTayRang.AutoSize = true;
            chkTayRang.Location = new Point(36, 125);
            chkTayRang.Name = "chkTayRang";
            chkTayRang.Size = new Size(71, 19);
            chkTayRang.TabIndex = 5;
            chkTayRang.Text = "Tẩy răng";
            chkTayRang.UseVisualStyleBackColor = true;
            // 
            // chkChupHinh
            // 
            chkChupHinh.AutoSize = true;
            chkChupHinh.Location = new Point(36, 165);
            chkChupHinh.Name = "chkChupHinh";
            chkChupHinh.Size = new Size(109, 19);
            chkChupHinh.TabIndex = 7;
            chkChupHinh.Text = "Chụp hình răng";
            chkChupHinh.UseVisualStyleBackColor = true;
            // 
            // numTramrang
            // 
            numTramrang.Location = new Point(115, 197);
            numTramrang.Name = "numTramrang";
            numTramrang.Size = new Size(69, 23);
            numTramrang.TabIndex = 10;
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.Black;
            btnThoat.Location = new Point(54, 269);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(214, 269);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(75, 23);
            btnTinh.TabIndex = 15;
            btnTinh.Text = "Tính tiền";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 313);
            Controls.Add(btnTinh);
            Controls.Add(btnThoat);
            Controls.Add(numTramrang);
            Controls.Add(chkChupHinh);
            Controls.Add(chkTayRang);
            Controls.Add(chkCaoVoi);
            Controls.Add(txtTong);
            Controls.Add(txtTen);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numTramrang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtTen;
        private TextBox txtTong;
        private CheckBox chkCaoVoi;
        private CheckBox chkTayRang;
        private CheckBox chkChupHinh;
        private NumericUpDown numTramrang;
        private Button btnThoat;
        private Button btnTinh;
    }
}