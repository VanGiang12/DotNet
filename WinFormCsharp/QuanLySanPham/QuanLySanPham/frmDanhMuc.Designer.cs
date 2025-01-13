namespace QuanLySanPham
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
            btnThoatDM = new Button();
            btnXoaDM = new Button();
            btnLuuDM = new Button();
            label2 = new Label();
            txtTenDM = new TextBox();
            txtMaDM = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstDanhMuc);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(314, 267);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách danh mục";
            // 
            // lstDanhMuc
            // 
            lstDanhMuc.Dock = DockStyle.Fill;
            lstDanhMuc.FormattingEnabled = true;
            lstDanhMuc.ItemHeight = 28;
            lstDanhMuc.Location = new Point(5, 33);
            lstDanhMuc.Margin = new Padding(5, 6, 5, 6);
            lstDanhMuc.Name = "lstDanhMuc";
            lstDanhMuc.Size = new Size(304, 228);
            lstDanhMuc.TabIndex = 0;
            lstDanhMuc.SelectedIndexChanged += lstDanhMuc_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThoatDM);
            groupBox2.Controls.Add(btnXoaDM);
            groupBox2.Controls.Add(btnLuuDM);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtTenDM);
            groupBox2.Controls.Add(txtMaDM);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(314, 0);
            groupBox2.Margin = new Padding(5, 6, 5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 6, 5, 6);
            groupBox2.Size = new Size(307, 267);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết danh mục";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnThoatDM
            // 
            btnThoatDM.Location = new Point(188, 209);
            btnThoatDM.Name = "btnThoatDM";
            btnThoatDM.Size = new Size(75, 35);
            btnThoatDM.TabIndex = 6;
            btnThoatDM.Text = "Đóng";
            btnThoatDM.UseVisualStyleBackColor = true;
            btnThoatDM.Click += btnThoatDM_Click;
            // 
            // btnXoaDM
            // 
            btnXoaDM.Location = new Point(107, 209);
            btnXoaDM.Name = "btnXoaDM";
            btnXoaDM.Size = new Size(75, 35);
            btnXoaDM.TabIndex = 5;
            btnXoaDM.Text = "Xóa";
            btnXoaDM.UseVisualStyleBackColor = true;
            btnXoaDM.Click += btnXoaDM_Click;
            // 
            // btnLuuDM
            // 
            btnLuuDM.Location = new Point(26, 209);
            btnLuuDM.Name = "btnLuuDM";
            btnLuuDM.Size = new Size(75, 35);
            btnLuuDM.TabIndex = 4;
            btnLuuDM.Text = "Lưu";
            btnLuuDM.UseVisualStyleBackColor = true;
            btnLuuDM.Click += btnLuuDM_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 118);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên danh mục";
            // 
            // txtTenDM
            // 
            txtTenDM.Location = new Point(9, 151);
            txtTenDM.Margin = new Padding(5, 6, 5, 6);
            txtTenDM.Name = "txtTenDM";
            txtTenDM.Size = new Size(276, 34);
            txtTenDM.TabIndex = 3;
            // 
            // txtMaDM
            // 
            txtMaDM.Location = new Point(9, 69);
            txtMaDM.Margin = new Padding(5, 6, 5, 6);
            txtMaDM.Name = "txtMaDM";
            txtMaDM.Size = new Size(276, 34);
            txtMaDM.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 35);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã danh mục";
            // 
            // frmDanhMuc
            // 
            AcceptButton = btnLuuDM;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoatDM;
            ClientSize = new Size(621, 267);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "frmDanhMuc";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý danh mục";
            Load += frmDanhMuc_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstDanhMuc;
        private GroupBox groupBox2;
        private Button btnThoatDM;
        private Button btnXoaDM;
        private Button btnLuuDM;
        private Label label2;
        private TextBox txtTenDM;
        private TextBox txtMaDM;
        private Label label1;
    }
}