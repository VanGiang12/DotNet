namespace QLSach
{
    partial class frmSach
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
            label1 = new Label();
            label2 = new Label();
            txtMaSach = new TextBox();
            txtTenSach = new TextBox();
            label3 = new Label();
            txtTacGia = new TextBox();
            label4 = new Label();
            txtNhaXB = new TextBox();
            label5 = new Label();
            txtNamXB = new TextBox();
            label6 = new Label();
            txtSoLuong = new TextBox();
            label7 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            dgvDanhSach = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 26);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN SÁCH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 57);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã sách";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(115, 54);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(253, 23);
            txtMaSach.TabIndex = 2;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(115, 97);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(253, 23);
            txtTenSach.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 100);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "Tên sách";
            // 
            // txtTacGia
            // 
            txtTacGia.Location = new Point(115, 139);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(253, 23);
            txtTacGia.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 142);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 5;
            label4.Text = "Tác giả";
            // 
            // txtNhaXB
            // 
            txtNhaXB.Location = new Point(115, 179);
            txtNhaXB.Name = "txtNhaXB";
            txtNhaXB.Size = new Size(253, 23);
            txtNhaXB.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 182);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 7;
            label5.Text = "Nhà xuất bản";
            // 
            // txtNamXB
            // 
            txtNamXB.Location = new Point(115, 221);
            txtNamXB.Name = "txtNamXB";
            txtNamXB.Size = new Size(253, 23);
            txtNamXB.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 224);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 9;
            label6.Text = "Năm xb";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(115, 266);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(253, 23);
            txtSoLuong.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 269);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 11;
            label7.Text = "Số lượng";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(416, 99);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(416, 142);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(416, 184);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(416, 224);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 16;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Location = new Point(30, 312);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.RowTemplate.Height = 25;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSach.Size = new Size(461, 150);
            dgvDanhSach.TabIndex = 17;
            dgvDanhSach.CellClick += dgvDanhSach_CellClick;
            // 
            // frmSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 474);
            Controls.Add(dgvDanhSach);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSoLuong);
            Controls.Add(label7);
            Controls.Add(txtNamXB);
            Controls.Add(label6);
            Controls.Add(txtNhaXB);
            Controls.Add(label5);
            Controls.Add(txtTacGia);
            Controls.Add(label4);
            Controls.Add(txtTenSach);
            Controls.Add(label3);
            Controls.Add(txtMaSach);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSach";
            Load += frmSach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaSach;
        private TextBox txtTenSach;
        private Label label3;
        private TextBox txtTacGia;
        private Label label4;
        private TextBox txtNhaXB;
        private Label label5;
        private TextBox txtNamXB;
        private Label label6;
        private TextBox txtSoLuong;
        private Label label7;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private DataGridView dgvDanhSach;
    }
}