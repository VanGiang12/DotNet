namespace QLSach
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtSDT = new TextBox();
            label6 = new Label();
            txtDiaCHi = new TextBox();
            label5 = new Label();
            txtCoQuan = new TextBox();
            label4 = new Label();
            txtTen = new TextBox();
            label3 = new Label();
            txtMa = new TextBox();
            label2 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            groupBox2 = new GroupBox();
            dgvDanhSach = new DataGridView();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(172, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN ĐỘC GIẢ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDiaCHi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCoQuan);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(18, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 185);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết độc giả";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(134, 156);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(319, 23);
            txtSDT.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 159);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 8;
            label6.Text = "Số điện thoại";
            // 
            // txtDiaCHi
            // 
            txtDiaCHi.Location = new Point(134, 116);
            txtDiaCHi.Name = "txtDiaCHi";
            txtDiaCHi.Size = new Size(319, 23);
            txtDiaCHi.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 119);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 6;
            label5.Text = "Địa chỉ";
            // 
            // txtCoQuan
            // 
            txtCoQuan.Location = new Point(134, 84);
            txtCoQuan.Name = "txtCoQuan";
            txtCoQuan.Size = new Size(319, 23);
            txtCoQuan.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 87);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 4;
            label4.Text = "Cơ quan";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(134, 55);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(319, 23);
            txtTen.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 58);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên độc giả";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(134, 22);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(319, 23);
            txtMa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 25);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã độc giả";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(51, 228);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(148, 228);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(244, 228);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(337, 228);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDanhSach);
            groupBox2.Location = new Point(12, 257);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(525, 173);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách độc giả";
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Dock = DockStyle.Fill;
            dgvDanhSach.Location = new Point(3, 19);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.RowTemplate.Height = 25;
            dgvDanhSach.Size = new Size(519, 151);
            dgvDanhSach.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(428, 228);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 442);
            Controls.Add(btnThoat);
            Controls.Add(groupBox2);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtDiaCHi;
        private Label label5;
        private TextBox txtCoQuan;
        private Label label4;
        private TextBox txtTen;
        private Label label3;
        private TextBox txtMa;
        private Label label2;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private GroupBox groupBox2;
        private DataGridView dgvDanhSach;
        private TextBox txtSDT;
        private Label label6;
        private Button btnThoat;
    }
}