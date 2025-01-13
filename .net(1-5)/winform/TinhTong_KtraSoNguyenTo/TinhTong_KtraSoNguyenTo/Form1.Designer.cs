namespace TinhTong_KtraSoNguyenTo
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
            txtNhap = new TextBox();
            btnTong = new Button();
            btnktrasnt = new Button();
            lblKetQua = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 44);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập n";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(126, 36);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(233, 23);
            txtNhap.TabIndex = 1;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(12, 120);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(147, 23);
            btnTong.TabIndex = 2;
            btnTong.Text = "Tính tổng";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnktrasnt
            // 
            btnktrasnt.Location = new Point(12, 182);
            btnktrasnt.Name = "btnktrasnt";
            btnktrasnt.Size = new Size(147, 23);
            btnktrasnt.TabIndex = 3;
            btnktrasnt.Text = "Kiểm tra số nguyên tố";
            btnktrasnt.UseVisualStyleBackColor = true;
            btnktrasnt.Click += btnktrasnt_Click;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(126, 83);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(49, 15);
            lblKetQua.TabIndex = 4;
            lblKetQua.Text = "Kết Quả";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 232);
            Controls.Add(lblKetQua);
            Controls.Add(btnktrasnt);
            Controls.Add(btnTong);
            Controls.Add(txtNhap);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhap;
        private Button btnTong;
        private Button btnktrasnt;
        private Label lblKetQua;
    }
}