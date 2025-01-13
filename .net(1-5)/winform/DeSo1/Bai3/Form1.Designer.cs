namespace Bai3
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
            txtMa = new TextBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvSinhVien = new DataGridView();
            label6 = new Label();
            groupBox1 = new GroupBox();
            txtLuongTN = new TextBox();
            txtMucLuong = new TextBox();
            txtNamSinh = new TextBox();
            txtHoTen = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMa
            // 
            txtMa.Location = new Point(109, 25);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(191, 23);
            txtMa.TabIndex = 33;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(550, 296);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(92, 36);
            btnThoat.TabIndex = 31;
            btnThoat.Text = "&Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(419, 296);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(92, 36);
            btnXoa.TabIndex = 30;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(285, 296);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(92, 36);
            btnSua.TabIndex = 29;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(155, 296);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(92, 36);
            btnThem.TabIndex = 28;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Dock = DockStyle.Fill;
            dgvSinhVien.Location = new Point(3, 19);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowTemplate.Height = 25;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(525, 243);
            dgvSinhVien.TabIndex = 0;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 28);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 32;
            label6.Text = "Mã";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvSinhVien);
            groupBox1.Location = new Point(322, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(531, 265);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách Teamleader";
            // 
            // txtLuongTN
            // 
            txtLuongTN.Location = new Point(109, 245);
            txtLuongTN.Name = "txtLuongTN";
            txtLuongTN.Size = new Size(191, 23);
            txtLuongTN.TabIndex = 26;
            // 
            // txtMucLuong
            // 
            txtMucLuong.Location = new Point(109, 179);
            txtMucLuong.Name = "txtMucLuong";
            txtMucLuong.Size = new Size(191, 23);
            txtMucLuong.TabIndex = 24;
            // 
            // txtNamSinh
            // 
            txtNamSinh.Location = new Point(109, 122);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(191, 23);
            txtNamSinh.TabIndex = 23;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(109, 72);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(191, 23);
            txtHoTen.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 251);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 21;
            label5.Text = "Lương TN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 184);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 19;
            label3.Text = "Mức lương";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 128);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 18;
            label2.Text = "Năm sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 78);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 17;
            label1.Text = "Họ tên";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 361);
            Controls.Add(txtMa);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(txtLuongTN);
            Controls.Add(txtMucLuong);
            Controls.Add(txtNamSinh);
            Controls.Add(txtHoTen);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMa;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvSinhVien;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox txtLuongTN;
        private TextBox txtMucLuong;
        private TextBox txtNamSinh;
        private TextBox txtHoTen;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}