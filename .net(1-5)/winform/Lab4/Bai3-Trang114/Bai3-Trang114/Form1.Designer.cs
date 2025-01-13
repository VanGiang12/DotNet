namespace Bai3_Trang114
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
            txtNhap = new TextBox();
            btnCapNhat = new Button();
            groupBox1 = new GroupBox();
            lstLopA = new ListBox();
            groupBox2 = new GroupBox();
            lstLopB = new ListBox();
            btnXoa = new Button();
            btnKetThuc = new Button();
            btnLeftRight = new Button();
            btnRigthLeft = new Button();
            btnAllLeftRight = new Button();
            btnAllRigthLeft = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(89, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 21);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 45);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(72, 41);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(189, 23);
            txtNhap.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(267, 41);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 23);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstLopA);
            groupBox1.Location = new Point(12, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(135, 167);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lớp A";
            // 
            // lstLopA
            // 
            lstLopA.Dock = DockStyle.Fill;
            lstLopA.FormattingEnabled = true;
            lstLopA.ItemHeight = 15;
            lstLopA.Location = new Point(3, 19);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiSimple;
            lstLopA.Size = new Size(129, 145);
            lstLopA.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstLopB);
            groupBox2.Location = new Point(236, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(126, 167);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lớp B";
            // 
            // lstLopB
            // 
            lstLopB.Dock = DockStyle.Fill;
            lstLopB.FormattingEnabled = true;
            lstLopB.ItemHeight = 15;
            lstLopB.Location = new Point(3, 19);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiSimple;
            lstLopB.Size = new Size(120, 145);
            lstLopB.TabIndex = 0;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(23, 270);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(267, 270);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(75, 23);
            btnKetThuc.TabIndex = 7;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnLeftRight
            // 
            btnLeftRight.Location = new Point(153, 120);
            btnLeftRight.Name = "btnLeftRight";
            btnLeftRight.Size = new Size(34, 23);
            btnLeftRight.TabIndex = 8;
            btnLeftRight.Text = ">";
            btnLeftRight.UseVisualStyleBackColor = true;
            btnLeftRight.Click += btnLeftRight_Click;
            // 
            // btnRigthLeft
            // 
            btnRigthLeft.Location = new Point(193, 120);
            btnRigthLeft.Name = "btnRigthLeft";
            btnRigthLeft.Size = new Size(37, 23);
            btnRigthLeft.TabIndex = 9;
            btnRigthLeft.Text = "<";
            btnRigthLeft.UseVisualStyleBackColor = true;
            btnRigthLeft.Click += btnRigthLeft_Click;
            // 
            // btnAllLeftRight
            // 
            btnAllLeftRight.Location = new Point(153, 158);
            btnAllLeftRight.Name = "btnAllLeftRight";
            btnAllLeftRight.Size = new Size(37, 23);
            btnAllLeftRight.TabIndex = 10;
            btnAllLeftRight.Text = ">>";
            btnAllLeftRight.UseVisualStyleBackColor = true;
            btnAllLeftRight.Click += btnAllLeftRight_Click;
            // 
            // btnAllRigthLeft
            // 
            btnAllRigthLeft.Location = new Point(193, 158);
            btnAllRigthLeft.Name = "btnAllRigthLeft";
            btnAllRigthLeft.Size = new Size(34, 23);
            btnAllRigthLeft.TabIndex = 11;
            btnAllRigthLeft.Text = "<<";
            btnAllRigthLeft.UseVisualStyleBackColor = true;
            btnAllRigthLeft.Click += btnAllRigthLeft_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKetThuc;
            ClientSize = new Size(374, 305);
            Controls.Add(btnAllRigthLeft);
            Controls.Add(btnAllLeftRight);
            Controls.Add(btnRigthLeft);
            Controls.Add(btnLeftRight);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoa);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCapNhat);
            Controls.Add(txtNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNhap;
        private Button btnCapNhat;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnKetThuc;
        private ListBox lstLopA;
        private Button btnLeftRight;
        private Button btnRigthLeft;
        private Button btnAllLeftRight;
        private Button btnAllRigthLeft;
        private ListBox lstLopB;
    }
}