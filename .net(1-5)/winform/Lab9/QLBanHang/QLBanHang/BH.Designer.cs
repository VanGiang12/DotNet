namespace bai.banhang
{
    partial class BH
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
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnThanhToan = new Button();
            btnThem = new Button();
            cboKH = new ComboBox();
            txtDonGia = new TextBox();
            dgvDS = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txtSoHieu = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            cboMH = new ComboBox();
            dtpNgayMua = new DateTimePicker();
            txtSL = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDS).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(487, 158);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(81, 31);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(392, 158);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(81, 31);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(276, 158);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(81, 31);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(150, 158);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(81, 31);
            btnThanhToan.TabIndex = 11;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(20, 158);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(81, 31);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboKH
            // 
            cboKH.FormattingEnabled = true;
            cboKH.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboKH.Location = new Point(107, 74);
            cboKH.Name = "cboKH";
            cboKH.Size = new Size(189, 23);
            cboKH.TabIndex = 8;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(416, 110);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(189, 23);
            txtDonGia.TabIndex = 7;
            // 
            // dgvDS
            // 
            dgvDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDS.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvDS.Location = new Point(48, 289);
            dgvDS.Name = "dgvDS";
            dgvDS.RowHeadersWidth = 51;
            dgvDS.RowTemplate.Height = 24;
            dgvDS.Size = new Size(628, 145);
            dgvDS.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaKH";
            Column1.HeaderText = "STT";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Hoten";
            Column2.HeaderText = "Mã MH";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "GioiTinh";
            Column3.HeaderText = "Số Lượng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "DiaChi";
            Column4.HeaderText = "Đơn Giá";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "DienThoai";
            Column5.HeaderText = "Thành Tiền";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // txtSoHieu
            // 
            txtSoHieu.Location = new Point(107, 31);
            txtSoHieu.Name = "txtSoHieu";
            txtSoHieu.Size = new Size(189, 23);
            txtSoHieu.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(349, 112);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 4;
            label6.Text = "Đơn giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 74);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên KH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 37);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "Số hiệu HD";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboMH);
            groupBox1.Controls.Add(dtpNgayMua);
            groupBox1.Controls.Add(txtSL);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThanhToan);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboKH);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtSoHieu);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(48, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(628, 215);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin bán hàng";
            // 
            // cboMH
            // 
            cboMH.FormattingEnabled = true;
            cboMH.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboMH.Location = new Point(416, 26);
            cboMH.Name = "cboMH";
            cboMH.Size = new Size(189, 23);
            cboMH.TabIndex = 20;
            // 
            // dtpNgayMua
            // 
            dtpNgayMua.Format = DateTimePickerFormat.Short;
            dtpNgayMua.Location = new Point(107, 112);
            dtpNgayMua.Name = "dtpNgayMua";
            dtpNgayMua.Size = new Size(189, 23);
            dtpNgayMua.TabIndex = 19;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(416, 74);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(189, 23);
            txtSL.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(349, 74);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 17;
            label7.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 34);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 15;
            label5.Text = "Tên MH";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 112);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 2;
            label4.Text = "Ngày mua ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, -12);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 3;
            label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // BH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 458);
            Controls.Add(dgvDS);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "BH";
            Text = "BH";
            Load += BH_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDS).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnThanhToan;
        private Button btnThem;
        private ComboBox cboKH;
        private TextBox txtDonGia;
        private DataGridView dgvDS;
        private TextBox txtSoHieu;
        private Label label6;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label1;
        private Label label5;
        private ComboBox cboMH;
        private DateTimePicker dtpNgayMua;
        private TextBox txtSL;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}