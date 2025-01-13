namespace ListBox
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
            txtNhap = new TextBox();
            groupBox1 = new GroupBox();
            lstSo = new System.Windows.Forms.ListBox();
            groupBox2 = new GroupBox();
            btnLe = new Button();
            btnChan = new Button();
            btnBinhPhuong = new Button();
            btnTang2 = new Button();
            btnXoaChon = new Button();
            btnXoaDauCuoi = new Button();
            btnTong = new Button();
            btnKetThuc = new Button();
            btnCapNhat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập số";
            label1.Click += label1_Click;
            // 
            // txtNhap
            // 
            txtNhap.BorderStyle = BorderStyle.FixedSingle;
            txtNhap.Location = new Point(88, 9);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(203, 23);
            txtNhap.TabIndex = 1;
            txtNhap.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstSo);
            groupBox1.Location = new Point(12, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(117, 227);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách";
            // 
            // lstSo
            // 
            lstSo.Dock = DockStyle.Fill;
            lstSo.FormattingEnabled = true;
            lstSo.ItemHeight = 15;
            lstSo.Location = new Point(3, 19);
            lstSo.Name = "lstSo";
            lstSo.SelectionMode = SelectionMode.MultiSimple;
            lstSo.Size = new Size(111, 205);
            lstSo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLe);
            groupBox2.Controls.Add(btnChan);
            groupBox2.Controls.Add(btnBinhPhuong);
            groupBox2.Controls.Add(btnTang2);
            groupBox2.Controls.Add(btnXoaChon);
            groupBox2.Controls.Add(btnXoaDauCuoi);
            groupBox2.Controls.Add(btnTong);
            groupBox2.Location = new Point(172, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 227);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Các chức năng";
            // 
            // btnLe
            // 
            btnLe.Location = new Point(0, 193);
            btnLe.Name = "btnLe";
            btnLe.Size = new Size(200, 23);
            btnLe.TabIndex = 0;
            btnLe.Text = "Chọn số lẻ";
            btnLe.UseVisualStyleBackColor = true;
            btnLe.Click += btnLe_Click;
            // 
            // btnChan
            // 
            btnChan.Location = new Point(0, 164);
            btnChan.Name = "btnChan";
            btnChan.Size = new Size(200, 23);
            btnChan.TabIndex = 0;
            btnChan.Text = "Chọn số chẵn";
            btnChan.UseVisualStyleBackColor = true;
            btnChan.Click += btnChan_Click;
            // 
            // btnBinhPhuong
            // 
            btnBinhPhuong.Location = new Point(0, 135);
            btnBinhPhuong.Name = "btnBinhPhuong";
            btnBinhPhuong.Size = new Size(200, 23);
            btnBinhPhuong.TabIndex = 0;
            btnBinhPhuong.Text = " Bình phương";
            btnBinhPhuong.UseVisualStyleBackColor = true;
            btnBinhPhuong.Click += btnBinhPhuong_Click;
            // 
            // btnTang2
            // 
            btnTang2.Location = new Point(0, 106);
            btnTang2.Name = "btnTang2";
            btnTang2.Size = new Size(200, 23);
            btnTang2.TabIndex = 0;
            btnTang2.Text = "Tăng mỗi phần tử lên 2";
            btnTang2.UseVisualStyleBackColor = true;
            btnTang2.Click += btnTang2_Click;
            // 
            // btnXoaChon
            // 
            btnXoaChon.Location = new Point(0, 77);
            btnXoaChon.Name = "btnXoaChon";
            btnXoaChon.Size = new Size(200, 23);
            btnXoaChon.TabIndex = 0;
            btnXoaChon.Text = "Xóa phần tử đang chọn";
            btnXoaChon.UseVisualStyleBackColor = true;
            btnXoaChon.Click += btnXoaChon_Click;
            // 
            // btnXoaDauCuoi
            // 
            btnXoaDauCuoi.Location = new Point(0, 48);
            btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            btnXoaDauCuoi.Size = new Size(200, 23);
            btnXoaDauCuoi.TabIndex = 0;
            btnXoaDauCuoi.Text = "Xóa phần tử đầu và cuối";
            btnXoaDauCuoi.UseVisualStyleBackColor = true;
            btnXoaDauCuoi.Click += btnXoaDauCuoi_Click;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(0, 19);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(200, 23);
            btnTong.TabIndex = 0;
            btnTong.Text = "Tổng của danh sách";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(15, 283);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(357, 23);
            btnKetThuc.TabIndex = 4;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(297, 12);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 23);
            btnCapNhat.TabIndex = 5;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKetThuc;
            ClientSize = new Size(396, 326);
            Controls.Add(btnCapNhat);
            Controls.Add(btnKetThuc);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtNhap);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài tập listbox";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhap;
        private GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstSo;
        private GroupBox groupBox2;
        private Button btnLe;
        private Button btnChan;
        private Button btnBinhPhuong;
        private Button btnTang2;
        private Button btnXoaChon;
        private Button btnXoaDauCuoi;
        private Button btnTong;
        private Button btnKetThuc;
        private Button btnCapNhat;
    }
}