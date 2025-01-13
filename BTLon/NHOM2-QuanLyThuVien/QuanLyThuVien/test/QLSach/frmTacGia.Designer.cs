namespace test
{
    partial class frmTacGia
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
            radTatCa = new RadioButton();
            panel4 = new Panel();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            radTenTG = new RadioButton();
            radMaTG = new RadioButton();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtLienhe = new TextBox();
            txtTenTG = new TextBox();
            txtMaTG = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dgvTacGia = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTacGia).BeginInit();
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
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radTatCa);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(radTenTG);
            groupBox1.Controls.Add(radMaTG);
            groupBox1.Location = new Point(14, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 101);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // radTatCa
            // 
            radTatCa.AutoSize = true;
            radTatCa.Location = new Point(35, 22);
            radTatCa.Name = "radTatCa";
            radTatCa.Size = new Size(56, 19);
            radTatCa.TabIndex = 5;
            radTatCa.TabStop = true;
            radTatCa.Text = "Tất cả";
            radTatCa.UseVisualStyleBackColor = true;
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
            // radTenTG
            // 
            radTenTG.AutoSize = true;
            radTenTG.Location = new Point(232, 22);
            radTenTG.Name = "radTenTG";
            radTenTG.Size = new Size(81, 19);
            radTenTG.TabIndex = 1;
            radTenTG.TabStop = true;
            radTenTG.Text = "Tên tác giả";
            radTenTG.UseVisualStyleBackColor = true;
            // 
            // radMaTG
            // 
            radMaTG.AutoSize = true;
            radMaTG.Location = new Point(129, 22);
            radMaTG.Name = "radMaTG";
            radMaTG.Size = new Size(80, 19);
            radMaTG.TabIndex = 0;
            radMaTG.TabStop = true;
            radMaTG.Text = "Mã tác giả";
            radMaTG.UseVisualStyleBackColor = true;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtLienhe);
            panel2.Controls.Add(txtTenTG);
            panel2.Controls.Add(txtMaTG);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 310);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(160, 21);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 2;
            label5.Text = "Thông tin";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SeaGreen;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(313, 223);
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
            btnXoa.Location = new Point(217, 223);
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
            btnSua.Location = new Point(119, 223);
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
            btnThem.Location = new Point(17, 223);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtLienhe
            // 
            txtLienhe.Location = new Point(119, 172);
            txtLienhe.Name = "txtLienhe";
            txtLienhe.Size = new Size(199, 23);
            txtLienhe.TabIndex = 5;
            // 
            // txtTenTG
            // 
            txtTenTG.Location = new Point(120, 127);
            txtTenTG.Name = "txtTenTG";
            txtTenTG.Size = new Size(199, 23);
            txtTenTG.TabIndex = 4;
            // 
            // txtMaTG
            // 
            txtMaTG.Location = new Point(120, 80);
            txtMaTG.Name = "txtMaTG";
            txtMaTG.Size = new Size(199, 23);
            txtMaTG.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 175);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 2;
            label4.Text = "Liên hệ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 130);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên tác giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 83);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã tác giả";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvTacGia);
            panel3.Location = new Point(442, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(506, 471);
            panel3.TabIndex = 2;
            // 
            // dgvTacGia
            // 
            dgvTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTacGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTacGia.Dock = DockStyle.Fill;
            dgvTacGia.Location = new Point(0, 0);
            dgvTacGia.Name = "dgvTacGia";
            dgvTacGia.RowHeadersVisible = false;
            dgvTacGia.RowTemplate.Height = 25;
            dgvTacGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTacGia.Size = new Size(506, 471);
            dgvTacGia.TabIndex = 0;
            dgvTacGia.CellClick += dgvTacGia_CellClick;
            // 
            // frmTacGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 495);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "frmTacGia";
            Text = "frmTacGia";
            Load += frmTacGia_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTacGia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox1;
        private Panel panel4;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private RadioButton radTenTG;
        private RadioButton radMaTG;
        private Label label1;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtLienhe;
        private TextBox txtTenTG;
        private TextBox txtMaTG;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvTacGia;
        private Label label5;
        private RadioButton radTatCa;
    }
}