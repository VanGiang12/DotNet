namespace Bai20
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
            label2 = new Label();
            gbNhom1 = new GroupBox();
            lstNhom1 = new ListBox();
            label3 = new Label();
            btnThoat = new Button();
            txtTen = new TextBox();
            label4 = new Label();
            btnCapNhat = new Button();
            label1 = new Label();
            gbNhom2 = new GroupBox();
            lstNhom2 = new ListBox();
            btnMove1Right = new Button();
            btnMove1Left = new Button();
            btnMoveAllRight = new Button();
            btnMoveAllLeft = new Button();
            btnXoa = new Button();
            txtTongNhom1 = new TextBox();
            txtTongNhom2 = new TextBox();
            cbChonNhom = new ComboBox();
            gbNhom1.SuspendLayout();
            gbNhom2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(221, 9);
            label2.Name = "label2";
            label2.Size = new Size(355, 32);
            label2.TabIndex = 1;
            label2.Text = "Chương Trình Quản Lý Ca Học";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbNhom1
            // 
            gbNhom1.Controls.Add(lstNhom1);
            gbNhom1.Location = new Point(39, 192);
            gbNhom1.Name = "gbNhom1";
            gbNhom1.Size = new Size(235, 184);
            gbNhom1.TabIndex = 8;
            gbNhom1.TabStop = false;
            gbNhom1.Text = "Nhóm 1";
            // 
            // lstNhom1
            // 
            lstNhom1.Dock = DockStyle.Fill;
            lstNhom1.FormattingEnabled = true;
            lstNhom1.Location = new Point(3, 23);
            lstNhom1.Name = "lstNhom1";
            lstNhom1.SelectionMode = SelectionMode.MultiSimple;
            lstNhom1.Size = new Size(229, 158);
            lstNhom1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(30, 71);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 2;
            label3.Text = "Nhập tên SV";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(447, 123);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(153, 35);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát chương trình";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 14F);
            txtTen.Location = new Point(180, 60);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(236, 39);
            txtTen.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(30, 130);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 4;
            label4.Text = "Chọn nhóm";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(447, 60);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(153, 35);
            btnCapNhat.TabIndex = 6;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(120, 25);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 0;
            // 
            // gbNhom2
            // 
            gbNhom2.Controls.Add(lstNhom2);
            gbNhom2.Location = new Point(447, 192);
            gbNhom2.Name = "gbNhom2";
            gbNhom2.Size = new Size(235, 184);
            gbNhom2.TabIndex = 9;
            gbNhom2.TabStop = false;
            gbNhom2.Text = "Nhóm 2";
            // 
            // lstNhom2
            // 
            lstNhom2.Dock = DockStyle.Fill;
            lstNhom2.FormattingEnabled = true;
            lstNhom2.Location = new Point(3, 23);
            lstNhom2.Name = "lstNhom2";
            lstNhom2.SelectionMode = SelectionMode.MultiSimple;
            lstNhom2.Size = new Size(229, 158);
            lstNhom2.TabIndex = 1;
            // 
            // btnMove1Right
            // 
            btnMove1Right.Font = new Font("Segoe UI", 12F);
            btnMove1Right.Location = new Point(298, 203);
            btnMove1Right.Name = "btnMove1Right";
            btnMove1Right.Size = new Size(49, 47);
            btnMove1Right.TabIndex = 10;
            btnMove1Right.Text = ">";
            btnMove1Right.UseVisualStyleBackColor = true;
            btnMove1Right.Click += btnMove1Right_Click;
            // 
            // btnMove1Left
            // 
            btnMove1Left.Font = new Font("Segoe UI", 12F);
            btnMove1Left.Location = new Point(377, 203);
            btnMove1Left.Name = "btnMove1Left";
            btnMove1Left.Size = new Size(49, 47);
            btnMove1Left.TabIndex = 11;
            btnMove1Left.Text = "<";
            btnMove1Left.UseVisualStyleBackColor = true;
            btnMove1Left.Click += btnMove1Left_Click;
            // 
            // btnMoveAllRight
            // 
            btnMoveAllRight.Font = new Font("Segoe UI", 12F);
            btnMoveAllRight.Location = new Point(298, 269);
            btnMoveAllRight.Name = "btnMoveAllRight";
            btnMoveAllRight.Size = new Size(49, 47);
            btnMoveAllRight.TabIndex = 12;
            btnMoveAllRight.Text = ">>";
            btnMoveAllRight.UseVisualStyleBackColor = true;
            btnMoveAllRight.Click += btnMoveAllRight_Click;
            // 
            // btnMoveAllLeft
            // 
            btnMoveAllLeft.Font = new Font("Segoe UI", 12F);
            btnMoveAllLeft.Location = new Point(377, 269);
            btnMoveAllLeft.Name = "btnMoveAllLeft";
            btnMoveAllLeft.Size = new Size(49, 47);
            btnMoveAllLeft.TabIndex = 13;
            btnMoveAllLeft.Text = "<<";
            btnMoveAllLeft.UseVisualStyleBackColor = true;
            btnMoveAllLeft.Click += btnMoveAllLeft_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F);
            btnXoa.Location = new Point(298, 329);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 47);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // txtTongNhom1
            // 
            txtTongNhom1.Font = new Font("Segoe UI", 12F);
            txtTongNhom1.Location = new Point(61, 399);
            txtTongNhom1.Name = "txtTongNhom1";
            txtTongNhom1.Size = new Size(230, 34);
            txtTongNhom1.TabIndex = 15;
            // 
            // txtTongNhom2
            // 
            txtTongNhom2.Font = new Font("Segoe UI", 12F);
            txtTongNhom2.Location = new Point(423, 399);
            txtTongNhom2.Name = "txtTongNhom2";
            txtTongNhom2.Size = new Size(230, 34);
            txtTongNhom2.TabIndex = 16;
            // 
            // cbChonNhom
            // 
            cbChonNhom.FormattingEnabled = true;
            cbChonNhom.Items.AddRange(new object[] { "Nhóm 1", "Nhóm 2" });
            cbChonNhom.Location = new Point(180, 134);
            cbChonNhom.Name = "cbChonNhom";
            cbChonNhom.Size = new Size(236, 28);
            cbChonNhom.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 473);
            Controls.Add(cbChonNhom);
            Controls.Add(txtTongNhom2);
            Controls.Add(txtTongNhom1);
            Controls.Add(btnXoa);
            Controls.Add(btnMoveAllLeft);
            Controls.Add(btnMoveAllRight);
            Controls.Add(btnMove1Left);
            Controls.Add(btnMove1Right);
            Controls.Add(gbNhom2);
            Controls.Add(gbNhom1);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(label4);
            Controls.Add(txtTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            gbNhom1.ResumeLayout(false);
            gbNhom2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private GroupBox gbNhom1;
        private Label label3;
        private Button btnThoat;
        private TextBox txtTen;
        private Label label4;
        private Button btnCapNhat;
        private Label label1;
        private GroupBox gbNhom2;
        private Button btnMove1Right;
        private Button btnMove1Left;
        private Button btnMoveAllRight;
        private Button btnMoveAllLeft;
        private Button btnXoa;
        private TextBox txtTongNhom1;
        private TextBox txtTongNhom2;
        private ComboBox cbChonNhom;
        private ListBox lstNhom1;
        private ListBox lstNhom2;
    }
}
