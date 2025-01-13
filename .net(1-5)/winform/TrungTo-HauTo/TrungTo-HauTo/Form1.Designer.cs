namespace TrungTo_HauTo
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
            rtxtHauTo = new RichTextBox();
            rtxtTrungto = new RichTextBox();
            btnChuyenHauTo = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(465, 19);
            label1.TabIndex = 0;
            label1.Text = "CHUYỂN BIỂU THỨC TRUNG TỐ ĐẦY ĐỦ DẤU NGOẶC SANG HẬU TỐ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập biểu thức trung tố";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 199);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "Biểu thức hậu tố";
            // 
            // rtxtHauTo
            // 
            rtxtHauTo.Location = new Point(12, 226);
            rtxtHauTo.Name = "rtxtHauTo";
            rtxtHauTo.ReadOnly = true;
            rtxtHauTo.Size = new Size(493, 75);
            rtxtHauTo.TabIndex = 3;
            rtxtHauTo.Text = "";
            // 
            // rtxtTrungto
            // 
            rtxtTrungto.Location = new Point(12, 71);
            rtxtTrungto.Name = "rtxtTrungto";
            rtxtTrungto.Size = new Size(493, 68);
            rtxtTrungto.TabIndex = 4;
            rtxtTrungto.Text = "";
            rtxtTrungto.TextChanged += rtxtTrungto_TextChanged;
            // 
            // btnChuyenHauTo
            // 
            btnChuyenHauTo.Location = new Point(145, 167);
            btnChuyenHauTo.Name = "btnChuyenHauTo";
            btnChuyenHauTo.Size = new Size(107, 23);
            btnChuyenHauTo.TabIndex = 5;
            btnChuyenHauTo.Text = "Chuyển hậu tố";
            btnChuyenHauTo.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(304, 167);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 329);
            Controls.Add(btnThoat);
            Controls.Add(btnChuyenHauTo);
            Controls.Add(rtxtTrungto);
            Controls.Add(rtxtHauTo);
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
        private RichTextBox rtxtHauTo;
        private RichTextBox rtxtTrungto;
        private Button btnChuyenHauTo;
        private Button btnThoat;
    }
}