namespace bai20
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
            label2 = new Label();
            label3 = new Label();
            txtTen = new TextBox();
            cbChonNhom = new ComboBox();
            btnCapNhat = new Button();
            btnThoat = new Button();
            lstNhom1 = new ListBox();
            lstNhom2 = new ListBox();
            btnMove1Right = new Button();
            btnMove1Left = new Button();
            btnMoveAllLeft = new Button();
            btnMoveAllRight = new Button();
            btnXoa = new Button();
            txtTongNhom1 = new Label();
            txtTongNhom2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 25);
            label1.Name = "label1";
            label1.Size = new Size(195, 15);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ CA HỌC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 69);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập tên sv";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 102);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Chọn nhóm";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(116, 66);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(120, 23);
            txtTen.TabIndex = 3;
            // 
            // cbChonNhom
            // 
            cbChonNhom.FormattingEnabled = true;
            cbChonNhom.Items.AddRange(new object[] { "Nhóm 1", "Nhóm 2" });
            cbChonNhom.Location = new Point(115, 101);
            cbChonNhom.Name = "cbChonNhom";
            cbChonNhom.Size = new Size(121, 23);
            cbChonNhom.TabIndex = 4;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(297, 67);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 23);
            btnCapNhat.TabIndex = 5;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(297, 101);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lstNhom1
            // 
            lstNhom1.FormattingEnabled = true;
            lstNhom1.ItemHeight = 15;
            lstNhom1.Location = new Point(19, 143);
            lstNhom1.Name = "lstNhom1";
            lstNhom1.SelectionMode = SelectionMode.MultiSimple;
            lstNhom1.Size = new Size(168, 139);
            lstNhom1.TabIndex = 7;
            // 
            // lstNhom2
            // 
            lstNhom2.FormattingEnabled = true;
            lstNhom2.ItemHeight = 15;
            lstNhom2.Location = new Point(277, 143);
            lstNhom2.Name = "lstNhom2";
            lstNhom2.SelectionMode = SelectionMode.MultiSimple;
            lstNhom2.Size = new Size(168, 139);
            lstNhom2.TabIndex = 8;
            // 
            // btnMove1Right
            // 
            btnMove1Right.Location = new Point(189, 153);
            btnMove1Right.Name = "btnMove1Right";
            btnMove1Right.Size = new Size(32, 23);
            btnMove1Right.TabIndex = 9;
            btnMove1Right.Text = ">";
            btnMove1Right.UseVisualStyleBackColor = true;
            btnMove1Right.Click += btnMove1Right_Click;
            // 
            // btnMove1Left
            // 
            btnMove1Left.Location = new Point(239, 153);
            btnMove1Left.Name = "btnMove1Left";
            btnMove1Left.Size = new Size(32, 23);
            btnMove1Left.TabIndex = 10;
            btnMove1Left.Text = "<";
            btnMove1Left.UseVisualStyleBackColor = true;
            btnMove1Left.Click += btnMove1Left_Click;
            // 
            // btnMoveAllLeft
            // 
            btnMoveAllLeft.Location = new Point(239, 192);
            btnMoveAllLeft.Name = "btnMoveAllLeft";
            btnMoveAllLeft.Size = new Size(32, 23);
            btnMoveAllLeft.TabIndex = 11;
            btnMoveAllLeft.Text = "<<";
            btnMoveAllLeft.UseVisualStyleBackColor = true;
            btnMoveAllLeft.Click += btnMoveAllLeft_Click;
            // 
            // btnMoveAllRight
            // 
            btnMoveAllRight.Location = new Point(189, 192);
            btnMoveAllRight.Name = "btnMoveAllRight";
            btnMoveAllRight.Size = new Size(32, 23);
            btnMoveAllRight.TabIndex = 12;
            btnMoveAllRight.Text = ">>";
            btnMoveAllRight.UseVisualStyleBackColor = true;
            btnMoveAllRight.Click += btnMoveAllRight_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(189, 231);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 23);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // txtTongNhom1
            // 
            txtTongNhom1.AutoSize = true;
            txtTongNhom1.Location = new Point(19, 299);
            txtTongNhom1.Name = "txtTongNhom1";
            txtTongNhom1.Size = new Size(52, 15);
            txtTongNhom1.TabIndex = 14;
            txtTongNhom1.Text = "Tổng số ";
            // 
            // txtTongNhom2
            // 
            txtTongNhom2.AutoSize = true;
            txtTongNhom2.Location = new Point(277, 299);
            txtTongNhom2.Name = "txtTongNhom2";
            txtTongNhom2.Size = new Size(49, 15);
            txtTongNhom2.TabIndex = 15;
            txtTongNhom2.Text = "Tổng số";
            // 
            // Form1
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(479, 323);
            Controls.Add(txtTongNhom2);
            Controls.Add(txtTongNhom1);
            Controls.Add(btnXoa);
            Controls.Add(btnMoveAllRight);
            Controls.Add(btnMoveAllLeft);
            Controls.Add(btnMove1Left);
            Controls.Add(btnMove1Right);
            Controls.Add(lstNhom2);
            Controls.Add(lstNhom1);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(cbChonNhom);
            Controls.Add(txtTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTen;
        private ComboBox cbChonNhom;
        private Button btnCapNhat;
        private Button btnThoat;
        private ListBox lstNhom1;
        private ListBox lstNhom2;
        private Button btnMove1Right;
        private Button btnMove1Left;
        private Button btnMoveAllLeft;
        private Button btnMoveAllRight;
        private Button btnXoa;
        private Label txtTongNhom1;
        private Label txtTongNhom2;
    }
}