namespace bai19
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
            txtSo = new TextBox();
            btnCapNhat = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            btnChan = new Button();
            btnBinhPhuong = new Button();
            btnTang2 = new Button();
            btnXoaDangChon = new Button();
            btnXoaDauCuoi = new Button();
            btnTong = new Button();
            btnKetThuc = new Button();
            lstSo = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập số";
            // 
            // txtSo
            // 
            txtSo.Location = new Point(111, 25);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(258, 27);
            txtSo.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(407, 25);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(111, 29);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(btnChan);
            groupBox2.Controls.Add(btnBinhPhuong);
            groupBox2.Controls.Add(btnTang2);
            groupBox2.Controls.Add(btnXoaDangChon);
            groupBox2.Controls.Add(btnXoaDauCuoi);
            groupBox2.Controls.Add(btnTong);
            groupBox2.Location = new Point(252, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 280);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Các chức năng";
            // 
            // button2
            // 
            button2.Location = new Point(6, 236);
            button2.Name = "button2";
            button2.Size = new Size(254, 29);
            button2.TabIndex = 6;
            button2.Text = "Chọn số lẻ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnChan
            // 
            btnChan.Location = new Point(6, 201);
            btnChan.Name = "btnChan";
            btnChan.Size = new Size(254, 29);
            btnChan.TabIndex = 5;
            btnChan.Text = "Chọn số chẵn";
            btnChan.UseVisualStyleBackColor = true;
            btnChan.Click += btnChan_Click;
            // 
            // btnBinhPhuong
            // 
            btnBinhPhuong.Location = new Point(6, 166);
            btnBinhPhuong.Name = "btnBinhPhuong";
            btnBinhPhuong.Size = new Size(254, 29);
            btnBinhPhuong.TabIndex = 4;
            btnBinhPhuong.Text = "Thay bằng bình phương";
            btnBinhPhuong.UseVisualStyleBackColor = true;
            btnBinhPhuong.Click += btnBinhPhuong_Click;
            // 
            // btnTang2
            // 
            btnTang2.Location = new Point(6, 131);
            btnTang2.Name = "btnTang2";
            btnTang2.Size = new Size(254, 29);
            btnTang2.TabIndex = 3;
            btnTang2.Text = "Tăng mỗi phần tử lên 2";
            btnTang2.UseVisualStyleBackColor = true;
            btnTang2.Click += btnTang2_Click;
            // 
            // btnXoaDangChon
            // 
            btnXoaDangChon.Location = new Point(6, 96);
            btnXoaDangChon.Name = "btnXoaDangChon";
            btnXoaDangChon.Size = new Size(254, 29);
            btnXoaDangChon.TabIndex = 2;
            btnXoaDangChon.Text = "Xóa phần tử đang chọn";
            btnXoaDangChon.UseVisualStyleBackColor = true;
            btnXoaDangChon.Click += btnXoaDangChon_Click;
            // 
            // btnXoaDauCuoi
            // 
            btnXoaDauCuoi.Location = new Point(6, 61);
            btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            btnXoaDauCuoi.Size = new Size(254, 29);
            btnXoaDauCuoi.TabIndex = 1;
            btnXoaDauCuoi.Text = "Xóa phần tử đầu và cuối";
            btnXoaDauCuoi.UseVisualStyleBackColor = true;
            btnXoaDauCuoi.Click += btnXoaDauCuoi_Click;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(6, 26);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(254, 29);
            btnTong.TabIndex = 0;
            btnTong.Text = "Tổng của danh sách";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(32, 385);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(487, 34);
            btnKetThuc.TabIndex = 5;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // lstSo
            // 
            lstSo.FormattingEnabled = true;
            lstSo.Location = new Point(16, 35);
            lstSo.Name = "lstSo";
            lstSo.SelectionMode = SelectionMode.MultiSimple;
            lstSo.Size = new Size(200, 224);
            lstSo.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstSo);
            groupBox1.Location = new Point(7, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 280);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lớp A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 433);
            Controls.Add(groupBox1);
            Controls.Add(btnKetThuc);
            Controls.Add(groupBox2);
            Controls.Add(btnCapNhat);
            Controls.Add(txtSo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSo;
        private Button btnCapNhat;
        private GroupBox groupBox2;
        private Button button2;
        private Button btnChan;
        private Button btnBinhPhuong;
        private Button btnTang2;
        private Button btnXoaDangChon;
        private Button btnXoaDauCuoi;
        private Button btnTong;
        private Button btnKetThuc;
        private ListBox lstSo;
        private GroupBox groupBox1;
    }
}
