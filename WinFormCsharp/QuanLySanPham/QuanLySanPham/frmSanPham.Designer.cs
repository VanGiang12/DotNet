namespace QuanLySanPham
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
            lstDanhSachSP = new ListBox();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            dtpHanSuDung = new DateTimePicker();
            txtXuatXu = new TextBox();
            txtDonGia = new TextBox();
            txtMa = new TextBox();
            txtTen = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnQuanLyDanhMuc = new Button();
            cboDanhMuc = new ComboBox();
            label2 = new Label();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 53);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(749, 53);
            label1.TabIndex = 0;
            label1.Text = "Chương trình quản lý sản phẩm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 53);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(749, 478);
            splitContainer1.SplitterDistance = 269;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstDanhSachSP);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(269, 478);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // lstDanhSachSP
            // 
            lstDanhSachSP.Dock = DockStyle.Fill;
            lstDanhSachSP.FormattingEnabled = true;
            lstDanhSachSP.ItemHeight = 17;
            lstDanhSachSP.Location = new Point(3, 22);
            lstDanhSachSP.Margin = new Padding(3, 4, 3, 4);
            lstDanhSachSP.Name = "lstDanhSachSP";
            lstDanhSachSP.Size = new Size(263, 452);
            lstDanhSachSP.TabIndex = 0;
            lstDanhSachSP.SelectedIndexChanged += lstDanhSachSP_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(476, 478);
            panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(dtpHanSuDung);
            groupBox2.Controls.Add(txtXuatXu);
            groupBox2.Controls.Add(txtDonGia);
            groupBox2.Controls.Add(txtMa);
            groupBox2.Controls.Add(txtTen);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnQuanLyDanhMuc);
            groupBox2.Controls.Add(cboDanhMuc);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(476, 478);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(288, 221);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 26);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(207, 221);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 26);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(126, 221);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 26);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // dtpHanSuDung
            // 
            dtpHanSuDung.CustomFormat = "dd/MM/yyy";
            dtpHanSuDung.Format = DateTimePickerFormat.Custom;
            dtpHanSuDung.Location = new Point(95, 189);
            dtpHanSuDung.Margin = new Padding(3, 4, 3, 4);
            dtpHanSuDung.Name = "dtpHanSuDung";
            dtpHanSuDung.Size = new Size(318, 25);
            dtpHanSuDung.TabIndex = 12;
            dtpHanSuDung.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtXuatXu
            // 
            txtXuatXu.Location = new Point(95, 151);
            txtXuatXu.Margin = new Padding(3, 4, 3, 4);
            txtXuatXu.Name = "txtXuatXu";
            txtXuatXu.Size = new Size(318, 25);
            txtXuatXu.TabIndex = 10;
            txtXuatXu.TextChanged += textBox4_TextChanged;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(95, 119);
            txtDonGia.Margin = new Padding(3, 4, 3, 4);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(318, 25);
            txtDonGia.TabIndex = 8;
            txtDonGia.TextChanged += textBox3_TextChanged;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(95, 55);
            txtMa.Margin = new Padding(3, 4, 3, 4);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(318, 25);
            txtMa.TabIndex = 4;
            txtMa.TextChanged += textBox2_TextChanged;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(95, 87);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(318, 25);
            txtTen.TabIndex = 6;
            txtTen.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 185);
            label7.Name = "label7";
            label7.Size = new Size(88, 19);
            label7.TabIndex = 11;
            label7.Text = "Hạn sử dụng";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 151);
            label6.Name = "label6";
            label6.Size = new Size(55, 19);
            label6.TabIndex = 9;
            label6.Text = "Xuất xứ";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 123);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 7;
            label5.Text = "Đơn giá";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 87);
            label4.Name = "label4";
            label4.Size = new Size(49, 19);
            label4.TabIndex = 5;
            label4.Text = "Tên Sp";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 60);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 3;
            label3.Text = "Mã Sp";
            label3.Click += label3_Click;
            // 
            // btnQuanLyDanhMuc
            // 
            btnQuanLyDanhMuc.Location = new Point(338, 21);
            btnQuanLyDanhMuc.Margin = new Padding(3, 4, 3, 4);
            btnQuanLyDanhMuc.Name = "btnQuanLyDanhMuc";
            btnQuanLyDanhMuc.Size = new Size(75, 26);
            btnQuanLyDanhMuc.TabIndex = 2;
            btnQuanLyDanhMuc.Text = "...";
            btnQuanLyDanhMuc.UseVisualStyleBackColor = true;
            btnQuanLyDanhMuc.Click += btnQuanLyDanhMuc_Click;
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(95, 21);
            cboDanhMuc.Margin = new Padding(3, 4, 3, 4);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(237, 25);
            cboDanhMuc.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 30);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 0;
            label2.Text = "Danh mục";
            label2.Click += label2_Click;
            // 
            // frmSanPham
            // 
            AcceptButton = btnLuu;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(749, 531);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private ListBox lstDanhSachSP;
        private Panel panel2;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnQuanLyDanhMuc;
        private ComboBox cboDanhMuc;
        private Label label2;
        private DateTimePicker dtpHanSuDung;
        private TextBox txtXuatXu;
        private TextBox txtDonGia;
        private TextBox txtMa;
        private TextBox txtTen;
        private Label label7;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnLuu;
    }
}