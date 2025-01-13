namespace Bai16
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
            btnThucHien = new Button();
            btn2 = new Button();
            txtNamDuong = new TextBox();
            txtNamAm = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 62);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Năm dương lịch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 167);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Năm âm lịch";
            // 
            // btnThucHien
            // 
            btnThucHien.Location = new Point(72, 116);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(75, 23);
            btnThucHien.TabIndex = 2;
            btnThucHien.Text = "Chuyển 1";
            btnThucHien.UseVisualStyleBackColor = true;
            btnThucHien.Click += btnThucHien_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(176, 116);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 23);
            btn2.TabIndex = 3;
            btn2.Text = "Chuyển 2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // txtNamDuong
            // 
            txtNamDuong.Location = new Point(151, 62);
            txtNamDuong.Name = "txtNamDuong";
            txtNamDuong.Size = new Size(100, 23);
            txtNamDuong.TabIndex = 4;
            // 
            // txtNamAm
            // 
            txtNamAm.Location = new Point(151, 164);
            txtNamAm.Name = "txtNamAm";
            txtNamAm.Size = new Size(100, 23);
            txtNamAm.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 239);
            Controls.Add(txtNamAm);
            Controls.Add(txtNamDuong);
            Controls.Add(btn2);
            Controls.Add(btnThucHien);
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
        private Button btnThucHien;
        private Button btn2;
        private TextBox txtNamDuong;
        private TextBox txtNamAm;
    }
}