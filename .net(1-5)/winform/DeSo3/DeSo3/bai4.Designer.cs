namespace DeSo3
{
    partial class bai4
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
            label6 = new Label();
            txtKetQua = new TextBox();
            txtSo2 = new TextBox();
            cboPhepToan = new ComboBox();
            txtSo1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(291, 106);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 19;
            label6.Text = "=";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(312, 103);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(74, 23);
            txtKetQua.TabIndex = 18;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(204, 103);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(81, 23);
            txtSo2.TabIndex = 17;
            // 
            // cboPhepToan
            // 
            cboPhepToan.FormattingEnabled = true;
            cboPhepToan.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cboPhepToan.Location = new Point(115, 103);
            cboPhepToan.Name = "cboPhepToan";
            cboPhepToan.Size = new Size(61, 23);
            cboPhepToan.TabIndex = 16;
            cboPhepToan.SelectedIndexChanged += cboPhepToan_SelectedIndexChanged;
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(10, 103);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(83, 23);
            txtSo1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 77);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 14;
            label5.Text = "Kết quả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 77);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 13;
            label4.Text = "Số thứ hai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 75);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 12;
            label3.Text = "Phép toán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 77);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 11;
            label2.Text = "Số thứ nhất";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(120, 12);
            label1.Name = "label1";
            label1.Size = new Size(186, 21);
            label1.TabIndex = 10;
            label1.Text = "Chương trình tính toán";
            // 
            // bai4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 176);
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
            Name = "bai4";
            Text = "bai4";
            Load += bai4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txtKetQua;
        private TextBox txtSo2;
        private ComboBox cboPhepToan;
        private TextBox txtSo1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}