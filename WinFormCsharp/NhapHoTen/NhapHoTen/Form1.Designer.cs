namespace NhapHoTen
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
            lblHoTen = new Label();
            label1 = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            label2 = new Label();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnKetThuc = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = SystemColors.ActiveCaption;
            lblHoTen.Dock = DockStyle.Top;
            lblHoTen.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoTen.ForeColor = Color.Red;
            lblHoTen.Location = new Point(0, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(562, 73);
            lblHoTen.TabIndex = 0;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.DoubleClick += lblHoTen_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 104);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Họ lót";
            // 
            // txtHo
            // 
            txtHo.BorderStyle = BorderStyle.None;
            txtHo.Location = new Point(80, 104);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(450, 16);
            txtHo.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.White;
            txtTen.BorderStyle = BorderStyle.None;
            txtTen.Location = new Point(80, 153);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(450, 16);
            txtTen.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 156);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên";
            // 
            // btnHo
            // 
            btnHo.BackColor = SystemColors.ButtonHighlight;
            btnHo.Location = new Point(109, 217);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(75, 23);
            btnHo.TabIndex = 5;
            btnHo.Text = "&Họ lót";
            btnHo.UseVisualStyleBackColor = false;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(243, 217);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(75, 23);
            btnTen.TabIndex = 6;
            btnTen.Text = "&Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(374, 217);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(75, 23);
            btnHoTen.TabIndex = 7;
            btnHoTen.Text = "Họ &và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(219, 271);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(128, 23);
            btnKetThuc.TabIndex = 8;
            btnKetThuc.Text = "Thoát Chương Trình";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 253);
            label4.Name = "label4";
            label4.Size = new Size(161, 15);
            label4.TabIndex = 10;
            label4.Text = "nhập xong bấm alt h or t or v";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            CancelButton = btnKetThuc;
            ClientSize = new Size(562, 308);
            Controls.Add(label4);
            Controls.Add(btnKetThuc);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(txtHo);
            Controls.Add(label1);
            Controls.Add(lblHoTen);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài tập họ tên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label label1;
        private TextBox txtHo;
        private TextBox txtTen;
        private Label label2;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnKetThuc;
        private Label label4;
    }
}