namespace ListBox
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
            label1 = new Label();
            label2 = new Label();
            txtMa = new TextBox();
            txtTen = new TextBox();
            btnLuu = new Button();
            btnXoa = new Button();
            lstSinhVien = new System.Windows.Forms.ListBox();
            btnthoat = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 35);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 64);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(98, 32);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(302, 23);
            txtMa.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(98, 61);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(300, 23);
            txtTen.TabIndex = 3;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(121, 100);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(221, 100);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lstSinhVien
            // 
            lstSinhVien.FormattingEnabled = true;
            lstSinhVien.ItemHeight = 15;
            lstSinhVien.Location = new Point(34, 148);
            lstSinhVien.Name = "lstSinhVien";
            lstSinhVien.SelectionMode = SelectionMode.MultiSimple;
            lstSinhVien.Size = new Size(414, 154);
            lstSinhVien.TabIndex = 6;
            lstSinhVien.SelectedIndexChanged += lstSinhVien_SelectedIndexChanged;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(312, 100);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(75, 23);
            btnthoat.TabIndex = 7;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(510, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "mã";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "tên";
            Column2.Name = "Column2";
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnthoat;
            ClientSize = new Size(840, 389);
            Controls.Add(dataGridView1);
            Controls.Add(btnthoat);
            Controls.Add(lstSinhVien);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSinhVien";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMa;
        private TextBox txtTen;
        private Button btnLuu;
        private Button btnXoa;
        private System.Windows.Forms.ListBox lstSinhVien;
        private Button btnthoat;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}