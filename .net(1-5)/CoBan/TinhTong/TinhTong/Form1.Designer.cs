namespace TinhTong
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
            grLuaChon = new GroupBox();
            radTong1chiaN = new RadioButton();
            radTongn = new RadioButton();
            txtNhap = new TextBox();
            lblKetQUa = new Label();
            grLuaChon.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(106, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "TÍNH TỔNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 40);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập n";
            // 
            // grLuaChon
            // 
            grLuaChon.Controls.Add(radTong1chiaN);
            grLuaChon.Controls.Add(radTongn);
            grLuaChon.Location = new Point(24, 78);
            grLuaChon.Name = "grLuaChon";
            grLuaChon.Size = new Size(241, 100);
            grLuaChon.TabIndex = 2;
            grLuaChon.TabStop = false;
            grLuaChon.Text = "Lựa chọn";
            // 
            // radTong1chiaN
            // 
            radTong1chiaN.AutoSize = true;
            radTong1chiaN.Location = new Point(26, 57);
            radTong1chiaN.Name = "radTong1chiaN";
            radTong1chiaN.Size = new Size(200, 19);
            radTong1chiaN.TabIndex = 1;
            radTong1chiaN.TabStop = true;
            radTong1chiaN.Text = "Tính tổng của 1+1/2+1/3+...+1/n";
            radTong1chiaN.UseVisualStyleBackColor = true;
            radTong1chiaN.CheckedChanged += radTong1chiaN_CheckedChanged;
            // 
            // radTongn
            // 
            radTongn.AutoSize = true;
            radTongn.Location = new Point(24, 29);
            radTongn.Name = "radTongn";
            radTongn.Size = new Size(167, 19);
            radTongn.TabIndex = 0;
            radTongn.TabStop = true;
            radTongn.Text = "Tính tổng các chữ số của n";
            radTongn.UseVisualStyleBackColor = true;
            radTongn.CheckedChanged += radTongn_CheckedChanged;
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(84, 40);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(181, 23);
            txtNhap.TabIndex = 3;
            txtNhap.TextChanged += txtNhap_TextChanged;
            // 
            // lblKetQUa
            // 
            lblKetQUa.AutoSize = true;
            lblKetQUa.Location = new Point(24, 193);
            lblKetQUa.Name = "lblKetQUa";
            lblKetQUa.Size = new Size(47, 15);
            lblKetQUa.TabIndex = 4;
            lblKetQUa.Text = "Kết quả";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 222);
            Controls.Add(lblKetQUa);
            Controls.Add(txtNhap);
            Controls.Add(grLuaChon);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            grLuaChon.ResumeLayout(false);
            grLuaChon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox grLuaChon;
        private TextBox txtNhap;
        private RadioButton radTong1chiaN;
        private RadioButton radTongn;
        private Label lblKetQUa;
    }
}