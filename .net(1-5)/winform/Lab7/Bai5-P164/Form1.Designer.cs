namespace Bai5_P164
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
            btnThoat = new Button();
            btnDSSVTruot = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnHienThi = new Button();
            txtDiemCNC = new TextBox();
            txtDiemVeKyThuat = new TextBox();
            txtNamSinh = new TextBox();
            txtTenSinhVien = new TextBox();
            txtMaSinhVien = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            listViewDSSV = new ListView();
            masinhvien = new ColumnHeader();
            tensinhvien = new ColumnHeader();
            namsinh = new ColumnHeader();
            diemkithuat = new ColumnHeader();
            diemcnc = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(290, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 17);
            label1.TabIndex = 0;
            label1.Text = "SINH VIÊN KHOA CƠ KHÍ";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnDSSVTruot);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnHienThi);
            groupBox1.Controls.Add(txtDiemCNC);
            groupBox1.Controls.Add(txtDiemVeKyThuat);
            groupBox1.Controls.Add(txtNamSinh);
            groupBox1.Controls.Add(txtTenSinhVien);
            groupBox1.Controls.Add(txtMaSinhVien);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(708, 205);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết Sinh viên khoa cơ khí";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnThoat.Location = new Point(627, 169);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDSSVTruot
            // 
            btnDSSVTruot.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDSSVTruot.Location = new Point(445, 169);
            btnDSSVTruot.Name = "btnDSSVTruot";
            btnDSSVTruot.Size = new Size(152, 23);
            btnDSSVTruot.TabIndex = 14;
            btnDSSVTruot.Text = "Danh sách sinh viên trượt";
            btnDSSVTruot.UseVisualStyleBackColor = true;
            btnDSSVTruot.Click += btnDSSVTruot_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnXoa.Location = new Point(344, 169);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSua.Location = new Point(233, 169);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnThem.Location = new Point(122, 169);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHienThi
            // 
            btnHienThi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnHienThi.Location = new Point(17, 169);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(75, 23);
            btnHienThi.TabIndex = 10;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // txtDiemCNC
            // 
            txtDiemCNC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtDiemCNC.Location = new Point(484, 77);
            txtDiemCNC.Name = "txtDiemCNC";
            txtDiemCNC.Size = new Size(185, 21);
            txtDiemCNC.TabIndex = 9;
            // 
            // txtDiemVeKyThuat
            // 
            txtDiemVeKyThuat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtDiemVeKyThuat.Location = new Point(484, 30);
            txtDiemVeKyThuat.Name = "txtDiemVeKyThuat";
            txtDiemVeKyThuat.Size = new Size(185, 21);
            txtDiemVeKyThuat.TabIndex = 8;
            // 
            // txtNamSinh
            // 
            txtNamSinh.Location = new Point(102, 122);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(185, 21);
            txtNamSinh.TabIndex = 7;
            // 
            // txtTenSinhVien
            // 
            txtTenSinhVien.Location = new Point(102, 77);
            txtTenSinhVien.Name = "txtTenSinhVien";
            txtTenSinhVien.Size = new Size(185, 21);
            txtTenSinhVien.TabIndex = 6;
            // 
            // txtMaSinhVien
            // 
            txtMaSinhVien.Location = new Point(102, 30);
            txtMaSinhVien.Name = "txtMaSinhVien";
            txtMaSinhVien.Size = new Size(185, 21);
            txtMaSinhVien.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(373, 30);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 4;
            label6.Text = "Điểm vẽ kỹ thuật";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(373, 83);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 3;
            label5.Text = "Điểm CNC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 128);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 2;
            label4.Text = "Năm sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 83);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 30);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã sinh viên";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(listViewDSSV);
            groupBox2.Location = new Point(12, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(708, 167);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sinh viên";
            // 
            // listViewDSSV
            // 
            listViewDSSV.Columns.AddRange(new ColumnHeader[] { masinhvien, tensinhvien, namsinh, diemkithuat, diemcnc });
            listViewDSSV.Dock = DockStyle.Fill;
            listViewDSSV.Location = new Point(3, 17);
            listViewDSSV.Name = "listViewDSSV";
            listViewDSSV.Size = new Size(702, 147);
            listViewDSSV.TabIndex = 0;
            listViewDSSV.UseCompatibleStateImageBehavior = false;
            listViewDSSV.View = View.Details;
            // 
            // masinhvien
            // 
            masinhvien.Text = "Mã sinh viên";
            masinhvien.Width = 120;
            // 
            // tensinhvien
            // 
            tensinhvien.Text = "Tên sinh viên";
            tensinhvien.TextAlign = HorizontalAlignment.Center;
            tensinhvien.Width = 170;
            // 
            // namsinh
            // 
            namsinh.Text = "Năm sinh";
            namsinh.TextAlign = HorizontalAlignment.Center;
            namsinh.Width = 140;
            // 
            // diemkithuat
            // 
            diemkithuat.Text = "Điểm kỹ thuật";
            diemkithuat.TextAlign = HorizontalAlignment.Center;
            diemkithuat.Width = 140;
            // 
            // diemcnc
            // 
            diemcnc.Text = "Điểm cnc";
            diemcnc.TextAlign = HorizontalAlignment.Center;
            diemcnc.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(732, 425);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SVCK";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnThoat;
        private Button btnDSSVTruot;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnHienThi;
        private TextBox txtDiemCNC;
        private TextBox txtDiemVeKyThuat;
        private TextBox txtNamSinh;
        private TextBox txtTenSinhVien;
        private TextBox txtMaSinhVien;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private ListView listViewDSSV;
        private ColumnHeader masinhvien;
        private ColumnHeader tensinhvien;
        private ColumnHeader namsinh;
        private ColumnHeader diemkithuat;
        private ColumnHeader diemcnc;
    }
}