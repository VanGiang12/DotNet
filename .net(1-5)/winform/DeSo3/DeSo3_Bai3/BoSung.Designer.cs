namespace DeSo3_Bai3
{
    partial class BoSung
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
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            cboKhoa = new ComboBox();
            txtQueQuan = new TextBox();
            txtTen = new TextBox();
            txtMa = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(344, 118);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 24;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(344, 78);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 23;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(344, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Items.AddRange(new object[] { "cơ khí", "cntt", "điện tử" });
            cboKhoa.Location = new Point(84, 96);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(222, 23);
            cboKhoa.TabIndex = 20;
            // 
            // txtQueQuan
            // 
            txtQueQuan.Location = new Point(84, 132);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(222, 23);
            txtQueQuan.TabIndex = 19;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(84, 56);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(222, 23);
            txtTen.TabIndex = 18;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(84, 20);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(222, 23);
            txtMa.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 135);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 16;
            label4.Text = "Quê quán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 99);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 15;
            label3.Text = "Khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 59);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 14;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 23);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 13;
            label1.Text = "Mã SV";
            // 
            // BoSung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 187);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cboKhoa);
            Controls.Add(txtQueQuan);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BoSung";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BoSung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button2;
        private Button button1;
        private ComboBox cboKhoa;
        private TextBox txtQueQuan;
        private TextBox txtTen;
        private TextBox txtMa;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}