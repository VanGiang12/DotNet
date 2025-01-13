namespace ChuVi_DienTich_TamGiac
{
    partial class frmMain
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
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnNhap = new Button();
            txtCanh3 = new TextBox();
            txtCanh2 = new TextBox();
            txtCanh1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            rad_ChuVi = new RadioButton();
            rad_DienTich = new RadioButton();
            label1 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(txtCanh3);
            groupBox1.Controls.Add(txtCanh2);
            groupBox1.Controls.Add(txtCanh1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 137);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập dữ liệu";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(411, 89);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 26);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhap.Location = new Point(411, 40);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 29);
            btnNhap.TabIndex = 9;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // txtCanh3
            // 
            txtCanh3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCanh3.Location = new Point(132, 94);
            txtCanh3.Name = "txtCanh3";
            txtCanh3.Size = new Size(248, 29);
            txtCanh3.TabIndex = 8;
            // 
            // txtCanh2
            // 
            txtCanh2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCanh2.Location = new Point(132, 57);
            txtCanh2.Name = "txtCanh2";
            txtCanh2.Size = new Size(248, 29);
            txtCanh2.TabIndex = 7;
            // 
            // txtCanh1
            // 
            txtCanh1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCanh1.Location = new Point(132, 22);
            txtCanh1.Name = "txtCanh1";
            txtCanh1.Size = new Size(248, 29);
            txtCanh1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 29);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 3;
            label2.Text = "Cạnh thứ 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 60);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 4;
            label3.Text = "Cạnh thứ 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 94);
            label4.Name = "label4";
            label4.Size = new Size(92, 21);
            label4.TabIndex = 5;
            label4.Text = "Cạnh thứ 3";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rad_ChuVi);
            groupBox2.Controls.Add(rad_DienTich);
            groupBox2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(520, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tính";
            // 
            // rad_ChuVi
            // 
            rad_ChuVi.AutoSize = true;
            rad_ChuVi.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rad_ChuVi.Location = new Point(15, 60);
            rad_ChuVi.Name = "rad_ChuVi";
            rad_ChuVi.Size = new Size(144, 25);
            rad_ChuVi.TabIndex = 1;
            rad_ChuVi.TabStop = true;
            rad_ChuVi.Text = "Chu vi tam giác";
            rad_ChuVi.UseVisualStyleBackColor = true;
            rad_ChuVi.MouseClick += rad_ChuVi_MouseClick;
            // 
            // rad_DienTich
            // 
            rad_DienTich.AutoSize = true;
            rad_DienTich.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rad_DienTich.Location = new Point(15, 35);
            rad_DienTich.Name = "rad_DienTich";
            rad_DienTich.Size = new Size(163, 25);
            rad_DienTich.TabIndex = 0;
            rad_DienTich.TabStop = true;
            rad_DienTich.Text = "Diện tích tam giác";
            rad_DienTich.UseVisualStyleBackColor = true;
            rad_DienTich.CheckedChanged += rad_DienTich_CheckedChanged;
            rad_DienTich.MouseClick += rad_DienTich_MouseClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 9);
            label1.Name = "label1";
            label1.Size = new Size(434, 25);
            label1.TabIndex = 2;
            label1.Text = "TÍNH CHU VI VÀ DIỆN TÍCH TAM GIÁC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 293);
            label5.Name = "label5";
            label5.Size = new Size(72, 21);
            label5.TabIndex = 11;
            label5.Text = "Kết Quả";
            // 
            // frmMain
            // 
            AcceptButton = btnNhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(544, 332);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính chu vi và diện tích tam giác";
            Load += frmMain_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnThoat;
        private Button btnNhap;
        private TextBox txtCanh3;
        private TextBox txtCanh2;
        private TextBox txtCanh1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private Label label1;
        private RadioButton rad_ChuVi;
        private RadioButton rad_DienTich;
        private Label label5;
    }
}