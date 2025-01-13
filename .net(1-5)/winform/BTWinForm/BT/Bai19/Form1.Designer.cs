namespace Bai19
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
            groupBox1 = new GroupBox();
            lstDaySo = new ListBox();
            groupBox2 = new GroupBox();
            btnChonSoLe = new Button();
            btnChonSoChan = new Button();
            btnBinhPhuong = new Button();
            btnTang2 = new Button();
            btnXoaDangChon = new Button();
            btnXoaDauCuoi = new Button();
            btnTongDS = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập số";
            // 
            // txtSo
            // 
            txtSo.Location = new Point(80, 15);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(188, 23);
            txtSo.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(274, 18);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 23);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            btnCapNhat.KeyDown += txtSo_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstDaySo);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(109, 235);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lớp A";
            // 
            // lstDaySo
            // 
            lstDaySo.Dock = DockStyle.Fill;
            lstDaySo.FormattingEnabled = true;
            lstDaySo.ItemHeight = 15;
            lstDaySo.Location = new Point(3, 19);
            lstDaySo.Name = "lstDaySo";
            lstDaySo.SelectionMode = SelectionMode.MultiSimple;
            lstDaySo.Size = new Size(103, 213);
            lstDaySo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnChonSoLe);
            groupBox2.Controls.Add(btnChonSoChan);
            groupBox2.Controls.Add(btnBinhPhuong);
            groupBox2.Controls.Add(btnTang2);
            groupBox2.Controls.Add(btnXoaDangChon);
            groupBox2.Controls.Add(btnXoaDauCuoi);
            groupBox2.Controls.Add(btnTongDS);
            groupBox2.Location = new Point(127, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(222, 232);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Các chức năng";
            // 
            // btnChonSoLe
            // 
            btnChonSoLe.Location = new Point(6, 203);
            btnChonSoLe.Name = "btnChonSoLe";
            btnChonSoLe.Size = new Size(210, 23);
            btnChonSoLe.TabIndex = 6;
            btnChonSoLe.Text = "Chọn sỗ lẻ";
            btnChonSoLe.UseVisualStyleBackColor = true;
            btnChonSoLe.Click += btnChonSoLe_Click;
            // 
            // btnChonSoChan
            // 
            btnChonSoChan.Location = new Point(6, 177);
            btnChonSoChan.Name = "btnChonSoChan";
            btnChonSoChan.Size = new Size(210, 23);
            btnChonSoChan.TabIndex = 5;
            btnChonSoChan.Text = "Chọn sỗ chẵn";
            btnChonSoChan.UseVisualStyleBackColor = true;
            btnChonSoChan.Click += btnChonSoChan_Click;
            // 
            // btnBinhPhuong
            // 
            btnBinhPhuong.Location = new Point(6, 146);
            btnBinhPhuong.Name = "btnBinhPhuong";
            btnBinhPhuong.Size = new Size(210, 23);
            btnBinhPhuong.TabIndex = 4;
            btnBinhPhuong.Text = "Thay bằng bình phương";
            btnBinhPhuong.UseVisualStyleBackColor = true;
            btnBinhPhuong.Click += btnBinhPhuong_Click;
            // 
            // btnTang2
            // 
            btnTang2.Location = new Point(6, 115);
            btnTang2.Name = "btnTang2";
            btnTang2.Size = new Size(210, 23);
            btnTang2.TabIndex = 3;
            btnTang2.Text = "Tăng mỗi phần tử lên 2";
            btnTang2.UseVisualStyleBackColor = true;
            btnTang2.Click += btnTang2_Click;
            // 
            // btnXoaDangChon
            // 
            btnXoaDangChon.Location = new Point(6, 84);
            btnXoaDangChon.Name = "btnXoaDangChon";
            btnXoaDangChon.Size = new Size(210, 23);
            btnXoaDangChon.TabIndex = 2;
            btnXoaDangChon.Text = "Xóa phần tử đang chọn";
            btnXoaDangChon.UseVisualStyleBackColor = true;
            btnXoaDangChon.Click += btnXoaDangChon_Click;
            // 
            // btnXoaDauCuoi
            // 
            btnXoaDauCuoi.Location = new Point(6, 53);
            btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            btnXoaDauCuoi.Size = new Size(210, 23);
            btnXoaDauCuoi.TabIndex = 1;
            btnXoaDauCuoi.Text = "Xóa phần tử đầu và cuối";
            btnXoaDauCuoi.UseVisualStyleBackColor = true;
            btnXoaDauCuoi.Click += btnXoaDauCuoi_Click;
            // 
            // btnTongDS
            // 
            btnTongDS.Location = new Point(6, 22);
            btnTongDS.Name = "btnTongDS";
            btnTongDS.Size = new Size(210, 23);
            btnTongDS.TabIndex = 0;
            btnTongDS.Text = "Tổng của danh sách";
            btnTongDS.UseVisualStyleBackColor = true;
            btnTongDS.Click += btnTongDS_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 285);
            button2.Name = "button2";
            button2.Size = new Size(337, 23);
            button2.TabIndex = 5;
            button2.Text = "Kết thúc";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 318);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCapNhat);
            Controls.Add(txtSo);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSo;
        private Button btnCapNhat;
        private GroupBox groupBox1;
        private ListBox lstDaySo;
        private GroupBox groupBox2;
        private Button btnTongDS;
        private Button button2;
        private Button btnChonSoLe;
        private Button btnChonSoChan;
        private Button btnBinhPhuong;
        private Button btnTang2;
        private Button btnXoaDangChon;
        private Button btnXoaDauCuoi;
    }
}