namespace ListBox
{
    partial class frmSinhVien2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtTen = new TextBox();
            btnCapNhat = new Button();
            lstLopA = new System.Windows.Forms.ListBox();
            lstLopB = new System.Windows.Forms.ListBox();
            btnPhai = new Button();
            btnPhai2 = new Button();
            btnTrai = new Button();
            btnTrai2 = new Button();
            btnXoaA = new Button();
            btnKetThuc = new Button();
            btnXoaB = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Cập nhật hệ thống";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên SV";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(59, 36);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(189, 23);
            txtTen.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(264, 36);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 23);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.ItemHeight = 15;
            lstLopA.Location = new Point(12, 65);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(120, 169);
            lstLopA.TabIndex = 4;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.ItemHeight = 15;
            lstLopB.Location = new Point(219, 65);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(120, 169);
            lstLopB.TabIndex = 5;
            // 
            // btnPhai
            // 
            btnPhai.Location = new Point(138, 65);
            btnPhai.Name = "btnPhai";
            btnPhai.Size = new Size(75, 23);
            btnPhai.TabIndex = 6;
            btnPhai.Text = ">";
            btnPhai.UseVisualStyleBackColor = true;
            btnPhai.Click += btnPhai_Click;
            // 
            // btnPhai2
            // 
            btnPhai2.Location = new Point(138, 94);
            btnPhai2.Name = "btnPhai2";
            btnPhai2.Size = new Size(75, 23);
            btnPhai2.TabIndex = 7;
            btnPhai2.Text = ">>";
            btnPhai2.UseVisualStyleBackColor = true;
            btnPhai2.Click += btnPhai2_Click;
            // 
            // btnTrai
            // 
            btnTrai.Location = new Point(138, 123);
            btnTrai.Name = "btnTrai";
            btnTrai.Size = new Size(75, 23);
            btnTrai.TabIndex = 8;
            btnTrai.Text = "<";
            btnTrai.UseVisualStyleBackColor = true;
            btnTrai.Click += btnTrai_Click;
            // 
            // btnTrai2
            // 
            btnTrai2.Location = new Point(138, 152);
            btnTrai2.Name = "btnTrai2";
            btnTrai2.Size = new Size(75, 23);
            btnTrai2.TabIndex = 9;
            btnTrai2.Text = "<<";
            btnTrai2.UseVisualStyleBackColor = true;
            btnTrai2.Click += btnTrai2_Click;
            // 
            // btnXoaA
            // 
            btnXoaA.Location = new Point(29, 257);
            btnXoaA.Name = "btnXoaA";
            btnXoaA.Size = new Size(75, 23);
            btnXoaA.TabIndex = 10;
            btnXoaA.Text = "Xóa lớp A";
            btnXoaA.UseVisualStyleBackColor = true;
            btnXoaA.Click += btnXoaA_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(138, 257);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(75, 23);
            btnKetThuc.TabIndex = 11;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnXoaB
            // 
            btnXoaB.Location = new Point(254, 257);
            btnXoaB.Name = "btnXoaB";
            btnXoaB.Size = new Size(75, 23);
            btnXoaB.TabIndex = 12;
            btnXoaB.Text = "Xóa lớp B";
            btnXoaB.UseVisualStyleBackColor = true;
            btnXoaB.Click += btnXoaB_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmSinhVien2
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKetThuc;
            ClientSize = new Size(357, 294);
            Controls.Add(btnXoaB);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaA);
            Controls.Add(btnTrai2);
            Controls.Add(btnTrai);
            Controls.Add(btnPhai2);
            Controls.Add(btnPhai);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(btnCapNhat);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmSinhVien2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSinhVien2";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTen;
        private Button btnCapNhat;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.ListBox lstLopB;
        private Button btnPhai;
        private Button btnPhai2;
        private Button btnTrai;
        private Button btnTrai2;
        private Button btnXoaA;
        private Button btnKetThuc;
        private Button btnXoaB;
        private ErrorProvider errorProvider1;
    }
}