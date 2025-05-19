namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.UI.Hung
{
    partial class frm_QLNhanVien_Hung
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
            a = new GroupBox();
            cb_loainguoidung_hung = new ComboBox();
            dgv_ngaysinh_hung = new DateTimePicker();
            tb_hotennhanvien_hung = new TextBox();
            tb_matkhau_hung = new TextBox();
            tb_sodienthoai_hung = new TextBox();
            tb_manhanvien_hung = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            bt_tk_hung = new Button();
            tb_timkiem_hung = new TextBox();
            groupBox2 = new GroupBox();
            nt_capnhat_hung = new Button();
            bt_xoa_hung = new Button();
            bt_them_hung = new Button();
            dgv_hung = new DataGridView();
            a.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_hung).BeginInit();
            SuspendLayout();
            // 
            // a
            // 
            a.Controls.Add(cb_loainguoidung_hung);
            a.Controls.Add(dgv_ngaysinh_hung);
            a.Controls.Add(tb_hotennhanvien_hung);
            a.Controls.Add(tb_matkhau_hung);
            a.Controls.Add(tb_sodienthoai_hung);
            a.Controls.Add(tb_manhanvien_hung);
            a.Controls.Add(label6);
            a.Controls.Add(label5);
            a.Controls.Add(label4);
            a.Controls.Add(label3);
            a.Controls.Add(label2);
            a.Controls.Add(label1);
            a.Location = new Point(10, 9);
            a.Margin = new Padding(3, 2, 3, 2);
            a.Name = "a";
            a.Padding = new Padding(3, 2, 3, 2);
            a.Size = new Size(514, 320);
            a.TabIndex = 0;
            a.TabStop = false;
            a.Text = "Nhân viên";
            // 
            // cb_loainguoidung_hung
            // 
            cb_loainguoidung_hung.FormattingEnabled = true;
            cb_loainguoidung_hung.Items.AddRange(new object[] { "" });
            cb_loainguoidung_hung.Location = new Point(214, 226);
            cb_loainguoidung_hung.Margin = new Padding(3, 2, 3, 2);
            cb_loainguoidung_hung.Name = "cb_loainguoidung_hung";
            cb_loainguoidung_hung.Size = new Size(187, 23);
            cb_loainguoidung_hung.TabIndex = 13;
            // 
            // dgv_ngaysinh_hung
            // 
            dgv_ngaysinh_hung.CustomFormat = "dd/MM/yyyy";
            dgv_ngaysinh_hung.Format = DateTimePickerFormat.Custom;
            dgv_ngaysinh_hung.Location = new Point(214, 122);
            dgv_ngaysinh_hung.Margin = new Padding(3, 2, 3, 2);
            dgv_ngaysinh_hung.Name = "dgv_ngaysinh_hung";
            dgv_ngaysinh_hung.Size = new Size(182, 23);
            dgv_ngaysinh_hung.TabIndex = 12;
            // 
            // tb_hotennhanvien_hung
            // 
            tb_hotennhanvien_hung.Location = new Point(214, 86);
            tb_hotennhanvien_hung.Margin = new Padding(3, 2, 3, 2);
            tb_hotennhanvien_hung.Name = "tb_hotennhanvien_hung";
            tb_hotennhanvien_hung.Size = new Size(185, 23);
            tb_hotennhanvien_hung.TabIndex = 10;
            // 
            // tb_matkhau_hung
            // 
            tb_matkhau_hung.Location = new Point(214, 190);
            tb_matkhau_hung.Margin = new Padding(3, 2, 3, 2);
            tb_matkhau_hung.Name = "tb_matkhau_hung";
            tb_matkhau_hung.Size = new Size(185, 23);
            tb_matkhau_hung.TabIndex = 8;
            // 
            // tb_sodienthoai_hung
            // 
            tb_sodienthoai_hung.Location = new Point(214, 158);
            tb_sodienthoai_hung.Margin = new Padding(3, 2, 3, 2);
            tb_sodienthoai_hung.Name = "tb_sodienthoai_hung";
            tb_sodienthoai_hung.Size = new Size(185, 23);
            tb_sodienthoai_hung.TabIndex = 7;
            // 
            // tb_manhanvien_hung
            // 
            tb_manhanvien_hung.Location = new Point(214, 50);
            tb_manhanvien_hung.Margin = new Padding(3, 2, 3, 2);
            tb_manhanvien_hung.Name = "tb_manhanvien_hung";
            tb_manhanvien_hung.Size = new Size(185, 23);
            tb_manhanvien_hung.TabIndex = 6;
            // 
            // label6
            // 
            label6.Location = new Point(26, 228);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 5;
            label6.Text = "Loại người dùng";
            // 
            // label5
            // 
            label5.Location = new Point(26, 193);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 4;
            label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.Location = new Point(26, 158);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.Location = new Point(26, 122);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.Location = new Point(26, 87);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên nhân viên";
            // 
            // label1
            // 
            label1.Location = new Point(26, 52);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bt_tk_hung);
            groupBox3.Controls.Add(tb_timkiem_hung);
            groupBox3.Location = new Point(547, 272);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(400, 56);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // bt_tk_hung
            // 
            bt_tk_hung.Location = new Point(271, 18);
            bt_tk_hung.Margin = new Padding(3, 2, 3, 2);
            bt_tk_hung.Name = "bt_tk_hung";
            bt_tk_hung.Size = new Size(82, 22);
            bt_tk_hung.TabIndex = 3;
            bt_tk_hung.Text = "Tìm kiếm";
            bt_tk_hung.UseVisualStyleBackColor = true;
            bt_tk_hung.Click += tk_Click;
            // 
            // tb_timkiem_hung
            // 
            tb_timkiem_hung.Location = new Point(28, 20);
            tb_timkiem_hung.Margin = new Padding(3, 2, 3, 2);
            tb_timkiem_hung.Name = "tb_timkiem_hung";
            tb_timkiem_hung.Size = new Size(225, 23);
            tb_timkiem_hung.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nt_capnhat_hung);
            groupBox2.Controls.Add(bt_xoa_hung);
            groupBox2.Controls.Add(bt_them_hung);
            groupBox2.Location = new Point(547, 9);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(408, 184);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // nt_capnhat_hung
            // 
            nt_capnhat_hung.Location = new Point(136, 68);
            nt_capnhat_hung.Margin = new Padding(3, 2, 3, 2);
            nt_capnhat_hung.Name = "nt_capnhat_hung";
            nt_capnhat_hung.Size = new Size(82, 22);
            nt_capnhat_hung.TabIndex = 3;
            nt_capnhat_hung.Text = "Cập nhật";
            nt_capnhat_hung.UseVisualStyleBackColor = true;
            nt_capnhat_hung.Click += capnhat_Click;
            // 
            // bt_xoa_hung
            // 
            bt_xoa_hung.Location = new Point(136, 112);
            bt_xoa_hung.Margin = new Padding(3, 2, 3, 2);
            bt_xoa_hung.Name = "bt_xoa_hung";
            bt_xoa_hung.Size = new Size(82, 22);
            bt_xoa_hung.TabIndex = 1;
            bt_xoa_hung.Text = "Xóa";
            bt_xoa_hung.UseVisualStyleBackColor = true;
            bt_xoa_hung.Click += xoa_Click;
            // 
            // bt_them_hung
            // 
            bt_them_hung.Location = new Point(136, 31);
            bt_them_hung.Margin = new Padding(3, 2, 3, 2);
            bt_them_hung.Name = "bt_them_hung";
            bt_them_hung.Size = new Size(82, 22);
            bt_them_hung.TabIndex = 0;
            bt_them_hung.Text = "Thêm";
            bt_them_hung.UseVisualStyleBackColor = true;
            bt_them_hung.Click += them_Click;
            // 
            // dgv_hung
            // 
            dgv_hung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_hung.Location = new Point(10, 355);
            dgv_hung.Margin = new Padding(3, 2, 3, 2);
            dgv_hung.Name = "dgv_hung";
            dgv_hung.RowHeadersWidth = 51;
            dgv_hung.RowTemplate.Height = 29;
            dgv_hung.Size = new Size(936, 208);
            dgv_hung.TabIndex = 6;
            dgv_hung.CellClick += dgv_CellClick;
            // 
            // frm_QLNhanVien_Hung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 562);
            Controls.Add(dgv_hung);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(a);
            MaximumSize = new Size(983, 617);
            MinimumSize = new Size(983, 548);
            Name = "frm_QLNhanVien_Hung";
            Text = "frm_QLNhanVien_Hung";
            Load += frm_QLNhanVien_Hung_Load;
            a.ResumeLayout(false);
            a.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_hung).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox a;
        private TextBox tb_hotennhanvien_hung;
        private TextBox tb_matkhau_hung;
        private TextBox tb_sodienthoai_hung;
        private TextBox tb_manhanvien_hung;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button bt_tk_hung;
        private TextBox tb_timkiem_hung;
        private GroupBox groupBox2;
        private Button nt_capnhat_hung;
        private Button bt_xoa_hung;
        private Button bt_them_hung;
        private DataGridView dgv_hung;
        private DateTimePicker dgv_ngaysinh_hung;
        private ComboBox cb_loainguoidung_hung;
    }
}