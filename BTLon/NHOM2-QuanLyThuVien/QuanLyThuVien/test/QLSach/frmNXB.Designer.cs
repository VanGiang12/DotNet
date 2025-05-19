namespace test
{
    partial class frmNXB
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            panel4 = new Panel();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            radTenNXB = new RadioButton();
            radMaNXB = new RadioButton();
            label1 = new Label();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            txtTenNXB = new TextBox();
            txtMaNXB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dgvHienThi = new DataGridView();
            panel2 = new Panel();
            btnHienThi = new Button();
            label5 = new Label();
            txtLienHe = new TextBox();
            label4 = new Label();
            btnThem = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 137);
            panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(radTenNXB);
            groupBox1.Controls.Add(radMaNXB);
            groupBox1.Location = new Point(14, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 101);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnTimKiem);
            panel4.Controls.Add(txtTimKiem);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 68);
            panel4.Name = "panel4";
            panel4.Size = new Size(368, 30);
            panel4.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.SeaGreen;
            btnTimKiem.Dock = DockStyle.Fill;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(288, 0);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(80, 30);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Dock = DockStyle.Left;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(0, 0);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(288, 29);
            txtTimKiem.TabIndex = 2;
            // 
            // radTenNXB
            // 
            radTenNXB.AutoSize = true;
            radTenNXB.Location = new Point(232, 22);
            radTenNXB.Name = "radTenNXB";
            radTenNXB.Size = new Size(69, 19);
            radTenNXB.TabIndex = 1;
            radTenNXB.TabStop = true;
            radTenNXB.Text = "Tên NXB";
            radTenNXB.UseVisualStyleBackColor = true;
            // 
            // radMaNXB
            // 
            radMaNXB.AutoSize = true;
            radMaNXB.Location = new Point(53, 22);
            radMaNXB.Name = "radMaNXB";
            radMaNXB.Size = new Size(68, 19);
            radMaNXB.TabIndex = 0;
            radMaNXB.TabStop = true;
            radMaNXB.Text = "Mã NXB";
            radMaNXB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(130, 5);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm thông tin";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SeaGreen;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(217, 264);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SeaGreen;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(287, 218);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SeaGreen;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(158, 218);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // txtTenNXB
            // 
            txtTenNXB.Location = new Point(130, 124);
            txtTenNXB.Name = "txtTenNXB";
            txtTenNXB.Size = new Size(199, 23);
            txtTenNXB.TabIndex = 4;
            // 
            // txtMaNXB
            // 
            txtMaNXB.Location = new Point(130, 77);
            txtMaNXB.Name = "txtMaNXB";
            txtMaNXB.Size = new Size(199, 23);
            txtMaNXB.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 127);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên NXB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 80);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã NXB";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvHienThi);
            panel3.Location = new Point(442, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(506, 471);
            panel3.TabIndex = 8;
            // 
            // dgvHienThi
            // 
            dgvHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHienThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHienThi.Dock = DockStyle.Fill;
            dgvHienThi.Location = new Point(0, 0);
            dgvHienThi.Name = "dgvHienThi";
            dgvHienThi.RowHeadersVisible = false;
            dgvHienThi.RowTemplate.Height = 25;
            dgvHienThi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHienThi.Size = new Size(506, 471);
            dgvHienThi.TabIndex = 0;
            dgvHienThi.CellClick += dgvHienThi_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnHienThi);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtLienHe);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtTenNXB);
            panel2.Controls.Add(txtMaNXB);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 310);
            panel2.TabIndex = 7;
            // 
            // btnHienThi
            // 
            btnHienThi.BackColor = Color.SeaGreen;
            btnHienThi.FlatStyle = FlatStyle.Flat;
            btnHienThi.ForeColor = Color.White;
            btnHienThi.Location = new Point(89, 264);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(75, 23);
            btnHienThi.TabIndex = 13;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = false;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(158, 25);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 12;
            label5.Text = "Thông tin";
            // 
            // txtLienHe
            // 
            txtLienHe.Location = new Point(130, 171);
            txtLienHe.Name = "txtLienHe";
            txtLienHe.Size = new Size(199, 23);
            txtLienHe.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 174);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Liên hệ";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SeaGreen;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(17, 218);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // frmNXB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 495);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            ForeColor = Color.Black;
            Name = "frmNXB";
            Text = "frmNXB";
            Load += frmNXB_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel4;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private RadioButton radTenNXB;
        private RadioButton radMaNXB;
        private Label label1;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private TextBox txtTenNXB;
        private TextBox txtMaNXB;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private DataGridView dgvHienThi;
        private Panel panel2;
        private TextBox txtLienHe;
        private Label label4;
        private Label label5;
        private Button btnThem;
        private Button btnHienThi;
    }
}