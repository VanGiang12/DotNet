namespace bai19
{
    partial class frmSinhVien
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
            lstSinhVien = new ListBox();
            label1 = new Label();
            txtMa = new TextBox();
            label2 = new Label();
            txtTen = new TextBox();
            btnLuu = new Button();
            btnXoa = new Button();
            SuspendLayout();
            // 
            // lstSinhVien
            // 
            lstSinhVien.FormattingEnabled = true;
            lstSinhVien.Location = new Point(24, 152);
            lstSinhVien.Name = "lstSinhVien";
            lstSinhVien.Size = new Size(488, 204);
            lstSinhVien.TabIndex = 0;
            lstSinhVien.SelectedIndexChanged += lstSinhVien_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 20);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 1;
            label1.Text = " Mã";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(140, 17);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(372, 27);
            txtMa.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 66);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(140, 59);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(372, 27);
            txtTen.TabIndex = 4;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(187, 105);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(316, 105);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.BottomCenter;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 377);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(txtMa);
            Controls.Add(label1);
            Controls.Add(lstSinhVien);
            Name = "frmSinhVien";
            Text = "frmSinhVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSinhVien;
        private Label label1;
        private TextBox txtMa;
        private Label label2;
        private TextBox txtTen;
        private Button btnLuu;
        private Button btnXoa;
    }
}