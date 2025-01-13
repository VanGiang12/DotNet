namespace SqlNhanVien
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaNV = new TextBox();
            txtTenNV = new TextBox();
            radNam = new RadioButton();
            groupBox1 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtPhone = new TextBox();
            txtDiaChi = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            radNu = new RadioButton();
            groupBox2 = new GroupBox();
            dataGridViewDisPlay = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDisPlay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 85);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 73);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 28);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 143);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 147);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 5;
            label6.Text = "Số điện thoại";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(107, 25);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(100, 23);
            txtMaNV.TabIndex = 6;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(108, 82);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(100, 23);
            txtTenNV.TabIndex = 7;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(98, 141);
            radNam.Name = "radNam";
            radNam.Size = new Size(49, 19);
            radNam.TabIndex = 8;
            radNam.TabStop = true;
            radNam.Text = "nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(radNu);
            groupBox1.Controls.Add(radNam);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(548, 184);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(464, 141);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(464, 85);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(463, 32);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(332, 143);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(114, 23);
            txtPhone.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(316, 70);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ScrollBars = ScrollBars.Vertical;
            txtDiaChi.Size = new Size(130, 61);
            txtDiaChi.TabIndex = 11;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(316, 28);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(130, 23);
            dtpNgaySinh.TabIndex = 10;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(169, 143);
            radNu.Name = "radNu";
            radNu.Size = new Size(39, 19);
            radNu.TabIndex = 9;
            radNu.TabStop = true;
            radNu.Text = "nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewDisPlay);
            groupBox2.Location = new Point(12, 211);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(548, 217);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // dataGridViewDisPlay
            // 
            dataGridViewDisPlay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDisPlay.BackgroundColor = SystemColors.ControlLight;
            dataGridViewDisPlay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDisPlay.Dock = DockStyle.Fill;
            dataGridViewDisPlay.Location = new Point(3, 19);
            dataGridViewDisPlay.Name = "dataGridViewDisPlay";
            dataGridViewDisPlay.ReadOnly = true;
            dataGridViewDisPlay.RowTemplate.Height = 25;
            dataGridViewDisPlay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDisPlay.Size = new Size(542, 195);
            dataGridViewDisPlay.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 440);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDisPlay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMaNV;
        private TextBox txtTenNV;
        private RadioButton radNam;
        private GroupBox groupBox1;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtPhone;
        private TextBox txtDiaChi;
        private DateTimePicker dtpNgaySinh;
        private RadioButton radNu;
        private Button btnXoa;
        private GroupBox groupBox2;
        private DataGridView dataGridViewDisPlay;
    }
}