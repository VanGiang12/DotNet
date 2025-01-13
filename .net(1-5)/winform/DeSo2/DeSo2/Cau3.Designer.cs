namespace DeSo2
{
    partial class Cau3
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
            label5 = new Label();
            label6 = new Label();
            txtMa = new TextBox();
            txtHoTen = new TextBox();
            txtQueQuan = new TextBox();
            btnDau = new Button();
            btnTruoc = new Button();
            btnSau = new Button();
            btnCuoi = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtNgaySinh = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(370, 28);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ BÓNG ĐÁ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 0, 0);
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 28);
            label2.Name = "label2";
            label2.Size = new Size(370, 15);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 59);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Mã cầu thủ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 94);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Họ tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 129);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 168);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 5;
            label6.Text = "Quê quán";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(100, 56);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(232, 23);
            txtMa.TabIndex = 6;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(100, 91);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(232, 23);
            txtHoTen.TabIndex = 7;
            // 
            // txtQueQuan
            // 
            txtQueQuan.Location = new Point(100, 165);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(232, 23);
            txtQueQuan.TabIndex = 9;
            // 
            // btnDau
            // 
            btnDau.Location = new Point(82, 203);
            btnDau.Name = "btnDau";
            btnDau.Size = new Size(59, 23);
            btnDau.TabIndex = 11;
            btnDau.Text = "|<<";
            btnDau.UseVisualStyleBackColor = true;
            btnDau.Click += btnFirst_Click;
            // 
            // btnTruoc
            // 
            btnTruoc.Location = new Point(146, 203);
            btnTruoc.Name = "btnTruoc";
            btnTruoc.Size = new Size(59, 23);
            btnTruoc.TabIndex = 12;
            btnTruoc.Text = "<<";
            btnTruoc.UseVisualStyleBackColor = true;
            btnTruoc.Click += btnBack_Click;
            // 
            // btnSau
            // 
            btnSau.Location = new Point(211, 203);
            btnSau.Name = "btnSau";
            btnSau.Size = new Size(59, 23);
            btnSau.TabIndex = 13;
            btnSau.Text = ">>";
            btnSau.UseVisualStyleBackColor = true;
            btnSau.Click += btnNext_Click;
            // 
            // btnCuoi
            // 
            btnCuoi.Location = new Point(273, 203);
            btnCuoi.Name = "btnCuoi";
            btnCuoi.Size = new Size(59, 23);
            btnCuoi.TabIndex = 14;
            btnCuoi.Text = ">>|";
            btnCuoi.UseVisualStyleBackColor = true;
            btnCuoi.Click += btnEnd_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(273, 232);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(59, 23);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(211, 232);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(59, 23);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Update";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnUpdate_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(146, 232);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(59, 23);
            btnSua.TabIndex = 16;
            btnSua.Text = "Tìm";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(82, 232);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(59, 23);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(100, 126);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(232, 23);
            txtNgaySinh.TabIndex = 20;
            // 
            // Cau3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 444);
            Controls.Add(txtNgaySinh);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnCuoi);
            Controls.Add(btnSau);
            Controls.Add(btnTruoc);
            Controls.Add(btnDau);
            Controls.Add(txtQueQuan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMa);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cau3";
            Text = "Cau3";
            Load += Cau3_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMa;
        private TextBox txtHoTen;
        private TextBox txtQueQuan;
        private Button btnDau;
        private Button btnTruoc;
        private Button btnSau;
        private Button btnCuoi;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtNgaySinh;
    }
}