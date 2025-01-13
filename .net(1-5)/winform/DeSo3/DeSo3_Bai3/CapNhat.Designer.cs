namespace DeSo3_Bai3
{
    partial class CapNhat
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
            label3 = new Label();
            label4 = new Label();
            txtMa = new TextBox();
            txtTen = new TextBox();
            txtQueQuan = new TextBox();
            cboKhoa = new ComboBox();
            dataGridView1 = new DataGridView();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 137);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Quê quán";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(92, 22);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(121, 23);
            txtMa.TabIndex = 4;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(92, 58);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(121, 23);
            txtTen.TabIndex = 5;
            // 
            // txtQueQuan
            // 
            txtQueQuan.Location = new Point(92, 134);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(121, 23);
            txtQueQuan.TabIndex = 6;
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Items.AddRange(new object[] { "cơ khí", "cntt", "điện tử" });
            cboKhoa.Location = new Point(92, 98);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(121, 23);
            cboKhoa.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(228, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(322, 150);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(124, 183);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += button1_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(239, 183);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(352, 183);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // CapNhat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 232);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(dataGridView1);
            Controls.Add(cboKhoa);
            Controls.Add(txtQueQuan);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CapNhat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CapNhat";
            Load += CapNhat_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtQueQuan;
        private ComboBox cboKhoa;
        private DataGridView dataGridView1;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
    }
}