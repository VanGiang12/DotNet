namespace test.NhapSach
{
    partial class frmDatSach
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
            txtNXB = new TextBox();
            label3 = new Label();
            txtSoLuong = new TextBox();
            txtTenSach = new TextBox();
            txtMaSach = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgvDSMua = new DataGridView();
            btnDat = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSMua).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 142);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtNXB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(txtTenSach);
            groupBox1.Controls.Add(txtMaSach);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(671, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // txtNXB
            // 
            txtNXB.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNXB.Location = new Point(444, 33);
            txtNXB.Name = "txtNXB";
            txtNXB.Size = new Size(207, 23);
            txtNXB.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(354, 38);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 12;
            label3.Text = "Nhà xuất bản";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(444, 83);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(207, 23);
            txtSoLuong.TabIndex = 11;
            // 
            // txtTenSach
            // 
            txtTenSach.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenSach.Location = new Point(98, 88);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(207, 23);
            txtTenSach.TabIndex = 7;
            // 
            // txtMaSach
            // 
            txtMaSach.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaSach.Location = new Point(98, 35);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(207, 23);
            txtMaSach.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(354, 88);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 91);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên sách";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã sách";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDSMua);
            panel2.Location = new Point(12, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(927, 309);
            panel2.TabIndex = 1;
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
            dgvDSMua.Size = new Size(927, 309);
            dgvDSMua.TabIndex = 0;
            dgvDSMua.CellClick += dgvDSMua_CellClick;
            // 
            // btnDat
            // 
            btnDat.BackColor = Color.SeaGreen;
            btnDat.FlatStyle = FlatStyle.Flat;
            btnDat.ForeColor = Color.White;
            btnDat.Location = new Point(836, 92);
            btnDat.Name = "btnDat";
            btnDat.Size = new Size(103, 26);
            btnDat.TabIndex = 21;
            btnDat.Text = "Đặt";
            btnDat.UseVisualStyleBackColor = false;
            btnDat.Click += btnDat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SeaGreen;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(710, 38);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 26);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SeaGreen;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(836, 38);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 26);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SeaGreen;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(710, 92);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 26);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmDatSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 495);
            Controls.Add(btnDat);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "frmDatSach";
            Text = "frmDatSach";
            Load += frmDatSach_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSMua).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txtSoLuong;
        private TextBox txtTenSach;
        private TextBox txtMaSach;
        private Panel panel2;
        private DataGridView dgvDSMua;
        private Button btnDat;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtNXB;
        private Label label3;
    }
}