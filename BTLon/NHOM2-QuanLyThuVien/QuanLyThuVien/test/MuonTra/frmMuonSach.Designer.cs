namespace test
{
    partial class frmMuonSach
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
            groupBox2 = new GroupBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            panel1 = new Panel();
            gbinformation = new GroupBox();
            txtSoThe = new TextBox();
            dtpNgayTra = new DateTimePicker();
            dtpNgayHenTra = new DateTimePicker();
            dtpNgayMuon = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtSLMuon = new TextBox();
            txtMaPhieuMuon = new TextBox();
            label8 = new Label();
            label7 = new Label();
            cboTenDocGia = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            txtTenTacGia = new TextBox();
            txtSLCon = new TextBox();
            cboTenSach = new ComboBox();
            cboMaSach = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            panel2 = new Panel();
            dgvDSMuonTra = new DataGridView();
            btnTra = new Button();
            btnMuon = new Button();
            btnHuy = new Button();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            gbinformation.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSMuonTra).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(237, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(522, 69);
            groupBox2.TabIndex = 1;
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
            txtTimKiem.PlaceholderText = "Mã sách hoặc Tên độc giả hoặc không nhập gì để in tất cả";
            txtTimKiem.Size = new Size(434, 23);
            txtTimKiem.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(gbinformation);
            panel1.Controls.Add(groupBox3);
            panel1.Location = new Point(12, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 201);
            panel1.TabIndex = 2;
            // 
            // gbinformation
            // 
            gbinformation.Controls.Add(txtSoThe);
            gbinformation.Controls.Add(dtpNgayTra);
            gbinformation.Controls.Add(dtpNgayHenTra);
            gbinformation.Controls.Add(dtpNgayMuon);
            gbinformation.Controls.Add(label9);
            gbinformation.Controls.Add(label10);
            gbinformation.Controls.Add(label11);
            gbinformation.Controls.Add(txtSLMuon);
            gbinformation.Controls.Add(txtMaPhieuMuon);
            gbinformation.Controls.Add(label8);
            gbinformation.Controls.Add(label7);
            gbinformation.Controls.Add(cboTenDocGia);
            gbinformation.Controls.Add(label6);
            gbinformation.Controls.Add(label5);
            gbinformation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbinformation.Location = new Point(343, 13);
            gbinformation.Name = "gbinformation";
            gbinformation.Size = new Size(497, 169);
            gbinformation.TabIndex = 1;
            gbinformation.TabStop = false;
            gbinformation.Text = "Thông tin phiếu mượn";
            // 
            // txtSoThe
            // 
            txtSoThe.Location = new Point(112, 64);
            txtSoThe.Name = "txtSoThe";
            txtSoThe.ReadOnly = true;
            txtSoThe.Size = new Size(133, 23);
            txtSoThe.TabIndex = 26;
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.CustomFormat = "MM/dd/yyyy";
            dtpNgayTra.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.Location = new Point(340, 97);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(133, 23);
            dtpNgayTra.TabIndex = 25;
            // 
            // dtpNgayHenTra
            // 
            dtpNgayHenTra.CustomFormat = "MM/dd/yyyy";
            dtpNgayHenTra.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayHenTra.Format = DateTimePickerFormat.Custom;
            dtpNgayHenTra.Location = new Point(340, 62);
            dtpNgayHenTra.Name = "dtpNgayHenTra";
            dtpNgayHenTra.Size = new Size(133, 23);
            dtpNgayHenTra.TabIndex = 24;
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.CustomFormat = "MM/dd/yyyy";
            dtpNgayMuon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayMuon.Format = DateTimePickerFormat.Custom;
            dtpNgayMuon.Location = new Point(340, 28);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(133, 23);
            dtpNgayMuon.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(262, 29);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 16;
            label9.Text = "Ngày mượn";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(257, 65);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 17;
            label10.Text = "Ngày hẹn trả";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(280, 100);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 18;
            label11.Text = "Ngày trả";
            // 
            // txtSLMuon
            // 
            txtSLMuon.Location = new Point(112, 131);
            txtSLMuon.Name = "txtSLMuon";
            txtSLMuon.Size = new Size(133, 23);
            txtSLMuon.TabIndex = 15;
            // 
            // txtMaPhieuMuon
            // 
            txtMaPhieuMuon.Location = new Point(112, 24);
            txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            txtMaPhieuMuon.Size = new Size(133, 23);
            txtMaPhieuMuon.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(11, 29);
            label8.Name = "label8";
            label8.Size = new Size(92, 15);
            label8.TabIndex = 8;
            label8.Text = "Mã phiếu mượn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(11, 67);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 9;
            label7.Text = "Số thẻ";
            // 
            // cboTenDocGia
            // 
            cboTenDocGia.FormattingEnabled = true;
            cboTenDocGia.Location = new Point(112, 97);
            cboTenDocGia.Name = "cboTenDocGia";
            cboTenDocGia.Size = new Size(133, 23);
            cboTenDocGia.TabIndex = 12;
            cboTenDocGia.SelectedIndexChanged += cboTenDocGia_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(11, 100);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 10;
            label6.Text = "Tên độc giả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(11, 134);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 11;
            label5.Text = "SL mượn";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTenTacGia);
            groupBox3.Controls.Add(txtSLCon);
            groupBox3.Controls.Add(cboTenSach);
            groupBox3.Controls.Add(cboMaSach);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(14, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(302, 169);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sách";
            // 
            // txtTenTacGia
            // 
            txtTenTacGia.Location = new Point(97, 136);
            txtTenTacGia.Name = "txtTenTacGia";
            txtTenTacGia.Size = new Size(175, 23);
            txtTenTacGia.TabIndex = 7;
            // 
            // txtSLCon
            // 
            txtSLCon.Location = new Point(97, 102);
            txtSLCon.Name = "txtSLCon";
            txtSLCon.Size = new Size(175, 23);
            txtSLCon.TabIndex = 6;
            // 
            // cboTenSach
            // 
            cboTenSach.FormattingEnabled = true;
            cboTenSach.Location = new Point(97, 65);
            cboTenSach.Name = "cboTenSach";
            cboTenSach.Size = new Size(175, 23);
            cboTenSach.TabIndex = 5;
            cboTenSach.SelectedIndexChanged += cboTenSach_SelectedIndexChanged;
            // 
            // cboMaSach
            // 
            cboMaSach.FormattingEnabled = true;
            cboMaSach.Location = new Point(97, 31);
            cboMaSach.Name = "cboMaSach";
            cboMaSach.Size = new Size(175, 23);
            cboMaSach.TabIndex = 4;
            cboMaSach.SelectedIndexChanged += cboMaSach_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 139);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Tên tác giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 105);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Số lượng còn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 72);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên sách";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã sách";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SeaGreen;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(873, 179);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SeaGreen;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(873, 214);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDSMuonTra);
            panel2.Location = new Point(12, 303);
            panel2.Name = "panel2";
            panel2.Size = new Size(936, 180);
            panel2.TabIndex = 7;
            // 
            // dgvDSMuonTra
            // 
            dgvDSMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSMuonTra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSMuonTra.Dock = DockStyle.Fill;
            dgvDSMuonTra.Location = new Point(0, 0);
            dgvDSMuonTra.Name = "dgvDSMuonTra";
            dgvDSMuonTra.RowHeadersVisible = false;
            dgvDSMuonTra.RowTemplate.Height = 25;
            dgvDSMuonTra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSMuonTra.Size = new Size(936, 180);
            dgvDSMuonTra.TabIndex = 0;
            dgvDSMuonTra.CellClick += dgvDSMuonTra_CellClick;
            // 
            // btnTra
            // 
            btnTra.BackColor = Color.SeaGreen;
            btnTra.FlatStyle = FlatStyle.Flat;
            btnTra.ForeColor = Color.White;
            btnTra.Location = new Point(873, 146);
            btnTra.Name = "btnTra";
            btnTra.Size = new Size(75, 24);
            btnTra.TabIndex = 8;
            btnTra.Text = "Trả";
            btnTra.UseVisualStyleBackColor = false;
            btnTra.Click += btnTra_Click;
            // 
            // btnMuon
            // 
            btnMuon.BackColor = Color.SeaGreen;
            btnMuon.FlatStyle = FlatStyle.Flat;
            btnMuon.ForeColor = Color.White;
            btnMuon.Location = new Point(873, 112);
            btnMuon.Name = "btnMuon";
            btnMuon.Size = new Size(75, 24);
            btnMuon.TabIndex = 3;
            btnMuon.Text = "Mượn";
            btnMuon.UseVisualStyleBackColor = false;
            btnMuon.Click += btnMuon_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.SeaGreen;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(873, 246);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmMuonSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 495);
            Controls.Add(btnHuy);
            Controls.Add(btnTra);
            Controls.Add(panel2);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnMuon);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            ForeColor = Color.Black;
            Name = "frmMuonSach";
            Text = "frmMuonSach";
            Load += frmMuonSach_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            gbinformation.ResumeLayout(false);
            gbinformation.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSMuonTra).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Panel panel1;
        private Button btnSua;
        private Button btnXoa;
        private GroupBox gbinformation;
        private GroupBox groupBox3;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTenTacGia;
        private TextBox txtSLCon;
        private ComboBox cboTenSach;
        private ComboBox cboMaSach;
        private TextBox txtSLMuon;
        private TextBox txtMaPhieuMuon;
        private Label label8;
        private Label label7;
        private ComboBox cboTenDocGia;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpNgayHenTra;
        private DateTimePicker dtpNgayMuon;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel2;
        private DataGridView dgvDSMuonTra;
        private Button btnTra;
        private DateTimePicker dtpNgayTra;
        private TextBox txtSoThe;
        private Button btnMuon;
        private Button btnHuy;
    }
}