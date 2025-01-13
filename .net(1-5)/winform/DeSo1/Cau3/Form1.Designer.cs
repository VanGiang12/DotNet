namespace Cau3
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
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            txtMa = new TextBox();
            txtTen = new TextBox();
            txtNS = new TextBox();
            txtMucLuong = new TextBox();
            txtLuongTN = new TextBox();
            label6 = new Label();
            txtTienTK = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 31);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 0;
            label1.Text = "MÃ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 79);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 119);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Năm sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 157);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "Mức lương";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 206);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "Lương TN";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(248, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(540, 236);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(47, 321);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(197, 342);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(338, 316);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(481, 345);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(94, 34);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(100, 23);
            txtMa.TabIndex = 10;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(95, 81);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(100, 23);
            txtTen.TabIndex = 11;
            // 
            // txtNS
            // 
            txtNS.Location = new Point(106, 120);
            txtNS.Name = "txtNS";
            txtNS.Size = new Size(100, 23);
            txtNS.TabIndex = 12;
            // 
            // txtMucLuong
            // 
            txtMucLuong.Location = new Point(121, 158);
            txtMucLuong.Name = "txtMucLuong";
            txtMucLuong.Size = new Size(100, 23);
            txtMucLuong.TabIndex = 13;
            // 
            // txtLuongTN
            // 
            txtLuongTN.Location = new Point(126, 205);
            txtLuongTN.Name = "txtLuongTN";
            txtLuongTN.Size = new Size(100, 23);
            txtLuongTN.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 243);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 15;
            label6.Text = "Tiền tk";
            // 
            // txtTienTK
            // 
            txtTienTK.Location = new Point(125, 256);
            txtTienTK.Name = "txtTienTK";
            txtTienTK.Size = new Size(100, 23);
            txtTienTK.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTienTK);
            Controls.Add(label6);
            Controls.Add(txtLuongTN);
            Controls.Add(txtMucLuong);
            Controls.Add(txtNS);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtNS;
        private TextBox txtMucLuong;
        private TextBox txtLuongTN;
        private Label label6;
        private TextBox txtTienTK;
    }
}