namespace QLBanHang
{
    partial class frmKhachHang
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
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvKhachHang = new DataGridView();
            groupBox1 = new GroupBox();
            txtDiaChi = new RichTextBox();
            cboGioiTinh = new ComboBox();
            txtDienThoai = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnTimKiem = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(208, 29);
            label1.Name = "label1";
            label1.Size = new Size(309, 29);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(dgvKhachHang);
            groupBox2.Location = new Point(128, 297);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 167);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.Anchor = AnchorStyles.None;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(3, 17);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowTemplate.Height = 25;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(470, 147);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(134, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 180);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin KH";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.None;
            txtDiaChi.Location = new Point(339, 18);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(119, 80);
            txtDiaChi.TabIndex = 13;
            txtDiaChi.Text = "";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.Anchor = AnchorStyles.None;
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(114, 120);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(121, 23);
            cboGioiTinh.TabIndex = 12;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Anchor = AnchorStyles.None;
            txtDienThoai.Location = new Point(339, 120);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(119, 21);
            txtDienThoai.TabIndex = 11;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(254, 126);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 9;
            label5.Text = "Điện thoại";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(254, 33);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 8;
            label6.Text = "Địa chỉ";
            // 
            // txtTenKH
            // 
            txtTenKH.Anchor = AnchorStyles.None;
            txtTenKH.Location = new Point(114, 77);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(121, 21);
            txtTenKH.TabIndex = 6;
            // 
            // txtMaKH
            // 
            txtMaKH.Anchor = AnchorStyles.None;
            txtMaKH.Location = new Point(114, 30);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(121, 21);
            txtMaKH.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(17, 128);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 2;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(17, 83);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "Họ tên";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(17, 30);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã khách hàng";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.Location = new Point(508, 268);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(60, 23);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Location = new Point(334, 268);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(60, 23);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.Location = new Point(247, 268);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(60, 23);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Location = new Point(160, 268);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(60, 23);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.Location = new Point(421, 268);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(60, 23);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 476);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnTimKiem);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            Load += frmKhachHang_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnTimKiem;
        private TextBox txtDienThoai;
        private Label label5;
        private Label label6;
        private DataGridView dgvKhachHang;
        private ComboBox cboGioiTinh;
        private RichTextBox txtDiaChi;
    }
}