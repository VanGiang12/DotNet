namespace ThietKeMuaVeXemPhim_B37
{
    partial class frmThongTinKhach
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
            txtHoTen = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            btnXacNhan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ Và Tên";
            label1.Click += label1_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(88, 12);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(212, 23);
            txtHoTen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(88, 54);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(212, 23);
            txtPhone.TabIndex = 3;
            txtPhone.TextChanged += textBox2_TextChanged;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(88, 83);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(75, 23);
            btnXacNhan.TabIndex = 4;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // frmThongTinKhach
            // 
            AcceptButton = btnXacNhan;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 125);
            Controls.Add(btnXacNhan);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Name = "frmThongTinKhach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Điền thông tin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnXacNhan;
        public TextBox txtHoTen;
        public TextBox txtPhone;
    }
}