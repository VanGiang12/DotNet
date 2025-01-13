namespace ThietKeMuaVeXemPhim_B37
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            lstDanhSach = new ListBox();
            panel3 = new Panel();
            btnThoat = new Button();
            btnHuy = new Button();
            btnChon = new Button();
            lblTongThanhTien = new Label();
            label3 = new Label();
            lblThanhTien = new Label();
            label2 = new Label();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            pnDatGhe = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 47);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(214, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(311, 28);
            label1.TabIndex = 0;
            label1.Text = "Chương Trình Đặt Vé Xem Phim";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 47);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 461);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstDanhSach);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(266, 461);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Đặt vé";
            // 
            // lstDanhSach
            // 
            lstDanhSach.Dock = DockStyle.Fill;
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.ItemHeight = 21;
            lstDanhSach.Location = new Point(4, 26);
            lstDanhSach.Margin = new Padding(4);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(258, 431);
            lstDanhSach.TabIndex = 0;
            lstDanhSach.SelectedIndexChanged += lstDanhSach_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnThoat);
            panel3.Controls.Add(btnHuy);
            panel3.Controls.Add(btnChon);
            panel3.Controls.Add(lblTongThanhTien);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblThanhTien);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(266, 408);
            panel3.Name = "panel3";
            panel3.Size = new Size(416, 100);
            panel3.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThoat.Location = new Point(338, 63);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 31);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(88, 65);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 31);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnChon
            // 
            btnChon.Location = new Point(7, 63);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(75, 33);
            btnChon.TabIndex = 2;
            btnChon.Text = "Chọn";
            btnChon.UseVisualStyleBackColor = true;
            btnChon.Click += btnChon_Click;
            // 
            // lblTongThanhTien
            // 
            lblTongThanhTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTongThanhTien.BorderStyle = BorderStyle.Fixed3D;
            lblTongThanhTien.ForeColor = Color.Red;
            lblTongThanhTien.Location = new Point(134, 34);
            lblTongThanhTien.Name = "lblTongThanhTien";
            lblTongThanhTien.Size = new Size(279, 21);
            lblTongThanhTien.TabIndex = 1;
            lblTongThanhTien.TextAlign = ContentAlignment.MiddleRight;
            lblTongThanhTien.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 34);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 1;
            label3.Text = "Tổng Thành Tiền";
            label3.Click += label3_Click;
            // 
            // lblThanhTien
            // 
            lblThanhTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblThanhTien.BorderStyle = BorderStyle.Fixed3D;
            lblThanhTien.ForeColor = Color.Red;
            lblThanhTien.Location = new Point(133, 3);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(280, 21);
            lblThanhTien.TabIndex = 0;
            lblThanhTien.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 0;
            label2.Text = "Thành Tiền";
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(266, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(416, 361);
            panel4.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pnDatGhe);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 361);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Màn ảnh";
            // 
            // pnDatGhe
            // 
            pnDatGhe.ColumnCount = 10;
            pnDatGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnDatGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnDatGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnDatGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnDatGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnDatGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnDatGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnDatGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnDatGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnDatGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnDatGhe.Dock = DockStyle.Fill;
            pnDatGhe.Location = new Point(3, 25);
            pnDatGhe.Name = "pnDatGhe";
            pnDatGhe.RowCount = 10;
            pnDatGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnDatGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnDatGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnDatGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnDatGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnDatGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnDatGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnDatGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnDatGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnDatGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnDatGhe.Size = new Size(410, 333);
            pnDatGhe.TabIndex = 0;
            // 
            // Form1
            // 
            AcceptButton = btnChon;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 508);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt vé xem phim";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private ListBox lstDanhSach;
        private Panel panel3;
        private Button btnChon;
        private Label label3;
        private Label lblThanhTien;
        private Label label2;
        private Panel panel4;
        private Button btnThoat;
        private Button btnHuy;
        private Label lblTongThanhTien;
        private GroupBox groupBox2;
        private TableLayoutPanel pnDatGhe;
    }
}