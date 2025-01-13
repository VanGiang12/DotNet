namespace B1_Trang1
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
            lblHVT = new Label();
            lblLot = new Label();
            lblTen = new Label();
            txtLot = new TextBox();
            txtTen = new TextBox();
            btnLot = new Button();
            btnTen = new Button();
            btnHVT = new Button();
            btnKetThuc = new Button();
            SuspendLayout();
            // 
            // lblHVT
            // 
            lblHVT.BackColor = Color.Gold;
            lblHVT.Dock = DockStyle.Top;
            lblHVT.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblHVT.Location = new Point(0, 0);
            lblHVT.Name = "lblHVT";
            lblHVT.Size = new Size(395, 55);
            lblHVT.TabIndex = 0;
            lblHVT.Text = "Họ và Tên";
            // 
            // lblLot
            // 
            lblLot.BackColor = Color.FromArgb(128, 255, 255);
            lblLot.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblLot.Location = new Point(12, 68);
            lblLot.Name = "lblLot";
            lblLot.Size = new Size(100, 28);
            lblLot.TabIndex = 1;
            lblLot.Text = "Họ Lót";
            // 
            // lblTen
            // 
            lblTen.BackColor = Color.FromArgb(128, 255, 255);
            lblTen.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTen.Location = new Point(12, 115);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(100, 25);
            lblTen.TabIndex = 2;
            lblTen.Text = "Tên";
            // 
            // txtLot
            // 
            txtLot.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtLot.Location = new Point(138, 71);
            txtLot.Name = "txtLot";
            txtLot.Size = new Size(245, 25);
            txtLot.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(138, 114);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(245, 25);
            txtTen.TabIndex = 4;
            // 
            // btnLot
            // 
            btnLot.Location = new Point(37, 167);
            btnLot.Name = "btnLot";
            btnLot.Size = new Size(75, 23);
            btnLot.TabIndex = 5;
            btnLot.Text = "Họ lót";
            btnLot.UseVisualStyleBackColor = true;
            btnLot.Click += btnLot_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(161, 168);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(75, 23);
            btnTen.TabIndex = 6;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHVT
            // 
            btnHVT.Location = new Point(281, 168);
            btnHVT.Name = "btnHVT";
            btnHVT.Size = new Size(75, 23);
            btnHVT.TabIndex = 7;
            btnHVT.Text = "Họ và tên";
            btnHVT.UseVisualStyleBackColor = true;
            btnHVT.Click += btnHVT_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(161, 219);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(75, 23);
            btnKetThuc.TabIndex = 8;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 266);
            Controls.Add(btnKetThuc);
            Controls.Add(btnHVT);
            Controls.Add(btnTen);
            Controls.Add(btnLot);
            Controls.Add(txtTen);
            Controls.Add(txtLot);
            Controls.Add(lblTen);
            Controls.Add(lblLot);
            Controls.Add(lblHVT);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHVT;
        private Label lblLot;
        private Label lblTen;
        private TextBox txtLot;
        private TextBox txtTen;
        private Button btnLot;
        private Button btnTen;
        private Button btnHVT;
        private Button btnKetThuc;
    }
}