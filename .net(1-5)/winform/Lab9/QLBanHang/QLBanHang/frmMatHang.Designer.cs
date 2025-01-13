namespace QLBanHang
{
    partial class frmMatHang
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
            btnTimKiem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            txtTenMH = new TextBox();
            txtMaMH = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtDVT = new TextBox();
            dgvMatHang = new DataGridView();
            groupBox2 = new GroupBox();
            btnThem = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatHang).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.Location = new Point(457, 247);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(60, 23);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.Location = new Point(283, 247);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(60, 23);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Location = new Point(370, 247);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(60, 23);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.Location = new Point(544, 247);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(60, 23);
            btnThoat.TabIndex = 23;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtTenMH
            // 
            txtTenMH.Anchor = AnchorStyles.None;
            txtTenMH.Location = new Point(141, 93);
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(121, 23);
            txtTenMH.TabIndex = 6;
            // 
            // txtMaMH
            // 
            txtMaMH.Anchor = AnchorStyles.None;
            txtMaMH.Location = new Point(141, 46);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(121, 23);
            txtMaMH.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(44, 144);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 2;
            label4.Text = "Đơn vị tính";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(44, 99);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên mặt hàng";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(44, 46);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã mặt hàng";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(txtDVT);
            groupBox1.Controls.Add(txtTenMH);
            groupBox1.Controls.Add(txtMaMH);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(164, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 201);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin KH";
            // 
            // txtDVT
            // 
            txtDVT.Anchor = AnchorStyles.None;
            txtDVT.Location = new Point(141, 141);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(121, 23);
            txtDVT.TabIndex = 7;
            // 
            // dgvMatHang
            // 
            dgvMatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatHang.Dock = DockStyle.Fill;
            dgvMatHang.Location = new Point(3, 19);
            dgvMatHang.Name = "dgvMatHang";
            dgvMatHang.RowTemplate.Height = 25;
            dgvMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMatHang.Size = new Size(467, 145);
            dgvMatHang.TabIndex = 0;
            dgvMatHang.CellClick += dgvMatHang_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(dgvMatHang);
            groupBox2.Location = new Point(164, 276);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 167);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Location = new Point(196, 247);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(60, 23);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(244, 8);
            label1.Name = "label1";
            label1.Size = new Size(278, 29);
            label1.TabIndex = 16;
            label1.Text = "THÔNG TIN MẶT HÀNG";
            // 
            // frmMatHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTimKiem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Name = "frmMatHang";
            Text = "frmMatHang";
            Load += frmMatHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatHang).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTimKiem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private TextBox txtTenMH;
        private TextBox txtMaMH;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtDVT;
        private DataGridView dgvMatHang;
        private GroupBox groupBox2;
        private Button btnThem;
        private Label label1;
    }
}