namespace bai6
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
            so1 = new Label();
            so2 = new Label();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            lbKetQua = new Label();
            txtKQ = new TextBox();
            btnCong = new Button();
            SuspendLayout();
            // 
            // so1
            // 
            so1.AutoSize = true;
            so1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            so1.Location = new Point(40, 76);
            so1.Name = "so1";
            so1.Size = new Size(90, 21);
            so1.TabIndex = 0;
            so1.Text = "Số thứ nhất";
            // 
            // so2
            // 
            so2.AutoSize = true;
            so2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            so2.Location = new Point(40, 123);
            so2.Name = "so2";
            so2.Size = new Size(80, 21);
            so2.TabIndex = 1;
            so2.Text = "Số thứ hai";
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(178, 74);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(210, 23);
            txtSo1.TabIndex = 2;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(178, 121);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(210, 23);
            txtSo2.TabIndex = 3;
            // 
            // lbKetQua
            // 
            lbKetQua.AutoSize = true;
            lbKetQua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbKetQua.Location = new Point(40, 199);
            lbKetQua.Name = "lbKetQua";
            lbKetQua.Size = new Size(62, 21);
            lbKetQua.TabIndex = 4;
            lbKetQua.Text = "Kết quả";
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(190, 200);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(100, 23);
            txtKQ.TabIndex = 5;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(88, 277);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(75, 23);
            btnCong.TabIndex = 6;
            btnCong.Text = "Cộng";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCong);
            Controls.Add(txtKQ);
            Controls.Add(lbKetQua);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(so2);
            Controls.Add(so1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label so1;
        private Label so2;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private Label lbKetQua;
        private TextBox txtKQ;
        private Button btnCong;
    }
}