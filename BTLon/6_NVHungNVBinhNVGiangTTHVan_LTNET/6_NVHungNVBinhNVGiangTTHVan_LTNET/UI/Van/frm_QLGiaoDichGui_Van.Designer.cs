namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.UI.Van
{
    partial class frm_QLGiaoDichGui_Van
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
            dgv_LoaiSo_Van = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txt_MaSTK_Van = new TextBox();
            txt_MaNV_Van = new TextBox();
            label3 = new Label();
            txt_SoTienGui_Van = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cb_TenLoaiSo_Van = new ComboBox();
            txt_CMND_Van = new TextBox();
            label4 = new Label();
            label10 = new Label();
            label11 = new Label();
            txt_LaiSuat_Van = new TextBox();
            dgv_DanhSach_Van = new DataGridView();
            MaLoaiSo = new DataGridViewTextBoxColumn();
            MaNV = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            CMND = new DataGridViewTextBoxColumn();
            TenLoaiSo = new DataGridViewTextBoxColumn();
            LaiSuat = new DataGridViewTextBoxColumn();
            NgayMoSo = new DataGridViewTextBoxColumn();
            NgayDenHan = new DataGridViewTextBoxColumn();
            SoTienGui = new DataGridViewTextBoxColumn();
            TrangThaiSo = new DataGridViewTextBoxColumn();
            btn_Them_Van = new Button();
            btn_Sua_Van = new Button();
            btn_TimKiem_Van = new Button();
            txt_SDT_Van = new TextBox();
            label12 = new Label();
            txt_DC_Van = new TextBox();
            label13 = new Label();
            cb_TrangThaiSo_Van = new ComboBox();
            txt_TenKH_Van = new TextBox();
            label5 = new Label();
            txt_MaKH_Van = new TextBox();
            label14 = new Label();
            btn_Xoa_Van = new Button();
            btnGuiThem = new Button();
            dtp_NgayMoSo_Van = new DateTimePicker();
            dtp_NgayDenHan_Van = new DateTimePicker();
            btn_Huy_Van = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_LoaiSo_Van).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSach_Van).BeginInit();
            SuspendLayout();
            // 
            // dgv_LoaiSo_Van
            // 
            dgv_LoaiSo_Van.AllowUserToAddRows = false;
            dgv_LoaiSo_Van.AllowUserToDeleteRows = false;
            dgv_LoaiSo_Van.AllowUserToResizeColumns = false;
            dgv_LoaiSo_Van.AllowUserToResizeRows = false;
            dgv_LoaiSo_Van.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_LoaiSo_Van.BackgroundColor = SystemColors.ActiveCaption;
            dgv_LoaiSo_Van.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_LoaiSo_Van.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgv_LoaiSo_Van.Location = new Point(662, 53);
            dgv_LoaiSo_Van.Margin = new Padding(3, 2, 3, 2);
            dgv_LoaiSo_Van.Name = "dgv_LoaiSo_Van";
            dgv_LoaiSo_Van.ReadOnly = true;
            dgv_LoaiSo_Van.RowHeadersVisible = false;
            dgv_LoaiSo_Van.RowHeadersWidth = 51;
            dgv_LoaiSo_Van.RowTemplate.Height = 29;
            dgv_LoaiSo_Van.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_LoaiSo_Van.Size = new Size(281, 105);
            dgv_LoaiSo_Van.TabIndex = 0;
            dgv_LoaiSo_Van.CellClick += dgvLoaiSo_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "TenLoaiSo";
            Column1.HeaderText = "Tên loại sổ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "LaiSuatThang";
            Column2.HeaderText = "Lãi suất tháng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "SoThang";
            Column3.HeaderText = "Kì hạn";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(369, 16);
            label1.Name = "label1";
            label1.Size = new Size(234, 21);
            label1.TabIndex = 1;
            label1.Text = "PHIẾU GỬI TIỀN NGÂN HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 59);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Mã STK";
            // 
            // txt_MaSTK_Van
            // 
            txt_MaSTK_Van.Enabled = false;
            txt_MaSTK_Van.Location = new Point(129, 53);
            txt_MaSTK_Van.Margin = new Padding(3, 2, 3, 2);
            txt_MaSTK_Van.Name = "txt_MaSTK_Van";
            txt_MaSTK_Van.Size = new Size(182, 23);
            txt_MaSTK_Van.TabIndex = 3;
            // 
            // txt_MaNV_Van
            // 
            txt_MaNV_Van.Location = new Point(129, 85);
            txt_MaNV_Van.Margin = new Padding(3, 2, 3, 2);
            txt_MaNV_Van.Name = "txt_MaNV_Van";
            txt_MaNV_Van.Size = new Size(182, 23);
            txt_MaNV_Van.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 91);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 4;
            label3.Text = "Mã nhân viên";
            // 
            // txt_SoTienGui_Van
            // 
            txt_SoTienGui_Van.Location = new Point(444, 223);
            txt_SoTienGui_Van.Margin = new Padding(3, 2, 3, 2);
            txt_SoTienGui_Van.Name = "txt_SoTienGui_Van";
            txt_SoTienGui_Van.Size = new Size(182, 23);
            txt_SoTienGui_Van.TabIndex = 17;
            txt_SoTienGui_Van.MouseMove += txtSoTienGui_MouseMove;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(352, 229);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 16;
            label6.Text = "Số tiền gửi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(352, 193);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 14;
            label7.Text = "Ngày đến hạn";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 155);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 12;
            label8.Text = "Ngày mở sổ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(356, 82);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 10;
            label9.Text = "Tên loại sổ";
            // 
            // cb_TenLoaiSo_Van
            // 
            cb_TenLoaiSo_Van.FormattingEnabled = true;
            cb_TenLoaiSo_Van.Location = new Point(445, 76);
            cb_TenLoaiSo_Van.Margin = new Padding(3, 2, 3, 2);
            cb_TenLoaiSo_Van.Name = "cb_TenLoaiSo_Van";
            cb_TenLoaiSo_Van.Size = new Size(182, 23);
            cb_TenLoaiSo_Van.TabIndex = 19;
            cb_TenLoaiSo_Van.SelectedIndexChanged += cb_TenLoaiSo_Van_SelectedIndexChanged;
            cb_TenLoaiSo_Van.TextChanged += cbTenLoaiSo_TextChanged;
            // 
            // txt_CMND_Van
            // 
            txt_CMND_Van.Location = new Point(129, 119);
            txt_CMND_Van.Margin = new Padding(3, 2, 3, 2);
            txt_CMND_Van.Name = "txt_CMND_Van";
            txt_CMND_Van.Size = new Size(182, 23);
            txt_CMND_Van.TabIndex = 22;
            txt_CMND_Van.MouseLeave += txtCMND_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 125);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 21;
            label4.Text = "CMND";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(352, 266);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 23;
            label10.Text = "Trạng thái sổ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(356, 121);
            label11.Name = "label11";
            label11.Size = new Size(47, 15);
            label11.TabIndex = 25;
            label11.Text = "Lãi suất";
            // 
            // txt_LaiSuat_Van
            // 
            txt_LaiSuat_Van.Enabled = false;
            txt_LaiSuat_Van.Location = new Point(444, 116);
            txt_LaiSuat_Van.Margin = new Padding(3, 2, 3, 2);
            txt_LaiSuat_Van.Name = "txt_LaiSuat_Van";
            txt_LaiSuat_Van.Size = new Size(182, 23);
            txt_LaiSuat_Van.TabIndex = 26;
            // 
            // dgv_DanhSach_Van
            // 
            dgv_DanhSach_Van.AllowUserToAddRows = false;
            dgv_DanhSach_Van.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSach_Van.Columns.AddRange(new DataGridViewColumn[] { MaLoaiSo, MaNV, TenKH, CMND, TenLoaiSo, LaiSuat, NgayMoSo, NgayDenHan, SoTienGui, TrangThaiSo });
            dgv_DanhSach_Van.Location = new Point(23, 305);
            dgv_DanhSach_Van.Margin = new Padding(3, 2, 3, 2);
            dgv_DanhSach_Van.Name = "dgv_DanhSach_Van";
            dgv_DanhSach_Van.ReadOnly = true;
            dgv_DanhSach_Van.RowHeadersVisible = false;
            dgv_DanhSach_Van.RowHeadersWidth = 51;
            dgv_DanhSach_Van.RowTemplate.Height = 29;
            dgv_DanhSach_Van.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DanhSach_Van.Size = new Size(918, 248);
            dgv_DanhSach_Van.TabIndex = 27;
            dgv_DanhSach_Van.CellClick += dgvHT_CellClick;
            // 
            // MaLoaiSo
            // 
            MaLoaiSo.DataPropertyName = "MaSTK";
            MaLoaiSo.HeaderText = "Mã sổ";
            MaLoaiSo.MinimumWidth = 6;
            MaLoaiSo.Name = "MaLoaiSo";
            MaLoaiSo.ReadOnly = true;
            MaLoaiSo.Width = 125;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MaNV";
            MaNV.HeaderText = "Mã NV";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.ReadOnly = true;
            MaNV.Width = 125;
            // 
            // TenKH
            // 
            TenKH.DataPropertyName = "HoTenKH";
            TenKH.HeaderText = "Tên khách hàng";
            TenKH.MinimumWidth = 6;
            TenKH.Name = "TenKH";
            TenKH.ReadOnly = true;
            TenKH.Width = 125;
            // 
            // CMND
            // 
            CMND.DataPropertyName = "CMND";
            CMND.HeaderText = "CMND";
            CMND.MinimumWidth = 6;
            CMND.Name = "CMND";
            CMND.ReadOnly = true;
            CMND.Width = 125;
            // 
            // TenLoaiSo
            // 
            TenLoaiSo.DataPropertyName = "TenLoaiSo";
            TenLoaiSo.HeaderText = "Tên loại sổ";
            TenLoaiSo.MinimumWidth = 6;
            TenLoaiSo.Name = "TenLoaiSo";
            TenLoaiSo.ReadOnly = true;
            TenLoaiSo.Width = 125;
            // 
            // LaiSuat
            // 
            LaiSuat.DataPropertyName = "LaiSuatThang";
            LaiSuat.HeaderText = "Lãi suất";
            LaiSuat.MinimumWidth = 6;
            LaiSuat.Name = "LaiSuat";
            LaiSuat.ReadOnly = true;
            LaiSuat.Width = 125;
            // 
            // NgayMoSo
            // 
            NgayMoSo.DataPropertyName = "NgayMoSo";
            NgayMoSo.HeaderText = "Ngày mở sổ";
            NgayMoSo.MinimumWidth = 6;
            NgayMoSo.Name = "NgayMoSo";
            NgayMoSo.ReadOnly = true;
            NgayMoSo.Width = 125;
            // 
            // NgayDenHan
            // 
            NgayDenHan.DataPropertyName = "NgayDenHan";
            NgayDenHan.HeaderText = "Ngày đến hạn";
            NgayDenHan.MinimumWidth = 6;
            NgayDenHan.Name = "NgayDenHan";
            NgayDenHan.ReadOnly = true;
            NgayDenHan.Width = 125;
            // 
            // SoTienGui
            // 
            SoTienGui.DataPropertyName = "SoTienGui";
            SoTienGui.HeaderText = "Số tiền gửi";
            SoTienGui.MinimumWidth = 6;
            SoTienGui.Name = "SoTienGui";
            SoTienGui.ReadOnly = true;
            SoTienGui.Width = 125;
            // 
            // TrangThaiSo
            // 
            TrangThaiSo.DataPropertyName = "TrangThaiSo";
            TrangThaiSo.HeaderText = "Trạng thái sổ";
            TrangThaiSo.MinimumWidth = 6;
            TrangThaiSo.Name = "TrangThaiSo";
            TrangThaiSo.ReadOnly = true;
            TrangThaiSo.Width = 125;
            // 
            // btn_Them_Van
            // 
            btn_Them_Van.Location = new Point(697, 172);
            btn_Them_Van.Margin = new Padding(3, 2, 3, 2);
            btn_Them_Van.Name = "btn_Them_Van";
            btn_Them_Van.Size = new Size(82, 22);
            btn_Them_Van.TabIndex = 28;
            btn_Them_Van.Text = "Thêm";
            btn_Them_Van.UseVisualStyleBackColor = true;
            btn_Them_Van.Click += btnThem_Click;
            // 
            // btn_Sua_Van
            // 
            btn_Sua_Van.Location = new Point(814, 172);
            btn_Sua_Van.Margin = new Padding(3, 2, 3, 2);
            btn_Sua_Van.Name = "btn_Sua_Van";
            btn_Sua_Van.Size = new Size(82, 22);
            btn_Sua_Van.TabIndex = 29;
            btn_Sua_Van.Text = "Sửa";
            btn_Sua_Van.UseVisualStyleBackColor = true;
            btn_Sua_Van.Click += btnSua_Click;
            // 
            // btn_TimKiem_Van
            // 
            btn_TimKiem_Van.Location = new Point(814, 206);
            btn_TimKiem_Van.Margin = new Padding(3, 2, 3, 2);
            btn_TimKiem_Van.Name = "btn_TimKiem_Van";
            btn_TimKiem_Van.Size = new Size(82, 22);
            btn_TimKiem_Van.TabIndex = 31;
            btn_TimKiem_Van.Text = "Tìm kiếm";
            btn_TimKiem_Van.UseVisualStyleBackColor = true;
            btn_TimKiem_Van.Click += btnTK_Click;
            // 
            // txt_SDT_Van
            // 
            txt_SDT_Van.Location = new Point(129, 264);
            txt_SDT_Van.Margin = new Padding(3, 2, 3, 2);
            txt_SDT_Van.Name = "txt_SDT_Van";
            txt_SDT_Van.Size = new Size(182, 23);
            txt_SDT_Van.TabIndex = 35;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 269);
            label12.Name = "label12";
            label12.Size = new Size(26, 15);
            label12.TabIndex = 34;
            label12.Text = "SDT";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_DC_Van
            // 
            txt_DC_Van.Location = new Point(130, 227);
            txt_DC_Van.Margin = new Padding(3, 2, 3, 2);
            txt_DC_Van.Name = "txt_DC_Van";
            txt_DC_Van.Size = new Size(182, 23);
            txt_DC_Van.TabIndex = 33;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 232);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 32;
            label13.Text = "Địa chỉ";
            // 
            // cb_TrangThaiSo_Van
            // 
            cb_TrangThaiSo_Van.FormattingEnabled = true;
            cb_TrangThaiSo_Van.Items.AddRange(new object[] { "Mở", "Đóng" });
            cb_TrangThaiSo_Van.Location = new Point(444, 260);
            cb_TrangThaiSo_Van.Margin = new Padding(3, 2, 3, 2);
            cb_TrangThaiSo_Van.Name = "cb_TrangThaiSo_Van";
            cb_TrangThaiSo_Van.Size = new Size(182, 23);
            cb_TrangThaiSo_Van.TabIndex = 36;
            // 
            // txt_TenKH_Van
            // 
            txt_TenKH_Van.Location = new Point(131, 190);
            txt_TenKH_Van.Margin = new Padding(3, 2, 3, 2);
            txt_TenKH_Van.Name = "txt_TenKH_Van";
            txt_TenKH_Van.Size = new Size(182, 23);
            txt_TenKH_Van.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 195);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 37;
            label5.Text = "Tên khách hàng";
            // 
            // txt_MaKH_Van
            // 
            txt_MaKH_Van.Enabled = false;
            txt_MaKH_Van.Location = new Point(129, 155);
            txt_MaKH_Van.Margin = new Padding(3, 2, 3, 2);
            txt_MaKH_Van.Name = "txt_MaKH_Van";
            txt_MaKH_Van.Size = new Size(182, 23);
            txt_MaKH_Van.TabIndex = 40;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 161);
            label14.Name = "label14";
            label14.Size = new Size(89, 15);
            label14.TabIndex = 39;
            label14.Text = "Mã khách hàng";
            // 
            // btn_Xoa_Van
            // 
            btn_Xoa_Van.Location = new Point(697, 206);
            btn_Xoa_Van.Margin = new Padding(3, 2, 3, 2);
            btn_Xoa_Van.Name = "btn_Xoa_Van";
            btn_Xoa_Van.Size = new Size(82, 22);
            btn_Xoa_Van.TabIndex = 41;
            btn_Xoa_Van.Text = "Xóa";
            btn_Xoa_Van.UseVisualStyleBackColor = true;
            btn_Xoa_Van.Click += btnXoa_Click;
            // 
            // btnGuiThem
            // 
            btnGuiThem.Location = new Point(814, 242);
            btnGuiThem.Margin = new Padding(3, 2, 3, 2);
            btnGuiThem.Name = "btnGuiThem";
            btnGuiThem.Size = new Size(82, 22);
            btnGuiThem.TabIndex = 42;
            btnGuiThem.Text = "Gửi thêm";
            btnGuiThem.UseVisualStyleBackColor = true;
            btnGuiThem.Click += btnGuiThem_Click;
            // 
            // dtp_NgayMoSo_Van
            // 
            dtp_NgayMoSo_Van.CustomFormat = "dd/MM/yyyy";
            dtp_NgayMoSo_Van.Format = DateTimePickerFormat.Custom;
            dtp_NgayMoSo_Van.Location = new Point(444, 154);
            dtp_NgayMoSo_Van.Margin = new Padding(3, 2, 3, 2);
            dtp_NgayMoSo_Van.Name = "dtp_NgayMoSo_Van";
            dtp_NgayMoSo_Van.Size = new Size(182, 23);
            dtp_NgayMoSo_Van.TabIndex = 43;
            // 
            // dtp_NgayDenHan_Van
            // 
            dtp_NgayDenHan_Van.CustomFormat = "dd/MM/yyyy";
            dtp_NgayDenHan_Van.Enabled = false;
            dtp_NgayDenHan_Van.Format = DateTimePickerFormat.Custom;
            dtp_NgayDenHan_Van.Location = new Point(444, 191);
            dtp_NgayDenHan_Van.Margin = new Padding(3, 2, 3, 2);
            dtp_NgayDenHan_Van.Name = "dtp_NgayDenHan_Van";
            dtp_NgayDenHan_Van.Size = new Size(182, 23);
            dtp_NgayDenHan_Van.TabIndex = 44;
            // 
            // btn_Huy_Van
            // 
            btn_Huy_Van.Location = new Point(697, 241);
            btn_Huy_Van.Margin = new Padding(3, 2, 3, 2);
            btn_Huy_Van.Name = "btn_Huy_Van";
            btn_Huy_Van.Size = new Size(82, 22);
            btn_Huy_Van.TabIndex = 45;
            btn_Huy_Van.Text = "Hủy";
            btn_Huy_Van.UseVisualStyleBackColor = true;
            btn_Huy_Van.Click += btn_Huy_Van_Click;
            // 
            // frm_QLGiaoDichGui_Van
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(967, 562);
            Controls.Add(btn_Huy_Van);
            Controls.Add(dtp_NgayDenHan_Van);
            Controls.Add(dtp_NgayMoSo_Van);
            Controls.Add(btnGuiThem);
            Controls.Add(btn_Xoa_Van);
            Controls.Add(txt_MaKH_Van);
            Controls.Add(label14);
            Controls.Add(txt_TenKH_Van);
            Controls.Add(label5);
            Controls.Add(cb_TrangThaiSo_Van);
            Controls.Add(txt_SDT_Van);
            Controls.Add(label12);
            Controls.Add(txt_DC_Van);
            Controls.Add(label13);
            Controls.Add(btn_TimKiem_Van);
            Controls.Add(btn_Sua_Van);
            Controls.Add(btn_Them_Van);
            Controls.Add(dgv_DanhSach_Van);
            Controls.Add(txt_LaiSuat_Van);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txt_CMND_Van);
            Controls.Add(label4);
            Controls.Add(cb_TenLoaiSo_Van);
            Controls.Add(txt_SoTienGui_Van);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txt_MaNV_Van);
            Controls.Add(label3);
            Controls.Add(txt_MaSTK_Van);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_LoaiSo_Van);
            MaximumSize = new Size(983, 615);
            MinimumSize = new Size(983, 546);
            Name = "frm_QLGiaoDichGui_Van";
            Text = "frm_QLGiaoDichGui_Van";
            Load += frm_QLGiaoDichGui_Van_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_LoaiSo_Van).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSach_Van).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_LoaiSo_Van;
        private Label label1;
        private Label label2;
        private TextBox txt_MaSTK_Van;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox txt_MaNV_Van;
        private Label label3;
        private TextBox txt_SoTienGui_Van;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cb_TenLoaiSo_Van;
        private TextBox txt_CMND_Van;
        private Label label4;
        private Label label10;
        private Label label11;
        private TextBox txt_LaiSuat_Van;
        private DataGridView dgv_DanhSach_Van;
        private Button btn_Them_Van;
        private Button btn_Sua_Van;
        private Button btn_TimKiem_Van;
        private TextBox txt_SDT_Van;
        private Label label12;
        private TextBox txt_DC_Van;
        private Label label13;
        private ComboBox cb_TrangThaiSo_Van;
        private TextBox txt_TenKH_Van;
        private Label label5;
        private TextBox txt_MaKH_Van;
        private Label label14;
        private Button btn_Xoa_Van;
        private Button btnGuiThem;
        private DateTimePicker dtp_NgayMoSo_Van;
        private DateTimePicker dtp_NgayDenHan_Van;
        private DataGridViewTextBoxColumn MaLoaiSo;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn CMND;
        private DataGridViewTextBoxColumn TenLoaiSo;
        private DataGridViewTextBoxColumn LaiSuat;
        private DataGridViewTextBoxColumn NgayMoSo;
        private DataGridViewTextBoxColumn NgayDenHan;
        private DataGridViewTextBoxColumn SoTienGui;
        private DataGridViewTextBoxColumn TrangThaiSo;
        private Button btn_Huy_Van;
    }
}