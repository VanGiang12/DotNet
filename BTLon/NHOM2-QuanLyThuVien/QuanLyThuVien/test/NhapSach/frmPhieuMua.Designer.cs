namespace test.NhapSach
{
    partial class frmPhieuMua
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
            btnXemThongTin = new Button();
            btnThem = new Button();
            btnSua = new Button();
            groupBox2 = new GroupBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            txtTenNXB = new TextBox();
            label1 = new Label();
            txtDonViMua = new TextBox();
            label2 = new Label();
            dtpNgayMua = new DateTimePicker();
            label9 = new Label();
            txtMaPhieuMua = new TextBox();
            label8 = new Label();
            btnDatSach = new Button();
            panel2 = new Panel();
            dgvDSMua = new DataGridView();
            btnXoa = new Button();
            btnHuy = new Button();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSMua).BeginInit();
            SuspendLayout();
            // 
            // btnXemThongTin
            // 
            btnXemThongTin.BackColor = Color.SeaGreen;
            btnXemThongTin.FlatStyle = FlatStyle.Flat;
            btnXemThongTin.ForeColor = Color.White;
            btnXemThongTin.Location = new Point(859, 385);
            btnXemThongTin.Name = "btnXemThongTin";
            btnXemThongTin.Size = new Size(75, 26);
            btnXemThongTin.TabIndex = 26;
            btnXemThongTin.Text = "Xem";
            btnXemThongTin.UseVisualStyleBackColor = false;
            btnXemThongTin.Click += btnXemThongTin_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SeaGreen;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(859, 86);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 26);
            btnThem.TabIndex = 24;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SeaGreen;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(859, 129);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 26);
            btnSua.TabIndex = 23;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(202, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(522, 69);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhập thông tin";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.SeaGreen;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(446, 31);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(70, 23);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Location = new Point(6, 33);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Mã Phiếu hoặc không nhập gì";
            txtTimKiem.Size = new Size(434, 23);
            txtTimKiem.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox4);
            panel1.Location = new Point(31, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 150);
            panel1.TabIndex = 20;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTenNXB);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(txtDonViMua);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(dtpNgayMua);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(txtMaPhieuMua);
            groupBox4.Controls.Add(label8);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(19, 13);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(762, 122);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin phiếu mua";
            // 
            // txtTenNXB
            // 
            txtTenNXB.Location = new Point(127, 70);
            txtTenNXB.Margin = new Padding(3, 2, 3, 2);
            txtTenNXB.Name = "txtTenNXB";
            txtTenNXB.Size = new Size(154, 23);
            txtTenNXB.TabIndex = 31;
            txtTenNXB.Leave += txtTenNXB_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 75);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 30;
            label1.Text = "Nhà xuất bản";
            // 
            // txtDonViMua
            // 
            txtDonViMua.Location = new Point(533, 25);
            txtDonViMua.Name = "txtDonViMua";
            txtDonViMua.Size = new Size(154, 23);
            txtDonViMua.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(424, 30);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 28;
            label2.Text = "Đơn vị mua";
            // 
            // dtpNgayMua
            // 
            dtpNgayMua.CustomFormat = "dd/MM/yyyy";
            dtpNgayMua.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayMua.Format = DateTimePickerFormat.Custom;
            dtpNgayMua.Location = new Point(533, 71);
            dtpNgayMua.Name = "dtpNgayMua";
            dtpNgayMua.Size = new Size(154, 23);
            dtpNgayMua.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(424, 72);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 16;
            label9.Text = "Ngày mua";
            // 
            // txtMaPhieuMua
            // 
            txtMaPhieuMua.ForeColor = Color.Black;
            txtMaPhieuMua.Location = new Point(127, 25);
            txtMaPhieuMua.Name = "txtMaPhieuMua";
            txtMaPhieuMua.Size = new Size(154, 23);
            txtMaPhieuMua.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(11, 30);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 8;
            label8.Text = "Mã phiếu mua";
            // 
            // btnDatSach
            // 
            btnDatSach.BackColor = Color.SeaGreen;
            btnDatSach.FlatStyle = FlatStyle.Flat;
            btnDatSach.ForeColor = Color.White;
            btnDatSach.Location = new Point(859, 323);
            btnDatSach.Name = "btnDatSach";
            btnDatSach.Size = new Size(75, 26);
            btnDatSach.TabIndex = 25;
            btnDatSach.Text = "Đặt";
            btnDatSach.UseVisualStyleBackColor = false;
            btnDatSach.Click += btnDatSach_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDSMua);
            panel2.Location = new Point(31, 261);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 221);
            panel2.TabIndex = 22;
            // 
            // dgvDSMua
            // 
            dgvDSMua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSMua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSMua.Dock = DockStyle.Fill;
            dgvDSMua.Location = new Point(0, 0);
            dgvDSMua.Name = "dgvDSMua";
            dgvDSMua.RowHeadersVisible = false;
            dgvDSMua.RowHeadersWidth = 51;
            dgvDSMua.RowTemplate.Height = 25;
            dgvDSMua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSMua.Size = new Size(808, 221);
            dgvDSMua.TabIndex = 0;
            dgvDSMua.CellClick += dgvDSMua_CellClick;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SeaGreen;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(859, 167);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 26);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.SeaGreen;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(859, 210);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 26);
            btnHuy.TabIndex = 27;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmPhieuMua
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 495);
            Controls.Add(btnHuy);
            Controls.Add(btnXemThongTin);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(btnDatSach);
            Controls.Add(panel2);
            Controls.Add(btnXoa);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPhieuMua";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmPhieuMua";
            Load += frmPhieuMua_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSMua).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnXemThongTin;
        private Button btnThem;
        private Button btnSua;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Panel panel1;
        private GroupBox groupBox4;
        private Label label1;
        private TextBox txtDonViMua;
        private Label label2;
        private DateTimePicker dtpNgayMua;
        private Label label9;
        private TextBox txtMaPhieuMua;
        private Label label8;
        private Button btnDatSach;
        private Panel panel2;
        private Button btnXoa;
        private TextBox txtTenNXB;
        private DataGridView dgvDSMua;
        private Button btnHuy;
    }
}