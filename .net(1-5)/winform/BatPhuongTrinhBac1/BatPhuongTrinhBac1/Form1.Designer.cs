namespace BatPhuongTrinhBac1
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
            txtA = new TextBox();
            txtB = new TextBox();
            btnGiai = new Button();
            btnKiemTra = new Button();
            lblKetQua = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(288, 25);
            label1.TabIndex = 0;
            label1.Text = "Giải bất phương trình ax + b < 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 62);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 103);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Nhập b";
            // 
            // txtA
            // 
            txtA.Location = new Point(108, 59);
            txtA.Name = "txtA";
            txtA.Size = new Size(183, 23);
            txtA.TabIndex = 3;
            // 
            // txtB
            // 
            txtB.Location = new Point(108, 100);
            txtB.Name = "txtB";
            txtB.Size = new Size(183, 23);
            txtB.TabIndex = 4;
            // 
            // btnGiai
            // 
            btnGiai.Location = new Point(178, 167);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(113, 23);
            btnGiai.TabIndex = 5;
            btnGiai.Text = "Giải Phương Trình";
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += button1_Click;
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(12, 167);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(75, 23);
            btnKiemTra.TabIndex = 6;
            btnKiemTra.Text = "Kiểm tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(30, 140);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(49, 15);
            lblKetQua.TabIndex = 7;
            lblKetQua.Text = "Kết Quả";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 202);
            Controls.Add(lblKetQua);
            Controls.Add(btnKiemTra);
            Controls.Add(btnGiai);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bất phương trình bậc nhất";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtA;
        private TextBox txtB;
        private Button btnGiai;
        private Button btnKiemTra;
        private Label lblKetQua;
    }
}