namespace test.NhapSach
{
    partial class frmThemNXB
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
            panel2 = new Panel();
            label5 = new Label();
            txtLienHe = new TextBox();
            label4 = new Label();
            btnThem = new Button();
            txtTenNXB = new TextBox();
            txtMaNXB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtLienHe);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtTenNXB);
            panel2.Controls.Add(txtMaNXB);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(439, 428);
            panel2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(176, 51);
            label5.Name = "label5";
            label5.Size = new Size(113, 30);
            label5.TabIndex = 12;
            label5.Text = "Thông tin";
            // 
            // txtLienHe
            // 
            txtLienHe.Location = new Point(144, 246);
            txtLienHe.Margin = new Padding(3, 4, 3, 4);
            txtLienHe.Name = "txtLienHe";
            txtLienHe.Size = new Size(227, 27);
            txtLienHe.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 250);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 10;
            label4.Text = "Liên hệ";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SeaGreen;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(159, 320);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenNXB
            // 
            txtTenNXB.Location = new Point(144, 183);
            txtTenNXB.Margin = new Padding(3, 4, 3, 4);
            txtTenNXB.Name = "txtTenNXB";
            txtTenNXB.Size = new Size(227, 27);
            txtTenNXB.TabIndex = 4;
            // 
            // txtMaNXB
            // 
            txtMaNXB.Location = new Point(144, 121);
            txtMaNXB.Margin = new Padding(3, 4, 3, 4);
            txtMaNXB.Name = "txtMaNXB";
            txtMaNXB.Size = new Size(227, 27);
            txtMaNXB.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 187);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên NXB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 125);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã NXB";
            // 
            // frmThemNXB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 428);
            Controls.Add(panel2);
            Name = "frmThemNXB";
            Text = "frmNXB";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label5;
        private TextBox txtLienHe;
        private Label label4;
        private Button btnThem;
        private TextBox txtTenNXB;
        private TextBox txtMaNXB;
        private Label label3;
        private Label label2;
    }
}