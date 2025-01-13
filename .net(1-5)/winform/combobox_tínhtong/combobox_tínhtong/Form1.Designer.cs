namespace combobox_tínhtong
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
            txtSo1 = new TextBox();
            cboPhepToan = new ComboBox();
            txtSo2 = new TextBox();
            txtKetQua = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(163, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 21);
            label1.TabIndex = 0;
            label1.Text = "Chương trình tính toán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 74);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Số thứ nhất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 72);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Phép toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(252, 74);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Số thứ hai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(369, 74);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 4;
            label5.Text = "Kết quả";
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(53, 100);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(83, 23);
            txtSo1.TabIndex = 5;
            // 
            // cboPhepToan
            // 
            cboPhepToan.FormattingEnabled = true;
            cboPhepToan.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cboPhepToan.Location = new Point(158, 100);
            cboPhepToan.Name = "cboPhepToan";
            cboPhepToan.Size = new Size(61, 23);
            cboPhepToan.TabIndex = 6;
            cboPhepToan.SelectedIndexChanged += cboPhepToan_SelectedIndexChanged;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(247, 100);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(81, 23);
            txtSo2.TabIndex = 7;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(355, 100);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(74, 23);
            txtKetQua.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(334, 103);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 9;
            label6.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 166);
            Controls.Add(label6);
            Controls.Add(txtKetQua);
            Controls.Add(txtSo2);
            Controls.Add(cboPhepToan);
            Controls.Add(txtSo1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSo1;
        private ComboBox cboPhepToan;
        private TextBox txtSo2;
        private TextBox txtKetQua;
        private Label label6;
    }
}