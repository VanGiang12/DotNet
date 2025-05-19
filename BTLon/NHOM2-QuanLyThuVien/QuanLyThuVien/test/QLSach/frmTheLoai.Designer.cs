namespace test
{
    partial class frmTheLoai
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
            dgvHienThi = new DataGridView();
            panel3 = new Panel();
            btnThoat = new Button();
            panel2 = new Panel();
            btnHienThi = new Button();
            label5 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenTheLoai = new TextBox();
            txtMaTheLoai = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            radMaTheLoai = new RadioButton();
            btnTim = new Button();
            txtTim = new TextBox();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            radTenTheLoai = new RadioButton();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // panel3
            // 
            panel3.Controls.Add(dgvHienThi);
            panel3.Location = new Point(442, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(506, 471);
            panel3.TabIndex = 5;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SeaGreen;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(211, 219);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnHienThi);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtTenTheLoai);
            panel2.Controls.Add(txtMaTheLoai);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 310);
            panel2.TabIndex = 4;
            // 
            // btnHienThi
            // 
            btnHienThi.BackColor = Color.SeaGreen;
            btnHienThi.FlatStyle = FlatStyle.Flat;
            btnHienThi.ForeColor = Color.White;
            btnHienThi.Location = new Point(76, 219);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(75, 23);
            btnHienThi.TabIndex = 11;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = false;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(156, 17);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 10;
            label5.Text = "Thông tin";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SeaGreen;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(276, 169);
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
            btnSua.Location = new Point(156, 169);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SeaGreen;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(32, 169);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenTheLoai
            // 
            txtTenTheLoai.Location = new Point(130, 109);
            txtTenTheLoai.Name = "txtTenTheLoai";
            txtTenTheLoai.Size = new Size(199, 23);
            txtTenTheLoai.TabIndex = 4;
            // 
            // txtMaTheLoai
            // 
            txtMaTheLoai.Location = new Point(130, 62);
            txtMaTheLoai.Name = "txtMaTheLoai";
            txtMaTheLoai.Size = new Size(199, 23);
            txtMaTheLoai.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 112);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên thể loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 65);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã thể loại";
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
            // radMaTheLoai
            // 
            radMaTheLoai.AutoSize = true;
            radMaTheLoai.Location = new Point(53, 22);
            radMaTheLoai.Name = "radMaTheLoai";
            radMaTheLoai.Size = new Size(84, 19);
            radMaTheLoai.TabIndex = 0;
            radMaTheLoai.TabStop = true;
            radMaTheLoai.Text = "Mã thể loại";
            radMaTheLoai.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.SeaGreen;
            btnTim.Dock = DockStyle.Fill;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(288, 0);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(80, 30);
            btnTim.TabIndex = 3;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // txtTim
            // 
            txtTim.Dock = DockStyle.Left;
            txtTim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTim.Location = new Point(0, 0);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(288, 29);
            txtTim.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnTim);
            panel4.Controls.Add(txtTim);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 68);
            panel4.Name = "panel4";
            panel4.Size = new Size(368, 30);
            panel4.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(radTenTheLoai);
            groupBox1.Controls.Add(radMaTheLoai);
            groupBox1.Location = new Point(14, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 101);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // radTenTheLoai
            // 
            radTenTheLoai.AutoSize = true;
            radTenTheLoai.Location = new Point(232, 22);
            radTenTheLoai.Name = "radTenTheLoai";
            radTenTheLoai.Size = new Size(85, 19);
            radTenTheLoai.TabIndex = 1;
            radTenTheLoai.TabStop = true;
            radTenTheLoai.Text = "Tên thể loại";
            radTenTheLoai.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 137);
            panel1.TabIndex = 3;
            // 
            // frmTheLoai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 495);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "frmTheLoai";
            Text = "frmTheLoai";
            Load += frmTheLoai_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHienThi;
        private Panel panel3;
        private Button btnThoat;
        private Panel panel2;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenTheLoai;
        private TextBox txtMaTheLoai;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton radMaTheLoai;
        private Button btnTim;
        private TextBox txtTim;
        private Panel panel4;
        private GroupBox groupBox1;
        private RadioButton radTenTheLoai;
        private Panel panel1;
        private Label label5;
        private Button btnHienThi;
    }
}