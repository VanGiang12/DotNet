namespace Bai22
{
    partial class Form2
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
            label1 = new Label();
            txtNhap = new TextBox();
            btnNhap = new Button();
            btnXong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 40);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập mảng";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(93, 40);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(189, 23);
            txtNhap.TabIndex = 1;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(93, 93);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 2;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXong
            // 
            btnXong.Location = new Point(207, 93);
            btnXong.Name = "btnXong";
            btnXong.Size = new Size(75, 23);
            btnXong.TabIndex = 3;
            btnXong.Text = "Xong";
            btnXong.UseVisualStyleBackColor = true;
            btnXong.Click += btnXong_Click;
            // 
            // Form2
            // 
            AcceptButton = btnNhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 137);
            Controls.Add(btnXong);
            Controls.Add(btnNhap);
            Controls.Add(txtNhap);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhap;
        private Button btnNhap;
        private Button btnXong;
    }
}