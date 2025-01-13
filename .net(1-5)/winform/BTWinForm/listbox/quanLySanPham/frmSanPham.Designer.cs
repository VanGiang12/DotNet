namespace quanLySanPham
{
    partial class frmSanPham
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
            panel1 = new Panel();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            lstSanPham = new ListBox();
            txtMaSP = new TextBox();
            btnThoat = new Button();
            label3 = new Label();
            btnXoa = new Button();
            btnLuu = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtXuatXu = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtDonGia = new TextBox();
            txtTenSP = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            btnQuanLyDanhMuc = new Button();
            label2 = new Label();
            cbDanhMuc = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 81);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(136, 20);
            label1.Name = "label1";
            label1.Size = new Size(374, 28);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ SẢN PHẨM";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 81);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtMaSP);
            splitContainer1.Panel2.Controls.Add(btnThoat);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(btnXoa);
            splitContainer1.Panel2.Controls.Add(btnLuu);
            splitContainer1.Panel2.Controls.Add(dateTimePicker1);
            splitContainer1.Panel2.Controls.Add(txtXuatXu);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(txtDonGia);
            splitContainer1.Panel2.Controls.Add(txtTenSP);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(680, 481);
            splitContainer1.SplitterDistance = 260;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstSanPham);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 481);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // lstSanPham
            // 
            lstSanPham.Dock = DockStyle.Fill;
            lstSanPham.FormattingEnabled = true;
            lstSanPham.Location = new Point(3, 23);
            lstSanPham.Name = "lstSanPham";
            lstSanPham.Size = new Size(254, 455);
            lstSanPham.TabIndex = 0;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(162, 115);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(242, 27);
            txtMaSP.TabIndex = 4;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(278, 412);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 39);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 115);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 3;
            label3.Text = "Mã sản phẩm";
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F);
            btnXoa.Location = new Point(162, 412);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 39);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 12F);
            btnLuu.Location = new Point(46, 412);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 39);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(162, 345);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 34);
            dateTimePicker1.TabIndex = 11;
            // 
            // txtXuatXu
            // 
            txtXuatXu.Font = new Font("Segoe UI", 12F);
            txtXuatXu.Location = new Point(162, 282);
            txtXuatXu.Name = "txtXuatXu";
            txtXuatXu.Size = new Size(242, 34);
            txtXuatXu.TabIndex = 10;
            txtXuatXu.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(6, 345);
            label7.Name = "label7";
            label7.Size = new Size(98, 28);
            label7.TabIndex = 9;
            label7.Text = "Hạn dùng";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(6, 285);
            label6.Name = "label6";
            label6.Size = new Size(78, 28);
            label6.TabIndex = 8;
            label6.Text = "Xuất xứ";
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 12F);
            txtDonGia.Location = new Point(162, 230);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(242, 34);
            txtDonGia.TabIndex = 7;
            // 
            // txtTenSP
            // 
            txtTenSP.Font = new Font("Segoe UI", 12F);
            txtTenSP.Location = new Point(162, 170);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(242, 34);
            txtTenSP.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 230);
            label5.Name = "label5";
            label5.Size = new Size(81, 28);
            label5.TabIndex = 6;
            label5.Text = "Đơn giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 170);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 5;
            label4.Text = "Tên sản phẩm";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Segoe UI", 12F);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 125);
            panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(btnQuanLyDanhMuc);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbDanhMuc);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(410, 481);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết";
            // 
            // btnQuanLyDanhMuc
            // 
            btnQuanLyDanhMuc.Font = new Font("Segoe UI", 9F);
            btnQuanLyDanhMuc.Location = new Point(335, 53);
            btnQuanLyDanhMuc.Name = "btnQuanLyDanhMuc";
            btnQuanLyDanhMuc.Size = new Size(69, 36);
            btnQuanLyDanhMuc.TabIndex = 2;
            btnQuanLyDanhMuc.Text = "...";
            btnQuanLyDanhMuc.UseVisualStyleBackColor = true;
            btnQuanLyDanhMuc.Click += btnQuanLyDanhMuc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 0;
            label2.Text = "Danh mục";
            // 
            // cbDanhMuc
            // 
            cbDanhMuc.FormattingEnabled = true;
            cbDanhMuc.Location = new Point(162, 53);
            cbDanhMuc.Name = "cbDanhMuc";
            cbDanhMuc.Size = new Size(166, 36);
            cbDanhMuc.TabIndex = 1;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 562);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private ListBox lstSanPham;
        private Panel panel2;
        private GroupBox groupBox2;
        private Button btnQuanLyDanhMuc;
        private ComboBox cbDanhMuc;
        private Label label2;
        private TextBox txtMaSP;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox txtXuatXu;
        private Label label7;
        private Label label6;
        private TextBox txtDonGia;
        private TextBox txtTenSP;
        private Label label5;
        private Label label4;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnLuu;
    }
}
