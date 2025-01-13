namespace testSQL
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
            label4 = new Label();
            label5 = new Label();
            txtHoTen = new TextBox();
            txtNamSinh = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            groupBox1 = new GroupBox();
            dgvSinhVien = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            label6 = new Label();
            txtMa = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 78);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 117);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 1;
            label2.Text = "Năm sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 159);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 2;
            label3.Text = "Mức lương";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 209);
            label4.Name = "label4";
            label4.Size = new Size(91, 19);
            label4.TabIndex = 3;
            label4.Text = "Tiền trong TK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 264);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 4;
            label5.Text = "Lương TN";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(118, 72);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(191, 25);
            txtHoTen.TabIndex = 5;
            // 
            // txtNamSinh
            // 
            txtNamSinh.Location = new Point(118, 111);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(191, 25);
            txtNamSinh.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(118, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 25);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(118, 202);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 25);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(118, 258);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(191, 25);
            textBox5.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvSinhVien);
            groupBox1.Location = new Point(333, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 265);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách Teamleader";
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Dock = DockStyle.Fill;
            dgvSinhVien.Location = new Point(3, 21);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowTemplate.Height = 25;
            dgvSinhVien.Size = new Size(246, 241);
            dgvSinhVien.TabIndex = 0;
            dgvSinhVien.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(32, 324);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(92, 36);
            btnThem.TabIndex = 11;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(162, 324);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(92, 36);
            btnSua.TabIndex = 12;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(296, 324);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(92, 36);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(427, 324);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(92, 36);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "&Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 37);
            label6.Name = "label6";
            label6.Size = new Size(29, 19);
            label6.TabIndex = 15;
            label6.Text = "Mã";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(118, 34);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(191, 25);
            txtMa.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 370);
            Controls.Add(txtMa);
            Controls.Add(label6);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txtNamSinh);
            Controls.Add(txtHoTen);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtHoTen;
        private TextBox txtNamSinh;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private GroupBox groupBox1;
        private DataGridView dgvSinhVien;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Label label6;
        private TextBox txtMa;
    }
}