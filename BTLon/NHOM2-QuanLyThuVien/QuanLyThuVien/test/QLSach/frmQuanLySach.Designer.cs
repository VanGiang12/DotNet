namespace test
{
    partial class frmQuanLySach
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySach));
            btnThoat = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvDanhSachSach = new DataGridView();
            cboTimKiem = new ComboBox();
            label9 = new Label();
            txtNamXuatBan = new TextBox();
            txtSoLuong = new TextBox();
            cboNXB = new ComboBox();
            cboTheLoai = new ComboBox();
            cboTacGia = new ComboBox();
            txtTenSach = new TextBox();
            txtMaSach = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            txtKhoa = new TextBox();
            label10 = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnXoa = new Button();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSach).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SeaGreen;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(825, 175);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(123, 23);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SeaGreen;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(825, 90);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(123, 23);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SeaGreen;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(825, 45);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(123, 23);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvDanhSachSach
            // 
            dgvDanhSachSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachSach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDanhSachSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhSachSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDanhSachSach.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhSachSach.Location = new Point(10, 234);
            dgvDanhSachSach.Name = "dgvDanhSachSach";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDanhSachSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSachSach.RowHeadersVisible = false;
            dgvDanhSachSach.RowTemplate.Height = 25;
            dgvDanhSachSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachSach.Size = new Size(938, 249);
            dgvDanhSachSach.TabIndex = 0;
            dgvDanhSachSach.CellClick += dgvDanhSachSach_CellClick;
            // 
            // cboTimKiem
            // 
            cboTimKiem.FormattingEnabled = true;
            cboTimKiem.Items.AddRange(new object[] { "Tất cả", "Mã sách", "Tên sách", "Tác giả", "Thể loại", "Nhà xuất bản", "Năm xuất bản" });
            cboTimKiem.Location = new Point(647, 45);
            cboTimKiem.Name = "cboTimKiem";
            cboTimKiem.Size = new Size(125, 23);
            cboTimKiem.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(680, 18);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 15;
            label9.Text = "TÌM KIẾM";
            // 
            // txtNamXuatBan
            // 
            txtNamXuatBan.BorderStyle = BorderStyle.FixedSingle;
            txtNamXuatBan.Location = new Point(482, 106);
            txtNamXuatBan.Name = "txtNamXuatBan";
            txtNamXuatBan.Size = new Size(138, 23);
            txtNamXuatBan.TabIndex = 14;
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Location = new Point(482, 60);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(138, 23);
            txtSoLuong.TabIndex = 13;
            // 
            // cboNXB
            // 
            cboNXB.FormattingEnabled = true;
            cboNXB.Location = new Point(482, 151);
            cboNXB.Name = "cboNXB";
            cboNXB.Size = new Size(138, 23);
            cboNXB.TabIndex = 12;
            cboNXB.TextChanged += cboNXB_TextChanged;
            // 
            // cboTheLoai
            // 
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(254, 151);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(139, 23);
            cboTheLoai.TabIndex = 11;
            cboTheLoai.TextChanged += cboTheLoai_TextChanged;
            // 
            // cboTacGia
            // 
            cboTacGia.FormattingEnabled = true;
            cboTacGia.Location = new Point(254, 106);
            cboTacGia.Name = "cboTacGia";
            cboTacGia.Size = new Size(139, 23);
            cboTacGia.TabIndex = 10;
            cboTacGia.TextChanged += cboTacGia_TextChanged;
            // 
            // txtTenSach
            // 
            txtTenSach.BorderStyle = BorderStyle.FixedSingle;
            txtTenSach.Location = new Point(254, 60);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(139, 23);
            txtTenSach.TabIndex = 9;
            // 
            // txtMaSach
            // 
            txtMaSach.BorderStyle = BorderStyle.FixedSingle;
            txtMaSach.Location = new Point(254, 14);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(139, 23);
            txtMaSach.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(410, 62);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 7;
            label8.Text = "Số lượng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 109);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 6;
            label7.Text = "Năm XB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(434, 154);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 5;
            label6.Text = "NXB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 154);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "Thể loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 109);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Tác giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 63);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 18);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã sách";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtKhoa);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(txtTimKiem);
            panel2.Controls.Add(cboTimKiem);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtNamXuatBan);
            panel2.Controls.Add(txtSoLuong);
            panel2.Controls.Add(cboNXB);
            panel2.Controls.Add(cboTheLoai);
            panel2.Controls.Add(cboTacGia);
            panel2.Controls.Add(txtTenSach);
            panel2.Controls.Add(txtMaSach);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel1);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(10, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(792, 198);
            panel2.TabIndex = 7;
            // 
            // txtKhoa
            // 
            txtKhoa.BorderStyle = BorderStyle.FixedSingle;
            txtKhoa.Location = new Point(482, 18);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.Size = new Size(138, 23);
            txtKhoa.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(430, 20);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 18;
            label10.Text = "Khoa";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.SeaGreen;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(711, 116);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(61, 23);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(647, 74);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(125, 23);
            txtTimKiem.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(20, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(134, 160);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.SeaGreen;
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 124);
            label1.Name = "label1";
            label1.Size = new Size(134, 36);
            label1.TabIndex = 1;
            label1.Text = "Choose File";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 124);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SeaGreen;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(825, 134);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(123, 23);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "CaRo - Copy.png");
            // 
            // frmQuanLySach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(960, 495);
            Controls.Add(dgvDanhSachSach);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(panel2);
            Controls.Add(btnXoa);
            Name = "frmQuanLySach";
            Text = "frmQuanLySach";
            Load += frmQuanLySach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSach).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnThoat;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvDanhSachSach;
        private ComboBox cboTimKiem;
        private Label label9;
        private TextBox txtNamXuatBan;
        private TextBox txtSoLuong;
        private ComboBox cboNXB;
        private ComboBox cboTheLoai;
        private ComboBox cboTacGia;
        private TextBox txtTenSach;
        private TextBox txtMaSach;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnXoa;
        private ImageList imageList1;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private TextBox txtKhoa;
        private Label label10;
    }
}