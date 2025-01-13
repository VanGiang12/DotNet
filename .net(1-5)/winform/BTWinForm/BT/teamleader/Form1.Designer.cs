namespace teamleader
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtMa = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            dgvSinhVien = new DataGridView();
            txtLuongTN = new TextBox();
            txtTienTK = new TextBox();
            txtMucLuong = new TextBox();
            txtNamSinh = new TextBox();
            txtHoTen = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // txtMa
            // 
            txtMa.Location = new Point(119, 24);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(191, 23);
            txtMa.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 27);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 28;
            label6.Text = "Mã";
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(dgvSinhVien);
            groupBox1.Location = new Point(334, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 265);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách Teamleader";
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvSinhVien.DefaultCellStyle = dataGridViewCellStyle1;
            dgvSinhVien.Dock = DockStyle.Fill;
            dgvSinhVien.Location = new Point(3, 19);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowTemplate.Height = 25;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(411, 243);
            dgvSinhVien.TabIndex = 0;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // txtLuongTN
            // 
            txtLuongTN.Location = new Point(119, 248);
            txtLuongTN.Name = "txtLuongTN";
            txtLuongTN.Size = new Size(191, 23);
            txtLuongTN.TabIndex = 26;
            // 
            // txtTienTK
            // 
            txtTienTK.Location = new Point(119, 192);
            txtTienTK.Name = "txtTienTK";
            txtTienTK.Size = new Size(191, 23);
            txtTienTK.TabIndex = 25;
            // 
            // txtMucLuong
            // 
            txtMucLuong.Location = new Point(119, 144);
            txtMucLuong.Name = "txtMucLuong";
            txtMucLuong.Size = new Size(191, 23);
            txtMucLuong.TabIndex = 24;
            // 
            // txtNamSinh
            // 
            txtNamSinh.Location = new Point(119, 101);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(191, 23);
            txtNamSinh.TabIndex = 23;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(119, 62);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(191, 23);
            txtHoTen.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 254);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 21;
            label5.Text = "Lương TN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 199);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 20;
            label4.Text = "Tiền trong TK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 149);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 19;
            label3.Text = "Mức lương";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 107);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 18;
            label2.Text = "Năm sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 68);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 17;
            label1.Text = "Họ tên";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(440, 290);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(92, 36);
            btnThoat.TabIndex = 33;
            btnThoat.Text = "&Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(309, 290);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(92, 36);
            btnXoa.TabIndex = 32;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(175, 290);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(92, 36);
            btnSua.TabIndex = 31;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(45, 290);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(92, 36);
            btnThem.TabIndex = 30;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 338);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtMa);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(txtLuongTN);
            Controls.Add(txtTienTK);
            Controls.Add(txtMucLuong);
            Controls.Add(txtNamSinh);
            Controls.Add(txtHoTen);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMa;
        private Label label6;
        private GroupBox groupBox1;
        private DataGridView dgvSinhVien;
        private TextBox txtLuongTN;
        private TextBox txtTienTK;
        private TextBox txtMucLuong;
        private TextBox txtNamSinh;
        private TextBox txtHoTen;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}