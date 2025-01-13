namespace quanLySanPham
{
    partial class frmDanhMuc
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
            groupBox1 = new GroupBox();
            lstDanhMuc = new ListBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            txtMa = new TextBox();
            label2 = new Label();
            txtTen = new TextBox();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstDanhMuc);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 253);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách danh mục";
            // 
            // lstDanhMuc
            // 
            lstDanhMuc.Dock = DockStyle.Fill;
            lstDanhMuc.FormattingEnabled = true;
            lstDanhMuc.ItemHeight = 28;
            lstDanhMuc.Location = new Point(3, 30);
            lstDanhMuc.Name = "lstDanhMuc";
            lstDanhMuc.Size = new Size(244, 220);
            lstDanhMuc.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(txtTen);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtMa);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(250, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(294, 253);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết danh mục";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã danh mục";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(12, 83);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(270, 34);
            txtMa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 120);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên danh mục";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(12, 163);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(270, 34);
            txtTen.TabIndex = 3;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(12, 211);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(77, 36);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(108, 211);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(77, 36);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(200, 211);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(77, 36);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmDanhMuc
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 253);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "frmDanhMuc";
            StartPosition = FormStartPosition.CenterParent;
            Text = "QUẢN LÝ DANH MỤC";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstDanhMuc;
        private GroupBox groupBox2;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnLuu;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtMa;
        private Label label1;
    }
}